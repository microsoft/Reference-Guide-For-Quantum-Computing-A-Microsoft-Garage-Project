#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._03_Demo_X", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs", 188L, 8L, 5L)]
#line hidden
namespace Quantum._03_Demo_X
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.CCNOT), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Canon.MultiM), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Canon.ResultAsInt), typeof(Microsoft.Quantum.Canon.Subarray<>), typeof(Microsoft.Quantum.Extensions.Convert.ToStringI), typeof(Microsoft.Quantum.Primitive.X) };
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

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>, Microsoft.Quantum.Primitive.CCNOT>();
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
#line 11 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    var qubits = Allocate.Apply(3L);
#line 13 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    Message.Apply("Input: 0-0-0");
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    var results = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
#line 16 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    Message.Apply(((((("Output: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {0L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {1L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {2L}, results))))));
#line 19 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    ResetAll.Apply(qubits);
#line 21 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    Message.Apply("\nInput: 0-0-1");
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[2L]);
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
#line 24 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    results = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
#line 25 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    Message.Apply(((((("Output: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {0L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {1L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {2L}, results))))));
#line 28 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    ResetAll.Apply(qubits);
#line 30 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    Message.Apply("\nInput: 1-0-0");
#line 31 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 32 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
#line 33 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    results = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
#line 34 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    Message.Apply(((((("Output: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {0L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {1L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {2L}, results))))));
#line 37 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    ResetAll.Apply(qubits);
#line 39 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    Message.Apply("\nInput: 1-1-0");
#line 40 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 41 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
#line 42 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
#line 43 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    results = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
#line 44 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
                    Message.Apply(((((("Output: " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {0L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {1L}, results))))) + "-") + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonSubarray.Apply<QArray<Result>>((new QArray<Int64>()
                    {2L}, results))))));
#line 47 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\13_Demo CCNOT\\Operation.qs"
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