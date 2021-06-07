namespace _18_Demo_Rotations {
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    // Import this library to get Math operations like PI, Sqrt etc.
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Convert as Convert;
    

    @EntryPoint()
    operation HelloQ() : Unit {
        mutable countZero = 0;
        mutable countOne = 0;
        mutable iterations = 1000;

        use qubit = Qubit();
            // Measure without any operation
            for i in 1..iterations
            {
                let result = M(qubit);
                if(IsResultZero(result))
                {
                    set countZero = countZero + 1;
                }
                else
                {
                    set countOne = countOne + 1;
                }
                Reset(qubit);
            }
            Message("Measure without any operation:");
            Message("CountZero: " + Convert.IntAsString(countZero));
            Message("CountOne: " + Convert.IntAsString(countOne));
            

            // Rx(PI(), qubit); 
            // Will make Zero to One
            set countZero = 0;
            set countOne = 0;
            for i in 1..iterations
            {
                Rx(PI(), qubit);
                let result = M(qubit);
                if(IsResultZero(result))
                {
                    set countZero = countZero + 1;
                }
                else
                {
                    set countOne = countOne + 1;
                }
                Reset(qubit);
            }
            Message("Rx(PI(), qubit):");
            Message("CountZero: " + Convert.IntAsString(countZero));
            Message("CountOne: " + Convert.IntAsString(countOne));

            // Ry(PI(), qubit); 
            // Will also make Zero to One
            set countZero = 0;
            set countOne = 0;
            for i in 1..iterations
            {
                Ry(PI(), qubit);
                let result = M(qubit);
                if(IsResultZero(result))
                {
                    set countZero = countZero + 1;
                }
                else
                {
                    set countOne = countOne + 1;
                }
                Reset(qubit);
            }
            Message("Ry(PI(), qubit):");
            Message("CountZero: " + Convert.IntAsString(countZero));
            Message("CountOne: " + Convert.IntAsString(countOne));

            // Rz(PI(), qubit); 
            // Zero will remain as Zero
            set countZero = 0;
            set countOne = 0;
            for i in 1..iterations
            {
                Rz(PI(), qubit);
                let result = M(qubit);
                if(IsResultZero(result))
                {
                    set countZero = countZero + 1;
                }
                else
                {
                    set countOne = countOne + 1;
                }
                Reset(qubit);
            }
            Message("Rz(PI(), qubit):");
            Message("CountZero: " + Convert.IntAsString(countZero));
            Message("CountOne: " + Convert.IntAsString(countOne));

            // Ry(PI()/2.0, qubit); 
            // Same as H
            set countZero = 0;
            set countOne = 0;
            for i in 1..iterations
            {
                Ry(PI()/2.0, qubit);
                let result = M(qubit);
                if(IsResultZero(result))
                {
                    set countZero = countZero + 1;
                }
                else
                {
                    set countOne = countOne + 1;
                }
                Reset(qubit);
            }
            Message("Ry(PI()/2.0, qubit):");
            Message("CountZero: " + Convert.IntAsString(countZero));
            Message("CountOne: " + Convert.IntAsString(countOne));

            // R(PauliX, PI()/2.0, qubit); 
            set countZero = 0;
            set countOne = 0;
            for i in 1..iterations
            {
                // PauliX and PauliZ can also be used; They are similar to Rx, Ry, Rz.
                R(PauliY, PI()/2.0, qubit);
                let result = M(qubit);
                if(IsResultZero(result))
                {
                    set countZero = countZero + 1;
                }
                else
                {
                    set countOne = countOne + 1;
                }
                Reset(qubit);
            }
            Message("R(PauliY, PI()/2.0, qubit):");
            Message("CountZero: " + Convert.IntAsString(countZero));
            Message("CountOne: " + Convert.IntAsString(countOne));

            // R1(PI(), qubit); 
            // Zero will remain as Zero; This is same as Rz. We are changing only the phase of One
            set countZero = 0;
            set countOne = 0;
            for i in 1..iterations
            {
                R1(PI(), qubit);
                let result = M(qubit);
                if(IsResultZero(result))
                {
                    set countZero = countZero + 1;
                }
                else
                {
                    set countOne = countOne + 1;
                }
                Reset(qubit);
            }
            Message("R1(PI(), qubit):");
            Message("CountZero: " + Convert.IntAsString(countZero));
            Message("CountOne: " + Convert.IntAsString(countOne));

            // Ry(angle, qubit).
            // 1/4 probabilityOfZero.
            set countZero = 0;
            set countOne = 0;
            for i in 1..iterations
            {
                let probabilityOfZero = 1.0/4.0;
                let amplitudeOfZero = Sqrt(probabilityOfZero);
                let angle = 2.0 * ArcCos(amplitudeOfZero);
                Ry(angle, qubit);
                let result = M(qubit);
                if(IsResultZero(result))
                {
                    set countZero = countZero + 1;
                }
                else
                {
                    set countOne = countOne + 1;
                }
                Reset(qubit);
            }
            Message("Ry(angle, qubit):");
            Message("CountZero: " + Convert.IntAsString(countZero));
            Message("CountOne: " + Convert.IntAsString(countOne));

        
    }
}

