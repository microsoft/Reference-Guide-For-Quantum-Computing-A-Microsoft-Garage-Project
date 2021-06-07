namespace _12_Demo_CNOT {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Convert as Convert;
    

    @EntryPoint()
    operation HelloQ() : Unit {
        Message("Copmuting CNOT for a two qubit system for all possible combinations!");
        use qubits = Qubit[2];
        
            Message("Input: 0-0");
            CNOT(qubits[0], qubits[1]);
            mutable results = MultiM(qubits);
            Message("Output: " + Convert.IntAsString(Convert.ResultArrayAsInt(Subarray([0], results))) + "-" + 
            Convert.IntAsString(Convert.ResultArrayAsInt(Subarray([1], results))));
            ResetAll(qubits);

            Message("Input: 0-1");
            X(qubits[1]);
            CNOT(qubits[0], qubits[1]);
            set results = MultiM(qubits);
            Message("Output: " + Convert.IntAsString(Convert.ResultArrayAsInt(Subarray([0], results))) + "-" + 
            Convert.IntAsString(Convert.ResultArrayAsInt(Subarray([1], results))));
            ResetAll(qubits);
            
            Message("Input: 1-0");
            X(qubits[0]);
            CNOT(qubits[0], qubits[1]);
            set results = MultiM(qubits);
            Message("Output: " + Convert.IntAsString(Convert.ResultArrayAsInt(Subarray([0], results))) + "-" + 
            Convert.IntAsString(Convert.ResultArrayAsInt(Subarray([1], results))));
            ResetAll(qubits);

            Message("Input: 1-1");
            X(qubits[0]);
            X(qubits[1]);
            CNOT(qubits[0], qubits[1]);
            set results = MultiM(qubits);
            Message("Output: " + Convert.IntAsString(Convert.ResultArrayAsInt(Subarray([0], results))) + "-" + 
            Convert.IntAsString(Convert.ResultArrayAsInt(Subarray([1], results))));
            ResetAll(qubits);
        
    }
}

