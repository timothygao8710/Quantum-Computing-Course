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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"project\",\"Name\":\"Exercise1Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":13,\"Item2\":4},\"Comments\":{\"OpeningComments\":[\" open QSharpExercises.Solutions.Lab1;\"],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"project\",\"Name\":\"Exercise1Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"project\",\"Name\":\"Exercise2Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":25,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"project\",\"Name\":\"Exercise2Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"project\",\"Name\":\"Exercise3Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":39,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"project\",\"Name\":\"Exercise3Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"project\",\"Name\":\"Exercise4Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":55,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Transparent\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"project\",\"Name\":\"Exercise4Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace project
{
    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs", OperationFunctor.Body, 15, 27)]
    public partial class Exercise1Test : Operation<QVoid, QVoid>, ICallable
    {
        public Exercise1Test(IOperationFactory m) : base(m)
        {
        }

        public class QuantumSimulator
        {
            public QuantumSimulator(Xunit.Abstractions.ITestOutputHelper Output)
            {
                this.Output = Output;
            }

            internal Xunit.Abstractions.ITestOutputHelper Output
            {
                get;
            }

            [Xunit.Fact()]
            [Xunit.Trait("Target", "QuantumSimulator")]
            [Xunit.Trait("Name", "Exercise1Test")]
            public void Exercise1Test()
#line 15 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
            {
                var sim = new Microsoft.Quantum.Simulation.Simulators.QuantumSimulator();
                if (sim is Microsoft.Quantum.Simulation.Common.SimulatorBase baseSim && this.Output != null)
                {
                    baseSim.OnLog += this.Output.WriteLine;
                }

                try
                {
                    sim.Execute<Exercise1Test, QVoid, QVoid>(QVoid.Instance);
                }
                catch
                {
#line 15 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Xunit.Assert.True(false, "Q# Test failed. For details see the Standard output below.");
                }
                finally
                {
                    if (sim is IDisposable disposeSim)
                    {
                        disposeSim.Dispose();
                    }
                }
            }
        }

        String ICallable.Name => "Exercise1Test";
        String ICallable.FullName => "project.Exercise1Test";
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

        protected ICallable<Qubit, QVoid> Lab1__Exercise1
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected IUnitary<(Result,Qubit)> Microsoft__Quantum__Diagnostics__AssertQubit
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 16 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                var target = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 18 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Lab1__Exercise1.Apply(target);
#line 20 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Microsoft__Quantum__Intrinsic__X.Apply(target);
#line 22 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Microsoft__Quantum__Diagnostics__AssertQubit.Apply((Result.Zero, target));
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
                        Release__.Apply(target);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Lab1__Exercise1 = this.__Factory__.Get<ICallable<Qubit, QVoid>>(typeof(global::Lab1.Exercise1));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Diagnostics__AssertQubit = this.__Factory__.Get<IUnitary<(Result,Qubit)>>(typeof(global::Microsoft.Quantum.Diagnostics.AssertQubit));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise1Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs", OperationFunctor.Body, 27, 41)]
    public partial class Exercise2Test : Operation<QVoid, QVoid>, ICallable
    {
        public Exercise2Test(IOperationFactory m) : base(m)
        {
        }

        public class QuantumSimulator
        {
            public QuantumSimulator(Xunit.Abstractions.ITestOutputHelper Output)
            {
                this.Output = Output;
            }

            internal Xunit.Abstractions.ITestOutputHelper Output
            {
                get;
            }

            [Xunit.Fact()]
            [Xunit.Trait("Target", "QuantumSimulator")]
            [Xunit.Trait("Name", "Exercise2Test")]
            public void Exercise2Test()
#line 27 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
            {
                var sim = new Microsoft.Quantum.Simulation.Simulators.QuantumSimulator();
                if (sim is Microsoft.Quantum.Simulation.Common.SimulatorBase baseSim && this.Output != null)
                {
                    baseSim.OnLog += this.Output.WriteLine;
                }

                try
                {
                    sim.Execute<Exercise2Test, QVoid, QVoid>(QVoid.Instance);
                }
                catch
                {
#line 27 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Xunit.Assert.True(false, "Q# Test failed. For details see the Standard output below.");
                }
                finally
                {
                    if (sim is IDisposable disposeSim)
                    {
                        disposeSim.Dispose();
                    }
                }
            }
        }

        String ICallable.Name => "Exercise2Test";
        String ICallable.FullName => "project.Exercise2Test";
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

        protected ICallable<(Qubit,Qubit), QVoid> Lab1__Exercise2
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> Microsoft__Quantum__Diagnostics__AssertAllZero
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 28 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                var targets = Allocate__.Apply(2L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 30 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Lab1__Exercise2.Apply((targets[0L], targets[1L]));
#line 32 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(targets[0L]);
#line 33 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(targets[1L]);
#line 34 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Microsoft__Quantum__Intrinsic__X.Apply(targets[1L]);
#line 36 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Microsoft__Quantum__Diagnostics__AssertAllZero.Apply(targets);
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
                        Release__.Apply(targets);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Lab1__Exercise2 = this.__Factory__.Get<ICallable<(Qubit,Qubit), QVoid>>(typeof(global::Lab1.Exercise2));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Diagnostics__AssertAllZero = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(global::Microsoft.Quantum.Diagnostics.AssertAllZero));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise2Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs", OperationFunctor.Body, 41, 57)]
    public partial class Exercise3Test : Operation<QVoid, QVoid>, ICallable
    {
        public Exercise3Test(IOperationFactory m) : base(m)
        {
        }

        public class QuantumSimulator
        {
            public QuantumSimulator(Xunit.Abstractions.ITestOutputHelper Output)
            {
                this.Output = Output;
            }

            internal Xunit.Abstractions.ITestOutputHelper Output
            {
                get;
            }

            [Xunit.Fact()]
            [Xunit.Trait("Target", "QuantumSimulator")]
            [Xunit.Trait("Name", "Exercise3Test")]
            public void Exercise3Test()
#line 41 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
            {
                var sim = new Microsoft.Quantum.Simulation.Simulators.QuantumSimulator();
                if (sim is Microsoft.Quantum.Simulation.Common.SimulatorBase baseSim && this.Output != null)
                {
                    baseSim.OnLog += this.Output.WriteLine;
                }

                try
                {
                    sim.Execute<Exercise3Test, QVoid, QVoid>(QVoid.Instance);
                }
                catch
                {
#line 41 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Xunit.Assert.True(false, "Q# Test failed. For details see the Standard output below.");
                }
                finally
                {
                    if (sim is IDisposable disposeSim)
                    {
                        disposeSim.Dispose();
                    }
                }
            }
        }

        String ICallable.Name => "Exercise3Test";
        String ICallable.FullName => "project.Exercise3Test";
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

        protected ICallable<IQArray<Qubit>, QVoid> Lab1__Exercise3
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> Microsoft__Quantum__Intrinsic__Ry
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> Microsoft__Quantum__Math__PI
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> Microsoft__Quantum__Convert__IntAsDouble
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> Microsoft__Quantum__Diagnostics__AssertAllZero
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line 42 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
            foreach (var numQubits in new QRange(3L, 10L))
#line hidden
            {
#line hidden
                {
#line 43 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    var qubits = Allocate__.Apply(numQubits);
#line hidden
                    bool __arg1__ = true;
                    try
                    {
#line 45 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                        Lab1__Exercise3.Apply(qubits);
#line 47 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                        foreach (var index in new QRange(0L, (numQubits - 1L)))
#line hidden
                        {
#line 48 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                            Microsoft__Quantum__Intrinsic__Ry.Apply((((Microsoft__Quantum__Math__PI.Apply(QVoid.Instance) * Microsoft__Quantum__Convert__IntAsDouble.Apply(index)) / -(12D)), qubits[index]));
                        }

#line 51 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                        Microsoft__Quantum__Diagnostics__AssertAllZero.Apply(qubits);
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
                            Release__.Apply(qubits);
                        }
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Lab1__Exercise3 = this.__Factory__.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(global::Lab1.Exercise3));
            this.Microsoft__Quantum__Intrinsic__Ry = this.__Factory__.Get<IUnitary<(Double,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.Ry));
            this.Microsoft__Quantum__Math__PI = this.__Factory__.Get<ICallable<QVoid, Double>>(typeof(global::Microsoft.Quantum.Math.PI));
            this.Microsoft__Quantum__Convert__IntAsDouble = this.__Factory__.Get<ICallable<Int64, Double>>(typeof(global::Microsoft.Quantum.Convert.IntAsDouble));
            this.Microsoft__Quantum__Diagnostics__AssertAllZero = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(global::Microsoft.Quantum.Diagnostics.AssertAllZero));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise3Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs", OperationFunctor.Body, 57, -1)]
    public partial class Exercise4Test : Operation<QVoid, QVoid>, ICallable
    {
        public Exercise4Test(IOperationFactory m) : base(m)
        {
        }

        public class QuantumSimulator
        {
            public QuantumSimulator(Xunit.Abstractions.ITestOutputHelper Output)
            {
                this.Output = Output;
            }

            internal Xunit.Abstractions.ITestOutputHelper Output
            {
                get;
            }

            [Xunit.Fact()]
            [Xunit.Trait("Target", "QuantumSimulator")]
            [Xunit.Trait("Name", "Exercise4Test")]
            public void Exercise4Test()
#line 57 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
            {
                var sim = new Microsoft.Quantum.Simulation.Simulators.QuantumSimulator();
                if (sim is Microsoft.Quantum.Simulation.Common.SimulatorBase baseSim && this.Output != null)
                {
                    baseSim.OnLog += this.Output.WriteLine;
                }

                try
                {
                    sim.Execute<Exercise4Test, QVoid, QVoid>(QVoid.Instance);
                }
                catch
                {
#line 57 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    Xunit.Assert.True(false, "Q# Test failed. For details see the Standard output below.");
                }
                finally
                {
                    if (sim is IDisposable disposeSim)
                    {
                        disposeSim.Dispose();
                    }
                }
            }
        }

        String ICallable.Name => "Exercise4Test";
        String ICallable.FullName => "project.Exercise4Test";
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

        protected ICallable<(Int64,Int64), Int64> Microsoft__Quantum__Random__DrawRandomInt
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, IQArray<Int64>> Lab1__Exercise4
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Int64>,IQArray<Int64>,String), QVoid> Microsoft__Quantum__Diagnostics__AllEqualityFactI
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ResetAll__
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line 58 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
            foreach (var i in new QRange(0L, 4L))
#line hidden
            {
#line 59 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                var states = QArray<Int64>.Create(0L);
#line hidden
                {
#line 60 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                    var qubits = Allocate__.Apply(5L);
#line hidden
                    bool __arg1__ = true;
                    try
                    {
#line 61 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                        foreach (var j in new QRange(0L, 4L))
#line hidden
                        {
#line 62 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                            states = QArray<Int64>.Add(states, new QArray<Int64>(Microsoft__Quantum__Random__DrawRandomInt.Apply((0L, 1L))));
#line 63 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                            if ((states[j] == 1L))
                            {
#line 64 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                                Microsoft__Quantum__Intrinsic__X.Apply(qubits[j]);
                            }
                        }

#line 68 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                        var results = (IQArray<Int64>)Lab1__Exercise4.Apply(qubits);
#line 70 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                        Microsoft__Quantum__Diagnostics__AllEqualityFactI.Apply((states?.Copy(), results, "Exercise 4 test failed."));
#line 71 "/home/ubuntu/timothys-folder/QSharpExercises/Lab1/Tests.qs"
                        ResetAll__.Apply(qubits);
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
                            Release__.Apply(qubits);
                        }
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Random__DrawRandomInt = this.__Factory__.Get<ICallable<(Int64,Int64), Int64>>(typeof(global::Microsoft.Quantum.Random.DrawRandomInt));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Lab1__Exercise4 = this.__Factory__.Get<ICallable<IQArray<Qubit>, IQArray<Int64>>>(typeof(global::Lab1.Exercise4));
            this.Microsoft__Quantum__Diagnostics__AllEqualityFactI = this.__Factory__.Get<ICallable<(IQArray<Int64>,IQArray<Int64>,String), QVoid>>(typeof(global::Microsoft.Quantum.Diagnostics.AllEqualityFactI));
            this.ResetAll__ = this.__Factory__.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise4Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}