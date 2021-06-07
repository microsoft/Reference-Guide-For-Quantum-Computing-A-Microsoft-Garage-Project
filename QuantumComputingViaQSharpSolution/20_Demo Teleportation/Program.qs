namespace Quantum._20_Demo_Teleportation {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Convert;
    
    @EntryPoint()
    operation HelloQ () : Unit {
        mutable iterations = 1000;
        mutable countZero = 0;
        mutable countOne = 0;

        // Circuit diagram located here.
        // https://www.media.mit.edu/quanta/qasm2circ/test2.png
        use qubits = Qubit[3];
        
        let sourceQubit = qubits[0];
        let tempQubit = qubits[1];
        let destinationQubit = qubits[2];
        
        // iterations needed only for testing.
        for i in 1..iterations
        {
            // Setting the sourceQubit in such a way that it has 25% probabilityOfZero.
            let probabilityOfZero = 1.0/4.0;
            let amplitudeOfZero = Sqrt(probabilityOfZero);
            let angle = 2.0 * ArcCos(amplitudeOfZero);
            Rx(angle, qubits[0]);

            // Teleportation start.
            H(tempQubit);
            CNOT(tempQubit, destinationQubit);
            CNOT(sourceQubit, tempQubit);
            H(sourceQubit);

            let resultSource = M(sourceQubit);
            let resultTemp = M(tempQubit);

            if(resultTemp == One)
            {
                X(destinationQubit);
            }

            if(resultSource == One)
            {
                Z(destinationQubit);
            }
            // Teleportation completed in the above step.

            // Following code tests if the Teleportation succeded or not.
            let resultDestination = M(destinationQubit);

            if(resultDestination == Zero)
            {
                set countZero = countZero + 1;
            }
            else
            {
                set countOne = countOne + 1;
            }

             ResetAll(qubits);
        }

        // CountZero should be close to 250 and CountOne should be close to 750.
        Message("CountZero:" + IntAsString(countZero));
        Message("CountOne:" + IntAsString(countOne));
    }
}
