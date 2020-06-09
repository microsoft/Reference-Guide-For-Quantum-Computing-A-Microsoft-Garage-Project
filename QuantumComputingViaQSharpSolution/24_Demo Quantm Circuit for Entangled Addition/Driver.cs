using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum._24_Demo_Quantm_Circuit_for_Addition
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                //Running the simulation 100 times.
                for (var i = 0; i < 100; i++)
                {
                    var r = Operation.Run(sim).Result;
                }
            }
            System.Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}