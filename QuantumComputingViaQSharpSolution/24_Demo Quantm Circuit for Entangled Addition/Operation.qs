namespace Quantum._24_Demo_Quantm_Circuit_for_Addition
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;

    operation Operation () : ()
    {
        body
        {
            mutable strSum = "";
			//First Number
			using(a = Qubit[2])
			{

				//Second Number
				using(b = Qubit[2])
				{

					//sum will be a 3 bit number that stores the sum of a and b along with carry
					// Not so optimal but works
					using(sum = Qubit[3])
					{
						
						ApplyToEach(H,a+b);

						//First qubit
						CNOT(a[0],sum[0]);
						CNOT(b[0],sum[0]);

						//Second qubit
						CNOT(a[1],sum[1]);
						CNOT(b[1],sum[1]);
						CCNOT(a[0],b[0],sum[1]);

						//Third qubit
						CCNOT(a[1],b[1],sum[2]);
						X(a[1]);
						(Controlled X)(a + b,sum[2]);
						X(a[1]);
						X(b[1]);
						(Controlled X)(a + b,sum[2]);
						X(b[1]);

						set strSum = ToStringI(ResultAsInt(MultiM(sum)));

						//Change this number to see various super positions
						if(strSum == "4")
						{
							//We can see that the input is entangled with the output.
							//If the output is 4, then only entangled states 2 + 2, 1 + 3 and 3 + 3
							//will remain and all other states will vanish from the input bits.
							Message(strSum + " : " +
								ToStringI(ResultAsInt(MultiM(a))) + " + " + 
								ToStringI(ResultAsInt(MultiM(b)))
							);
						}
						
						ResetAll(sum);
					}
					ResetAll(b);

				}
				ResetAll(a);
				
			}

        }
    }
}
