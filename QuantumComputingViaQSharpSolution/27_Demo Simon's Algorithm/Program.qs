namespace Quantum._27_Demo_Simon_s_Algorithm {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Measurement;
 
    //Circuit is here:
	//https://en.wikipedia.org/wiki/Simon%27s_problem#/media/File:Simons_algorithm.svg
    @EntryPoint()
	operation Demo_Simon_s_Algorithm () : Unit {
        
		//Implementing the Simon's Algo for n = 4
		use inputQubits = Qubit[4];
		
			//All output qubits will be initialized to 0
			use outputQubits = Qubit[4];
			
				//Running the algorithm 20 times. 
				//Ideally running it 3 times should be enough with good probability
				for(iter in 0..19)
				{
					//Creating equal superpostion for all the input qubits
					ApplyToEach(H, inputQubits);
					//Execute the blackbox
					//BlackBox0000(inputQubits, outputQubits);
					BlackBox1010(inputQubits, outputQubits);
				
					//Applying H again on all the input qubits
					ApplyToEach(H, inputQubits);

					let inputQubitsResults = MultiM(inputQubits);
					let outputQubitsResults = MultiM(outputQubits);

					//We should get Non-Zero vectors that are linearly independant with very good probability
					//that satisfy the condigion y.s = 0; i.e y1.s1 + y2.s2 + y3.s3 + y4.s4 = 0; here + is used to denote xor
					//There is still some probability of getting Zero vectors and linearly dependant vectors.
					//However, we will never get a vector that satisfies y.s = 1;
					Message("");
					Message($"Iteration: {iter + 1}");
					for(i in 0..3){
						Message($"{inputQubitsResults[i]}");
					}

					ResetAll(outputQubits);
					ResetAll(inputQubits);
				}

				//From the above for loop; we ignore the cases when we get 0000;
				//We ignore the cases where the vectors are linearly dependant;
				//We pick only those cases where the vectors are linearly independant (n-1) and solve them to find s;
				//Once we find the value of s, we need to evaluate the BlackBox for 0000 and s and if both the values are same
				//then we have found the solution; if they don't match then it means that s=0000 is the solution.

				//Algorithm ends above; following lines are just to test the black boxes by sending data without superposition.

				//Testing the blackbox for input=0000
				//BlackBox0000(inputQubits, outputQubits);
				//Output should be 0000
				BlackBox1010(inputQubits, outputQubits);
				//Output should be 0000
				let outputQubitsResults1 = MultiM(outputQubits);
				Message("");
				Message("Testing the blackbox for input=0000");
				for i in 0..3{
						Message($"{outputQubitsResults1[i]}");
				}
				ResetAll(outputQubits);
				ResetAll(inputQubits);

				//Testing the blackbox for input=1010;
				ApplyToEach(X,[inputQubits[0],inputQubits[2]]);
				//BlackBox0000(inputQubits, outputQubits);
				//Output should be same as input 1010
				BlackBox1010(inputQubits, outputQubits);
				//Output should be 0000 (same as that of the input 0000); because here s = 1010
				let outputQubitsResults2 = MultiM(outputQubits);
				Message("");
				Message("Testing the blackbox for input=1010");
				for i in 0..3{
						Message($"{outputQubitsResults2[i]}");
				}
				ResetAll(outputQubits);
				ResetAll(inputQubits);

				//Testing the blackbox for input=1110; 
				ApplyToEach(X,[inputQubits[0],inputQubits[1], inputQubits[2]]);
				//BlackBox0000(inputQubits, outputQubits);
				//Output should be same as input 1110
				BlackBox1010(inputQubits, outputQubits);
				//Output should be 0100
				let outputQubitsResults3 = MultiM(outputQubits);
				Message("");
				Message("Testing the blackbox for input=1110");
				for i in 0..3{
						Message($"{outputQubitsResults3[i]}");
				}
				ResetAll(outputQubits);
				ResetAll(inputQubits);

				//Testing the blackbox for input=0100; 
				ApplyToEach(X,[inputQubits[1]]);
				//BlackBox0000(inputQubits, outputQubits);
				//Output should be same as input 0100
				BlackBox1010(inputQubits, outputQubits);
				//Output should be 0100 (same as that of the input 1110; because s(1010) = 0100 xor 1110)
				let outputQubitsResults4 = MultiM(outputQubits);
				Message("");
				Message("Testing the blackbox for input=0100");
				for i in 0..3{
						Message($"{outputQubitsResults4[i]}");
				}
				ResetAll(outputQubits);
				ResetAll(inputQubits);

				ResetAll(outputQubits);
				ResetAll(inputQubits);
			
			
		
    }

	//This will create a 1-1 function and s=0000
	//Here we have choosen the function y=f(x) such that y = x; This need not be the case as long as the function is 1-1;
	operation BlackBox0000(inputQubits: Qubit[], outputQubits: Qubit[]): Unit{
		
		CNOT(inputQubits[0], outputQubits[0]);
		CNOT(inputQubits[1], outputQubits[1]);
		CNOT(inputQubits[2], outputQubits[2]);
		CNOT(inputQubits[3], outputQubits[3]);

	}

	//This will create a 2-1 function and s=1010
	operation BlackBox1010(inputQubits: Qubit[], outputQubits: Qubit[]): Unit{
		
		//Do nothing for 0000 and 1010 (output will be left as 0000)

		//output=0001 for the inputs 0001 and 1011
		ApplyToEach(X,[inputQubits[0],inputQubits[1],inputQubits[2]]);
		(Controlled X)(inputQubits,outputQubits[3]);
		ApplyToEach(X,[inputQubits[0],inputQubits[1],inputQubits[2]]);
		
		ApplyToEach(X,[inputQubits[1]]);
		(Controlled X)(inputQubits,outputQubits[3]);
		ApplyToEach(X,[inputQubits[1]]);

		//output=0010 for the inputs 0010 and 1000
		ApplyToEach(X,[inputQubits[0],inputQubits[1],inputQubits[3]]);
		(Controlled X)(inputQubits,outputQubits[2]);
		ApplyToEach(X,[inputQubits[0],inputQubits[1],inputQubits[3]]);
		
		ApplyToEach(X,[inputQubits[1],inputQubits[2],inputQubits[3]]);
		(Controlled X)(inputQubits,outputQubits[2]);
		ApplyToEach(X,[inputQubits[1],inputQubits[2],inputQubits[3]]);

		//output=0011 for the inputs 0011 and 1001
		ApplyToEach(X,[inputQubits[0],inputQubits[1]]);
		(Controlled X)(inputQubits,outputQubits[2]);
		(Controlled X)(inputQubits,outputQubits[3]);
		ApplyToEach(X,[inputQubits[0],inputQubits[1]]);
		
		ApplyToEach(X,[inputQubits[1],inputQubits[2]]);
		(Controlled X)(inputQubits,outputQubits[2]);
		(Controlled X)(inputQubits,outputQubits[3]);
		ApplyToEach(X,[inputQubits[1],inputQubits[2]]);

		//output=0100 for the inputs 0100 and 1110
		ApplyToEach(X,[inputQubits[0],inputQubits[2],inputQubits[3]]);
		(Controlled X)(inputQubits,outputQubits[1]);
		ApplyToEach(X,[inputQubits[0],inputQubits[2],inputQubits[3]]);
		
		ApplyToEach(X,[inputQubits[3]]);
		(Controlled X)(inputQubits,outputQubits[1]);
		ApplyToEach(X,[inputQubits[3]]);

		//output=0101 for the inputs 0101 and 1111
		ApplyToEach(X,[inputQubits[0],inputQubits[2]]);
		(Controlled X)(inputQubits,outputQubits[1]);
		(Controlled X)(inputQubits,outputQubits[3]);
		ApplyToEach(X,[inputQubits[0],inputQubits[2]]);
		
		//ApplyToEach(X,[]);
		(Controlled X)(inputQubits,outputQubits[1]);
		(Controlled X)(inputQubits,outputQubits[3]);
		//ApplyToEach(X,[]);
		
		//output=0110 for the inputs 0110 and 1100
		ApplyToEach(X,[inputQubits[0],inputQubits[3]]);
		(Controlled X)(inputQubits,outputQubits[1]);
		(Controlled X)(inputQubits,outputQubits[2]);
		ApplyToEach(X,[inputQubits[0],inputQubits[3]]);
		
		ApplyToEach(X,[inputQubits[2],inputQubits[3]]);
		(Controlled X)(inputQubits,outputQubits[1]);
		(Controlled X)(inputQubits,outputQubits[2]);
		ApplyToEach(X,[inputQubits[2],inputQubits[3]]);

		//output=0111 for the inputs 0111 and 1101
		ApplyToEach(X,[inputQubits[0]]);
		(Controlled X)(inputQubits,outputQubits[1]);
		(Controlled X)(inputQubits,outputQubits[2]);
		(Controlled X)(inputQubits,outputQubits[3]);
		ApplyToEach(X,[inputQubits[0]]);
		
		ApplyToEach(X,[inputQubits[2]]);
		(Controlled X)(inputQubits,outputQubits[1]);
		(Controlled X)(inputQubits,outputQubits[2]);
		(Controlled X)(inputQubits,outputQubits[3]);
		ApplyToEach(X,[inputQubits[2]]);

	}
}
