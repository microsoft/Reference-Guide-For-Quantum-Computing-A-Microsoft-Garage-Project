#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._05_Demo_MultiM_ResetAll", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\05_Demo MultiM-ResetAll\\Operation.qs", 202L, 8L, 5L)]
#line hidden
namespace Quantum._05_Demo_MultiM_ResetAll
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Canon.BoolFromResult), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Canon.MultiM), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Extensions.Convert.ToStringB), typeof(Microsoft.Quantum.Primitive.X) };
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

        protected ICallable<String, QVoid> Message
        {
            get
            {
                return this.Factory.Get<ICallable<String, QVoid>, Microsoft.Quantum.Primitive.Message>();
            }
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>, Microsoft.Quantum.Canon.MultiM>();
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
                this.Factory.StartOperation("Quantum._05_Demo_MultiM_ResetAll.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    // Creating an array of two qubits
#line 12 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\05_Demo MultiM-ResetAll\\Operation.qs"
                    var qubits = Allocate.Apply(2L);
                    // Reversing the second qubit.
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\05_Demo MultiM-ResetAll\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
                    //MultiM will measure all the qubits in the array
                    //and retuns an array of Result datatype.
#line 18 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\05_Demo MultiM-ResetAll\\Operation.qs"
                    var results = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
#line 19 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\05_Demo MultiM-ResetAll\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringB.Apply<String>(MicrosoftQuantumCanonBoolFromResult.Apply<Boolean>(results[0L])));
#line 20 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\05_Demo MultiM-ResetAll\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringB.Apply<String>(MicrosoftQuantumCanonBoolFromResult.Apply<Boolean>(results[1L])));
                    //ResetAll will reset all the qubits in the array.
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\05_Demo MultiM-ResetAll\\Operation.qs"
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