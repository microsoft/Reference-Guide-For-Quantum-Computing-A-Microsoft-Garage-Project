using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum._27_Demo_Simon_s_Algorithm
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                HelloQ.Run(qsim).Wait();
                Console.WriteLine("\nDone");
                Console.ReadLine();
            }
        }
    }
}