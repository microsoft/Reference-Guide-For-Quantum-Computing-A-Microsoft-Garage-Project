namespace Quantum._03_Demo_X
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;

    operation DemoOperation () : ()
    {
        body
        {
            using(qubits = Qubit[2])
			{
				
				let result = M(qubits[0]);
				//BoolFromResult
				Message(ToStringB(BoolFromResult(result)));

				let resultArr = MultiM(qubits);
				//BoolArrFromResultArr
				let boolArr = BoolArrFromResultArr(resultArr);
				for(i in 0..Length(boolArr)-1)
				{
					Message(ToStringB(boolArr[i]));
				}

				//ResultFromBool
				let resultFromBool = ResultFromBool(true);
				if(resultFromBool == One)
				{
					Message("One");
				}

				//ResultArrFromBoolArr
				let resultArrFromBoolArr = ResultArrFromBoolArr([true;false;true]);
				if(resultArrFromBoolArr[0] == One)
				{
					Message("One");
				}

				//IsResultZero
				let isResultZero = IsResultZero(M(qubits[0]));
				if(isResultZero == true){
					Message("Zero");
				}

				//IsResultOne
				let isResultOne = IsResultOne(M(qubits[0]));
				if(isResultOne != true){
					Message("Zero");
				}

				//ResultAsInt
				//0th entry will be LSB
				X(qubits[1]);
				mutable resultAsInt = ResultAsInt(MultiM(qubits));
				//Output will be 2
				Message(ToStringI(resultAsInt));

				//PositiveIntFromResultArr
				mutable positiveIntFromResultArr = PositiveIntFromResultArr(MultiM(qubits));
				//Output will be 2
				Message(ToStringI(positiveIntFromResultArr));

				ResetAll(qubits);

			}
        }
    }
}
