// Lab 9: Shor's Algorithm
// Copyright 2021 The MITRE Corporation. All Rights Reserved.

namespace Lab9 {

    open Microsoft.Quantum.Arithmetic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;


    /// # Summary
    /// In this exercise, you must implement the Quantum Fourier Transform
    /// circuit. This will perform an in-place transformation of the
    /// amplitudes of each state in the superposition from the
    /// value-versus-time to the value-versus-frequency domain.
    /// 
    /// # Input
    /// ## register
    /// A register containing qubits in superposition.
    /// The superposition is unknown, and the amplitudes are not guaranteed to
    /// be uniform.

    operation Reverse (register : BigEndian) : Unit is Adj + Ctl {
        for i in 0..Length(register!)/2-1 {
            SWAP(register![i], register![Length(register!)-1-i]);
        }
    }

    operation QFT (register : BigEndian) : Unit is Adj + Ctl {
        // Hint: there are two functions you may want to use here:
        // the first is your implementation of register reversal in Lab 2,
        // Exercise 2.
        // The second is the Microsoft.Quantum.Intrinsic.R1Frac() gate.
        let len = Length(register!);
        
        for i in 0..len-1{
            H(register![i]);
            for j in i+1 .. len-1{
                let a = j - i + 1;
                Controlled R1Frac(register![j..j], (2, a, register![i]));
            }
        }

        Reverse(register);
    }



    /// # Summary
    /// In this exercise, you must implement the quantum modular
    /// exponentiation function: |o> = a^|x> mod b.
    /// |x> and |o> are input and output registers respectively, and a and b
    /// are classical integers.
    /// 
    /// # Input
    /// ## a
    /// The base power of the term being exponentiated.
    /// 
    /// ## b
    /// The modulus for the function.
    /// 
    /// ## input
    /// The register containing a superposition of all of the exponent values
    /// that the user wants to calculate; this superposition is arbitrary.
    /// 
    /// ## output
    /// This register must contain the output |o> of the modular
    /// exponentiation function. It will start in the |0...0> state.
    operation Exercise1 (
        a : Int,
        b : Int,
        input : Qubit[],
        output : Qubit[]
    ) : Unit {
        // Note: For convenience, you can use the
        // Microsoft.Quantum.Math.ExpModI() function to calculate a modular
        // exponent classically. You can use the
        // Microsoft.Quantum.Arithmetic.MultiplyByModularInteger() function to
        // do an in-place quantum modular multiplication.

        let lenin = Length(input);
        let lenout = Length(output);

        // mutable pow = 1;
        X(output[lenout-1]);
        // //a ^ x mod b
        for i in lenin-1..-1..0{
            let pow = 2 ^ (lenin - 1 - i);
            let c = ExpModI(a, pow, b);
            Controlled MultiplyByModularInteger(
                [input[i]],
                (c, b, LittleEndian(output))
            );
            // set pow = pow * 2;
        }
    }


    /// # Summary
    /// In this exercise, you must implement the quantum subroutine of Shor's
    /// algorithm. You will be given a number to factor and some guess to a
    /// possible factor - both of which are integers.
    /// You must set up, execute, and measure the quantum circuit.
    /// You should return the fraction that was produced by measuring the
    /// result at the end of the subroutine, in the form of a tuple:
    /// the first value should be the number you measured, and the second
    /// value should be 2^n, where n is the number of qubits you use in your
    /// input register.
    /// 
    /// # Input
    /// ## numberToFactor
    /// The number that the user wants to factor. This will become the modulus
    /// for the modular arithmetic used in the subroutine.
    /// 
    /// ## guess
    /// The number that's being guessed as a possible factor. This will become
    /// the base of exponentiation for the modular arithmetic used in the 
    /// subroutine.
    /// 
    /// # Output
    /// A tuple representing the continued fraction approximation that the
    /// subroutine measured. The first value should be the numerator (the
    /// value that was measured from the qubits), and the second value should
    /// be the denominator (the total size of the input space, which is 2^n
    /// where n is the size of your input register).
    operation Exercise2 (
        numberToFactor : Int,
        guess : Int
    ) : (Int, Int) {
        // Hint: you can use the Microsoft.Quantum.Arithmetic.MeasureInteger()
        // function to measure a whole set of qubits and transform them into
        // their integer representation.

        // NOTE: This is a *probablistic* test. There is a chance that the
        // unit test fails, even if you have the correct answer. If you think
        // you do, run the test again. Also, look at the output of the test to
        // see what values you came up with versus what the system expects.
        // Message("SDFJKSL");
        // mutable n = 0; //greatest bit
        // for i in 0..6{
        //     if((guess>>>i)%2 == 0){
        //         set n = i;
        //     }
        // }        
        // set n = n + 1;
        let n = Ceiling(Log(IntAsDouble(numberToFactor))/Log(2.0));

        use input = Qubit[2 * n];
        use output = Qubit[n];

        ApplyToEach(H, input);

        Exercise1(guess, numberToFactor, input, output);

        Adjoint QFT(BigEndian(input));

        let res = MeasureInteger(BigEndianAsLittleEndian(BigEndian(input)));
        ResetAll(output);
        ResetAll(input);
        return (res, 2 ^ (2 * n));
    }


