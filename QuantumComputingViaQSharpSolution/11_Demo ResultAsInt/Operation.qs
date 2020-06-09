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
				//ResultAsInt will take an array of results and returns an integer.
				// The input array is considered to be LittleEndian
				Message("[Zero;Zero]:");
				mutable value = ResultAsInt([Zero;Zero]);
				Message(ToStringI(value));

				//This will give 2 because the input is considered LittleEndian
				Message("[Zero;One]:");
				set value = ResultAsInt([Zero;One]);
				Message(ToStringI(value));

				//This will give 1 because the input is considered LittleEndian
				Message("[One;Zero]:");
				set value = ResultAsInt([One;Zero]);
				Message(ToStringI(value));

				Message("[One;One]:");
				set value = ResultAsInt([One;One]);
				Message(ToStringI(value));

				ResetAll(qubits);
				
			}
        }
    }
}
