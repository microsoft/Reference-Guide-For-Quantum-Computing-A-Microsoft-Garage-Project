namespace Quantum._02_Demo_using_M_Message_let_Zero_One {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    
    @EntryPoint()
    operation HelloQ () : Unit {
        use qubit = Qubit();		
		// M is used to measure a qubit.
		// it returns output of type Result. It can be either Zero or One.
		// let will create an immutable variable. Once assigned it can't be changed.
		// immutables will give better performance as compiler may optimize our code.
		let result = M(qubit);
		// Since we performed no operation, the Result will always be Zero.
		if(IsResultZero(result))
		{
			//Message will print a string.
			Message("Zero");
		}
		elif(IsResultOne(result))
		{
			Message("One");
		}
    }
}
