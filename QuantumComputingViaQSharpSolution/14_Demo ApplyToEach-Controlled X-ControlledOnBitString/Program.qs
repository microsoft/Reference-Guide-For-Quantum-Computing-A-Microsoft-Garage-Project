namespace _14_Demo_ApplyToEach_Controlled_X_ControlledOnBitString {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Convert as Convert;
    

    @EntryPoint()
    operation HelloQ() : Unit {
        Message("AppyToEach Demo:");
        using(qubits = Qubit[3])
        {
            mutable str = "";
            // X is applied to all the qubits.
            ApplyToEach(X, qubits);
            let results = MultiM(qubits);
            for(i in IndexRange(qubits))
            {
                set str = str + Convert.IntAsString(Convert.ResultArrayAsInt([results[i]]));
            }

            // Output will be 111.
            Message(str);
            ResetAll(qubits);   
        }

       
        // Controlled X Demo
        // First parameter should be an array of qubits and the second parameter a single Qubit
        // X will be applied on the qubit in teh second parameter only if all the qubits in the array are ones
        // This is a generic form of CNOT
        Message("Controlled X Demo:");
        using(inputQubits = Qubit[3])
        {
            ApplyToEach(X, inputQubits);
            for(i in IndexRange(inputQubits))
            {
                using(outputQubit = Qubit())
                {
                    // Any gate can be used in the place of X..
                    (Controlled X)(inputQubits, outputQubit);
                    Message(Convert.IntAsString(Convert.ResultArrayAsInt([M(outputQubit)])));
                    Reset(outputQubit);
                }
            }
            ResetAll(inputQubits);
        }

        
        // ControlledOnBitString: This is more generic than Controlled X.
        // We can control on any bit combination; In this example: 101
        Message("ControlledOnBitString  Demo:");
        using(inputQubits = Qubit[3])
        {
            X(inputQubits[0]);
            X(inputQubits[2]);
            using(outputQubit = Qubit())
            {
                (ControlledOnBitString([true, false, true], X))(inputQubits, outputQubit);
                Message(Convert.IntAsString(Convert.ResultArrayAsInt([M(outputQubit)])));
                Reset(outputQubit);
            }
            ResetAll(inputQubits);
        }
    }
}

