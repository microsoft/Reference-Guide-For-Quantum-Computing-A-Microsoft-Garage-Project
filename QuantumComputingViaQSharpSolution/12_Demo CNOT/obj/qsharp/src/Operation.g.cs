#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._03_Demo_X", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs", 188L, 8L, 5L)]
#line hidden
namespace Quantum._03_Demo_X
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Canon.MultiM), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Canon.ResultAsInt), typeof(Microsoft.Quantum.Canon.Subarray<>), typeof(Microsoft.Quantum.Extensions.Convert.ToStringI), typeof(Microsoft.Quantum.Primitive.X) };
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit)>, Microsoft.Quantum.Primitive.CNOT>();
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

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Result>, Int64>, Microsoft.Quantum.Canon.ResultAsInt>();
            }
        }

        protected ICallable MicrosoftQuantumCanonSubarray
        {
            get
            {
                return new GenericOperation(this.Factory, typeof(Microsoft.Quantum.Canon.Subarray<>));
            }
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get
            {
                return this.Factory.Get<ICallable<Int64, String>, Microsoft.Quantum.Extensions.Convert.ToStringI>();
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
#line 11 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    var qubits = Allocate.Apply(2L);
#line 13 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    Message.Apply("Input: 0-0");
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    var results = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
#line 16 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    Message.Apply(((("Output: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {0L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {1L}, results))))));
#line 18 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    ResetAll.Apply(qubits);
#line 20 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    Message.Apply("\nInput: 0-1");
#line 21 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    results = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
#line 24 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    Message.Apply(((("Output: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {0L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {1L}, results))))));
#line 26 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    ResetAll.Apply(qubits);
#line 28 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    Message.Apply("\nInput: 1-0");
#line 29 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 30 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 31 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    results = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
#line 32 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    Message.Apply(((("Output: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {0L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {1L}, results))))));
#line 34 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    ResetAll.Apply(qubits);
#line 36 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    Message.Apply("\nInput: 1-1");
#line 37 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 38 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
#line 39 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 40 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    results = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
#line 41 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
                    Message.Apply(((("Output: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {0L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {1L}, results))))));
#line 43 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\12_Demo CNOT\\Operation.qs"
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