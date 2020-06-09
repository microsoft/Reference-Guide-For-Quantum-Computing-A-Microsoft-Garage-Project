namespace Quantum._09_Demo_Temp
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation DemoOperation (iterations: Int, message: String) : (Int,Int)
    {
        body
        {
			//Printing the message received as input
			Message(message);
			mutable countZeroes = 0;
			mutable countOnes = 0;
			//Using the parameter from the Driver
			for(iter in 1..iterations)
			{
				using(qubits = Qubit[1])
				{
					// Applying Hadamard on the qubit
					H(qubits[0]);
					let result = M(qubits[0]);
					if(result == Zero)
					{
						set countZeroes = countZeroes + 1;
					}
					if(result == One)
					{
						set countOnes = countOnes + 1;
					}
					//Resetting the qubit to Zero at the end of every iteration.
					ResetAll(qubits);
				}
			}
			//Returning the counts as a tuple with two values.
			// You can return a tuple with one value also
			return (countZeroes, countOnes);
        }
    }
}
