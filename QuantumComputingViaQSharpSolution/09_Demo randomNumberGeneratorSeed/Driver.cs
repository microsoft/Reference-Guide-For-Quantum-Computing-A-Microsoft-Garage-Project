using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum._09_Demo_Temp
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Passing the randomNumberGeneratorSeed will make the output deterministic.
            //If this parameter is omitted, every time the program is executed we get two differnt counts.
            //But if we set this seed to some constant number, then everytime we get the same counts.
            using (var quantumSimulator = new QuantumSimulator(randomNumberGeneratorSeed: 10))
            {
                var result = DemoOperation.Run(quantumSimulator, 50, "Hello").Result;
                //To split the tuple into individual variables
                var (countZeroes, countOnes) = result;
                Console.WriteLine("countZeroes: " + countZeroes);
                Console.WriteLine("countOnes: " + countOnes);
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}