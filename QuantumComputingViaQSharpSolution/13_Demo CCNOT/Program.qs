namespace Quantum._13_Demo_CCNOT {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Convert;
	open Microsoft.Quantum.Measurement;
	open Microsoft.Quantum.Arrays;

    
    @EntryPoint()
    operation Demo_CCNOT () : Unit {
        use qubits = Qubit[3]
		{

			//CCNOT gate ensures that when first two controlling bit are set,
			//Controlled bit gets flipped
			Message("Input: 0-0-0");
			CCNOT(qubits[0], qubits[1], qubits[2]);
			mutable results = MultiM(qubits);
			Message("Output: " + IntAsString(ResultArrayAsInt(Subarray([0],results))) + "-" + 
									IntAsString(ResultArrayAsInt(Subarray([1],results))) + "-" + 
									IntAsString(ResultArrayAsInt(Subarray([2],results))));

			ResetAll(qubits);

			Message("Input: 0-0-1");
			X(qubits[2]);
			CCNOT(qubits[0], qubits[1], qubits[2]);
			set results = MultiM(qubits);
			Message("Output: " + IntAsString(ResultArrayAsInt(Subarray([0],results))) + "-" + 
									IntAsString(ResultArrayAsInt(Subarray([1],results))) + "-" + 
									IntAsString(ResultArrayAsInt(Subarray([2],results))));
			ResetAll(qubits);

			Message("Input: 1-0-0");
			X(qubits[0]);
			CCNOT(qubits[0], qubits[1], qubits[2]);
			set results = MultiM(qubits);
			Message("Output: " + IntAsString(ResultArrayAsInt(Subarray([0],results))) + "-" + 
									IntAsString(ResultArrayAsInt(Subarray([1],results))) + "-" + 
									IntAsString(ResultArrayAsInt(Subarray([2],results))));
			ResetAll(qubits);

			Message("Input: 1-1-0");
			X(qubits[0]);
			X(qubits[1]);
			CCNOT(qubits[0], qubits[1], qubits[2]);
			set results = MultiM(qubits);
			Message("Output: " + IntAsString(ResultArrayAsInt(Subarray([0],results))) + "-" + 
									IntAsString(ResultArrayAsInt(Subarray([1],results))) + "-" + 
									IntAsString(ResultArrayAsInt(Subarray([2],results))));
			ResetAll(qubits);
				
		}
    }
}
