namespace Quantum._07_Demo_H_count_mutable_set_for_IntAsString {

     open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Convert;

    
    @EntryPoint()
    operation Demo_H_count_mutable_set_for_IntAsString () : Unit {

             // Unlike let, variables declared as mutable can be modified later.
			// Data type is infered during initialization. Her it is Int.
			mutable countZeroes = 0;
			mutable countOnes = 0;

			//Running the for loop for 1000 times
			for iter in 1..1000
			{
				use qubits = Qubit[1]
				{
					// Applying Hadamard on the qubit
					H(qubits[0]);
					
					//Perform Measurement
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

			//ToStringI will convert an integer to string
			// Since we have executed the loop for 1000 times.
			// Each count should be approximately equal to 500.
			// But it might vary on each execution.
			Message("countZeroes: " + IntAsString(countZeroes));
			Message("countOnes: " + IntAsString(countOnes));
    }
}
