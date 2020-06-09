#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum._24_Demo_Quantm_Circuit_for_Addition", "Operation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs", 210L, 8L, 5L)]
#line hidden
namespace Quantum._24_Demo_Quantm_Circuit_for_Addition
{
    public class Operation : Operation<QVoid, QVoid>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "Quantum._24_Demo_Quantm_Circuit_for_Addition.Operation";
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

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
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

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 11 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            var strSum = "";
            //First Number
#line 13 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            var a = Allocate.Apply(2L);
            //Second Number
#line 17 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            var b = Allocate.Apply(2L);
            //sum will be a 3 bit number that stores the sum of a and b along with carry
            // Not so optimal but works
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            var sum = Allocate.Apply(3L);
#line 25 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), (a + b)));
            //First qubit
#line 28 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((a[0L], sum[0L]));
#line 29 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((b[0L], sum[0L]));
            //Second qubit
#line 32 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((a[1L], sum[1L]));
#line 33 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((b[1L], sum[1L]));
#line 34 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((a[0L], b[0L], sum[1L]));
            //Third qubit
#line 37 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((a[1L], b[1L], sum[2L]));
#line 38 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(a[1L]);
#line 39 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply(((a + b), sum[2L]));
#line 40 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(a[1L]);
#line 41 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(b[1L]);
#line 42 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply(((a + b), sum[2L]));
#line 43 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(b[1L]);
#line 45 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            strSum = MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonResultAsInt.Apply(MicrosoftQuantumCanonMultiM.Apply(sum)));
            //Change this number to see various super positions
#line 48 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            if ((strSum == "4"))
            {
                //We can see that the input is entangled with the output.
                //If the output is 4, then only entangled states 2 + 2, 1 + 3 and 3 + 3
                //will remain and all other states will vanish from the input bits.
#line 53 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
                Message.Apply(((((strSum + " : ") + MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonResultAsInt.Apply(MicrosoftQuantumCanonMultiM.Apply(a)))) + " + ") + MicrosoftQuantumExtensionsConvertToStringI.Apply(MicrosoftQuantumCanonResultAsInt.Apply(MicrosoftQuantumCanonMultiM.Apply(b)))));
            }

#line 59 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            ResetAll.Apply(sum);
#line hidden
            Release.Apply(sum);
#line 61 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            ResetAll.Apply(b);
#line hidden
            Release.Apply(b);
#line 64 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\24_Demo Quantm Circuit for Entangled Addition\\Operation.qs"
            ResetAll.Apply(a);
#line hidden
            Release.Apply(a);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Operation, QVoid, QVoid>(QVoid.Instance);
        }
    }
}