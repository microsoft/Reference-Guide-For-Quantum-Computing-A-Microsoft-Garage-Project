#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._05_Demo_MultiM_ResetAll", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\06_Demo H\\Operation.qs", 202L, 8L, 5L)]
#line hidden
namespace Quantum._05_Demo_MultiM_ResetAll
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Canon.BoolFromResult), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Extensions.Convert.ToStringB) };
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

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonBoolFromResult
        {
            get
            {
                return this.Factory.Get<ICallable<Result, Boolean>, Microsoft.Quantum.Canon.BoolFromResult>();
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

        protected ICallable<Boolean, String> MicrosoftQuantumExtensionsConvertToStringB
        {
            get
            {
                return this.Factory.Get<ICallable<Boolean, String>, Microsoft.Quantum.Extensions.Convert.ToStringB>();
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
#line 11 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\06_Demo H\\Operation.qs"
                    var qubits = Allocate.Apply(1L);
                    // Applying Hadamard on the qubit
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\06_Demo H\\Operation.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\06_Demo H\\Operation.qs"
                    var result = M.Apply<Result>(qubits[0L]);
                    //This output might change for every execution
                    //because H will put the qubit in a 50/50 superposition of 0 and 1
#line 18 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\06_Demo H\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringB.Apply<String>(MicrosoftQuantumCanonBoolFromResult.Apply<Boolean>(result)));
#line 19 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\06_Demo H\\Operation.qs"
                    ResetAll.Apply(qubits);
#line hidden
                    Release.Apply(qubits);
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