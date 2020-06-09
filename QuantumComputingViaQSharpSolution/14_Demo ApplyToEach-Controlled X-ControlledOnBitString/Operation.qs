namespace Quantum._03_Demo_X
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;

    operation DemoOperation () : ()
    {
        body
        {
            using(qubits = Qubit[3])
			{
				mutable str = "";
				//X is applied to all the qubits
				ApplyToEach(X, qubits);
				let results = MultiM(qubits);
				for(i in 0..Length(qubits)-1)
				{
					set str = str + ToStringI(ResultAsInt([results[0]]));
				}
				//Output will be 111
				Message(str);
				ResetAll(qubits);
				
			}

			Message("\n(Controlled X) Demo:");
			//(Controlled X) Demo
			//First parameter should be an array of qubits and the second parameter a single Qubit
			// X will be applied on the qubit in teh second parameter only if all the qubits in the array are ones
			// This is a generic form of CNOT
			using(inputQubits = Qubit[3])
			{
				ApplyToEach(X, inputQubits);
				using(outputQubits = Qubit[1])
				{
					//Any gate can be used in the place of X
					(Controlled X)(inputQubits, outputQubits[0]);
					Message(ToStringI(ResultAsInt([M(outputQubits[0])])));
					ResetAll(outputQubits);
				}
				ResetAll(inputQubits);
			}

			Message("\nControlledOnBitString  Demo:");
			//ControlledOnBitString: This is more generic than Controlled X
			//We can control on any bit combination; In this example: 101
			using(inputQubits2 = Qubit[3])
			{
				X(inputQubits2[0]);
				X(inputQubits2[2]);
				using(outputQubits2 = Qubit[1])
				{
					(ControlledOnBitString([true;false;true],X))(inputQubits2, outputQubits2[0]);
					Message(ToStringI(ResultAsInt([M(outputQubits2[0])])));
					ResetAll(outputQubits2);
				}
				ResetAll(inputQubits2);
			}

        }
    }
}
