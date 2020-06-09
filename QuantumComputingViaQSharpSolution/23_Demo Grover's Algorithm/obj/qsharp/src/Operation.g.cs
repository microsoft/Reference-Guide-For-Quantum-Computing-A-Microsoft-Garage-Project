#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._23_Demo_Grover_s_Algorithm", "GetNumberOfIterations (n : Double) : Double", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs", 262L, 9L, 2L)]
[assembly: OperationDeclaration("Quantum._23_Demo_Grover_s_Algorithm", "GenericFlip (qubits : Qubit[], controlString : Bool[], extraBit : Qubit, n : Int) : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs", 673L, 24L, 2L)]
[assembly: OperationDeclaration("Quantum._23_Demo_Grover_s_Algorithm", "GenericReflectionAboutMean (qubits : Qubit[], extraBit : Qubit) : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs", 1297L, 53L, 2L)]
[assembly: OperationDeclaration("Quantum._23_Demo_Grover_s_Algorithm", "GenericGroversAlgo (n : Int, pattern : Bool[]) : Int", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs", 2071L, 74L, 5L)]
#line hidden
namespace Quantum._23_Demo_Grover_s_Algorithm
{
    public class GetNumberOfIterations : Operation<Double, Double>, ICallable
    {
        public GetNumberOfIterations(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetNumberOfIterations";
        String ICallable.FullName => "Quantum._23_Demo_Grover_s_Algorithm.GetNumberOfIterations";
        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcSin
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        public override Func<Double, Double> Body => (__in) =>
        {
            var n = __in;
#line 12 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            var root = 1D;
#line 13 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            root = (1D / MicrosoftQuantumExtensionsMathSqrt.Apply(n));
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            var angle = 1D;
#line 15 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            var pi = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
#line 16 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            angle = ((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / (4D * MicrosoftQuantumExtensionsMathArcSin.Apply(root))) - 0.5D);
#line 17 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            return angle;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcSin));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double n)
        {
            return __m__.Run<GetNumberOfIterations, Double, Double>(n);
        }
    }

    public class GenericFlip : Operation<(QArray<Qubit>,QArray<Boolean>,Qubit,Int64), QVoid>, ICallable
    {
        public GenericFlip(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Boolean>,Qubit,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Boolean>,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "GenericFlip";
        String ICallable.FullName => "Quantum._23_Demo_Grover_s_Algorithm.GenericFlip";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Boolean>,Qubit,Int64), QVoid> Body => (__in) =>
        {
            var (qubits,controlString,extraBit,n) = __in;
            //Changing the qubits to 1 whereever we have 0
#line 28 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            foreach (var i in new Range(0L, (n - 1L)))
            {
#line 30 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
                if ((controlString[i] == false))
                {
#line 32 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[i]);
                }
            }

            //Flipping the extraBit; Now, X will be applieed only if bits match the controlString
#line 37 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((qubits, extraBit));
            //Undoing the changes we made in the first for loop
#line 40 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            foreach (var i in new Range(0L, (n - 1L)))
            {
#line 42 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
                if ((controlString[i] == false))
                {
#line 44 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Boolean>,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits, QArray<Boolean> controlString, Qubit extraBit, Int64 n)
        {
            return __m__.Run<GenericFlip, (QArray<Qubit>,QArray<Boolean>,Qubit,Int64), QVoid>((qubits, controlString, extraBit, n));
        }
    }

    public class GenericReflectionAboutMean : Operation<(QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public GenericReflectionAboutMean(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "GenericReflectionAboutMean";
        String ICallable.FullName => "Quantum._23_Demo_Grover_s_Algorithm.GenericReflectionAboutMean";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (qubits,extraBit) = __in;
            //Change of bases so that |00000> aligns with H*H*H*H*H(|00000>)
#line 57 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), qubits));
            //Flip the extraBit only for the states != |00000>
#line 60 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveX), qubits));
            //This will make |00000> to |11111>
#line 61 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(extraBit);
            //This will always flip the extraBit
#line 62 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((qubits, extraBit));
            //This will flip only if the state is |11111>, this step and above step will effectively
            //ensure that except for |00000>, all other states's amplitudes will be negated
#line 64 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveX), qubits));
            //This will undo the above ApplyToEach
            //Undoing the basis change
#line 67 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits, Qubit extraBit)
        {
            return __m__.Run<GenericReflectionAboutMean, (QArray<Qubit>,Qubit), QVoid>((qubits, extraBit));
        }
    }

    public class GenericGroversAlgo : Operation<(Int64,QArray<Boolean>), Int64>, ICallable
    {
        public GenericGroversAlgo(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Boolean>)>, IApplyData
        {
            public In((Int64,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GenericGroversAlgo";
        String ICallable.FullName => "Quantum._23_Demo_Grover_s_Algorithm.GenericGroversAlgo";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Boolean>,Qubit,Int64), QVoid> GenericFlip
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Qubit), QVoid> GenericReflectionAboutMean
        {
            get;
            set;
        }

        protected ICallable<Double, Double> GetNumberOfIterations
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathRound
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Boolean>), Int64> Body => (__in) =>
        {
            var (n,pattern) = __in;
#line 77 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            var qubits = Allocate.Apply(n);
#line 79 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            var extraBit = Allocate.Apply(1L);
#line 81 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), qubits));
#line 83 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(extraBit[0L]);
#line 84 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(extraBit[0L]);
#line 86 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            var iter = 1L;
#line 87 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            iter = MicrosoftQuantumExtensionsMathRound.Apply(GetNumberOfIterations.Apply(MicrosoftQuantumExtensionsMathPowD.Apply((MicrosoftQuantumExtensionsConvertToDouble.Apply(n), 2D))));
#line 89 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            foreach (var i in new Range(1L, iter))
            {
#line 91 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
                GenericFlip.Apply((qubits, pattern, extraBit[0L], n));
#line 92 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
                GenericReflectionAboutMean.Apply((qubits, extraBit[0L]));
            }

            //Measuing the system and generating a binary string
#line 96 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            var str = "";
#line 97 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            var results = MicrosoftQuantumCanonMultiM.Apply(qubits);
#line 98 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            foreach (var i in new Range(0L, (qubits.Count - 1L)))
            {
#line 100 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
                str = (str + MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonResultAsInt.Apply(new QArray<Result>()
                {results[i]})));
            }

#line 102 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            Message.Apply((("State of the system at the end of " + MicrosoftQuantumExtensionsConvertToStringI.Apply(iter)) + " iterations:"));
#line 103 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            Message.Apply(str);
#line 106 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            ResetAll.Apply(qubits);
#line 107 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            ResetAll.Apply(extraBit);
#line hidden
            Release.Apply(extraBit);
#line hidden
            Release.Apply(qubits);
            //Returning some dummy result
#line 112 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\23_Demo Grover's Algorithm\\Operation.qs"
            return 1L;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.GenericFlip = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Boolean>,Qubit,Int64), QVoid>>(typeof(Quantum._23_Demo_Grover_s_Algorithm.GenericFlip));
            this.GenericReflectionAboutMean = this.Factory.Get<ICallable<(QArray<Qubit>,Qubit), QVoid>>(typeof(Quantum._23_Demo_Grover_s_Algorithm.GenericReflectionAboutMean));
            this.GetNumberOfIterations = this.Factory.Get<ICallable<Double, Double>>(typeof(Quantum._23_Demo_Grover_s_Algorithm.GetNumberOfIterations));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
            this.MicrosoftQuantumExtensionsMathRound = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Round));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 n, QArray<Boolean> pattern)
        {
            return __m__.Run<GenericGroversAlgo, (Int64,QArray<Boolean>), Int64>((n, pattern));
        }
    }
}