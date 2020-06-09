#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._05_Demo_MultiM_ResetAll", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs", 202L, 8L, 5L)]
#line hidden
namespace Quantum._05_Demo_MultiM_ResetAll
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Extensions.Convert.ToStringI) };
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

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get
            {
                return this.Factory.Get<ICallable<Int64, String>, Microsoft.Quantum.Extensions.Convert.ToStringI>();
            }
        }

        public override Func<QVoid, QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum._05_Demo_MultiM_ResetAll.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    //Unlike let, variables declared as mutable can be modified later.
                    // Data type is infered during initialization. Her it is Int.
#line 13 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                    var countZeroes = 0L;
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                    var countOnes = 0L;
                    //Running the for loop for 1000 times
#line 16 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                    foreach (var iter in new Range(1L, 1000L))
                    {
#line 18 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                        var qubits = Allocate.Apply(1L);
                        // Applying Hadamard on the qubit
#line 21 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 25 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                            countZeroes = (countZeroes + 1L);
                        }

#line 27 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                        if ((result == Result.One))
                        {
#line 29 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                            countOnes = (countOnes + 1L);
                        }

                        //Resetting the qubit to Zero at the end of every iteration.
#line 32 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                        ResetAll.Apply(qubits);
#line hidden
                        Release.Apply(qubits);
                    }

                    //ToStringI will convert an integer to string
                    // Since we have executed the loop for 1000 times.
                    // Each count should be approximately equal to 500.
                    // But it might vary on each execution.
#line 39 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                    Message.Apply(("countZeroes: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZeroes)));
#line 40 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\07_Demo H count-mutable-set-for-ToStringI\\Operation.qs"
                    Message.Apply(("countOnes: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOnes)));
#line hidden
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

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<DemoOperation, QVoid, QVoid>(QVoid.Instance);
        }
    }
}