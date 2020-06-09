#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Demo_M", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\02_Demo using-M-Message-let-Zero-One\\Operation.qs", 140L, 7L, 5L)]
#line hidden
namespace Quantum.Demo_M
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release) };
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

        public override Func<QVoid, QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Demo_M.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    // Here we are creating an array of one Qubit
                    // By default all Qubits will be set to Zero
#line 12 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\02_Demo using-M-Message-let-Zero-One\\Operation.qs"
                    var qubits = Allocate.Apply(1L);
                    // M is used to measure a qubit.
                    // it returns output of type Result. It can be either Zero or One.
                    // let will create an immutable variable. Once assigned it can't be changed.
                    // immutables will give better performance as compiler may optimize our code.
#line 18 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\02_Demo using-M-Message-let-Zero-One\\Operation.qs"
                    var r = M.Apply<Result>(qubits[0L]);
                    // Since we performed no operation, the Result will always be Zero.
#line 20 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\02_Demo using-M-Message-let-Zero-One\\Operation.qs"
                    if ((r == Result.Zero))
                    {
                        // Message will print a string.
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\02_Demo using-M-Message-let-Zero-One\\Operation.qs"
                        Message.Apply("Zero");
                    }
                    else if ((r == Result.One))
                    {
#line 27 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\02_Demo using-M-Message-let-Zero-One\\Operation.qs"
                        Message.Apply("One");
                    }

#line hidden
                    Release.Apply(qubits);
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Demo_M.DemoOperation", OperationFunctor.Body, __result__);
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