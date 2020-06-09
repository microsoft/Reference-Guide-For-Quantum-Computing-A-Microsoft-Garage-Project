namespace Quantum._03_Demo_X
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;
	//This extension is needed for all math functions
	open Microsoft.Quantum.Extensions.Math;

    operation DemoOperation () : ()
    {
        body
        {
		
		  //AbsD
          Message(ToStringD(AbsD(-1.2)));
		  //AbsI
		  Message(ToStringI(AbsI(-12)));
		  //Ceiling
		  Message(ToStringI(Ceiling(12.2)));
		  //Complex
		  mutable complex = Complex(1.0,2.2);

		  //PI()
		  Message(ToStringD(PI()));

		  //Sin 0
		  Message("Sin(0): " + ToStringD(Sin(0.0)));
		  //Sin(PI()/2.0)
		  Message("Sin(PI()/2.0): " + ToStringD(Sin(PI()/2.0)));
		  //Sin(PI())
		  Message("Sin(PI()): " + ToStringD(Sin(PI())));
		  //ArcSin(1.0)
		  Message("ArcSin(1.0): " + ToStringD(ArcSin(1.0)));
		  //ArcTan(0.5)
		  Message("ArcTan(0.5): " + ToStringD(ArcTan(0.5)));
		  //ArcTan2(1.0,0.0)
		  Message("ArcTan2(1.0,0.0): " + ToStringD(ArcTan2(1.0,0.0)));

		  //e
		  Message("e: " + ToStringD(E()));
		  //e^2
		  Message("e^2: " + ToStringD(ExpD(2.0)));
		  //Modulus
		  Message("Modulus : " + ToStringI(Modulus(8,5)));
		  //PowD
		  Message("PowD : " + ToStringD(PowD(2.0,3.0)));
		  //Round
		  Message("Round : " + ToStringI(Round(2.6)));
		  //Truncate
		  Message("Truncate : " + ToStringI(Truncate(2.6)));
		  //Sqrt
		  Message("Sqrt : " + ToStringD(Sqrt(8.0)));
		  //Log-base e
		  Message("Log : " + ToStringD(Log(E())));
		  //Log10-base 10
		  Message("Log10 : " + ToStringD(Log10(100.0)));
		  //Lg-base 2
		  Message("Lg : " + ToStringD(Lg(4.0)));

		  Message("Done");

        }
    }
}
