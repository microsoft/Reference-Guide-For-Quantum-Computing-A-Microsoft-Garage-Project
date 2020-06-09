using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum._23_Demo_Grover_s_Algorithm
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var simulator = new QuantumSimulator())
            {
                //We are trying to simulate the Grover's algo for a 5 qubit system.
                var pattern = new Microsoft.Quantum.Simulation.Core.QArray<bool>(5);
                // We are trying to find 10100
                // If we measure the system at the end of the algorithem, we should get 10100
                pattern[0] = true;
                pattern[1] = false;
                pattern[2] = true;
                pattern[3] = false;
                pattern[4] = false;
                var result = GenericGroversAlgo.Run(simulator, 5, pattern).Result;
            }
            Console.ReadLine();
        }
    }
}