    /// # Summary
    /// In this exercise, you will be given an arbitrary numerator and
    /// denominator for a fraction, along with some threshold value for the
    /// denominator.
    /// Your goal is to return the largest convergent of the continued
    /// fraction that matches the provided number, with the condition that the
    /// denominator of your convergent must be less than the threshold value.
    /// 
    /// Using the example from the lecture section, if you are given the
    /// number 341 / 512 with a threshold of 21, the most accurate convergent
    /// that respects this threshold is 2 / 3, so that's what you would return.
    /// 
    /// # Input
    /// ## numerator
    /// The numerator of the original fraction
    /// 
    /// ## denominator
    /// The denominator of the original fraction
    /// 
    /// ## denominatorThreshold
    /// A threshold value for the denominator. The continued fraction
    /// convergent that you find must be less than this value. If it's higher,
    /// you must return the previous convergent.
    /// 
    /// # Output
    /// A tuple representing the convergent that you found. The first element
    /// should be the numerator, and the second should be the denominator.


    function Exercise3 (
        numerator : Int,
        denominator : Int,
        denominatorThreshold : Int
    ) : (Int, Int) {
        mutable a_i = 0;            // Coefficient
        mutable P_i = numerator;    // Numerator
        mutable Q_i = denominator;  // Denominator
        mutable r_i = 0;            // Remainder

        mutable n_i = 0;            // Convergent numerator
        mutable n_i1 = 1;           // Convergent numerator from previous iteration
        mutable n_i2 = 0;           // Convergent numerator from 2 iterations previous

        mutable d_i = 0;            // Convergent denominator
        mutable d_i1 = 0;           // Convergent denominator from previous iteration
        mutable d_i2 = 1;           // Convergent denominator from 2 iterations previous

        while true {
            set a_i = P_i / Q_i;
            set r_i = P_i % Q_i;
            set n_i = a_i * n_i1 + n_i2;
            set d_i = a_i * d_i1 + d_i2;

            if d_i > denominatorThreshold {
                return (n_i1, d_i1);
            }
            if r_i == 0 {
                return (n_i, d_i);
            }

            set P_i = Q_i;
            set Q_i = r_i;
            set n_i2 = n_i1;
            set n_i1 = n_i;
            set d_i2 = d_i1;
            set d_i1 = d_i;
        }
        return (-1, -1);
    }


    /// # Summary
    /// In this exercise, you are given two integers - a number that you want
    /// to find the factors of, and an arbitrary guess as to one of the
    /// factors of the number. This guess was already checked to see if it was
    /// a factor of the number, so you know that it *isn't* a factor. It is
    /// guaranteed to be co-prime with numberToFactor.
    /// 
    /// Your job is to find the period of the modular exponentation function
    /// using these two values as the arguments. That is, you must find the
    /// period of the equation y = guess^x mod numberToFactor.
    /// 
    /// # Input
    /// ## numberToFactor
    /// The number that the user wants to find the factors for
    /// 
    /// ## guess
    /// Some co-prime integer that is smaller than numberToFactor
    /// 
    /// # Output
    /// The period of y = guess^x mod numberToFactor.
    operation Exercise4 (numberToFactor : Int, guess : Int) : Int
    {
        // Note: you can't use while loops in operations in Q#.
        // You'll have to use a repeat loop if you want to run
        // something several times.

        // Hint: you can use the
        // Microsoft.Quantum.Math.GreatestCommonDivisorI()
        // function to calculate the GCD of two numbers.

        mutable periodFactor = 1;
        mutable remainder = 0;
        mutable numberOfZeroMeasurements = 0;

        repeat {
            let (specialState, numberOfStates) = Exercise2(numberToFactor, guess);

            if (specialState == 0) {
            } else {
                let (n, d) = Exercise3(specialState, numberOfStates, numberToFactor);
                
                set periodFactor = d * periodFactor / GreatestCommonDivisorI(d, periodFactor);
                
                set remainder = ExpModI(guess, periodFactor, numberToFactor);
            }
        }
        until (remainder == 1)
        fixup { }

        return periodFactor;
    }


    /// # Summary
    /// In this exercise, you are given a number to find the factors of,
    /// a guess of a factor (which is guaranteed to be co-prime), and the
    /// period of the modular exponentiation function that you found in
    /// Exercise 4.
    /// 
    /// Your goal is to use the period to find a factor of the number if
    /// possible.
    /// 
    /// # Input
    /// ## numberToFactor
    /// The number to find a factor of
    /// 
    /// ## guess
    /// A co-prime number that is *not* a factor
    /// 
    /// ## period
    /// The period of the function y = guess^x mod numberToFactor.
    /// 
    /// # Output
    /// - If you can find a factor, return that factor.
    /// - If the period is odd, return -1.
    /// - If the period doesn't work for factoring, return -2.
    function Exercise5 (
        numberToFactor : Int,
        guess : Int, period : Int
    ) : Int {
        if (period % 2 == 1) {
            // Odd number, we can't use it
            return -1;
        }
        
        let factorTermBase = ExpModI(guess, period / 2, numberToFactor);
        if (factorTermBase == 1 or factorTermBase == numberToFactor - 1) {
            // The factors are just be the number itself and 1
            return -2;
        }
        
        let b0 = GreatestCommonDivisorI(numberToFactor, factorTermBase + 1);
        let b1 = GreatestCommonDivisorI(numberToFactor, factorTermBase - 1);
        
        if 2 > b0 or b0 > numberToFactor {
            fail "${b0} is invalid for {numberToFactor}";
        }
        if 2 > b1 or b1 > numberToFactor {
            fail "${b1} is invalid for {numberToFactor}";
        }
        if b0 * b1 != numberToFactor {
            fail $"{b0} * {b1} != {numberToFactor}";
        }

        Message($"Found factors {b0} and {b1} of {numberToFactor}");
        return b0;
    }
}
