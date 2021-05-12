namespace Quantum._19_Demo_Entanglement {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Measurement;
	open Microsoft.Quantum.Convert;
	open Microsoft.Quantum.Arrays;

    
    @EntryPoint()
    operation Demo_Entanglement () : Unit {
        mutable iterations = 20;

			use qubits = Qubit[2]
			{
				for i in 1..iterations
				{
					H(qubits[0]);
					CNOT(qubits[0],qubits[1]);

					mutable results = MultiM(qubits);
					
					//The output will always be 0-0 or 1-1, and can never be 0-1 or 1-0, those possibilities will be eliminated.
					Message("Output: " + IntAsString(ResultArrayAsInt(Subarray([0],results))) + "-" + 
					IntAsString(ResultArrayAsInt(Subarray([1],results))));
					
					ResetAll(qubits);
				}
			}
    }
}
