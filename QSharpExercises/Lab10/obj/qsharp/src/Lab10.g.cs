//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Lab10\",\"Name\":\"Exercise1\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Empty\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"original\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"spares\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" In this exercise, you are provided with an original qubit in an\",\" unknown state a|0> + b|1>. You are also provided with two blank\",\" qubits, both of which are in the |0> state. Your goal is to construct\",\" a \\\"logical qubit\\\" from these three qubits that acts like a single\",\" qubit, but can protect against bit-flip errors on any one of the three\",\" actual qubits.\",\"\",\" To construct the logical qubit, put the three qubits into the\",\" entangled state a|000> + b|111>.\",\"\",\" # Input\",\" ## original\",\" A qubit that you want to protect from bit flips. It will be in the\",\" state a|0> + b|1>.\",\"\",\" ## spares\",\" A register of two spare qubits that you can use to add error\",\" correction to the original qubit. Both are in the |0> state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Lab10\",\"Name\":\"Exercise1\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Lab10\",\"Name\":\"Exercise1\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":71}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Lab10.Exercise1\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Lab10\",\"Name\":\"Exercise2\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" In this exercise, you are provided with a logical qubit, represented\",\" by an error-protected register that was encoded with your Exercise 1\",\" implementation. Your goal is to perform a syndrome measurement on the\",\" register. This should consist of two parity checks (a parity check is\",\" an operation to see whether or not two qubits have the same state).\",\" The first parity check should be between qubits 0 and 1, and the\",\" second check should be between qubits 0 and 2.\",\"\",\" # Input\",\" ## register\",\" A three-qubit register representing a single error-protected logical\",\" qubit. Its state is unknown, and one of the qubits may have suffered\",\" a bit flip error.\",\"\",\" # Output\",\" An array of two measurement results. The first result should be the\",\" measurement of the parity check on qubits 0 and 1, and the second\",\" result should be the measurement of the parity check on qubits 0 and\",\" 2. If both qubits in a parity check have the same state, the resulting\",\" bit should be Zero. If the two qubits have different states (meaning\",\" one of the two qubits was flipped), the result should be One.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Lab10\",\"Name\":\"Exercise2\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Lab10\",\"Name\":\"Exercise3\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Controlled\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Empty\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"syndromeMeasurement\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" In this exercise, you are provided with a logical qubit encoded with\",\" your Exercise 1 implementation and a syndrome measurement array\",\" produced by your Exercise 2 implementation. Your goal is to interpret\",\" the syndrome measurement to find which qubit in the error-corrected\",\" register suffered a bit-flip error (if any), and to correct it by\",\" flipping it back to the proper state.\",\"\",\" # Input\",\" ## register\",\" A three-qubit register representing a single error-protected logical\",\" qubit. Its state is unknown, and one of the qubits may have suffered\",\" a bit flip error.\",\"\",\" ## syndromeMeasurement\",\" An array of two measurement results that represent parity checks. The\",\" first one represents a parity check between qubit 0 and qubit 1; if\",\" both qubits have the same parity, the result will be 0, and if they\",\" have opposite parity, the result will be One. The second result\",\" corresponds to a parity check between qubit 0 and qubit 2.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Lab10\",\"Name\":\"Exercise3\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
#line hidden
namespace Lab10
{
    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs", OperationFunctor.Body, 29, 62)]
    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs", OperationFunctor.Adjoint, 29, 62)]
    public partial class Exercise1 : Adjointable<(Qubit,IQArray<Qubit>)>, ICallable
    {
        public Exercise1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,IQArray<Qubit>)>, IApplyData
        {
            public In((Qubit,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
                }
            }
        }

        String ICallable.Name => "Exercise1";
        String ICallable.FullName => "Lab10.Exercise1";
        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        public override Func<(Qubit,IQArray<Qubit>), QVoid> __Body__ => (__in__) =>
        {
            var (original,spares) = __in__;
#line 35 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
            Microsoft__Quantum__Intrinsic__CNOT.Apply((original, spares[0L]));
#line 36 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
            Microsoft__Quantum__Intrinsic__CNOT.Apply((original, spares[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,IQArray<Qubit>), QVoid> __AdjointBody__ => (__in__) =>
        {
            var (original,spares) = __in__;
#line 29 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
            Microsoft__Quantum__Intrinsic__CNOT.Adjoint.Apply((original, spares[1L]));
#line 29 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
            Microsoft__Quantum__Intrinsic__CNOT.Adjoint.Apply((original, spares[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __DataIn__((Qubit,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit original, IQArray<Qubit> spares)
        {
            return __m__.Run<Exercise1, (Qubit,IQArray<Qubit>), QVoid>((original, spares));
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs", OperationFunctor.Body, 62, 104)]
    public partial class Exercise2 : Operation<IQArray<Qubit>, IQArray<Result>>, ICallable
    {
        public Exercise2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Exercise2";
        String ICallable.FullName => "Lab10.Exercise2";
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset__
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, IQArray<Result>> __Body__ => (__in__) =>
        {
            var register = __in__;
#line 69 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
            var res = QArray<Result>.Create(0L);
#line hidden
            {
#line 70 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                var anc = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 72 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                    Microsoft__Quantum__Intrinsic__CNOT.Apply((register[0L], anc));
#line 73 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                    Microsoft__Quantum__Intrinsic__CNOT.Apply((register[1L], anc));
#line 74 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                    res = QArray<Result>.Add(res, new QArray<Result>(Microsoft__Quantum__Intrinsic__M.Apply(anc)));
#line 75 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                    Reset__.Apply(anc);
#line 76 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                    Microsoft__Quantum__Intrinsic__CNOT.Apply((register[0L], anc));
#line 77 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                    Microsoft__Quantum__Intrinsic__CNOT.Apply((register[2L], anc));
#line 78 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                    res = QArray<Result>.Add(res, new QArray<Result>(Microsoft__Quantum__Intrinsic__M.Apply(anc)));
#line 79 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                    Reset__.Apply(anc);
#line 80 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                    return res;
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(anc);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Reset__ = this.__Factory__.Get<ICallable<Qubit, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Reset));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Qubit> register)
        {
            return __m__.Run<Exercise2, IQArray<Qubit>, IQArray<Result>>(register);
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs", OperationFunctor.Body, 104, -1)]
    public partial class Exercise3 : Operation<(IQArray<Qubit>,IQArray<Result>), QVoid>, ICallable
    {
        public Exercise3(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Result>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Result>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return ((IApplyData)Data.Item1)?.Qubits;
                }
            }
        }

        String ICallable.Name => "Exercise3";
        String ICallable.FullName => "Lab10.Exercise3";
        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Result>), QVoid> __Body__ => (__in__) =>
        {
            var (register,syndromeMeasurement) = __in__;
#line 114 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
            if (((syndromeMeasurement[1L] == Result.One) && (syndromeMeasurement[0L] == Result.One)))
            {
#line 115 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                Microsoft__Quantum__Intrinsic__X.Apply(register[0L]);
            }
            else if ((syndromeMeasurement[0L] == Result.One))
            {
#line 117 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                Microsoft__Quantum__Intrinsic__X.Apply(register[1L]);
            }
            else if ((syndromeMeasurement[1L] == Result.One))
            {
#line 119 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Lab10.qs"
                Microsoft__Quantum__Intrinsic__X.Apply(register[2L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __DataIn__((IQArray<Qubit>,IQArray<Result>) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, IQArray<Result> syndromeMeasurement)
        {
            return __m__.Run<Exercise3, (IQArray<Qubit>,IQArray<Result>), QVoid>((register, syndromeMeasurement));
        }
    }
}