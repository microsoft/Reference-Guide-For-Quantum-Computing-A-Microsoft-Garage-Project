#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._03_Demo_X", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs", 188L, 8L, 5L)]
#line hidden
namespace Quantum._03_Demo_X
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Canon.BoolArrFromResultArr), typeof(Microsoft.Quantum.Canon.BoolFromResult), typeof(Microsoft.Quantum.Canon.IsResultOne), typeof(Microsoft.Quantum.Canon.IsResultZero), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Canon.MultiM), typeof(Microsoft.Quantum.Canon.PositiveIntFromResultArr), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Canon.ResultArrFromBoolArr), typeof(Microsoft.Quantum.Canon.ResultAsInt), typeof(Microsoft.Quantum.Canon.ResultFromBool), typeof(Microsoft.Quantum.Extensions.Convert.ToStringB), typeof(Microsoft.Quantum.Extensions.Convert.ToStringI), typeof(Microsoft.Quantum.Primitive.X) };
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

        protected ICallable<QArray<Result>, QArray<Boolean>> MicrosoftQuantumCanonBoolArrFromResultArr
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Result>, QArray<Boolean>>, Microsoft.Quantum.Canon.BoolArrFromResultArr>();
            }
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonBoolFromResult
        {
            get
            {
                return this.Factory.Get<ICallable<Result, Boolean>, Microsoft.Quantum.Canon.BoolFromResult>();
            }
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonIsResultOne
        {
            get
            {
                return this.Factory.Get<ICallable<Result, Boolean>, Microsoft.Quantum.Canon.IsResultOne>();
            }
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonIsResultZero
        {
            get
            {
                return this.Factory.Get<ICallable<Result, Boolean>, Microsoft.Quantum.Canon.IsResultZero>();
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

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>, Microsoft.Quantum.Canon.MultiM>();
            }
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonPositiveIntFromResultArr
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Result>, Int64>, Microsoft.Quantum.Canon.PositiveIntFromResultArr>();
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

        protected ICallable<QArray<Boolean>, QArray<Result>> MicrosoftQuantumCanonResultArrFromBoolArr
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Boolean>, QArray<Result>>, Microsoft.Quantum.Canon.ResultArrFromBoolArr>();
            }
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Result>, Int64>, Microsoft.Quantum.Canon.ResultAsInt>();
            }
        }

        protected ICallable<Boolean, Result> MicrosoftQuantumCanonResultFromBool
        {
            get
            {
                return this.Factory.Get<ICallable<Boolean, Result>, Microsoft.Quantum.Canon.ResultFromBool>();
            }
        }

        protected ICallable<Boolean, String> MicrosoftQuantumExtensionsConvertToStringB
        {
            get
            {
                return this.Factory.Get<ICallable<Boolean, String>, Microsoft.Quantum.Extensions.Convert.ToStringB>();
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
#line 11 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var qubits = Allocate.Apply(2L);
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var result = M.Apply<Result>(qubits[0L]);
                    //BoolFromResult
#line 16 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringB.Apply<String>(MicrosoftQuantumCanonBoolFromResult.Apply<Boolean>(result)));
#line 18 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var resultArr = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits);
                    //BoolArrFromResultArr
#line 20 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var boolArr = MicrosoftQuantumCanonBoolArrFromResultArr.Apply<QArray<Boolean>>(resultArr);
#line 21 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    foreach (var i in new Range(0L, (boolArr.Count - 1L)))
                    {
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                        Message.Apply(MicrosoftQuantumExtensionsConvertToStringB.Apply<String>(boolArr[i]));
                    }

                    //ResultFromBool
#line 27 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var resultFromBool = MicrosoftQuantumCanonResultFromBool.Apply<Result>(true);
#line 28 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    if ((resultFromBool == Result.One))
                    {
#line 30 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                        Message.Apply("One");
                    }

                    //ResultArrFromBoolArr
#line 34 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var resultArrFromBoolArr = MicrosoftQuantumCanonResultArrFromBoolArr.Apply<QArray<Result>>(new QArray<Boolean>()
                    {true, false, true});
#line 35 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    if ((resultArrFromBoolArr[0L] == Result.One))
                    {
#line 37 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                        Message.Apply("One");
                    }

                    //IsResultZero
#line 41 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var isResultZero = MicrosoftQuantumCanonIsResultZero.Apply<Boolean>(M.Apply<Result>(qubits[0L]));
#line 42 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    if ((isResultZero == true))
                    {
#line 43 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                        Message.Apply("Zero");
                    }

                    //IsResultOne
#line 47 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var isResultOne = MicrosoftQuantumCanonIsResultOne.Apply<Boolean>(M.Apply<Result>(qubits[0L]));
#line 48 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    if ((isResultOne != true))
                    {
#line 49 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                        Message.Apply("Zero");
                    }

                    //ResultAsInt
                    //0th entry will be LSB
#line 54 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
#line 55 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var resultAsInt = MicrosoftQuantumCanonResultAsInt.Apply<Int64>(MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits));
                    //Output will be 2
#line 57 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(resultAsInt));
                    //PositiveIntFromResultArr
#line 60 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    var positiveIntFromResultArr = MicrosoftQuantumCanonPositiveIntFromResultArr.Apply<Int64>(MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(qubits));
                    //Output will be 2
#line 62 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(positiveIntFromResultArr));
#line 64 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\16_Demo bool-result-int-conversions\\Operation.qs"
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