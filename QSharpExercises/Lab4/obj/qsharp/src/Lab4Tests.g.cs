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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests.Lab4\",\"Name\":\"Exercise1Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":14,\"Item2\":4},\"Comments\":{\"OpeningComments\":[\" open QSharpExercises.Solutions.Lab4;\"],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Transparent\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Tests.Lab4\",\"Name\":\"Exercise1Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Tests.Lab4\",\"Name\":\"Exercise2Test\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":51,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Transparent\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Tests.Lab4\",\"Name\":\"Exercise2Test\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Tests.Lab4
{
    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs", OperationFunctor.Body, 16, 53)]
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
#line 16 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
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
#line 16 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
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
        String ICallable.FullName => "Tests.Lab4.Exercise1Test";
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

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,Qubit), QVoid> Lab4__Exercise1
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> Microsoft__Quantum__Diagnostics__EqualityFactB
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> Microsoft__Quantum__Convert__ResultAsBool
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
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
#line 17 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
            var buffers = (IQArray<IQArray<Boolean>>)new QArray<IQArray<Boolean>>(new QArray<Boolean>(false, false), new QArray<Boolean>(false, true), new QArray<Boolean>(true, false), new QArray<Boolean>(true, true));
#line 24 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
            foreach (var i in new QRange(1L, 10L))
#line hidden
            {
#line 25 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                foreach (var buffer in buffers)
#line hidden
                {
#line hidden
                    {
#line 26 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                        var qubits = Allocate__.Apply(2L);
#line hidden
                        bool __arg1__ = true;
                        try
                        {
#line 27 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Microsoft__Quantum__Intrinsic__H.Apply(qubits[0L]);
#line 28 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Microsoft__Quantum__Intrinsic__CNOT.Apply((qubits[0L], qubits[1L]));
#line 30 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Lab4__Exercise1.Apply((buffer, qubits[0L]));
#line 32 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Microsoft__Quantum__Intrinsic__CNOT.Apply((qubits[0L], qubits[1L]));
#line 33 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Microsoft__Quantum__Intrinsic__H.Apply(qubits[0L]);
#line 35 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Microsoft__Quantum__Diagnostics__EqualityFactB.Apply((Microsoft__Quantum__Convert__ResultAsBool.Apply(Microsoft__Quantum__Intrinsic__M.Apply(qubits[0L])), buffer[0L], "First qubit is incorrect."));
#line 40 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Microsoft__Quantum__Diagnostics__EqualityFactB.Apply((Microsoft__Quantum__Convert__ResultAsBool.Apply(Microsoft__Quantum__Intrinsic__M.Apply(qubits[1L])), buffer[1L], "Second qubit is incorrect."));
#line 46 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
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
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Lab4__Exercise1 = this.__Factory__.Get<ICallable<(IQArray<Boolean>,Qubit), QVoid>>(typeof(global::Lab4.Exercise1));
            this.Microsoft__Quantum__Diagnostics__EqualityFactB = this.__Factory__.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(global::Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.Microsoft__Quantum__Convert__ResultAsBool = this.__Factory__.Get<ICallable<Result, Boolean>>(typeof(global::Microsoft.Quantum.Convert.ResultAsBool));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.ResetAll__ = this.__Factory__.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise1Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs", OperationFunctor.Body, 53, -1)]
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
#line 53 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
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
#line 53 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
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
        String ICallable.FullName => "Tests.Lab4.Exercise2Test";
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

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), IQArray<Boolean>> Lab4__Exercise2
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>,String), QVoid> Microsoft__Quantum__Diagnostics__AllEqualityFactB
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
#line 54 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
            var buffers = (IQArray<IQArray<Boolean>>)new QArray<IQArray<Boolean>>(new QArray<Boolean>(false, false), new QArray<Boolean>(false, true), new QArray<Boolean>(true, false), new QArray<Boolean>(true, true));
#line 61 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
            foreach (var i in new QRange(1L, 10L))
#line hidden
            {
#line 62 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                foreach (var buffer in buffers)
#line hidden
                {
#line hidden
                    {
#line 63 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                        var qubits = Allocate__.Apply(2L);
#line hidden
                        bool __arg1__ = true;
                        try
                        {
#line 64 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Microsoft__Quantum__Intrinsic__H.Apply(qubits[0L]);
#line 65 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Microsoft__Quantum__Intrinsic__CNOT.Apply((qubits[0L], qubits[1L]));
#line 66 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            if (buffer[1L])
                            {
#line 67 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                                Microsoft__Quantum__Intrinsic__X.Apply(qubits[0L]);
                            }

#line 69 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            if (buffer[0L])
                            {
#line 70 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                                Microsoft__Quantum__Intrinsic__Z.Apply(qubits[0L]);
                            }

#line 73 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            var result = (IQArray<Boolean>)Lab4__Exercise2.Apply((qubits[0L], qubits[1L]));
#line 75 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
                            Microsoft__Quantum__Diagnostics__AllEqualityFactB.Apply((result, buffer, "Exercise 2 result is incorrect."));
#line 81 "/home/ubuntu/timothys-folder/QSharpExercises/Lab4/Lab4Tests.qs"
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
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
            this.Lab4__Exercise2 = this.__Factory__.Get<ICallable<(Qubit,Qubit), IQArray<Boolean>>>(typeof(global::Lab4.Exercise2));
            this.Microsoft__Quantum__Diagnostics__AllEqualityFactB = this.__Factory__.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>,String), QVoid>>(typeof(global::Microsoft.Quantum.Diagnostics.AllEqualityFactB));
            this.ResetAll__ = this.__Factory__.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Exercise2Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}