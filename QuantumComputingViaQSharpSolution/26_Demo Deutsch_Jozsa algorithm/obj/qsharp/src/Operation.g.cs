#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"DJAlgo\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"DJAlgo\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":10,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxConstant0\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":56,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxConstant0\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":58,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxConstant1\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":65,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxConstant1\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":67,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxBalanced1\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":74,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxBalanced1\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":76,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxBalanced2\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":83,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxBalanced2\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":85,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxBalancedRandom1\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":92,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxBalancedRandom1\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":94,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxBalancedRandom2\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":128,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum._26_Demo_Deutsch_Jozsa_algorithm\",\"Name\":\"BlackBoxBalancedRandom2\"},\"SourceFile\":\"c:/Users/kitty/Documents/Quantum%20Computing/QuantumComputingViaQSharpSolution/QuantumComputingViaQSharpSolution/26_Demo%20Deutsch_Jozsa%20algorithm/Operation.qs\",\"Position\":{\"Item1\":130,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Quantum._26_Demo_Deutsch_Jozsa_algorithm
{
    public class DJAlgo : Operation<QVoid, QVoid>, ICallable
    {
        public DJAlgo(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DJAlgo";
        String ICallable.FullName => "Quantum._26_Demo_Deutsch_Jozsa_algorithm.DJAlgo";
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

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
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

        protected ICallable<(QArray<Qubit>,QArray<Qubit>), QVoid> BlackBoxConstant0
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 14 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                var inputQubits = Allocate.Apply(3L);
#line 18 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, inputQubits?.Copy()));
#line hidden
                {
#line 19 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                    var outputQubits = Allocate.Apply(1L);
#line 22 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(outputQubits[0L]);
#line 23 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                    MicrosoftQuantumPrimitiveH.Apply(outputQubits[0L]);
#line 26 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                    BlackBoxConstant0.Apply((inputQubits?.Copy(), outputQubits?.Copy()));
#line 32 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, inputQubits?.Copy()));
#line 34 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                    var results = MicrosoftQuantumCanonMultiM.Apply(inputQubits?.Copy());
#line 35 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                    var resultAsInt = MicrosoftQuantumCanonResultAsInt.Apply(results);
#line 38 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                    if ((resultAsInt == 0L))
                    {
#line 40 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                        Message.Apply("Constant");
                    }
                    else
                    {
#line 45 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                        Message.Apply("Balanced");
                    }

#line 48 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                    ResetAll.Apply(outputQubits?.Copy());
#line hidden
                    Release.Apply(outputQubits);
                }

#line 50 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
                ResetAll.Apply(inputQubits?.Copy());
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
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.BlackBoxConstant0 = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>), QVoid>>(typeof(BlackBoxConstant0));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<DJAlgo, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class BlackBoxConstant0 : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public BlackBoxConstant0(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BlackBoxConstant0";
        String ICallable.FullName => "Quantum._26_Demo_Deutsch_Jozsa_algorithm.BlackBoxConstant0";
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (inputQubits,outputQubits) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> inputQubits, QArray<Qubit> outputQubits)
        {
            return __m__.Run<BlackBoxConstant0, (QArray<Qubit>,QArray<Qubit>), QVoid>((inputQubits, outputQubits));
        }
    }

    public class BlackBoxConstant1 : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public BlackBoxConstant1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BlackBoxConstant1";
        String ICallable.FullName => "Quantum._26_Demo_Deutsch_Jozsa_algorithm.BlackBoxConstant1";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (inputQubits,outputQubits) = __in;
#line 70 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(outputQubits[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> inputQubits, QArray<Qubit> outputQubits)
        {
            return __m__.Run<BlackBoxConstant1, (QArray<Qubit>,QArray<Qubit>), QVoid>((inputQubits, outputQubits));
        }
    }

    public class BlackBoxBalanced1 : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public BlackBoxBalanced1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BlackBoxBalanced1";
        String ICallable.FullName => "Quantum._26_Demo_Deutsch_Jozsa_algorithm.BlackBoxBalanced1";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (inputQubits,outputQubits) = __in;
#line 79 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((inputQubits[0L], outputQubits[0L]));
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
            return __m__.Run<BlackBoxBalanced1, (QArray<Qubit>,QArray<Qubit>), QVoid>((inputQubits, outputQubits));
        }
    }

    public class BlackBoxBalanced2 : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public BlackBoxBalanced2(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BlackBoxBalanced2";
        String ICallable.FullName => "Quantum._26_Demo_Deutsch_Jozsa_algorithm.BlackBoxBalanced2";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (inputQubits,outputQubits) = __in;
#line 88 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((inputQubits[2L], outputQubits[0L]));
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
            return __m__.Run<BlackBoxBalanced2, (QArray<Qubit>,QArray<Qubit>), QVoid>((inputQubits, outputQubits));
        }
    }

    public class BlackBoxBalancedRandom1 : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public BlackBoxBalancedRandom1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BlackBoxBalancedRandom1";
        String ICallable.FullName => "Quantum._26_Demo_Deutsch_Jozsa_algorithm.BlackBoxBalancedRandom1";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (inputQubits,outputQubits) = __in;
#line 98 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[0L]);
#line 99 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[1L]);
#line 100 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[2L]);
#line 101 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[0L]));
#line 102 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[0L]);
#line 103 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[1L]);
#line 104 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[2L]);
#line 107 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[0L]);
#line 108 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[2L]);
#line 109 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[0L]));
#line 110 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[0L]);
#line 111 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[2L]);
#line 114 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[1L]);
#line 115 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[2L]);
#line 116 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[0L]));
#line 117 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[1L]);
#line 118 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[2L]);
#line 121 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[2L]);
#line 122 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[0L]));
#line 123 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[2L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> inputQubits, QArray<Qubit> outputQubits)
        {
            return __m__.Run<BlackBoxBalancedRandom1, (QArray<Qubit>,QArray<Qubit>), QVoid>((inputQubits, outputQubits));
        }
    }

    public class BlackBoxBalancedRandom2 : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public BlackBoxBalancedRandom2(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BlackBoxBalancedRandom2";
        String ICallable.FullName => "Quantum._26_Demo_Deutsch_Jozsa_algorithm.BlackBoxBalancedRandom2";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (inputQubits,outputQubits) = __in;
#line 134 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[0L]);
#line 135 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[1L]);
#line 136 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[0L]));
#line 137 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[0L]);
#line 138 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[1L]);
#line 141 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[0L]);
#line 142 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[0L]));
#line 143 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[0L]);
#line 146 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[1L]);
#line 147 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[0L]));
#line 148 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(inputQubits[1L]);
#line 151 "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\26_Demo Deutsch_Jozsa algorithm\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((inputQubits?.Copy(), outputQubits[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> inputQubits, QArray<Qubit> outputQubits)
        {
            return __m__.Run<BlackBoxBalancedRandom2, (QArray<Qubit>,QArray<Qubit>), QVoid>((inputQubits, outputQubits));
        }
    }
}