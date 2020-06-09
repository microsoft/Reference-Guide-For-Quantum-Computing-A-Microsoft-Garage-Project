#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._27_Demo_Simon_s_Algorithm\",\"Name\":\"HelloQ\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/27_Demo%20Simon's%20Algorithm/Operations.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._27_Demo_Simon_s_Algorithm\",\"Name\":\"HelloQ\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/27_Demo%20Simon's%20Algorithm/Operations.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._27_Demo_Simon_s_Algorithm\",\"Name\":\"BlackBox0000\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/27_Demo%20Simon's%20Algorithm/Operations.qs\",\"Position\":{\"Item1\":112,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._27_Demo_Simon_s_Algorithm\",\"Name\":\"BlackBox0000\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/27_Demo%20Simon's%20Algorithm/Operations.qs\",\"Position\":{\"Item1\":112,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._27_Demo_Simon_s_Algorithm\",\"Name\":\"BlackBox1010\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/27_Demo%20Simon's%20Algorithm/Operations.qs\",\"Position\":{\"Item1\":122,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._27_Demo_Simon_s_Algorithm\",\"Name\":\"BlackBox1010\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/27_Demo%20Simon's%20Algorithm/Operations.qs\",\"Position\":{\"Item1\":122,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
#line hidden
namespace Quantum._27_Demo_Simon_s_Algorithm
{
    public class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Quantum._27_Demo_Simon_s_Algorithm.HelloQ";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected Allocate Allocate
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>), QVoid> BlackBox1010
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 10 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                var inputQubits = Allocate.Apply(4L);
#line hidden
                {
#line 13 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    var outputQubits = Allocate.Apply(4L);
#line 17 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    foreach (var iter in new Range(0L, 19L))
#line hidden
                    {
#line 20 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, inputQubits?.Copy()));
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        BlackBox1010.Apply((inputQubits?.Copy(), outputQubits?.Copy()));
#line 26 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, inputQubits?.Copy()));
#line 28 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        var inputQubitsResults = MicrosoftQuantumCanonMultiM.Apply(inputQubits?.Copy());
#line 29 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        var outputQubitsResults = MicrosoftQuantumCanonMultiM.Apply(outputQubits?.Copy());
#line 35 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        Message.Apply("");
#line 36 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        Message.Apply(String.Format("Iteration: {0}", (iter + 1L)));
#line 37 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        foreach (var i in new Range(0L, 3L))
#line hidden
                        {
#line 38 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                            Message.Apply(String.Format("{0}", inputQubitsResults[i]));
                        }

#line 41 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        ResetAll.Apply(outputQubits?.Copy());
#line 42 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        ResetAll.Apply(inputQubits?.Copy());
                    }

#line 55 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    BlackBox1010.Apply((inputQubits?.Copy(), outputQubits?.Copy()));
#line 56 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    var outputQubitsResults1 = MicrosoftQuantumCanonMultiM.Apply(outputQubits?.Copy());
#line 57 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    Message.Apply("");
#line 58 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    Message.Apply("Testing the blackbox for input=0000");
#line 59 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    foreach (var i in new Range(0L, 3L))
#line hidden
                    {
#line 60 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        Message.Apply(String.Format("{0}", outputQubitsResults1[i]));
                    }

#line 62 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(outputQubits?.Copy());
#line 63 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(inputQubits?.Copy());
#line 66 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[2L])));
#line 68 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    BlackBox1010.Apply((inputQubits?.Copy(), outputQubits?.Copy()));
#line 69 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    var outputQubitsResults2 = MicrosoftQuantumCanonMultiM.Apply(outputQubits?.Copy());
#line 70 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    Message.Apply("");
#line 71 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    Message.Apply("Testing the blackbox for input=1010");
#line 72 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    foreach (var i in new Range(0L, 3L))
#line hidden
                    {
#line 73 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        Message.Apply(String.Format("{0}", outputQubitsResults2[i]));
                    }

#line 75 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(outputQubits?.Copy());
#line 76 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(inputQubits?.Copy());
#line 79 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[1L], inputQubits[2L])));
#line 81 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    BlackBox1010.Apply((inputQubits?.Copy(), outputQubits?.Copy()));
#line 82 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    var outputQubitsResults3 = MicrosoftQuantumCanonMultiM.Apply(outputQubits?.Copy());
#line 83 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    Message.Apply("");
#line 84 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    Message.Apply("Testing the blackbox for input=1110");
#line 85 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    foreach (var i in new Range(0L, 3L))
#line hidden
                    {
#line 86 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        Message.Apply(String.Format("{0}", outputQubitsResults3[i]));
                    }

#line 88 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(outputQubits?.Copy());
#line 89 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(inputQubits?.Copy());
#line 92 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>()
                    {inputQubits[1L]}));
