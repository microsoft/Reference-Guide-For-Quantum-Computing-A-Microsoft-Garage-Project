namespace Quantum._08_Demo_Parameters {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert;
    
    @EntryPoint()
    operation HelloQ () : Unit {
        let iterations = 1000;
        let message = "Starting to measure the output of H gate by running it " + IntAsString(iterations) + " number of times.";
        let (zeroCount, oneCount) = CountZeroesAndOnes(iterations, message);
        Message($"Number of Zeroes: {zeroCount}");
        Message($"Number of Onoes: {oneCount}");
    }

    // Changed the signature to take a tuple with two values and
	// return a tuple with two values.
	// Number of values in the tuple can be anything.
    operation CountZeroesAndOnes(iterations: Int, message: String) : (Int,Int){
        Message(message);
        mutable countZeroes = 0;
        mutable countOnes = 0;
        // Using the parameter from the EntryPoint operation.
        for iter in 1..iterations
        {
            use qubit = Qubit();
            // Applying Hadamard on the qubit
            H(qubit);
            let result = M(qubit);
            if(IsResultZero(result))
            {
                set countZeroes = countZeroes + 1;
            }
            if(IsResultOne(result))
            {
                set countOnes = countOnes + 1;
            }

            // Resetting the qubit to Zero at the end of every iteration.
            Reset(qubit);
        }
        
        // Returning the count of zeroes and ones as a tuple with two values.
        // You can return a tuple with one value also.
        return (countZeroes, countOnes);
    }
}
