// Tests for Lab 2: Multi-Qubit Gates
// Copyright 2021 The MITRE Corporation. All Rights Reserved.

namespace QSharpExercises.Tests.Lab2 {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Intrinsic;

    open Tests.Utils;


    @Test("QuantumSimulator")
    operation temp () : Unit {
        use qubits = Qubit[2];

        qubits

        AssertAllZero(qubits);
    }
}
