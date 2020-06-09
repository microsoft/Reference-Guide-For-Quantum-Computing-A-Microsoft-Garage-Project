namespace Quantum._05_Demo_MultiM_ResetAll
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;

    operation DemoOperation () : ()
    {
        body
        {
			// Creating an array of two qubits
            using(qubits = Qubit[2])
			{
				// Reversing the second qubit.
				X(qubits[1]);
				//MultiM will measure all the qubits in the array
				//and retuns an array of Result datatype.
				let results = MultiM(qubits);
				Message(ToStringB(BoolFromResult(results[0])));
				Message(ToStringB(BoolFromResult(results[1])));
				//ResetAll will reset all the qubits in the array.
				ResetAll(qubits);
			}
        }
    }
}
