namespace Quantum._04_Demo_ResultAsBool_BoolAsString {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert as Convert;
    
    @EntryPoint()
    operation Demo_ResultAsBool_BoolAsString () : Unit {
        use qubit = Qubit();
        X(qubit);
        let result = M(qubit);
        // Message will only take strings.
        // First convert the Result to Bool
        // Then convert the bool to String
        Message(Convert.BoolAsString(Convert.ResultAsBool(result)));
        Reset(qubit);
    }
}
