namespace Quantum._26_Demo_Deutsch_Jozsa_algorithm
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;

	//Circuit:
	//https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Deutsch-Jozsa_Algorithm.svg/800px-Deutsch-Jozsa_Algorithm.svg.png
    operation DJAlgo () : ()
    {
        body
        {
            
			using(inputQubits = Qubit[3])
			{
				
				//Apply H on all the input Qubits
				ApplyToEach(H, inputQubits);
				using(outputQubits = Qubit[1])
				{
					//Creating |->
					X(outputQubits[0]);
					H(outputQubits[0]);

					//Applying the relevant black box;
					BlackBoxConstant0(inputQubits, outputQubits);
					//BlackBoxConstant1(inputQubits, outputQubits);
					//BlackBoxBalanced1(inputQubits, outputQubits);
					//BlackBoxBalanced2(inputQubits, outputQubits);

					//Apply H on all input Qubits
					ApplyToEach(H, inputQubits);

					let results = MultiM(inputQubits);
					let resultAsInt = ResultAsInt(results);

					//For all Constant blackboxes, the probability of getting |000> is 1
					if(resultAsInt == 0)
					{
						Message("Constant");
					}
					//For all Balanced blackboxes, the probability of getting |000> is 0
					else
					{
						Message("Balanced");
					}

					ResetAll(outputQubits);
				}
				ResetAll(inputQubits);
			}

        }
    }

	//Don't perform anything here.
	operation BlackBoxConstant0(inputQubits: Qubit[], outputQubits: Qubit[]) : ()
	{
		body
		{
		
		}
	}

	//Flip the output in all the scenarios
	operation BlackBoxConstant1(inputQubits: Qubit[], outputQubits: Qubit[]) : ()
	{
		body
		{
			X(outputQubits[0]);
		}
	}

	//Flip the output only when the first qubit is 1
	operation BlackBoxBalanced1(inputQubits: Qubit[], outputQubits: Qubit[]) : ()
	{
		body
		{
			CNOT(inputQubits[0], outputQubits[0]);
		}
	}

	//Flip the output only when the third qubit is 1
	operation BlackBoxBalanced2(inputQubits: Qubit[], outputQubits: Qubit[]) : ()
	{
		body
		{
			CNOT(inputQubits[2], outputQubits[0]);
		}
	}

	//Flip only when we have 000, 010, 100, 110
	operation BlackBoxBalancedRandom1(inputQubits: Qubit[], outputQubits: Qubit[]) : ()
	{
		body
		{
			//000
			X(inputQubits[0]);
			X(inputQubits[1]);
			X(inputQubits[2]);
			(Controlled X)(inputQubits, outputQubits[0]);
			X(inputQubits[0]);
			X(inputQubits[1]);
			X(inputQubits[2]);

			//010
			X(inputQubits[0]);
			X(inputQubits[2]);
			(Controlled X)(inputQubits, outputQubits[0]);
			X(inputQubits[0]);
			X(inputQubits[2]);

			//100
			X(inputQubits[1]);
			X(inputQubits[2]);
			(Controlled X)(inputQubits, outputQubits[0]);
			X(inputQubits[1]);
			X(inputQubits[2]);

			//110
			X(inputQubits[2]);
			(Controlled X)(inputQubits, outputQubits[0]);
			X(inputQubits[2]);
			
		}
	}

	//Flip only when we have 001, 011, 101, 111 
	operation BlackBoxBalancedRandom2(inputQubits: Qubit[], outputQubits: Qubit[]) : ()
	{
		body
		{
			//001
			X(inputQubits[0]);
			X(inputQubits[1]);
			(Controlled X)(inputQubits, outputQubits[0]);
			X(inputQubits[0]);
			X(inputQubits[1]);

			//011
			X(inputQubits[0]);
			(Controlled X)(inputQubits, outputQubits[0]);
			X(inputQubits[0]);

			//101
			X(inputQubits[1]);
			(Controlled X)(inputQubits, outputQubits[0]);
			X(inputQubits[1]);

			//111
			(Controlled X)(inputQubits, outputQubits[0]);
			
		}
	}
	
}
