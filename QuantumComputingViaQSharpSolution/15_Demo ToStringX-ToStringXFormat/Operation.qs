namespace Quantum.Demo_ToStringI
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	// This namespace has all the Convert functions
	open Microsoft.Quantum.Extensions.Convert;

    operation DemoOperation () : ()
    {
        body
        {
            using(qubits = Qubit[1])
			{
				//Convert an integer to a String
				Message(ToStringI(2));
				//Convert a double to a String
				Message(ToStringD(2.3));
				//Convert a boolean to a String
				Message(ToStringB(true));
				//Formatted integer
				Message(ToStringIFormat(22345,"C"));//Currency
				Message(ToStringIFormat(22345,"D8"));//D8
				Message(ToStringIFormat(31,"X8"));//X8
				Message(ToStringIFormat(142,"0000#"));

				//Formatted double
				Message(ToStringDFormat(22345.12,"C"));//Currency
				Message(ToStringDFormat(142.12,"0000.000"));
			}
        }
    }
}
