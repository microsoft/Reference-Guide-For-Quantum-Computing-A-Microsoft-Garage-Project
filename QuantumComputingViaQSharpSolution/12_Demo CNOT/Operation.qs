namespace Quantum._03_Demo_X
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;

    operation DemoOperation () : ()
    {
        body
        {
            using(qubits = Qubit[2])
			{
				Message("Input: 0-0");
				CNOT(qubits[0], qubits[1]);
				mutable results = MultiM(qubits);
				Message("Output: " + ToStringI(ResultAsInt(Subarray([0],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([1],results))));
				ResetAll(qubits);

				Message("\nInput: 0-1");
				X(qubits[1]);
				CNOT(qubits[0], qubits[1]);
				set results = MultiM(qubits);
				Message("Output: " + ToStringI(ResultAsInt(Subarray([0],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([1],results))));
				ResetAll(qubits);
				
				Message("\nInput: 1-0");
				X(qubits[0]);
				CNOT(qubits[0], qubits[1]);
				set results = MultiM(qubits);
				Message("Output: " + ToStringI(ResultAsInt(Subarray([0],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([1],results))));
				ResetAll(qubits);

				Message("\nInput: 1-1");
				X(qubits[0]);
				X(qubits[1]);
				CNOT(qubits[0], qubits[1]);
				set results = MultiM(qubits);
				Message("Output: " + ToStringI(ResultAsInt(Subarray([0],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([1],results))));
				ResetAll(qubits);
				
			}
        }
    }
}
