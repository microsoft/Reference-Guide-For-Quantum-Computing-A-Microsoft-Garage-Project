namespace Quantum._26_Demo_Deutsch_Jozsa_algorithm {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Convert;
    
    @EntryPoint()
    operation HelloQ () : Unit {
        
        use inputQubits = Qubit[3];
        // Apply H on all the input Qubits
        ApplyToEach(H, inputQubits);
        
        use outputQubit = Qubit();
        // Creating |->
        X(outputQubit);
        H(outputQubit);

        // Applying the relevant black box;
        BlackBoxConstant0(inputQubits, outputQubit);
        // BlackBoxConstant1(inputQubits, outputQubit);
        // BlackBoxBalanced1(inputQubits, outputQubit);
        // BlackBoxBalanced2(inputQubits, outputQubit);
        
        // Apply H on all input Qubits
        ApplyToEach(H, inputQubits);

        let results = MultiM(inputQubits);
        let resultAsInt = ResultArrayAsInt(results);

        // For all Constant blackboxes, the probability of getting |000> is 1
        if(resultAsInt == 0)
        {
            Message("Constant");
        }
        // For all Balanced blackboxes, the probability of getting |000> is 0
        else
        {
            Message("Balanced");
        }

        Reset(outputQubit);
        ResetAll(inputQubits);
    }

    // Don't perform anything here.
	operation BlackBoxConstant0(inputQubits: Qubit[], outputQubit: Qubit) : Unit
	{
	}

	// Flip the output in all the scenarios
	operation BlackBoxConstant1(inputQubits: Qubit[], outputQubit: Qubit) : Unit
	{
        X(outputQubit);
	}

	// Flip the output only when the first qubit is 1
	operation BlackBoxBalanced1(inputQubits: Qubit[], outputQubit: Qubit) : Unit
	{
        CNOT(inputQubits[0], outputQubit);
	}

	// Flip the output only when the third qubit is 1
	operation BlackBoxBalanced2(inputQubits: Qubit[], outputQubit: Qubit) : Unit
	{

        CNOT(inputQubits[2], outputQubit);
	}

    //Flip only when we have 000, 010, 100, 110
	operation BlackBoxBalancedRandom1(inputQubits: Qubit[], outputQubits: Qubit[]) : Unit
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

	//Flip only when we have 001, 011, 101, 111 
	operation BlackBoxBalancedRandom2(inputQubits: Qubit[], outputQubits: Qubit[]) : Unit
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
