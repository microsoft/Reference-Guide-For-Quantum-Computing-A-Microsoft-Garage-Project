namespace _25_Demo_Shor_s_Algorithm_Classical_Simulation
{
    using System;
    using System.Numerics;

    class Shor_s_Algorithm
    {
        // This is only a classical simulation for Shor's algo just for demonstration.
        // So there will not be any Q# code.
        static void Main(string[] args)
        {
            BigInteger N = 15; // Number we are trying to factorize.
            BigInteger Q = 256; // Next highest power of 2 nearest to N^2 (225) 
            BigInteger a = 7; // 7 is co-prime of 15. a should be a random number less than 15 that is also a co-prime of 15

            var arrAmp = new Complex[(int)Q];
            var arrModExp = new BigInteger[arrAmp.Length];

            // Initial amplitudes after applying H on all the bits
            for (int i = 0; i < arrAmp.Length; i++)
            {
                arrAmp[i] = 1 / Math.Sqrt(arrAmp.Length);
            }

            // Calculating a ^ x Mod N for all Q entries
            for (int i = 0; i < arrModExp.Length; i++)
            {
                arrModExp[i] = BigInteger.ModPow(a, i, N);
            }

            double count4 = 0;

            // Let's say we found 4 as output.
            for (int i = 0; i < arrModExp.Length; i++)
            {
                if (arrModExp[i] == 4)
                {
                    count4++;
                }
            }

            // Calculating the probability of getting 4
            var prob4 = ((double)1) / count4;

            // Calculating the amplitude. Seeting the non-4 amplitues to zero
            for (int i = 0; i < arrAmp.Length; i++)
            {
                if (arrModExp[i] == 4)
                {
                    arrAmp[i] = Math.Sqrt(prob4);
                }
                else
                {
                    arrAmp[i] = 0;
                }
            }

            // Calculating QFT
            var arrAmpQFT = new Complex[arrAmp.Length];

            for (int i = 0; i < arrAmpQFT.Length; i++)
            {
                Complex tempSum = 0;
                for (int j = 0; j < arrAmp.Length; j++)
                {
                    tempSum = tempSum + (arrAmp[j] * Complex.Exp(((double)2) * Math.PI * Complex.ImaginaryOne * ((double)i) * ((double)j) / ((double)Q)));
                }
                arrAmpQFT[i] = tempSum / Math.Sqrt((double)Q);
            }

            double totalProb = 0;
            for (int i = 0; i < arrAmpQFT.Length; i++)
            {
                totalProb = totalProb + Math.Pow(arrAmpQFT[i].Magnitude, 2);
            }

            // If this is one, the above code is correct
            Console.WriteLine("Total Probability: " + totalProb);

            for (int i = 0; i < arrModExp.Length; i++)
            {
                Console.WriteLine(i + " - " +
                    arrModExp[i] + " - " +
                    arrAmp[i].Magnitude + " - " +
                    arrAmpQFT[i].Magnitude + " - " +
                    (arrAmpQFT[i].Magnitude > 0.1 ? arrAmpQFT[i].Magnitude : 0));
            }

            for (int i = 0; i < arrModExp.Length; i++)
            {
                if (arrAmpQFT[i].Magnitude > 0.1)
                {
                    Console.WriteLine(i + " - " +
                        arrModExp[i] + " - " +
                        arrAmp[i].Magnitude + " - " +
                        arrAmpQFT[i].Magnitude + " - " +
                        arrAmpQFT[i].Magnitude);
                }
            }

            // We will get multiples of 64 as output.
            // x = L * (Q / r) // Here x is the measured output// L could be 0, 1, 2...
            // In the above equation we know x and Q and we need r
            // x/Q = L/r
            // We might have to run the quantum algo a few times to find the correct answer
            // We should discard r if r is odd
            // We should discard r if N divies a^(r/2)-1 or a^(r/2) + 1
            // From which we can find r; r = 4 in this case
            // GCD of a^r/2 - 1, 15 and a^r/2 + 1, 15 will result in 3 and 5 which is the required answer
            // If you don't get the answer, try with multiples of r for a few times. If you still don't get, then restart the algo with a different a
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
