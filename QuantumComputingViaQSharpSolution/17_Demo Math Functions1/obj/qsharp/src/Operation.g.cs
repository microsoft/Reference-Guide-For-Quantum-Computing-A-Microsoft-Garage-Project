#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._03_Demo_X", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs", 280L, 10L, 5L)]
#line hidden
namespace Quantum._03_Demo_X
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Extensions.Math.AbsD), typeof(Microsoft.Quantum.Extensions.Math.AbsI), typeof(Microsoft.Quantum.Extensions.Math.ArcSin), typeof(Microsoft.Quantum.Extensions.Math.ArcTan), typeof(Microsoft.Quantum.Extensions.Math.ArcTan2), typeof(Microsoft.Quantum.Extensions.Math.Ceiling), typeof(Microsoft.Quantum.Extensions.Math.E), typeof(Microsoft.Quantum.Extensions.Math.ExpD), typeof(Microsoft.Quantum.Canon.Lg), typeof(Microsoft.Quantum.Extensions.Math.Log), typeof(Microsoft.Quantum.Extensions.Math.Log10), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Canon.Modulus), typeof(Microsoft.Quantum.Extensions.Math.PI), typeof(Microsoft.Quantum.Extensions.Math.PowD), typeof(Microsoft.Quantum.Extensions.Math.Round), typeof(Microsoft.Quantum.Extensions.Math.Sin), typeof(Microsoft.Quantum.Extensions.Math.Sqrt), typeof(Microsoft.Quantum.Extensions.Convert.ToStringD), typeof(Microsoft.Quantum.Extensions.Convert.ToStringI), typeof(Microsoft.Quantum.Extensions.Math.Truncate) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathAbsD
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.AbsD>();
            }
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumExtensionsMathAbsI
        {
            get
            {
                return this.Factory.Get<ICallable<Int64, Int64>, Microsoft.Quantum.Extensions.Math.AbsI>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcSin
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.ArcSin>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcTan
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.ArcTan>();
            }
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathArcTan2
        {
            get
            {
                return this.Factory.Get<ICallable<(Double,Double), Double>, Microsoft.Quantum.Extensions.Math.ArcTan2>();
            }
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathCeiling
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Int64>, Microsoft.Quantum.Extensions.Math.Ceiling>();
            }
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathE
        {
            get
            {
                return this.Factory.Get<ICallable<QVoid, Double>, Microsoft.Quantum.Extensions.Math.E>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathExpD
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.ExpD>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumCanonLg
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Canon.Lg>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.Log>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog10
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.Log10>();
            }
        }

        protected ICallable<String, QVoid> Message
        {
            get
            {
                return this.Factory.Get<ICallable<String, QVoid>, Microsoft.Quantum.Primitive.Message>();
            }
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumCanonModulus
        {
            get
            {
                return this.Factory.Get<ICallable<(Int64,Int64), Int64>, Microsoft.Quantum.Canon.Modulus>();
            }
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get
            {
                return this.Factory.Get<ICallable<QVoid, Double>, Microsoft.Quantum.Extensions.Math.PI>();
            }
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get
            {
                return this.Factory.Get<ICallable<(Double,Double), Double>, Microsoft.Quantum.Extensions.Math.PowD>();
            }
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathRound
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Int64>, Microsoft.Quantum.Extensions.Math.Round>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.Sin>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.Sqrt>();
            }
        }

        protected ICallable<Double, String> MicrosoftQuantumExtensionsConvertToStringD
        {
            get
            {
                return this.Factory.Get<ICallable<Double, String>, Microsoft.Quantum.Extensions.Convert.ToStringD>();
            }
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get
            {
                return this.Factory.Get<ICallable<Int64, String>, Microsoft.Quantum.Extensions.Convert.ToStringI>();
            }
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathTruncate
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Int64>, Microsoft.Quantum.Extensions.Math.Truncate>();
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
                    //AbsD
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathAbsD.Apply<Double>(-(1.2D))));
                    //AbsI
#line 17 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumExtensionsMathAbsI.Apply<Int64>(-(12L))));
                    //Ceiling
#line 19 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumExtensionsMathCeiling.Apply<Int64>(12.2D)));
                    //Complex
#line 21 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    var complex = (1D, 2.2D);
                    //PI()
#line 24 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathPI.Apply<Double>(QVoid.Instance)));
                    //Sin 0
#line 27 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Sin(0): " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathSin.Apply<Double>(0D))));
                    //Sin(PI()/2.0)
#line 29 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Sin(PI()/2.0): " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathSin.Apply<Double>((MicrosoftQuantumExtensionsMathPI.Apply<Double>(QVoid.Instance) / 2D)))));
                    //Sin(PI())
#line 31 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Sin(PI()): " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathSin.Apply<Double>(MicrosoftQuantumExtensionsMathPI.Apply<Double>(QVoid.Instance)))));
                    //ArcSin(1.0)
#line 33 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("ArcSin(1.0): " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathArcSin.Apply<Double>(1D))));
                    //ArcTan(0.5)
#line 35 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("ArcTan(0.5): " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathArcTan.Apply<Double>(0.5D))));
                    //ArcTan2(1.0,0.0)
#line 37 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("ArcTan2(1.0,0.0): " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathArcTan2.Apply<Double>((1D, 0D)))));
                    //e
#line 40 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("e: " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathE.Apply<Double>(QVoid.Instance))));
                    //e^2
#line 42 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("e^2: " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathExpD.Apply<Double>(2D))));
                    //Modulus
#line 44 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Modulus : " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumCanonModulus.Apply<Int64>((8L, 5L)))));
                    //PowD
#line 46 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("PowD : " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathPowD.Apply<Double>((2D, 3D)))));
                    //Round
#line 48 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Round : " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumExtensionsMathRound.Apply<Int64>(2.6D))));
                    //Truncate
#line 50 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Truncate : " + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(MicrosoftQuantumExtensionsMathTruncate.Apply<Int64>(2.6D))));
                    //Sqrt
#line 52 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Sqrt : " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathSqrt.Apply<Double>(8D))));
                    //Log-base e
#line 54 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Log : " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathLog.Apply<Double>(MicrosoftQuantumExtensionsMathE.Apply<Double>(QVoid.Instance)))));
                    //Log10-base 10
#line 56 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Log10 : " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumExtensionsMathLog10.Apply<Double>(100D))));
                    //Lg-base 2
#line 58 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply(("Lg : " + MicrosoftQuantumExtensionsConvertToStringD.Apply<String>(MicrosoftQuantumCanonLg.Apply<Double>(4D))));
#line 60 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\17_Demo Math Functions1\\Operation.qs"
                    Message.Apply("Done");
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