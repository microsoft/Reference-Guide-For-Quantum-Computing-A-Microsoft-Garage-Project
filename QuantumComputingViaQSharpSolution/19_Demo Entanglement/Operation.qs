namespace Quantum._03_Demo_X
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;
	//This extension is needed for all math functions
	open Microsoft.Quantum.Extensions.Math;

    operation DemoOperation () : ()
    {
        body
        {
			mutable iterations = 20;

			using(qubits = Qubit[2])
			{
				for(i in 1..iterations)
				{
					//X(qubits[0]);
					H(qubits[0]);
					CNOT(qubits[0],qubits[1]);
					CNOT(qubits[0],qubits[1]);
					H(qubits[0]);
					mutable results = MultiM(qubits);
					//The output will always be 0-0 or 1-1, and can never be 0-1 or 1-0, those possibilities will be eliminated.
					Message("Output: " + ToStringI(ResultAsInt(Subarray([0],results))) + "-" + 
					ToStringI(ResultAsInt(Subarray([1],results))));
					ResetAll(qubits);
				}
			}


        }
    }
}
