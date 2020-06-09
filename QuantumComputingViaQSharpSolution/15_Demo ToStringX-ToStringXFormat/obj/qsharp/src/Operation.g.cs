#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Demo_ToStringI", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs", 241L, 9L, 5L)]
#line hidden
namespace Quantum.Demo_ToStringI
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Extensions.Convert.ToStringB), typeof(Microsoft.Quantum.Extensions.Convert.ToStringD), typeof(Microsoft.Quantum.Extensions.Convert.ToStringDFormat), typeof(Microsoft.Quantum.Extensions.Convert.ToStringI), typeof(Microsoft.Quantum.Extensions.Convert.ToStringIFormat) };
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

        protected ICallable<Boolean, String> MicrosoftQuantumExtensionsConvertToStringB
        {
            get
            {
                return this.Factory.Get<ICallable<Boolean, String>, Microsoft.Quantum.Extensions.Convert.ToStringB>();
            }
        }

        protected ICallable<Double, String> MicrosoftQuantumExtensionsConvertToStringD
        {
            get
            {
                return this.Factory.Get<ICallable<Double, String>, Microsoft.Quantum.Extensions.Convert.ToStringD>();
            }
        }

        protected ICallable<(Double,String), String> MicrosoftQuantumExtensionsConvertToStringDFormat
        {
            get
            {
                return this.Factory.Get<ICallable<(Double,String), String>, Microsoft.Quantum.Extensions.Convert.ToStringDFormat>();
            }
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get
            {
                return this.Factory.Get<ICallable<Int64, String>, Microsoft.Quantum.Extensions.Convert.ToStringI>();
            }
        }

        protected ICallable<(Int64,String), String> MicrosoftQuantumExtensionsConvertToStringIFormat
        {
            get
            {
                return this.Factory.Get<ICallable<(Int64,String), String>, Microsoft.Quantum.Extensions.Convert.ToStringIFormat>();
            }
        }

        public override Func<QVoid, QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Demo_ToStringI.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
#line 12 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    var qubits = Allocate.Apply(1L);
                    //Convert an integer to a String
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(2L));
                    //Convert a double to a String
#line 17 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(2.3D));
                    //Convert a boolean to a String
#line 19 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringB.Apply<String>(true));
                    //Formatted integer
#line 21 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringIFormat.Apply<String>((22345L, "C")));
                    //Currency
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringIFormat.Apply<String>((22345L, "D8")));
                    //D8
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringIFormat.Apply<String>((31L, "X8")));
                    //X8
#line 24 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringIFormat.Apply<String>((142L, "0000#")));
                    //Formatted double
#line 27 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringDFormat.Apply<String>((22345.12D, "C")));
                    //Currency
#line 28 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\15_Demo ToStringX-ToStringXFormat\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringDFormat.Apply<String>((142.12D, "0000.000")));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Demo_ToStringI.DemoOperation", OperationFunctor.Body, __result__);
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