namespace Quantum._14_Demo_ApplyToEach_Controlled_X_ControlledOnBitString {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Convert;
    
    @EntryPoint()
    operation HelloQ () : Unit {
        
        use qubits = Qubit[3];   
        mutable str = "";
        // X is applied to all the qubits.
        ApplyToEach(X, qubits);
        let results = MultiM(qubits);
        for i in IndexRange(qubits)
        {
            set str = str + IntAsString(ResultArrayAsInt([results[i]]));
        }

        // Output will be 111.
        Message($"ApplyToEach Demo: {str}");
        ResetAll(qubits);

        // Controlled X Demo
        // First parameter should be an array of qubits and the second parameter a single Qubit
        // X will be applied on the qubit in teh second parameter only if all the qubits in the array are ones
        // This is a generic form of CNOT
        set str = "";
        use inputQubits = Qubit[3];
        ApplyToEach(X, inputQubits);
        for i in IndexRange(inputQubits)
        {
            use outputQubit = Qubit();
            // Any gate can be used in the place of X..
            (Controlled X)(inputQubits, outputQubit);
            set str = str + IntAsString(ResultArrayAsInt([M(outputQubit)]));
            Reset(outputQubit);
            
        }
        
        ResetAll(inputQubits);
        Message($"Controlled X Demo: {str}");

        // ControlledOnBitString: This is more generic than Controlled X.
        // We can control on any bit combination; In this example: 101
        X(inputQubits[0]);
        X(inputQubits[2]);
        use outputQubit = Qubit();
        (ControlledOnBitString([true, false, true], X))(inputQubits, outputQubit);
        let result = IntAsString(ResultArrayAsInt([M(outputQubit)]));
        Message($"ControlledOnBitString Demo: {result}");
        Reset(outputQubit);
        ResetAll(inputQubits);
        
    }
}
