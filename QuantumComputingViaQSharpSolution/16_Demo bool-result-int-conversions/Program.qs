namespace Quantum._16_Demo_bool_result_int_conversions {

    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Convert as Convert;
    
    @EntryPoint()
    operation Demo_Bool_Result_Int_Conversions () : Unit {
        use qubits = Qubit[2]
        {
            
            let result = M(qubits[0]);

            // ResultAsBool demo.
            Message("ResultAsBool demo");
            Message(Convert.BoolAsString(Convert.ResultAsBool(result)));

            let resultArr = MultiM(qubits);

            // ResultArrayAsBoolArray demo.
            Message("ResultArrayAsBoolArray demo");
            let boolArr = Convert.ResultArrayAsBoolArray(resultArr);
            for i in IndexRange(boolArr)
            {
                Message(Convert.BoolAsString(boolArr[i]));
            }

            // BoolAsResult demo.
            Message("BoolAsResult demo");
            mutable resultFromBool = Convert.BoolAsResult(true);
            if(resultFromBool == One)
            {
                Message("One");
            }
            set resultFromBool = Convert.BoolAsResult(false);
            if(resultFromBool == Zero)
            {
                Message("Zero");
            }

            // BoolArrayAsResultArray demo.
            Message("BoolArrayAsResultArray  demo");
            let boolArray = [true, false, true];
            let resultArrFromBoolArr = Convert.BoolArrayAsResultArray(boolArray);
            if (IsResultOne(resultArrFromBoolArr[0]))
            {
                Message("First Result: One");
            }

            if (IsResultZero(resultArrFromBoolArr[1]))
            {
                Message("Second Result: Zero");
            }

            if (not IsResultZero(resultArrFromBoolArr[2]))
            {
                Message("Third Result: One");
            }

            // IsResultZero demo.
            Message("IsResultZero demo");
            if(IsResultZero(M(qubits[0])) == true){
                Message("Zero");
            }

            // IsResultOne demo.
            Message("IsResultOne demo");
            if(IsResultOne(M(qubits[0])) != true){
                Message("Zero");
            }

            // ResultArrayAsInt demo.
            // 0th entry will be LSB.
            Message("ResultArrayAsInt demo");
            X(qubits[1]);
            mutable resultAsInt = Convert.ResultArrayAsInt(MultiM(qubits));
            // Output will be 2.
            Message(Convert.IntAsString(resultAsInt));

            ResetAll(qubits);

        }
    }
}
