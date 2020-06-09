using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum._05_Demo_MultiM_ResetAll
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var quantumSimulator = new QuantumSimulator())
            {
                var result = DemoOperation.Run(quantumSimulator,50,"Hello").Result;
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