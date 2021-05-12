namespace Quantum._09_Demo_randomNumberGenerator {

    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    
    operation RandomNumberGenerator() : Result {
        use qubit = Qubit();
            
        return MResetX(qubit);
        
    }

    operation RandomNumberInRange(max : Int) : Int {
        mutable bits = new Result[0];

        for idxBit in 1..BitSizeI(max) {
            
            set bits += [RandomNumberGenerator()];
        
        }
        
        // Coverting Bit Array to give an Int
        let sample = ResultArrayAsInt(bits);
        
        // In case the random number generated is greater than max value, max value is returned.
        return sample > max ? RandomNumberInRange(max) | sample;
    }
    
    @EntryPoint()
    operation RandomNumber() : Int {
        
        // pre-setting the max value as 100
        let max = 100;

        Message($"Sampling a random number between 0 and {max}: ");
        
        return RandomNumberInRange(max);

    }
}
