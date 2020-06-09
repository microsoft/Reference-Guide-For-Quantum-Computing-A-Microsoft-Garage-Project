#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._03_Demo_X", "DemoOperation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs", 280L, 10L, 5L)]
#line hidden
namespace Quantum._03_Demo_X
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Extensions.Math.ArcCos), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Extensions.Math.PI), typeof(Microsoft.Quantum.Primitive.R), typeof(Microsoft.Quantum.Primitive.R1), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Primitive.Rx), typeof(Microsoft.Quantum.Primitive.Ry), typeof(Microsoft.Quantum.Primitive.Rz), typeof(Microsoft.Quantum.Extensions.Math.Sqrt), typeof(Microsoft.Quantum.Extensions.Convert.ToStringI) };
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

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get
            {
                return this.Factory.Get<ICallable<QVoid, Double>, Microsoft.Quantum.Extensions.Math.PI>();
            }
        }

        protected IUnitary<(Pauli,Double,Qubit)> MicrosoftQuantumPrimitiveR
        {
            get
            {
                return this.Factory.Get<IUnitary<(Pauli,Double,Qubit)>, Microsoft.Quantum.Primitive.R>();
            }
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
        {
            get
            {
                return this.Factory.Get<IUnitary<(Double,Qubit)>, Microsoft.Quantum.Primitive.R1>();
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

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get
            {
                return this.Factory.Get<IUnitary<(Double,Qubit)>, Microsoft.Quantum.Primitive.Ry>();
            }
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRz
        {
            get
            {
                return this.Factory.Get<IUnitary<(Double,Qubit)>, Microsoft.Quantum.Primitive.Rz>();
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

        public override Func<QVoid, QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum._03_Demo_X.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
#line 13 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    var countZero = 0L;
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    var countOne = 0L;
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    var iterations = 1000L;
#line 17 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    var qubits = Allocate.Apply(2L);
                    //Measure without any operation
#line 20 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    foreach (var i in new Range(1L, iterations))
                    {
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 25 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 29 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countOne = (countOne + 1L);
                        }

#line 31 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line 33 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply("Measure without any operation:");
#line 34 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countZero:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZero)));
#line 35 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countOne:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOne)));
                    //Rx(PI(), qubits[0]); 
                    // Will make Zero to One
#line 40 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countZero = 0L;
#line 41 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countOne = 0L;
#line 42 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    foreach (var i in new Range(1L, iterations))
                    {
#line 44 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        MicrosoftQuantumPrimitiveRx.Apply((MicrosoftQuantumExtensionsMathPI.Apply<Double>(QVoid.Instance), qubits[0L]));
#line 45 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 46 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 48 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 52 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countOne = (countOne + 1L);
                        }

#line 54 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line 56 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply("Rx(PI(), qubits[0]):");
#line 57 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countZero:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZero)));
#line 58 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countOne:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOne)));
                    //Ry(PI(), qubits[0]); 
                    // Will also make Zero to One
#line 62 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countZero = 0L;
#line 63 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countOne = 0L;
#line 64 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    foreach (var i in new Range(1L, iterations))
                    {
#line 66 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        MicrosoftQuantumPrimitiveRy.Apply((MicrosoftQuantumExtensionsMathPI.Apply<Double>(QVoid.Instance), qubits[0L]));
#line 67 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 68 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 70 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 74 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countOne = (countOne + 1L);
                        }

#line 76 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line 78 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply("Ry(PI(), qubits[0]):");
#line 79 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countZero:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZero)));
#line 80 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countOne:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOne)));
                    //Rz(PI(), qubits[0]); 
                    // Zero will remain as Zero
#line 84 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countZero = 0L;
#line 85 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countOne = 0L;
#line 86 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    foreach (var i in new Range(1L, iterations))
                    {
#line 88 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        MicrosoftQuantumPrimitiveRz.Apply((MicrosoftQuantumExtensionsMathPI.Apply<Double>(QVoid.Instance), qubits[0L]));
#line 89 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 90 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 92 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 96 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countOne = (countOne + 1L);
                        }

#line 98 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line 100 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply("Rz(PI(), qubits[0]):");
#line 101 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countZero:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZero)));
#line 102 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countOne:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOne)));
                    //Ry(PI()/2.0, qubits[0]); 
                    // Same as H
#line 106 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countZero = 0L;
#line 107 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countOne = 0L;
#line 108 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    foreach (var i in new Range(1L, iterations))
                    {
#line 110 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        MicrosoftQuantumPrimitiveRy.Apply(((MicrosoftQuantumExtensionsMathPI.Apply<Double>(QVoid.Instance) / 2D), qubits[0L]));
#line 111 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 112 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 114 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 118 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countOne = (countOne + 1L);
                        }

#line 120 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line 122 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply("Ry(PI()/2.0, qubits[0]):");
#line 123 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countZero:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZero)));
#line 124 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countOne:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOne)));
                    //R(PauliX, PI()/2.0, qubits[0]); 
#line 127 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countZero = 0L;
#line 128 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countOne = 0L;
#line 129 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    foreach (var i in new Range(1L, iterations))
                    {
                        //PauliX and PauliZ can also be used; They are similar to Rx, Ry, Rz
#line 132 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        MicrosoftQuantumPrimitiveR.Apply((Pauli.PauliY, (MicrosoftQuantumExtensionsMathPI.Apply<Double>(QVoid.Instance) / 2D), qubits[0L]));
#line 133 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 134 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 136 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 140 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countOne = (countOne + 1L);
                        }

#line 142 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line 144 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply("R(PauliY, PI()/2.0, qubits[0]):");
#line 145 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countZero:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZero)));
#line 146 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countOne:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOne)));
                    //R1(PI(), qubits[0]); 
                    // Zero will remain as Zero; This is same as Rz. We are changing only the phase of One
#line 150 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countZero = 0L;
#line 151 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countOne = 0L;
#line 152 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    foreach (var i in new Range(1L, iterations))
                    {
#line 154 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        MicrosoftQuantumPrimitiveR1.Apply((MicrosoftQuantumExtensionsMathPI.Apply<Double>(QVoid.Instance), qubits[0L]));
#line 155 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 156 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 158 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 162 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countOne = (countOne + 1L);
                        }

#line 164 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line 166 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply("R1(PI(), qubits[0]):");
#line 167 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countZero:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZero)));
#line 168 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countOne:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOne)));
                    //Ry(angle, qubits[0]);
                    // 1/4 probabilityOfZero
#line 172 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countZero = 0L;
#line 173 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    countOne = 0L;
#line 174 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    foreach (var i in new Range(1L, iterations))
                    {
#line 176 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var probabilityOfZero = (1D / 4D);
#line 177 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var amplitudeOfZero = MicrosoftQuantumExtensionsMathSqrt.Apply<Double>(probabilityOfZero);
#line 178 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var angle = (2D * MicrosoftQuantumExtensionsMathArcCos.Apply<Double>(amplitudeOfZero));
#line 179 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        MicrosoftQuantumPrimitiveRy.Apply((angle, qubits[0L]));
#line 180 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        var result = M.Apply<Result>(qubits[0L]);
#line 181 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        if ((result == Result.Zero))
                        {
#line 183 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 187 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                            countOne = (countOne + 1L);
                        }

#line 189 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line 191 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply("Ry(angle, qubits[0]):");
#line 192 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countZero:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countZero)));
#line 193 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\18_Demo Rotations 1\\Operation.qs"
                    Message.Apply(("countOne:" + MicrosoftQuantumExtensionsConvertToStringI.Apply<String>(countOne)));
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