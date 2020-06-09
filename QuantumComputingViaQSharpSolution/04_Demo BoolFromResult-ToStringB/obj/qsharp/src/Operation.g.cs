#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._04_Demo_ResetAll", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\04_Demo BoolFromResult-ToStringB\\Operation.qs", 252L, 9L, 5L)]
#line hidden
namespace Quantum._04_Demo_ResetAll
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Canon.BoolFromResult), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.Reset), typeof(Microsoft.Quantum.Extensions.Convert.ToStringB), typeof(Microsoft.Quantum.Primitive.X) };
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

        protected ICallable<Boolean, String> MicrosoftQuantumExtensionsConvertToStringB
        {
            get
            {
                return this.Factory.Get<ICallable<Boolean, String>, Microsoft.Quantum.Extensions.Convert.ToStringB>();
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
                this.Factory.StartOperation("Quantum._04_Demo_ResetAll.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
#line 12 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\04_Demo BoolFromResult-ToStringB\\Operation.qs"
                    var qubits = Allocate.Apply(1L);
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\04_Demo BoolFromResult-ToStringB\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\04_Demo BoolFromResult-ToStringB\\Operation.qs"
                    var r = M.Apply<Result>(qubits[0L]);
                    //Message will only take strings.
                    // First convert the Result to Bool
                    // Then convert the bool to String
#line 19 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\04_Demo BoolFromResult-ToStringB\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringB.Apply<String>(MicrosoftQuantumCanonBoolFromResult.Apply<Boolean>(r)));
#line 20 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\04_Demo BoolFromResult-ToStringB\\Operation.qs"
                    Reset.Apply(qubits[0L]);
#line hidden
                    Release.Apply(qubits);
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum._04_Demo_ResetAll.DemoOperation", OperationFunctor.Body, __result__);
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