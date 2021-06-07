using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Linq;

namespace Quantum._22_Demo_Grover_s_Algorithm_Classical_Simulation
{
    class Driver
    {
        //This program has no Q# code as it is only a simulation to demostrate the Grover's algo
        static void Main(string[] args)
        {
            int numberOfStates = (int)Math.Pow(2, 4);
            int numberBeingSearched = 9;
            double[] amplitudesOfAllTheStates = new double[numberOfStates];

            //Initiatlly, there will be an amplitude of 1 for |0000>, and 0 for all others.
            amplitudesOfAllTheStates[0] = 1;
            Console.WriteLine("We are searching for 9 in this example, so observe the changes to the amplitude of 9.");
            Console.WriteLine("\nInitial Amplitudes:");
            for (int i = 0; i < amplitudesOfAllTheStates.Length; i++)
            {
                Console.Write(i + ": " + Math.Round(amplitudesOfAllTheStates[i], 2) + "; ");
            }

            //Apply H on all the 4 qubits. 
            //This will change the amplitudes of all the qubits to 1/Sqrt(numberOfStates)
            for (int i = 0; i < amplitudesOfAllTheStates.Length; i++)
            {
                amplitudesOfAllTheStates[i] = 1 / Math.Sqrt(numberOfStates);
            }

            //Will be uploading a video soon to give proof for this
            int numberOfIterationsNeeded = (int)Math.Round(
                                                        (
                                                         Math.PI
                                                            /
                                                        (
                                                         4.0
                                                         *
                                                         Math.Asin(1.0 / Math.Sqrt(numberOfStates))
                                                        )
                                                        ) - 0.5);

            Console.WriteLine("\n\nAmplitudes after applying H on all the Qubits:");
            for (int i = 0; i < amplitudesOfAllTheStates.Length; i++)
            {
                Console.Write(i + ": " + Math.Round(amplitudesOfAllTheStates[i], 2) + "; ");
            }

            //Observe the amplitudes at the end of each iteration.
            for (int i = 0; i < numberOfIterationsNeeded; i++)
            {

                //Step 1
                //Flip the amplitude of the state we are searching for
                amplitudesOfAllTheStates[numberBeingSearched] = -1 * amplitudesOfAllTheStates[numberBeingSearched];
                Console.WriteLine("\n\nAmplitudes after iteration " + (i + 1) + " Step 1 (flipping the amplitude of required number):");
                //Final amplitudes.
                //The amplitude will be close to 1 for the number we are searching for; 9 in this case
                //All other amplitudes will be close to 0.
                for (int k = 0; k < amplitudesOfAllTheStates.Length; k++)
                {
                    Console.Write(k + ": " + Math.Round(amplitudesOfAllTheStates[k], 2) + "; ");
                }

                //Step 2
                //Reflect each amplitude over the mean.
                //Mathematically this is same as newAmplitude = 2 * mean - oldAmplitude
                var meanOfAllAmplitudes = amplitudesOfAllTheStates.Average();
                for (int j = 0; j < amplitudesOfAllTheStates.Length; j++)
                {
                    amplitudesOfAllTheStates[j] = 2 * meanOfAllAmplitudes - amplitudesOfAllTheStates[j];
                }

                Console.WriteLine("\n\nAmplitudes after iteration " + (i + 1) + " Step 2 (newAplitude = 2 * meanOfAllAmplitudes - oldAmplitude):");
                //Final amplitudes.
                //The amplitude will be close to 1 for the number we are searching for; 9 in this case
                //All other amplitudes will be close to 0.
                for (int k = 0; k < amplitudesOfAllTheStates.Length; k++)
                {
                    Console.Write(k + ": " + Math.Round(amplitudesOfAllTheStates[k], 2) + "; ");
                }

            }

            Console.WriteLine("\n\nFinal Amplitudes:");
            //Final amplitudes.
            //The amplitude will be close to 1 for the number we are searching for; 9 in this case
            //All other amplitudes will be close to 0.
            for (int i = 0; i < amplitudesOfAllTheStates.Length; i++)
            {
                Console.Write(i + ": " + Math.Round(amplitudesOfAllTheStates[i], 2) + "; ");
            }

            Console.WriteLine("\n\nDone");
            Console.ReadLine();
        }
    }
}