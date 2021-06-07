namespace _06_Demo_H {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert as Convert;

    @EntryPoint()
    operation HelloQ() : Unit {
        use qubit = Qubit();
        
        // Applying Hadamard on the qubit.
            H(qubit);
            let result = M(qubit);
        // This output might change for every execution
        // because H will put the qubit in a 50/50 superposition of 0 and 1.
            Message(Convert.BoolAsString(Convert.ResultAsBool(result)));
            Reset(qubit);
        
    }
}

