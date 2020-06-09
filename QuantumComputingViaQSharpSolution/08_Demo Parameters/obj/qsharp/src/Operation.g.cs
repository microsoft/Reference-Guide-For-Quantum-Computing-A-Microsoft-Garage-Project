#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._05_Demo_MultiM_ResetAll", "DemoOperation (iterations : Int, message : String) : (Int, Int)", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs", 388L, 11L, 5L)]
#line hidden
namespace Quantum._05_Demo_MultiM_ResetAll
{
    public class DemoOperation : Operation<(Int64,String), (Int64,Int64)>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected Allocate Allocate
        {
            get
            {
                return this.Factory.Get<Allocate, Microsoft.Quantum.Primitive.Allocate>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected ICallable<String, QVoid> Message
        {
            get
            {
                return this.Factory.Get<ICallable<String, QVoid>, Microsoft.Quantum.Primitive.Message>();
            }
        }

        protected Release Release
        {
            get
            {
                return this.Factory.Get<Release, Microsoft.Quantum.Primitive.Release>();
            }
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Qubit>, QVoid>, Microsoft.Quantum.Primitive.ResetAll>();
            }
        }

        public override Func<(Int64,String), (Int64,Int64)> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum._05_Demo_MultiM_ResetAll.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default((Int64,Int64));
                try
                {
                    var (iterations,message) = _args;
                    //Printing the message received as input
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                    Message.Apply(message);
#line 16 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                    var countZeroes = 0L;
#line 17 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                    var countOnes = 0L;
                    //Using the parameter from the Driver
#line 19 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                    foreach (var iter in new Range(1L, iterations))
                    {
#line 21 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                        var qubits = Allocate.Apply(1L);
                        // Applying Hadamard on the qubit
#line 24 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 25 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 26 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 28 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                            countZeroes = (countZeroes + 1L);
                        }

#line 30 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                        if ((result == Result.One))
                        {
#line 32 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                            countOnes = (countOnes + 1L);
                        }

                        //Resetting the qubit to Zero at the end of every iteration.
#line 35 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                        ResetAll.Apply(qubits);
#line hidden
                        Release.Apply(qubits);
                    }

#line hidden
                    __result__ = (countZeroes, countOnes);
                    //Returning the counts as a tuple with two values.
                    // You can return a tuple with one value also
#line 40 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\08_Demo Parameters\\Operation.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum._05_Demo_MultiM_ResetAll.DemoOperation", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 iterations, String message)
        {
            return __m__.Run<DemoOperation, (Int64,String), (Int64,Int64)>((iterations, message));
        }
    }
}