namespace Quantum._05_Demo_MultiM_ResetAll {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Measurement;
	open Microsoft.Quantum.Convert;
    
    @EntryPoint()
    operation HelloQ () : Unit {
        
        use qubits = Qubit[2];
		// Reversing the second qubit.
		X(qubits[1]);
		//MultiM will measure all the qubits in the array
		//and retuns an array of Result datatype.
		let results = MultiM(qubits);

		Message(BoolAsString(ResultAsBool(results[0])));
		Message(BoolAsString(ResultAsBool(results[1])));
				
		//ResetAll will reset all the qubits in the array.
		ResetAll(qubits);
		
    }
}