#line 94 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    BlackBox1010.Apply((inputQubits?.Copy(), outputQubits?.Copy()));
#line 95 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    var outputQubitsResults4 = MicrosoftQuantumCanonMultiM.Apply(outputQubits?.Copy());
#line 96 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    Message.Apply("");
#line 97 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    Message.Apply("Testing the blackbox for input=0100");
#line 98 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    foreach (var i in new Range(0L, 3L))
#line hidden
                    {
#line 99 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                        Message.Apply(String.Format("{0}", outputQubitsResults4[i]));
                    }

#line 101 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(outputQubits?.Copy());
#line 102 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(inputQubits?.Copy());
#line 104 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(outputQubits?.Copy());
#line 105 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
                    ResetAll.Apply(inputQubits?.Copy());
#line hidden
                    Release.Apply(outputQubits);
                }

#line hidden
                Release.Apply(inputQubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.BlackBox1010 = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>), QVoid>>(typeof(BlackBox1010));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<HelloQ, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class BlackBox0000 : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public BlackBox0000(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BlackBox0000";
        String ICallable.FullName => "Quantum._27_Demo_Simon_s_Algorithm.BlackBox0000";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (inputQubits,outputQubits) = __in;
#line 115 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((inputQubits[0L], outputQubits[0L]));
#line 116 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((inputQubits[1L], outputQubits[1L]));
#line 117 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((inputQubits[2L], outputQubits[2L]));
#line 118 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((inputQubits[3L], outputQubits[3L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> inputQubits, QArray<Qubit> outputQubits)
        {
            return __m__.Run<BlackBox0000, (QArray<Qubit>,QArray<Qubit>), QVoid>((inputQubits, outputQubits));
        }
    }

    public class BlackBox1010 : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public BlackBox1010(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BlackBox1010";
        String ICallable.FullName => "Quantum._27_Demo_Simon_s_Algorithm.BlackBox1010";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (inputQubits,outputQubits) = __in;
#line 128 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[1L], inputQubits[2L])));
#line 129 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[3L]));
#line 130 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[1L], inputQubits[2L])));
#line 132 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>()
            {inputQubits[1L]}));
#line 133 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[3L]));
#line 134 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>()
            {inputQubits[1L]}));
#line 137 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[1L], inputQubits[3L])));
#line 138 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[2L]));
#line 139 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[1L], inputQubits[3L])));
#line 141 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[1L], inputQubits[2L], inputQubits[3L])));
#line 142 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[2L]));
#line 143 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[1L], inputQubits[2L], inputQubits[3L])));
#line 146 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[1L])));
#line 147 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[2L]));
#line 148 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[3L]));
#line 149 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[1L])));
#line 151 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[1L], inputQubits[2L])));
#line 152 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[2L]));
#line 153 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[3L]));
#line 154 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[1L], inputQubits[2L])));
#line 157 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[2L], inputQubits[3L])));
#line 158 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[1L]));
#line 159 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[2L], inputQubits[3L])));
#line 161 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>()
            {inputQubits[3L]}));
#line 162 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[1L]));
#line 163 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>()
            {inputQubits[3L]}));
#line 166 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[2L])));
#line 167 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[1L]));
#line 168 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[3L]));
#line 169 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[2L])));
#line 172 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[1L]));
#line 173 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[3L]));
#line 177 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[3L])));
#line 178 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[1L]));
#line 179 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[2L]));
#line 180 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[0L], inputQubits[3L])));
#line 182 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[2L], inputQubits[3L])));
#line 183 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[1L]));
#line 184 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[2L]));
#line 185 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>(inputQubits[2L], inputQubits[3L])));
#line 188 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>()
            {inputQubits[0L]}));
#line 189 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[1L]));
#line 190 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[2L]));
#line 191 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[3L]));
#line 192 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>()
            {inputQubits[0L]}));
#line 194 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>()
            {inputQubits[2L]}));
#line 195 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[1L]));
#line 196 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[2L]));
#line 197 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[3L]));
#line 198 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\27_Demo Simon's Algorithm\\Operations.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, new QArray<Qubit>()
            {inputQubits[2L]}));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> inputQubits, QArray<Qubit> outputQubits)
        {
            return __m__.Run<BlackBox1010, (QArray<Qubit>,QArray<Qubit>), QVoid>((inputQubits, outputQubits));
        }
    }
}