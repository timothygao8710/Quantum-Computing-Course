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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests.Lab10\",\"Name\":\"Exercise1Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":14,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Tests.Lab10\",\"Name\":\"Exercise1Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests.Lab10\",\"Name\":\"Exercise2Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":32,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Controlled\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Tests.Lab10\",\"Name\":\"Exercise2Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests.Lab10\",\"Name\":\"Exercise3Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":90,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Controlled\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs\",\"Position\":{\"Item1\":91,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Tests.Lab10\",\"Name\":\"Exercise3Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs\",\"Position\":{\"Item1\":91,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Tests.Lab10
{
    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs", OperationFunctor.Body, 16, 34)]
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
#line 16 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
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
#line 16 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
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
        String ICallable.FullName => "Tests.Lab10.Exercise1Test";
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

        protected ICallable<QVoid, IQArray<Double>> Tests__Utils__GenerateRandomRotation
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Double>,Qubit)> Tests__Utils__ApplyRotation
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,IQArray<Qubit>)> Lab10__Exercise1
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
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
#line 17 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
            foreach (var i in new QRange(1L, 25L))
#line hidden
            {
#line hidden
                {
#line 18 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                    var (original,spares) = (Allocate__.Apply(), Allocate__.Apply(2L));
#line hidden
                    bool __arg1__ = true;
                    try
                    {
#line 19 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                        var rotation = (IQArray<Double>)Tests__Utils__GenerateRandomRotation.Apply(QVoid.Instance);
#line 20 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                        Tests__Utils__ApplyRotation.Apply((rotation, original));
#line 22 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                        Lab10__Exercise1.Apply((original, spares));
#line 24 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                        Microsoft__Quantum__Intrinsic__CNOT.Apply((original, spares[0L]));
#line 25 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                        Microsoft__Quantum__Intrinsic__CNOT.Apply((original, spares[1L]));
#line 26 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                        Tests__Utils__ApplyRotation.Adjoint.Apply((rotation, original));
#line 28 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                        Microsoft__Quantum__Diagnostics__AssertAllZero.Apply(QArray<Qubit>.Add(new QArray<Qubit>(original), spares));
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
                            Release__.Apply(original);
#line hidden
                            Release__.Apply(spares);
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
            this.Tests__Utils__GenerateRandomRotation = this.__Factory__.Get<ICallable<QVoid, IQArray<Double>>>(typeof(global::Tests.Utils.GenerateRandomRotation));
            this.Tests__Utils__ApplyRotation = this.__Factory__.Get<IUnitary<(IQArray<Double>,Qubit)>>(typeof(global::Tests.Utils.ApplyRotation));
            this.Lab10__Exercise1 = this.__Factory__.Get<IAdjointable<(Qubit,IQArray<Qubit>)>>(typeof(global::Lab10.Exercise1));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Microsoft__Quantum__Diagnostics__AssertAllZero = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(global::Microsoft.Quantum.Diagnostics.AssertAllZero));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise1Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs", OperationFunctor.Body, 34, 92)]
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
#line 34 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
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
#line 34 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
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
        String ICallable.FullName => "Tests.Lab10.Exercise2Test";
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

        protected ICallable<QVoid, IQArray<Double>> Tests__Utils__GenerateRandomRotation
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Double>,Qubit)> Tests__Utils__ApplyRotation
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,IQArray<Qubit>)> Lab10__Exercise1
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, IQArray<Result>> Lab10__Exercise2
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
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
#line 35 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
            foreach (var i in new QRange(1L, 10L))
