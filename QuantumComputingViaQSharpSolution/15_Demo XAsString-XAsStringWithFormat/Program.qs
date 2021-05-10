namespace Quantum._15_Demo_XAsString_XAsStringWithFormat {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Convert;

    
    @EntryPoint()
    operation Demo_XAsString_XAsStringWithFormat () : Unit {
        
       use qubit = Qubit();
		//Convert an integer to a String
		Message(IntAsString(2));
		//Convert a double to a String
		Message(DoubleAsString(2.3));
		//Convert a boolean to a String
		Message(BoolAsString(true));
		//Formatted integer
		Message(IntAsStringWithFormat(22345,"C"));//Currency
		Message(IntAsStringWithFormat(22345,"D8"));//D8
		Message(IntAsStringWithFormat(31,"X8"));//X8
		Message(IntAsStringWithFormat(142,"0000#"));
		//Formatted double
		Message(DoubleAsStringWithFormat(22345.12,"C"));//Currency
		Message(DoubleAsStringWithFormat(142.12,"0000.000"));
			

    }
}
