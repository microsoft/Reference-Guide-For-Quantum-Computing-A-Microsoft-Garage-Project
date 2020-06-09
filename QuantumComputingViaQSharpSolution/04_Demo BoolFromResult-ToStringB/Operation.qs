namespace Quantum._04_Demo_ResetAll
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	//This namespace is needed to use the convert functions
	open Microsoft.Quantum.Extensions.Convert;

    operation DemoOperation () : ()
    {
        body
        {
            using(qubits = Qubit[1])
			{
				X(qubits[0]);
				let r = M(qubits[0]);
				//Message will only take strings.
				// First convert the Result to Bool
				// Then convert the bool to String
				Message(ToStringB(BoolFromResult(r)));
				Reset(qubits[0]);
			}
        }
    }
}
