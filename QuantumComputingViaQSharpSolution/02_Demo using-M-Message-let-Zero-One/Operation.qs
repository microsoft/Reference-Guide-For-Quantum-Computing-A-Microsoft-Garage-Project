namespace Quantum.Demo_M
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation DemoOperation () : ()
    {
        body
        {
			// Here we are creating an array of one Qubit
			// By default all Qubits will be set to Zero
            using(qubits = Qubit[1])
			{
				// M is used to measure a qubit.
				// it returns output of type Result. It can be either Zero or One.
				// let will create an immutable variable. Once assigned it can't be changed.
				// immutables will give better performance as compiler may optimize our code.
				let r = M(qubits[0]);
				// Since we performed no operation, the Result will always be Zero.
				if(r == Zero)
				{
					// Message will print a string.
					Message("Zero");
				}
				elif(r == One)
				{
					Message("One");
				}
				
			}
        }
    }
}
