namespace Quantum._03_Demo_X
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation DemoOperation () : ()
    {
        body
        {
            using(qubits = Qubit[1])
			{
				//Applying X will reverse the value.
				X(qubits[0]);
				let r = M(qubits[0]);
				if(r == Zero)
				{
					Message("Zero");
				}
				elif(r == One)
				{	
					//Output will be one.
					Message("One");
				}
				// At the end of using, we need to Reset all the qubits to Zero
				Reset(qubits[0]);
				
			}
        }
    }
}
