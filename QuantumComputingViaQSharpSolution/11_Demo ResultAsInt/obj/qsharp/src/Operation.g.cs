#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._03_Demo_X", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs", 188L, 8L, 5L)]
#line hidden
namespace Quantum._03_Demo_X
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Canon.ResultAsInt), typeof(Microsoft.Quantum.Extensions.Convert.ToStringI) };
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

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Result>, Int64>, Microsoft.Quantum.Canon.ResultAsInt>();
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
                this.Factory.StartOperation("Quantum._03_Demo_X.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
#line 11 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    var qubits = Allocate.Apply(2L);
                    //ResultAsInt will take an array of results and returns an integer.
                    // The input array is considered to be LittleEndian
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    Message.Apply("[Zero;Zero]:");
#line 16 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    var value = MicrosoftQuantumCanonResultAsInt.Apply<Int64>(new QArray<Result>()
                    {Result.Zero, Result.Zero});
#line 17 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(value));
                    //This will give 2 because the input is considered LittleEndian
#line 20 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    Message.Apply("[Zero;One]:");
#line 21 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    value = MicrosoftQuantumCanonResultAsInt.Apply<Int64>(new QArray<Result>()
                    {Result.Zero, Result.One});
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(value));
                    //This will give 1 because the input is considered LittleEndian
#line 25 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    Message.Apply("[One;Zero]:");
#line 26 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    value = MicrosoftQuantumCanonResultAsInt.Apply<Int64>(new QArray<Result>()
                    {Result.One, Result.Zero});
#line 27 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(value));
#line 29 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    Message.Apply("[One;One]:");
#line 30 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    value = MicrosoftQuantumCanonResultAsInt.Apply<Int64>(new QArray<Result>()
                    {Result.One, Result.One});
#line 31 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(value));
#line 33 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\11_Demo ResultAsInt\\Operation.qs"
                    ResetAll.Apply(qubits);
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