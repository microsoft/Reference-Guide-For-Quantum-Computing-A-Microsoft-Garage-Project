using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum.Demo_M
{
    class Driver
    {
        static void Main(string[] args)
        {
            using(var quantumSimulator = new QuantumSimulator())
            {
                // For every operation defined in the .qs file, a corresponding class will be
                // created with a static async Run method.
                var result = DemoOperation.Run(quantumSimulator).Result;
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}