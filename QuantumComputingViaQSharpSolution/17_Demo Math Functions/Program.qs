namespace Quantum._17_Demo_Math_Functions {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Convert;
	open Microsoft.Quantum.Math;

    
    @EntryPoint()
    operation Demo_Math_Functions () : Unit {
        
          //AbsD
          Message("AbsD(-1.2): " + DoubleAsString(AbsD(-1.2)));
		  //AbsI
		  Message("AbsI(-12): " + IntAsString(AbsI(-12)));
		  //Ceiling
		  Message("Ceiling(12.2): " + IntAsString(Ceiling(12.2)));
		  //Complex
		  mutable complex = Complex(1.0,2.2);

		  //PI()
		  Message("PI(): " + DoubleAsString(PI()));

		  //Sin 0
		  Message("Sin(0): " + DoubleAsString(Sin(0.0)));
		  //Sin(PI()/2.0)
		  Message("Sin(PI()/2.0): " + DoubleAsString(Sin(PI()/2.0)));
		  //Sin(PI())
		  Message("Sin(PI()): " + DoubleAsString(Sin(PI())));
		  //ArcSin(1.0)
		  Message("ArcSin(1.0): " + DoubleAsString(ArcSin(1.0)));
		  //ArcTan(0.5)
		  Message("ArcTan(0.5): " + DoubleAsString(ArcTan(0.5)));
		  //ArcTan2(1.0,0.0)
		  Message("ArcTan2(1.0,0.0): " + DoubleAsString(ArcTan2(1.0,0.0)));

		  //e
		  Message("e: " + DoubleAsString(E()));
		  //e^2
		  Message("e^2: " + DoubleAsString(ExpD(2.0)));
		  //Modulus
		  Message("Modulus : " + IntAsString(ModulusI(8,5)));
		  //PowD
		  Message("PowD : " + DoubleAsString(PowD(2.0,3.0)));
		  //Round
		  Message("Round : " + IntAsString(Round(2.6)));
		  //Truncate
		  Message("Truncate : " + IntAsString(Truncate(2.6)));
		  //Sqrt
		  Message("Sqrt : " + DoubleAsString(Sqrt(8.0)));
		  //Log-base e
		  Message("Log : " + DoubleAsString(Log(E())));
		  //Log10-base 10
		  Message("Log10 : " + DoubleAsString(Log10(100.0)));
		  //Lg-base 2
		  Message("Lg : " + DoubleAsString(Lg(4.0)));

		  Message("Done");
    }
}
