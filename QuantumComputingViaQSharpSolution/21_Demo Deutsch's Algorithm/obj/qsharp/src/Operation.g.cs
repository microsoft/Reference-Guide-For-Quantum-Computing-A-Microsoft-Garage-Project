#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._21_Demo_Deutsch", "DemoOperation () : ()", new string[] { }, "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs", 286L, 10L, 5L)]
[assembly: OperationDeclaration("Quantum._21_Demo_Deutsch", "BlackBoxConstant0 (qubits : Qubit[]) : ()", new string[] { }, "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs", 1604L, 60L, 2L)]
[assembly: OperationDeclaration("Quantum._21_Demo_Deutsch", "BlackBoxConstant1 (qubits : Qubit[]) : ()", new string[] { }, "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs", 1970L, 73L, 2L)]
[assembly: OperationDeclaration("Quantum._21_Demo_Deutsch", "BlackBoxBalancedSame (qubits : Qubit[]) : ()", new string[] { }, "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs", 2452L, 87L, 2L)]
[assembly: OperationDeclaration("Quantum._21_Demo_Deutsch", "BlackBoxBalancedDifferent (qubits : Qubit[]) : ()", new string[] { }, "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs", 2965L, 101L, 2L)]
#line hidden
namespace Quantum._21_Demo_Deutsch
{
    public class DemoOperation : Operation<QVoid, QVoid>
    {
        public DemoOperation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Canon.ApplyToEach<>), typeof(Quantum._21_Demo_Deutsch.BlackBoxConstant0), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Message), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Primitive.X) };
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

        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get
            {
                return new GenericOperation(this.Factory, typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            }
        }

        protected ICallable<QArray<Qubit>, QVoid> BlackBoxConstant0
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Qubit>, QVoid>, Quantum._21_Demo_Deutsch.BlackBoxConstant0>();
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
                this.Factory.StartOperation("Quantum._21_Demo_Deutsch.DemoOperation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    //Circuit diagram located here
                    //https://www.researchgate.net/profile/Piotr_Gawron/publication/250802186/figure/fig2/AS:298189887426561@1448105417119/Graphical-representation-of-Deutsch-algorithm.png
#line 16 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    var qubits = Allocate.Apply(2L);
                    //Making the second qubit 1
#line 20 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
                    //H on both
#line 23 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), qubits));
                    //Apply the blackbox
                    //blackbox will set y = f(x) XOR y; which is same as CNOT(f(x),y)
#line 27 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    BlackBoxConstant0.Apply(qubits);
                    //BlackBoxConstant1(qubits);
                    //BlackBoxBalancedSame(qubits);
                    //BlackBoxBalancedDifferent(qubits);
                    //H on the first qubit
#line 33 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
                    //Measuring the first Qubit
#line 36 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    var result = M.Apply<Result>(qubits[0L]);
                    //For BlackBoxConstant0 and BlackBoxConstant1, the output will be Zero
#line 39 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    if ((result == Result.Zero))
                    {
#line 41 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                        Message.Apply("Constant");
                    }
                    else if ((result == Result.One))
                    {
#line 46 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                        Message.Apply("Balanced");
                    }

#line 49 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    ResetAll.Apply(qubits);
#line hidden
                    Release.Apply(qubits);
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum._21_Demo_Deutsch.DemoOperation", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<DemoOperation, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class BlackBoxConstant0 : Operation<QArray<Qubit>, QVoid>
    {
        public BlackBoxConstant0(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { };
        }

        public override Type[] Dependencies
        {
            get;
        }

        public override Func<QArray<Qubit>, QVoid> Body
        {
            get => (qubits) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum._21_Demo_Deutsch.BlackBoxConstant0", OperationFunctor.Body, qubits);
                var __result__ = default(QVoid);
                try
                {
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum._21_Demo_Deutsch.BlackBoxConstant0", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<BlackBoxConstant0, QArray<Qubit>, QVoid>(qubits);
        }
    }

    public class BlackBoxConstant1 : Operation<QArray<Qubit>, QVoid>
    {
        public BlackBoxConstant1(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<QArray<Qubit>, QVoid> Body
        {
            get => (qubits) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum._21_Demo_Deutsch.BlackBoxConstant1", OperationFunctor.Body, qubits);
                var __result__ = default(QVoid);
                try
                {
#line 76 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum._21_Demo_Deutsch.BlackBoxConstant1", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<BlackBoxConstant1, QArray<Qubit>, QVoid>(qubits);
        }
    }

    public class BlackBoxBalancedSame : Operation<QArray<Qubit>, QVoid>
    {
        public BlackBoxBalancedSame(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.CNOT) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit)>, Microsoft.Quantum.Primitive.CNOT>();
            }
        }

        public override Func<QArray<Qubit>, QVoid> Body
        {
            get => (qubits) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum._21_Demo_Deutsch.BlackBoxBalancedSame", OperationFunctor.Body, qubits);
                var __result__ = default(QVoid);
                try
                {
#line 90 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum._21_Demo_Deutsch.BlackBoxBalancedSame", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<BlackBoxBalancedSame, QArray<Qubit>, QVoid>(qubits);
        }
    }

    public class BlackBoxBalancedDifferent : Operation<QArray<Qubit>, QVoid>
    {
        public BlackBoxBalancedDifferent(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit)>, Microsoft.Quantum.Primitive.CNOT>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<QArray<Qubit>, QVoid> Body
        {
            get => (qubits) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum._21_Demo_Deutsch.BlackBoxBalancedDifferent", OperationFunctor.Body, qubits);
                var __result__ = default(QVoid);
                try
                {
#line 104 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 105 "C:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\21_Demo Deutsch's Algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum._21_Demo_Deutsch.BlackBoxBalancedDifferent", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<BlackBoxBalancedDifferent, QArray<Qubit>, QVoid>(qubits);
        }
    }
}