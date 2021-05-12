namespace Quantum._11_Demo_ResultArrayAsInt {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Convert;
    
    @EntryPoint()
    operation HelloQ () : Unit {
		//ResultAsInt will take an array of results and returns an integer.
		//The input array is considered to be LittleEndian
		mutable value = ResultArrayAsInt([Zero,Zero]);
		Message($"[Zero;Zero]: {value}");

		//This will give 2 because the input is considered LittleEndian
		set value = ResultArrayAsInt([Zero,One]);
		Message($"[Zero;One]: {value}");
		
		//This will give 1 because the input is considered LittleEndian
		set value = ResultArrayAsInt([One,Zero]);
		Message($"[One;Zero]: {value}");
		
		//This will give 3 because the input is considered LittleEndian
		set value = ResultArrayAsInt([One,One]);
		Message($"[One;One]: {value}");
    }
}
