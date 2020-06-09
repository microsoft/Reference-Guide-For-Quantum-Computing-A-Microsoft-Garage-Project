#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._20_Demo_Teleportation", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs", 292L, 10L, 5L)]
#line hidden
namespace Quantum._20_Demo_Teleportation
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Extensions.Math.ArcCos), typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Primitive.Rx), typeof(Microsoft.Quantum.Extensions.Math.Sqrt), typeof(Microsoft.Quantum.Extensions.Convert.ToStringI), typeof(Microsoft.Quantum.Primitive.X), typeof(Microsoft.Quantum.Primitive.Z) };
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

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcCos
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.ArcCos>();
            }
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit)>, Microsoft.Quantum.Primitive.CNOT>();
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

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRx
        {
            get
            {
                return this.Factory.Get<IUnitary<(Double,Qubit)>, Microsoft.Quantum.Primitive.Rx>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.Sqrt>();
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.Z>();
            }
        }

        public override Func<QVoid, QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum._20_Demo_Teleportation.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
#line 13 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    var iterations = 1000L;
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    var countZero = 0L;
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    var countOne = 0L;
                    //Circuit diagram located here
                    //https://www.media.mit.edu/quanta/qasm2circ/test2.png
#line 19 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    var qubits = Allocate.Apply(3L);
#line 21 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    var sourceQubit = qubits[0L];
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    var tempQubit = qubits[1L];
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    var destinationQubit = qubits[2L];
                    //iterations needed only for testing.
#line 26 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    foreach (var i in new Range(1L, iterations))
                    {
                        //Setting the sourceQubit in such a way that it has 25% probabilityOfZero
#line 30 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        var probabilityOfZero = (1D / 4D);
#line 31 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        var amplitudeOfZero = MicrosoftQuantumExtensionsMathSqrt.Apply<Double>(probabilityOfZero);
#line 32 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        var angle = (2D * MicrosoftQuantumExtensionsMathArcCos.Apply<Double>(amplitudeOfZero));
#line 33 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        MicrosoftQuantumPrimitiveRx.Apply((angle, qubits[0L]));
                        //Teleportation start
#line 36 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(tempQubit);
#line 37 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((tempQubit, destinationQubit));
#line 38 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((sourceQubit, tempQubit));
#line 39 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(sourceQubit);
#line 41 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        var resultSource = M.Apply<Result>(sourceQubit);
#line 42 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        var resultTemp = M.Apply<Result>(tempQubit);
#line 44 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        if ((resultTemp == Result.One))
                        {
#line 46 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                            MicrosoftQuantumPrimitiveX.Apply(destinationQubit);
                        }

#line 49 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        if ((resultSource == Result.One))
                        {
#line 51 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                            MicrosoftQuantumPrimitiveZ.Apply(destinationQubit);
                        }

                        //Teleportation completed in the above step
                        //Following code tests if the Teleportation succeded or not
#line 56 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        var resultDestination = M.Apply<Result>(destinationQubit);
#line 58 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        if ((resultDestination == Result.Zero))
                        {
#line 60 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 64 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                            countOne = (countOne + 1L);
                        }

#line 67 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line hidden
                    Release.Apply(qubits);
                    //countZero should be close to 250 and countOne should be close to 750
#line 72 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    Message.Apply(("countZero:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZero)));
#line 73 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\20_Demo Teleportation\\Operation.qs"
                    Message.Apply(("countOne:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOne)));
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum._20_Demo_Teleportation.DemoOperation", OperationFunctor.Body, __result__);
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