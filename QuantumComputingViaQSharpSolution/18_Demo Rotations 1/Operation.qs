namespace Quantum._03_Demo_X
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;
	//This extension is needed for all math functions
	open Microsoft.Quantum.Extensions.Math;

    operation DemoOperation () : ()
    {
        body
        {
			mutable countZero = 0;
			mutable countOne = 0;
			mutable iterations = 1000;

			using(qubits = Qubit[2])
			{
				//Measure without any operation
				for(i in 1..iterations)
				{
					let result = M(qubits[0]);
					if(result == Zero)
					{
						set countZero = countZero + 1;
					}
					else
					{
						set countOne = countOne + 1;
					}
					ResetAll(qubits);
				}
				Message("Measure without any operation:");
				Message("countZero:" + ToStringI(countZero));
				Message("countOne:" + ToStringI(countOne));
				

				//Rx(PI(), qubits[0]); 
				// Will make Zero to One
				set countZero = 0;
				set countOne = 0;
				for(i in 1..iterations)
				{
					Rx(PI(), qubits[0]);
					let result = M(qubits[0]);
					if(result == Zero)
					{
						set countZero = countZero + 1;
					}
					else
					{
						set countOne = countOne + 1;
					}
					ResetAll(qubits);
				}
				Message("Rx(PI(), qubits[0]):");
				Message("countZero:" + ToStringI(countZero));
				Message("countOne:" + ToStringI(countOne));

				//Ry(PI(), qubits[0]); 
				// Will also make Zero to One
				set countZero = 0;
				set countOne = 0;
				for(i in 1..iterations)
				{
					Ry(PI(), qubits[0]);
					let result = M(qubits[0]);
					if(result == Zero)
					{
						set countZero = countZero + 1;
					}
					else
					{
						set countOne = countOne + 1;
					}
					ResetAll(qubits);
				}
				Message("Ry(PI(), qubits[0]):");
				Message("countZero:" + ToStringI(countZero));
				Message("countOne:" + ToStringI(countOne));

				//Rz(PI(), qubits[0]); 
				// Zero will remain as Zero
				set countZero = 0;
				set countOne = 0;
				for(i in 1..iterations)
				{
					Rz(PI(), qubits[0]);
					let result = M(qubits[0]);
					if(result == Zero)
					{
						set countZero = countZero + 1;
					}
					else
					{
						set countOne = countOne + 1;
					}
					ResetAll(qubits);
				}
				Message("Rz(PI(), qubits[0]):");
				Message("countZero:" + ToStringI(countZero));
				Message("countOne:" + ToStringI(countOne));

				//Ry(PI()/2.0, qubits[0]); 
				// Same as H
				set countZero = 0;
				set countOne = 0;
				for(i in 1..iterations)
				{
					Ry(PI()/2.0, qubits[0]);
					let result = M(qubits[0]);
					if(result == Zero)
					{
						set countZero = countZero + 1;
					}
					else
					{
						set countOne = countOne + 1;
					}
					ResetAll(qubits);
				}
				Message("Ry(PI()/2.0, qubits[0]):");
				Message("countZero:" + ToStringI(countZero));
				Message("countOne:" + ToStringI(countOne));

				//R(PauliX, PI()/2.0, qubits[0]); 
				set countZero = 0;
				set countOne = 0;
				for(i in 1..iterations)
				{
					//PauliX and PauliZ can also be used; They are similar to Rx, Ry, Rz
					R(PauliY, PI()/2.0, qubits[0]);
					let result = M(qubits[0]);
					if(result == Zero)
					{
						set countZero = countZero + 1;
					}
					else
					{
						set countOne = countOne + 1;
					}
					ResetAll(qubits);
				}
				Message("R(PauliY, PI()/2.0, qubits[0]):");
				Message("countZero:" + ToStringI(countZero));
				Message("countOne:" + ToStringI(countOne));

				//R1(PI(), qubits[0]); 
				// Zero will remain as Zero; This is same as Rz. We are changing only the phase of One
				set countZero = 0;
				set countOne = 0;
				for(i in 1..iterations)
				{
					R1(PI(), qubits[0]);
					let result = M(qubits[0]);
					if(result == Zero)
					{
						set countZero = countZero + 1;
					}
					else
					{
						set countOne = countOne + 1;
					}
					ResetAll(qubits);
				}
				Message("R1(PI(), qubits[0]):");
				Message("countZero:" + ToStringI(countZero));
				Message("countOne:" + ToStringI(countOne));

				//Ry(angle, qubits[0]);
				// 1/4 probabilityOfZero
				set countZero = 0;
				set countOne = 0;
				for(i in 1..iterations)
				{
					let probabilityOfZero = 1.0/4.0;
					let amplitudeOfZero = Sqrt(probabilityOfZero);
					let angle = 2.0 * ArcCos(amplitudeOfZero);
					Ry(angle, qubits[0]);
					let result = M(qubits[0]);
					if(result == Zero)
					{
						set countZero = countZero + 1;
					}
					else
					{
						set countOne = countOne + 1;
					}
					ResetAll(qubits);
				}
				Message("Ry(angle, qubits[0]):");
				Message("countZero:" + ToStringI(countZero));
				Message("countOne:" + ToStringI(countOne));

			}


        }
    }
}
