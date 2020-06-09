#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.HelloQuantumWorld", "Operation () : ()", new string[] { }, "c:\\Users\\kitty\\Documents\\Quantum Computing\\QuantumComputingViaQSharpSolution\\QuantumComputingViaQSharpSolution\\01_HelloQuantumWorld\\Operation.qs", 147L, 7L, 5L)]
#line hidden
namespace Quantum.HelloQuantumWorld
{
    public class Operation : Operation<QVoid, QVoid>
    {
        public Operation(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { };
        }

        public override Type[] Dependencies
        {
            get;
        }

        public override Func<QVoid, QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.HelloQuantumWorld.Operation", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.HelloQuantumWorld.Operation", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Operation, QVoid, QVoid>(QVoid.Instance);
        }
    }
}