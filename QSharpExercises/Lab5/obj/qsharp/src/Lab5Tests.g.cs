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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests.Lab5\",\"Name\":\"Exercise1Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":14,\"Item2\":4},\"Comments\":{\"OpeningComments\":[\" open QSharpExercises.Solutions.Lab5;\"],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Tests.Lab5\",\"Name\":\"Exercise1Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests.Lab5\",\"Name\":\"Exercise2Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":34,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Tests.Lab5\",\"Name\":\"Exercise2Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests.Lab5\",\"Name\":\"Exercise3Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":59,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Transparent\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Tests.Lab5\",\"Name\":\"Exercise3Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Tests.Lab5
{
    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs", OperationFunctor.Body, 16, 36)]
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
#line 16 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
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
#line 16 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
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
        String ICallable.FullName => "Tests.Lab5.Exercise1Test";
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

        protected ICallable Microsoft__Quantum__Canon__ApplyToEach
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

        protected ICallable<(IQArray<Qubit>,Qubit), QVoid> Lab5__Exercise1
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
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
#line 17 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
            foreach (var numQubits in new QRange(3L, 8L))
#line hidden
            {
#line hidden
                {
#line 18 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                    var (input,output) = (Allocate__.Apply(numQubits), Allocate__.Apply());
#line hidden
                    bool __arg1__ = true;
                    try
                    {
#line 19 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, input));
#line 20 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        Microsoft__Quantum__Intrinsic__X.Apply(output);
#line 22 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        Lab5__Exercise1.Apply((input, output));
#line 24 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        foreach (var qubit in input)
#line hidden
                        {
#line 25 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            Microsoft__Quantum__Intrinsic__Z.Controlled.Apply((new QArray<Qubit>(qubit), output));
                        }

#line 27 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        Microsoft__Quantum__Intrinsic__X.Apply(output);
#line 28 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, input));
#line 30 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        Microsoft__Quantum__Diagnostics__AssertAllZero.Apply(QArray<Qubit>.Add(input, new QArray<Qubit>(output)));
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
                            Release__.Apply(input);
#line hidden
                            Release__.Apply(output);
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
            this.Microsoft__Quantum__Canon__ApplyToEach = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Lab5__Exercise1 = this.__Factory__.Get<ICallable<(IQArray<Qubit>,Qubit), QVoid>>(typeof(global::Lab5.Exercise1));
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
            this.Microsoft__Quantum__Diagnostics__AssertAllZero = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(global::Microsoft.Quantum.Diagnostics.AssertAllZero));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise1Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs", OperationFunctor.Body, 36, 61)]
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
#line 36 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
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
#line 36 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
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
        String ICallable.FullName => "Tests.Lab5.Exercise2Test";
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

        protected ICallable Microsoft__Quantum__Canon__ApplyToEach
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

        protected ICallable<(Int64,Int64,IQArray<Qubit>,Qubit), QVoid> Lab5__Exercise2
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
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
#line 37 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
            foreach (var i in new QRange(1L, 10L))
#line hidden
            {
#line 38 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                foreach (var numQubits in new QRange(3L, 8L))
#line hidden
                {
#line hidden
                    {
#line 39 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        var (input,output) = (Allocate__.Apply(numQubits), Allocate__.Apply());
#line hidden
                        bool __arg1__ = true;
                        try
                        {
#line 40 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            var firstIndex = Microsoft__Quantum__Random__DrawRandomInt.Apply((0L, (numQubits - 1L)));
#line 41 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            var temp = Microsoft__Quantum__Random__DrawRandomInt.Apply((0L, (numQubits - 2L)));
#line 42 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            var secondIndex = ((firstIndex != temp) ? temp : (temp + 1L));
#line 44 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, input));
#line 45 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            Microsoft__Quantum__Intrinsic__X.Apply(output);
#line 47 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            Lab5__Exercise2.Apply((firstIndex, secondIndex, input, output));
#line 49 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            Microsoft__Quantum__Intrinsic__Z.Controlled.Apply((new QArray<Qubit>(input[firstIndex]), output));
#line 50 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            Microsoft__Quantum__Intrinsic__Z.Controlled.Apply((new QArray<Qubit>(input[secondIndex]), output));
#line 51 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            Microsoft__Quantum__Intrinsic__X.Apply(output);
#line 52 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, input));
#line 54 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                            Microsoft__Quantum__Diagnostics__AssertAllZero.Apply(QArray<Qubit>.Add(input, new QArray<Qubit>(output)));
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
                                Release__.Apply(input);
#line hidden
                                Release__.Apply(output);
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
            this.Microsoft__Quantum__Random__DrawRandomInt = this.__Factory__.Get<ICallable<(Int64,Int64), Int64>>(typeof(global::Microsoft.Quantum.Random.DrawRandomInt));
            this.Microsoft__Quantum__Canon__ApplyToEach = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Lab5__Exercise2 = this.__Factory__.Get<ICallable<(Int64,Int64,IQArray<Qubit>,Qubit), QVoid>>(typeof(global::Lab5.Exercise2));
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
            this.Microsoft__Quantum__Diagnostics__AssertAllZero = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(global::Microsoft.Quantum.Diagnostics.AssertAllZero));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise2Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs", OperationFunctor.Body, 61, -1)]
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
#line 61 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
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
#line 61 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
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
        String ICallable.FullName => "Tests.Lab5.Exercise3Test";
        protected ICallable<(Int64,Int64), Int64> Microsoft__Quantum__Random__DrawRandomInt
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Boolean> Lab5__Exercise3
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit), QVoid> Lab5__AlwaysZero
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit), QVoid> Lab5__AlwaysOne
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit), QVoid> Lab5__Exercise1
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,IQArray<Qubit>,Qubit), QVoid> Lab5__Exercise2
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line 62 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
            foreach (var i in new QRange(0L, 10L))
#line hidden
            {
#line 63 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                foreach (var numQubits in new QRange(3L, 8L))
#line hidden
                {
#line 64 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                    var firstIndex = Microsoft__Quantum__Random__DrawRandomInt.Apply((0L, (numQubits - 1L)));
#line 65 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                    var temp = Microsoft__Quantum__Random__DrawRandomInt.Apply((0L, (numQubits - 2L)));
#line 66 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                    var secondIndex = ((firstIndex != temp) ? temp : (temp + 1L));
#line 68 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                    if ((Lab5__Exercise3.Apply((numQubits, Lab5__AlwaysZero)) == false))
                    {
#line 69 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        throw new ExecutionFailException("Incorrectly classified AlwaysZero as balanced.");
                    }

#line 72 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                    if ((Lab5__Exercise3.Apply((numQubits, Lab5__AlwaysOne)) == false))
                    {
#line 73 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        throw new ExecutionFailException("Incorrectly classified AlwaysOne as balanced.");
                    }

#line 76 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                    if ((Lab5__Exercise3.Apply((numQubits, Lab5__Exercise1)) == true))
                    {
#line 77 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        throw new ExecutionFailException("Incorrectly classified Exercise1 as constant.");
                    }

#line 80 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                    if ((Lab5__Exercise3.Apply((numQubits, Lab5__Exercise2.Partial(new Func<(IQArray<Qubit>,Qubit), (Int64,Int64,IQArray<Qubit>,Qubit)>((__arg1__) => (firstIndex, secondIndex, __arg1__.Item1, __arg1__.Item2))))) == true))
                    {
#line 84 "/home/ubuntu/timothys-folder/QSharpExercises/Lab5/Lab5Tests.qs"
                        throw new ExecutionFailException("Incorrectly classified Exercise2 as constant.");
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Random__DrawRandomInt = this.__Factory__.Get<ICallable<(Int64,Int64), Int64>>(typeof(global::Microsoft.Quantum.Random.DrawRandomInt));
            this.Lab5__Exercise3 = this.__Factory__.Get<ICallable<(Int64,ICallable), Boolean>>(typeof(global::Lab5.Exercise3));
            this.Lab5__AlwaysZero = this.__Factory__.Get<ICallable<(IQArray<Qubit>,Qubit), QVoid>>(typeof(global::Lab5.AlwaysZero));
            this.Lab5__AlwaysOne = this.__Factory__.Get<ICallable<(IQArray<Qubit>,Qubit), QVoid>>(typeof(global::Lab5.AlwaysOne));
            this.Lab5__Exercise1 = this.__Factory__.Get<ICallable<(IQArray<Qubit>,Qubit), QVoid>>(typeof(global::Lab5.Exercise1));
            this.Lab5__Exercise2 = this.__Factory__.Get<ICallable<(Int64,Int64,IQArray<Qubit>,Qubit), QVoid>>(typeof(global::Lab5.Exercise2));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise3Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}