#line hidden
            {
#line 36 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                foreach (var brokenQubitIndex in new QRange(-(1L), 3L))
#line hidden
                {
#line hidden
                    {
#line 37 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                        var register = Allocate__.Apply(3L);
#line hidden
                        bool __arg1__ = true;
                        try
                        {
#line 38 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            var rotation = (IQArray<Double>)Tests__Utils__GenerateRandomRotation.Apply(QVoid.Instance);
#line 39 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            Tests__Utils__ApplyRotation.Apply((rotation, register[0L]));
#line 40 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            Lab10__Exercise1.Apply((register[0L], register.Slice(new QRange(1L, 2L))));
#line 43 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            if ((brokenQubitIndex == -(1L)))
                            {
#line 44 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                var syndrome = new QArray<Result>(Lab10__Exercise2.Apply(register));
#line 45 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                if (((syndrome[0L] != Result.Zero) || (syndrome[1L] != Result.Zero)))
                                {
#line 46 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                    throw new ExecutionFailException((("Incorrect syndrome measurement. " + "It should have been [Zero, Zero] but it was") + String.Format("[{0}, {1}", syndrome[0L], syndrome[1L])));
                                }
                            }
                            else if ((brokenQubitIndex == 0L))
                            {
#line 54 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                Microsoft__Quantum__Intrinsic__X.Apply(register[0L]);
#line 55 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                var syndrome = new QArray<Result>(Lab10__Exercise2.Apply(register));
#line 56 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                if (((syndrome[0L] != Result.One) || (syndrome[1L] != Result.One)))
                                {
#line 57 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                    throw new ExecutionFailException((("Incorrect syndrome measurement. " + "It should have been [One, One] but it was") + String.Format("[{0}, {1}", syndrome[0L], syndrome[1L])));
                                }
                            }
                            else if ((brokenQubitIndex == 1L))
                            {
#line 65 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                Microsoft__Quantum__Intrinsic__X.Apply(register[1L]);
#line 66 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                var syndrome = new QArray<Result>(Lab10__Exercise2.Apply(register));
#line 67 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                if (((syndrome[0L] != Result.One) || (syndrome[1L] != Result.Zero)))
                                {
#line 68 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                    throw new ExecutionFailException((("Incorrect syndrome measurement. " + "It should have been [One, Zero] but it was") + String.Format("[{0}, {1}", syndrome[0L], syndrome[1L])));
                                }
                            }
                            else if ((brokenQubitIndex == 1L))
                            {
#line 76 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                Microsoft__Quantum__Intrinsic__X.Apply(register[2L]);
#line 77 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                var syndrome = new QArray<Result>(Lab10__Exercise2.Apply(register));
#line 78 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                if (((syndrome[0L] != Result.Zero) || (syndrome[1L] != Result.One)))
                                {
#line 79 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                    throw new ExecutionFailException((("Incorrect syndrome measurement. " + "It should have been [Zero, One] but it was") + String.Format("[{0}, {1}", syndrome[0L], syndrome[1L])));
                                }
                            }

#line 85 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            ResetAll__.Apply(register);
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
                                Release__.Apply(register);
                            }
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
            this.Tests__Utils__GenerateRandomRotation = this.__Factory__.Get<ICallable<QVoid, IQArray<Double>>>(typeof(global::Tests.Utils.GenerateRandomRotation));
            this.Tests__Utils__ApplyRotation = this.__Factory__.Get<IUnitary<(IQArray<Double>,Qubit)>>(typeof(global::Tests.Utils.ApplyRotation));
            this.Lab10__Exercise1 = this.__Factory__.Get<IAdjointable<(Qubit,IQArray<Qubit>)>>(typeof(global::Lab10.Exercise1));
            this.Lab10__Exercise2 = this.__Factory__.Get<ICallable<IQArray<Qubit>, IQArray<Result>>>(typeof(global::Lab10.Exercise2));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.ResetAll__ = this.__Factory__.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise2Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs", OperationFunctor.Body, 92, -1)]
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
#line 92 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
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
#line 92 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
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
        String ICallable.FullName => "Tests.Lab10.Exercise3Test";
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

        protected ICallable<QVoid, IQArray<Double>> Tests__Utils__GenerateRandomRotation
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Double>,Qubit)> Tests__Utils__ApplyRotation
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,IQArray<Qubit>)> Lab10__Exercise1
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, IQArray<Result>> Lab10__Exercise2
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<Result>), QVoid> Lab10__Exercise3
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
#line 93 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
            foreach (var i in new QRange(1L, 10L))
#line hidden
            {
#line 94 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                foreach (var brokenQubitIndex in new QRange(-(1L), 2L))
#line hidden
                {
#line hidden
                    {
#line 95 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                        var register = Allocate__.Apply(3L);
#line hidden
                        bool __arg1__ = true;
                        try
                        {
#line 96 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            var rotation = (IQArray<Double>)Tests__Utils__GenerateRandomRotation.Apply(QVoid.Instance);
#line 97 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            Tests__Utils__ApplyRotation.Apply((rotation, register[0L]));
#line 98 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            Lab10__Exercise1.Apply((register[0L], register.Slice(new QRange(1L, 2L))));
#line 100 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            if ((brokenQubitIndex >= 0L))
                            {
#line 101 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                                Microsoft__Quantum__Intrinsic__X.Apply(register[brokenQubitIndex]);
                            }

#line 104 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            var syndrome = (IQArray<Result>)Lab10__Exercise2.Apply(register);
#line 106 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            Lab10__Exercise3.Apply((register, syndrome));
#line 108 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            Lab10__Exercise1.Adjoint.Apply((register[0L], register.Slice(new QRange(1L, 2L))));
#line 109 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            Tests__Utils__ApplyRotation.Adjoint.Apply((rotation, register[0L]));
#line 111 "/home/ubuntu/timothys-folder/QSharpExercises/Lab10/Tests.qs"
                            Microsoft__Quantum__Diagnostics__AssertAllZero.Apply(register);
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
                                Release__.Apply(register);
                            }
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
            this.Tests__Utils__GenerateRandomRotation = this.__Factory__.Get<ICallable<QVoid, IQArray<Double>>>(typeof(global::Tests.Utils.GenerateRandomRotation));
            this.Tests__Utils__ApplyRotation = this.__Factory__.Get<IUnitary<(IQArray<Double>,Qubit)>>(typeof(global::Tests.Utils.ApplyRotation));
            this.Lab10__Exercise1 = this.__Factory__.Get<IAdjointable<(Qubit,IQArray<Qubit>)>>(typeof(global::Lab10.Exercise1));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Lab10__Exercise2 = this.__Factory__.Get<ICallable<IQArray<Qubit>, IQArray<Result>>>(typeof(global::Lab10.Exercise2));
            this.Lab10__Exercise3 = this.__Factory__.Get<ICallable<(IQArray<Qubit>,IQArray<Result>), QVoid>>(typeof(global::Lab10.Exercise3));
            this.Microsoft__Quantum__Diagnostics__AssertAllZero = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(global::Microsoft.Quantum.Diagnostics.AssertAllZero));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise3Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}