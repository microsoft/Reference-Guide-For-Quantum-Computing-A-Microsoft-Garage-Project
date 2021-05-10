namespace Quantum._21_Demo_Deutsch_s_Algorithm {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    
    @EntryPoint()
    operation Demo_Deutsch_s_Algorithm () : Unit {
        
			//Circuit diagram located here
			//https://www.researchgate.net/profile/Piotr_Gawron/publication/250802186/figure/fig2/AS:298189887426561@1448105417119/Graphical-representation-of-Deutsch-algorithm.png
			
			use qubits = Qubit[2];
			

				//Making the second qubit 1
				X(qubits[1]);

				//H on both
				ApplyToEach(H,qubits);
			
				//Apply the blackbox
				//blackbox will set y = f(x) XOR y; which is same as CNOT(f(x),y)
				BlackBoxConstant0(qubits);
				//BlackBoxConstant1(qubits);
				//BlackBoxBalancedSame(qubits);
				//BlackBoxBalancedDifferent(qubits);

				//H on the first qubit
				H(qubits[0]);

				//Measuring the first Qubit
				let result = M(qubits[0]);

				//For BlackBoxConstant0 and BlackBoxConstant1, the output will be Zero
				if(result == Zero)
				{
					Message("Constant");
				}
				elif(result == One)
				//For BlackBoxBalancedSame and BlackBoxBalancedDifferent, the output will be One
				{
					Message("Balanced");
				}

				ResetAll(qubits);
			
    }

	//This BB will always return 0
	//This implemenents y = f(x) XOR y; which is same as CNOT(f(x), y);
	//since f(x) = 0, for x = 0 and x = 1, we don't have to change y
	//x will be the first qubit; y will be the second qubit;
	operation BlackBoxConstant0(qubits:Qubit[]) : Unit
	{
		
	}

	//This BB will always return 1
	//This implemenents y = f(x) XOR y; which is same as CNOT(f(x), y);
	//since f(x) = 1, for x = 0 and x = 1, we need to do y = 1 XOR y, which is same as CNOT(1,y)
	//So it's enough to flip y every time
	//x will be the first qubit; y will be the second qubit;
	operation BlackBoxConstant1(qubits:Qubit[]) : Unit
	{
		
		X(qubits[1]);

	}

	//This BB will output 0 if the input is 0
	// and outputs 1 if the input is 1
	//This implemenents y = f(x) XOR y; which is same as CNOT(f(x), y);
	//Here f(x) = 0, for x = 0 and f(x) = 1 for x = 1, we need to do y = f(x) XOR y, which is same as CNOT(f(x),y)
	//Since f(x) = x, we need to do y = x XOR y, which is same ase CNOT(x,y)
	//x will be the first qubit; y will be the second qubit;
	operation BlackBoxBalancedSame(qubits:Qubit[]) : Unit
	{
		
		CNOT(qubits[0],qubits[1]);
		
	}

	//This BB will output 0 if the input is 1
	// and outputs 0 if the input is 1
	//This implemenents y = f(x) XOR y; which is same as CNOT(f(x), y);
	//Here f(x) = 1, for x = 0 and f(x) = 0 for x = 1, we need to do y = f(x) XOR y, which is same as CNOT(f(x),y)
	//Since f(x) = Not x, we need to do y = (NOT x) XOR y, which is same ase CNOT(X(x),y)
	//x will be the first qubit; y will be the second qubit;
	operation BlackBoxBalancedDifferent(qubits:Qubit[]) : Unit
	{
		X(qubits[0]);
		CNOT(qubits[0],qubits[1]);
		
	}
}
