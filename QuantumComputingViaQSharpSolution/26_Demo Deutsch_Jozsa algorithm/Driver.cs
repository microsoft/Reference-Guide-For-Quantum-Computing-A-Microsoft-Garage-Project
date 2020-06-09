using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum._26_Demo_Deutsch_Jozsa_algorithm
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var simulator = new QuantumSimulator())
            {
                var result = DJAlgo.Run(simulator).Result;
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}