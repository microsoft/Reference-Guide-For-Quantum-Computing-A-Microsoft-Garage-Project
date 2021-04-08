namespace Quantum._11_Demo_ResultArrayAsInt {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Convert;
    
    @EntryPoint()
    operation Demo_ResultArrayAsInt () : Unit {
        
		using(qubits = Qubit[2])
			{
				//ResultAsInt will take an array of results and returns an integer.
				//The input array is considered to be LittleEndian
				Message("[Zero;Zero]:");
				mutable value = ResultArrayAsInt([Zero,Zero]);
				Message(IntAsString(value));

				//This will give 2 because the input is considered LittleEndian
				Message("[Zero;One]:");
				set value = ResultArrayAsInt([Zero,One]);
				Message(IntAsString(value));

				//This will give 1 because the input is considered LittleEndian
				Message("[One;Zero]:");
				set value = ResultArrayAsInt([One,Zero]);
				Message(IntAsString(value));

				Message("[One;One]:");
				set value = ResultArrayAsInt([One,One]);
				Message(IntAsString(value));

				ResetAll(qubits);
				
			}

    }
}
