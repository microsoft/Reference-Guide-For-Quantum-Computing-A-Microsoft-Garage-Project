#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._03_Demo_X", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\03_Demo X-Reset\\Operation.qs", 144L, 7L, 5L)]
#line hidden
namespace Quantum._03_Demo_X
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.Reset), typeof(Microsoft.Quantum.Primitive.X) };
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

        protected ICallable<Qubit, QVoid> Reset
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, QVoid>, Microsoft.Quantum.Primitive.Reset>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<QVoid, QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum._03_Demo_X.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
#line 10 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\03_Demo X-Reset\\Operation.qs"
                    var qubits = Allocate.Apply(1L);
                    //Applying X will reverse the value.
#line 13 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\03_Demo X-Reset\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\03_Demo X-Reset\\Operation.qs"
                    var r = M.Apply<Result>(qubits[0L]);
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\03_Demo X-Reset\\Operation.qs"
                    if ((r == Result.Zero))
                    {
#line 17 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\03_Demo X-Reset\\Operation.qs"
                        Message.Apply("Zero");
                    }
                    else if ((r == Result.One))
                    {
                        //Output will be one.
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\03_Demo X-Reset\\Operation.qs"
                        Message.Apply("One");
                    }

                    // At the end of using, we need to Reset all the qubits to Zero
#line 25 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\03_Demo X-Reset\\Operation.qs"
                    Reset.Apply(qubits[0L]);
#line hidden
                    Release.Apply(qubits);
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum._03_Demo_X.DemoOperation", OperationFunctor.Body, __result__);
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