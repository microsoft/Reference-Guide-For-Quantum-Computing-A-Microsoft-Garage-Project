namespace Quantum._05_Demo_MultiM_ResetAll
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;

    operation DemoOperation () : ()
    {
        body
        {
			using(qubits = Qubit[1])
			{
				// Applying Hadamard on the qubit
				H(qubits[0]);
				let result = M(qubits[0]);
				//This output might change for every execution
				//because H will put the qubit in a 50/50 superposition of 0 and 1
				Message(ToStringB(BoolFromResult(result)));
				ResetAll(qubits);
			}
        }
    }
}
