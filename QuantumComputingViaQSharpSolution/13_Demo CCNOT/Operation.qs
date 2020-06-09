namespace Quantum._03_Demo_X
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;

    operation DemoOperation () : ()
    {
        body
        {
            using(qubits = Qubit[3])
			{
				Message("Input: 0-0-0");
				CCNOT(qubits[0], qubits[1], qubits[2]);
				mutable results = MultiM(qubits);
				Message("Output: " + ToStringI(ResultAsInt(Subarray([0],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([1],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([2],results))));
				ResetAll(qubits);

				Message("\nInput: 0-0-1");
				X(qubits[2]);
				CCNOT(qubits[0], qubits[1], qubits[2]);
				set results = MultiM(qubits);
				Message("Output: " + ToStringI(ResultAsInt(Subarray([0],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([1],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([2],results))));
				ResetAll(qubits);

				Message("\nInput: 1-0-0");
				X(qubits[0]);
				CCNOT(qubits[0], qubits[1], qubits[2]);
				set results = MultiM(qubits);
				Message("Output: " + ToStringI(ResultAsInt(Subarray([0],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([1],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([2],results))));
				ResetAll(qubits);

				Message("\nInput: 1-1-0");
				X(qubits[0]);
				X(qubits[1]);
				CCNOT(qubits[0], qubits[1], qubits[2]);
				set results = MultiM(qubits);
				Message("Output: " + ToStringI(ResultAsInt(Subarray([0],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([1],results))) + "-" + 
				ToStringI(ResultAsInt(Subarray([2],results))));
				ResetAll(qubits);
				
			}
        }
    }
}
