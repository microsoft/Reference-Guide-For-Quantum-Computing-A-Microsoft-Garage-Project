## 1.2 Gates

* [Unitary matrix]()
* [The Control-NOT Gate (CNOT)]()
    * [Q# exercise: CNOT gate]()
* [Circuit Representation]()
* [Hadamard Gate]()
    * [Q# exercise: H gate]()
* [Bloch Sphere]()
* [Pauli Gates]()
    * [Q# exercise: Pauli gates]()
* [Measurement]()
    * [Q# exercise: Measurement using M operation]()
* [Interference]()

### Unitary matrix

Since qubit states are represented with vectors, the way to manipulate them is through matrix
multiplications, which transforms a vector into a different vector. Such matrix operations applied onto the
states are called "gates". In quantum mechanics, matrices representing gates are required to be unitary
(see _Math insert - unitary, adjoint or Hermitian conjugate_ ). This is to ensure normalization condition, i.e.
probabilities add up to 1, mentioned in Section 1.1. Unitarity also constraints the operation to be
reversible. This is intuitive as one can find an operation that reverts the gate and returns a system back to
its original state.

```
Math insert – unitary, adjoint or Hermitian conjugate --------------------------------------------
```
```
A matrix 푈푈 is unitary if 푈푈⟊푈푈=퐼퐼, where 퐼퐼 is the identity matrix and the "⟊" symbol (reads
"dagger") means adjoint or Hermitian conjugate of matrix 푈푈. It can be further written as
푈푈⟊= (푈푈∗)푇푇= (푈푈푇푇)∗, where " T " denotes transpose and "*" complex conjugate:
```
#### �

#### 푈푈 1

#### 푈푈 2

#### ⋮

#### 푈푈푁푁

#### �

```
푇푇
```
```
= (푈푈 1 푈푈 2 ... 푈푈푁푁)
```
```
and if 푎푎= 푎푎 0 +푓푓푎푎 1 , then 푎푎∗= 푎푎 0 −푓푓푎푎 1 by definition. Therefore,
�푎푎 푏푏
푓푓 푑푑
```
#### �

```
⟊
=�푎푎
```
#### ∗ 푓푓∗

#### 푏푏∗ 푑푑∗

#### �.


Let's take a complex number 푓푓=푎푎+푓푓푏푏; its complex conjugate will be 푓푓∗=
푎푎− 푓푓푏푏. Multiplying them:
푓푓∗푓푓=푎푎^2 +푏푏^2 = |푓푓|^2.
Now, let's take a matrix 푥푥 as follows:

#### 푥푥= �

#### 푎푎 1 +푓푓푏푏 1

#### 푎푎 2 +푓푓푏푏 2

#### 푎푎 3 +푓푓푏푏 3

#### 푎푎 4 +푓푓푏푏 4

#### �.

The adjoint 푥푥† will be:
푥푥†=[푎푎 1 −푓푓푏푏 1 푎푎 2 −푓푓푏푏 2 푎푎 3 −푓푓푏푏 3 푎푎 4 −푓푓푏푏 4 ].
Multiplying them:

#### 푥푥†푥푥=[푎푎 1 −푓푓푏푏 1 푎푎 2 −푓푓푏푏 2 푎푎 3 −푓푓푏푏 3 푎푎 4 −푓푓푏푏 4 ]∗�

#### 푎푎 1 +푓푓푏푏 1

#### 푎푎 2 +푓푓푏푏 2

#### 푎푎 3 +푓푓푏푏 3

#### 푎푎 4 +푓푓푏푏 4

#### �.

#### 푥푥†푥푥=�푎푎 12 +푏푏 12 + 푎푎 22 +푏푏 22 + 푎푎 32 +푏푏 32 + 푎푎 42 +푏푏 42 �

If 푥푥 represents an amplitude matrix in a 2-qubit system, then from the concepts you
have learned from the previous sessions, we can conclude the following:
Pr (| 00 ⟩) = |푎푎 1 +푓푓푏푏 1 |^2 =푎푎 12 +푏푏 12
Pr (| 01 ⟩) = |푎푎 2 +푓푓푏푏 2 |^2 =푎푎 2
2
+푏푏 22
Pr (| 10 ⟩) = |푎푎 3 +푓푓푏푏 3 |^2 =푎푎 32 +푏푏 32
Pr (| 11 ⟩) = |푎푎 4 +푓푓푏푏 4 |^2 =푎푎 42 +푏푏 42
And 푥푥†푥푥=푆푆푓푓퐼퐼 푓푓푓푓 푝푝푟푟푓푓푏푏푎푎푏푏푓푓푝푝푓푓푓푓푓푓푅푅푝푝 푓푓푓푓 푎푎푝푝푝푝 푏푏푎푎푝푝푓푓푝푝 푝푝푓푓푎푎푓푓푅푅푝푝= 1.

Now, let's say we apply a gate whose matrix is 푈푈 on 푥푥 and the resultant state is
푦푦 as follows:
푦푦=푈푈푥푥
Applying conjugate transpose on both sides:
푦푦†= (푈푈푥푥)†
After multiplication:
푦푦†푦푦= (푈푈푥푥)†푈푈푥푥

```
푦푦†푦푦= 푥푥†푈푈†푈푈 푓푓푎푎푓푓푝푝푅푅푥푥 (푏푏푅푅 (퐴퐴퐴퐴)†
= 퐴퐴†퐴퐴†; 푓푓 푎푎푓푓 푦푦푓푓 푓푓 푅푅푎푎푝푝푓푓푝푝푓푓푦푦 푓푓푓푓푓푓푑푑 푓푓ℎ푅푅 푝푝푟푟푓푓푓푓푓푓 푓푓푓푓푟푟 푓푓ℎ푓푓푝푝 푓푓푓푓푝푝푓푓푓푓푅푅)
```
Now, if 푈푈 is unitary, then by definition 푈푈†=푈푈−1. It implies:
푦푦†푦푦= 푥푥†퐴퐴−1퐴퐴 푥푥,
푦푦†푦푦= 푥푥†퐼퐼 푥푥,
푦푦†푦푦= 푥푥†푥푥,
푦푦†푦푦= 1.
It implies that 푦푦 is also a valid quantum state. This is possible only because we assume
that 푈푈†=푈푈−1 (푈푈 is unitary). The bottom line here is that all the matrices (gates) we
use in quantum computing must be unitary.


### The Control-NOT Gate (CNOT)

Let's introduce a commonly used gate, CNOT. One may know that NOT gate in classical computing is an
operation that flips 0s and 1s. The CNOT gate acts on a two-qubit state. The two-qubit states is
represented by a four-element vector, with the first qubit represented by the first two elements of the
vector, and the second qubit by the last two elements. A CNOT gate flips the second qubit based on the
state of the first qubit. Thus, the first qubit is called the "control" qubit, while the second one is called the
"target" qubit. The CNOT gate takes the form of a 4 x 4 matrix

#### 퐶퐶퐶퐶퐶퐶퐶퐶=�

#### 1 0

#### 0 1

#### 0 0

#### 0 0

#### 0 0

#### 0 0

#### 0 1

#### 1 0

#### �.

One can see that the first quadrant is a 2 x 2 identity matrix. It keeps the control qubit intact after
multiplication. The fourth quadrant is the 2 x 2 NOT gate. It flips the target qubit from "0" to be "1" and
from "1" to be "0" if the control qubit is "1" but does nothing if the control qubit is "0". Here's an example
to examine this behavior.

#### 퐶퐶퐶퐶퐶퐶퐶퐶|10⟩=�

#### 1 0

#### 0 1

#### 0 0

#### 0 0

#### 0 0

#### 0 0

#### 0 1

#### 1 0

#### ��

#### 0

#### 0

#### 1

#### 0

#### �

#### =�

#### 0

#### 0

#### 0

#### 1

```
�= | 11 ⟩. eq. (2.1)
```
Similarly, 퐶퐶|00⟩= | 00 ⟩,퐶퐶|01⟩= | 01 ⟩ and 퐶퐶|11⟩= | 10 ⟩. Use _Math insert – matrix multiplication_ to show
these equations.

```
Math insert - matrix multiplication -------------------------------------------------------------------
```
```
Gates are N by N matrices that multiply to state with 2N vector elements. They follow
the rules such that
```
#### �푎푎 푏푏

#### 푓푓 푑푑

#### ��

#### 푥푥

#### 푦푦�=�

#### 푎푎푥푥+푏푏푦푦

#### 푓푓푥푥+푑푑푦푦� ,^

#### �

#### 푎푎 푏푏 푓푓

#### 푑푑 푅푅 푓푓

#### 푔푔 ℎ 푓푓

#### ��

#### 푥푥

#### 푦푦

#### 푧푧

#### �= �

#### 푎푎푥푥+푏푏푦푦+푓푓푧푧

#### 푑푑푥푥+푅푅푦푦+푓푓푧푧

#### 푔푔푥푥+ℎ푦푦+푓푓푧푧

#### � ′

```
and so on.
```

### Q# exercise: CNOT gate

```
Local:
```
1. Go to Quantum Katas: https://github.com/Microsoft/QuantumKatas Download or clone.
2. In Visual Studio (Code) open folder "BasicGates". The CNOT exercise is in Tasks.qs
3. Read about CNOT in Microsoft.Quantum.Primitive Reference Documentation
    **Link:** https://docs.microsoft.com/en-us/qsharp/api/qsharp/microsoft.quantum.primitive
4. The command for CNOT is
    operation CNOT (control : Qubit, target : Qubit) : ()
5. Don' t change anything and run dotnet test in the integrated terminal. This should automatically
    build the kata project and run all unit tests; initially, all unit tests should fail. You should get
6. Open Tasks.qs file. I n "Task 2.1. Two-qubit gate – 1" in the body, add the appropriate command
    inside the operation and run dotnet test again.
7. If your answer is correct, you should get
8. The Katas has many projects in this exercise. Feel free to try out the other ones. As you answer
    more questions correctly, the number of passed tests will increase accordingly.

```
Jupyter Notebook:
```
1. Go to https://github.com/microsoft/QuantumKatas/tree/master/BasicGates and follow link to
    Jupyter Notebook to the BasicGates exercise.
2. Run the package and jump to Task 2.1. It is the same exercise as above.


### Circuit Representation

Matrix calculations can sometimes get messy. To make quantum operations easier to follow, a graphic
representation below is used to illustrate quantum operations. Because the diagram looks like a circuit, it
is called a circuit representation. A qubit is denoted by a horizontal line:

```
Figure 1.2.1 Circuit representation of qubits.
```
The purpose of using horizontal lines is to provide a visualization of qubits' evolution over time. Individual
qubits are placed in parallel so that gates can connect them vertically in the diagram. What happens to
each qubit is apparent. For example, CNOT introduced above can be captured in the following circuit
diagram:

```
Figure 1.2.2 Circuit representation of CNOT gate.
```
Control qubit |퐴퐴⟩ is unchanged after CNOT but target qubit |퐴퐴⟩ becomes |퐴퐴⊕퐴퐴⟩ based on the control.

### Hadamard Gate

Another frequently used gate is the Hadamard gate, H. Its matrix form is written as

#### 퐻퐻=�

```
1
√ 2
```
```
1
√ 2
1
√^2 −
```
```
1
√^2
```
#### �.

The Hadamard gate puts states |0⟩ and |1⟩ into a superposition of the two with equal probability, i.e.


#### 퐻퐻|0⟩=�

```
1
√^2
```
```
1
√^2
1
√ 2 −
```
```
1
√ 2
```
#### ��^1

#### 0

#### �

#### =�

```
1
√^2
1
√ 2
```
#### �=√^12 �^1

#### 0

#### �+√^12 �^0

#### 1

#### �

#### =

```
1
√^2 (|0
⟩+ |1⟩)≡|+⟩ , eq. (2.2)
```
and

#### 퐻퐻|1⟩=�

```
1
√ 2
```
```
1
√ 2
1
√^2
```
#### −^1

```
√^2
```
#### ��^0

#### 1

#### �

#### =^1

```
√^2
(|0⟩−|1⟩)≡|−⟩. eq. (2.3)
```
The symbol "≡" here means "defined as" or "equivalent to". In other words, the Hadamard gate converts
classical states, i.e. |0⟩ and |1⟩, into quantum states |+⟩ and |−⟩. It also converts quantum states
quantum states |+⟩ and |−⟩ back to classical states |0⟩ and |1⟩. Readers should prove 퐻퐻|+⟩= |0⟩ and
퐻퐻|−⟩= |1⟩ as an exercise. The negative sign in the fourth element in the 퐻퐻 matrix highlighted in eq. (2.3)
has the significance. It makes the operation reversible. Without it, applying H to the states |+⟩ and |−⟩
would give indistinguishable results. The circuit representation of a Hadamard gate is

```
Figure 1.2.3 Circuit representation of the Hadamard gate.
```
It acts on a single qubit.

### Q# exercise: H gate

1. In Quantum Katas Basic Gate is designed to implement H gate. Try the exercise on Jupiter
    Notebook.
2. To further your familiarity, let's do another exercise in QuantumComputingViaQSharpSolution
    introduced in session 1.1.
3. Open 07_Demo H Operation.qs in Visual Studio (Code) and run dotnet run.
4. "M" here is a measurement operation. We will talk about it at the end of the session.
    M(qubits[0])
5. If the measured result is 0, it'll output "False"; if "1", it'll output "true". Run the script several
    times, you'll see the output changes randomly because H puts the qubit into a state with equal
    probability of getting "0" and "1".


6. Also run 07_Demo H count-mutable-set-for-ToStringI. Half of the time, you will measure the
    state to be in |0⟩ and half of the time in |1⟩.

### Bloch Sphere

There is yet another graphic representation to visualize a qubit. It gives more information about a qubit
than the circuit representation. It is called a Bloch sphere - a 3D sphere drawn in 2D with the North and
South poles representing states |0⟩ and |1⟩, respectively.

```
Figure 1.2.4 Bloch sphere with states |0⟩ and |1⟩ labelled by red dots.
```
A Hadamard gate applied to the state |0⟩ or |1⟩ moves the state to |+⟩ or |−⟩ which is a superposition

of |0⟩ and |1⟩ with the same amplitude
1
√^2. This means the state |+⟩ or |−⟩ is on the equator on the
Bloch sphere.

```
Figure 1.2.5 Bloch sphere with states |0⟩ and |1⟩ labelled by red dots and states |+⟩ and |−⟩ by blue
dots.
```

This is illustrating eq. (2.2 and 2.3) graphically on a Bloch sphere. It looks as if the states are rotated along
the sphere about the y-axis by 90 degrees. But it is actually not a one-step rotation. This will be explained
later in Pauli Gates.

In general, an arbitrary one-qubit state |휓휓⟩ can be represented by a point anywhere on a Bloch
sphere. |휓휓⟩ is on the sphere with angle 휙휙 away from the x-axis and angle θ away from the z-axis. Thus it

can be written as |휓휓⟩=cos휃휃 2 |0⟩+푅푅−푖푖푖푖sin휃휃 2 |1⟩, which is a superposition of states |0⟩ and |1⟩ with the

angles defining the amplitudes. This further makes it clear that the states |0⟩ and |1⟩ are just two special
cases with θ = 0° and 180°, respectively.

```
Figure 1.2.6 Bloch sphere with an arbitrary state |휓휓⟩ labelled by a red dot.
```
### Pauli Gates

Since a general one-qubit state can be represented on a Bloch sphere with relative angles to the axes,
what the gates do is to changes the angles, altering the position on the sphere that represents the state.
We introduce three special rotational gates below named after physicist Wolfgang Pauli.

```
Pauli X gate is the NOT gate that rotates the state about the x-axis by 180 degrees.
```
```
푋푋=�^01
1 0
```
#### �,

so that

```
푋푋�
```
#### 훼훼

#### 훽훽�=�

#### 훽훽

#### 훼훼

#### �.

It has the effect of swapping the coefficients, 훼훼 and 훽훽 (Figure 1.7). Thus, a |0⟩ state "flips" to a |1⟩ and a
|1⟩ state "flips" to a |0⟩.

Pauli Y gate is a rotation about the y-axis by 180°. Not only does it flip 0s and 1s, the complex
numbers 푓푓 and −푓푓 change the phase of the vector (Figure 1.7).

```
푌푌=�^0 −푓푓
푓푓 0
```
#### �,


so that

```
푌푌�
```
#### 훼훼

#### 훽훽�=푓푓�

#### −훽훽

#### 훼훼

#### �.

Pauli Z gate rotates about the z-axis by 180°. Without the minus sign in the fourth element, it
would be an identity matrix, but the minus sign provides a phase shift to |1⟩ (Figure 1.7).

```
푍푍=�^10
0 − 1
```
#### �,

so that

```
푍푍�
```
#### 훼훼

#### 훽훽�=�

#### 훼훼

#### −훽훽�.

```
Figure 1.2.7 Bloch sphere representation of the Pauli gate interactions. Graph copied from Microsoft
quantum computing.
```
```
In general, rotation gates, R, about an axis can be described by the angles 휙휙 and 휃휃 in Figure 1.6:
```
```
푅푅푧푧(휙휙)=�푅푅
```
푖푖푖푖/ (^20)
0 푅푅−푖푖푖푖/^2

#### � ,

#### 푅푅푦푦(휃휃)=�

```
cos휃휃 2 sin휃휃 2
−sin휃휃 2 cos휃휃 2
```
#### � ,

and

#### 푅푅푥푥(휃휃)=�

```
cos
```
#### 휃휃

#### 2

```
푓푓sin
```
#### 휃휃

#### 2

```
−푓푓sin
```
#### 휃휃

#### 2

```
cos
```
#### 휃휃

#### 2

#### �


#### =푅푅푧푧�

```
휋휋
2 �푅푅푦푦(휃휃)푅푅푧푧�−
```
```
휋휋
2 �.
```
In fact, any arbitrary single quantum logic gate can be decomposed into a series of rotation
matrices:

#### 푈푈=푅푅푖푖푖푖�푅푅

−푖푖푖푖/ (^20)
0 푅푅푖푖푖푖/^2

#### ��

```
cos
```
#### 휃휃

#### 2

```
−sin
```
#### 휃휃

#### 2

```
sin
```
#### 휃휃

#### 2

```
cos
```
#### 휃휃

#### 2

#### �

with the only constraint on the gate being unitary. Here, 푅푅푖푖푖푖 is a global phase shift that can be added
without affecting the behavior.

Now, if we revisit the Hadamard gate, it can be decomposed as a rotation about the x-axis by 180°
followed by a clockwise rotation about the y-axis by 90°. The negative sign in the Hadamard gate
determines the direction of rotation. |+⟩ and |−⟩ have opposite signs that put them on opposite sides of
the Bloch sphere.

```
Figure 1.2.8 Hadamard gate on Block sphere using |0⟩ as the initial state as an example. Graph copied
from Microsoft quantum computing.
```
```
The circuit representation of the Pauli gates and general rotation gates are
```
```
Figure 1.2.9 Circuit representation of the Pauli X, Y, Z and R gates. Pauli X gate is the same as a NOT
gate.
```

### Q# exercise: Pauli gates

1. Go to Quantum Katas: https://github.com/Microsoft/QuantumKatas introduced earlier in the
    CNOT excercise.
2. In Visual Studio (Code) open folder "BasicGates" and then Tasks.qs. Or go to Basic Gates in
    Quantum Katas Jupiter Notebook.
3. Try Task 1.1, 1.3, 1.4 and 1.6.
4. Read more about other gates:
    https://docs.microsoft.com/en-
    us/qsharp/api/prelude/microsoft.quantum.primitive?view=qsharp-preview

### Measurement – not a gate

Measurements are different from gates. Gates are unitary which makes operations reversible. Gates
acting upon a quantum system do not destroy the system or make connections between the system and
the outside world. Applying a gate does not lose information. However, when we in the outside world
want to obtain information from the system, we need to measure it. Measuring a system brings it into
contact with the outside world, irrevocably destroying information. Thus, measurement is, in general, not
reversible – the system cannot be brought back to its state before the measurement. One consequence
of this difference is that a measurement cannot be executed by a gate. It is an interaction between the
system and its environment. A parameter or physical variable measured from a quantum system is called
an "observable" (because we can observe it). Momentum, mass, velocity and energy are all observables.

```
Physics insert – measurement -----------------------------------------------------------------------------
--------
```

```
If we use the wavefunction approach (session 1.1), we can derive the value we
would expect to measure for a large number of measurements of a given observable,
푀푀. The expectation value can be obtained as
```
```
〈푀푀〉=〈휓휓|푀푀|휓휓〉=∑퐼퐼푗푗푗푗 |푓푓푗푗|^2 ,
```
```
for state |휓휓⟩=∑푗푗푓푓푗푗|휓휓푗푗� ,
```
```
where 퐼퐼푗푗 is each measurement result of 푀푀, and |푓푓푗푗|^2 =푃푃(퐼퐼푗푗) is the probability of
getting result 퐼퐼푗푗. Obtaining 퐼퐼푗푗 leaves the system in the state |휓휓푗푗�. This unavoidable
disturbance of the system caused by the measurement process is often described as a
"collapse," a "projection" or a "reduction" of the wavefunction.
```
In our qubit system, recall that with two qubits (eq. (1.7) ), a state is described by a superposition
of four basis states, i.e.

```
|휓휓⟩=푓푓 00 |00⟩+푓푓 01 |01⟩+푓푓 10 |10⟩+푓푓 11 |11⟩
```
with coefficients, 푓푓푖푖푗푗. Now, what happens if we do a measurement on the system – say, if we measure the

first qubit and find it to be 0? There are two possible states with the first qubit being 0. The probability of
getting a 0 in the first qubit is

```
푃푃= |푓푓 00 |^2 + |푓푓 01 |^2.
```
After such a measurement, there are only two possible states that can exist in the system. The state
becomes

```
|휓휓′⟩=
푐푐 00 | 00 ⟩+푐푐 01 | 01 ⟩
√푃푃. eq. (8)^
```
The denominator is there to keep the probability normalized (try the math yourself). A measurement
projects a state |휓휓⟩ into a basis state with a definite value of the observable (or "operator") being
measured.

```
Math insert – Hermitian operator -----------------------------------------------------------------------
---------
```
```
Recall that a gate is a unitary matrix, 푈푈, such that 푈푈⟊푈푈=퐼퐼 or 푈푈⟊=푈푈−1. A
measurement is not a unitary matrix. An observable corresponds to a Hermitian matrix,
푀푀, such that 푀푀⟊=푀푀. (Technically, the basis states that have a definite value of the
observable 푀푀 are the "eigenstates" of 푀푀, and the observed values of the operator are
the "eigenvalues.") Operating with the matrix M on an eigenstate yields a number 퐼퐼
times the eigenstate:
푀푀|휓휓⟩=퐼퐼|휓휓⟩.
```

```
This number, 퐼퐼, is the value of the observable 푀푀 that one would measure if the
system were in state |휓휓⟩.
The operator corresponding to an observable is required to be Hermitian,
because measurement results or observables need to be real numbers. Here's the proof
that the measurement operator must be Hermitian:
〈푀푀〉=〈휓휓|푀푀|휓휓〉
If 〈푀푀〉 is real, then 〈푀푀〉⟊=〈푀푀〉. Therefore,
〈푀푀〉⟊=〈휓휓|푀푀⟊|휓휓〉=〈휓휓|푀푀|휓휓〉.
This must hold for any state |휓휓⟩. Thus, 푀푀⟊=푀푀.
```
### Q# exercise: Measurement using M operation

1. Go to Quantum Katas: https://github.com/Microsoft/QuantumKatas introduced earlier in the
    CNOT exercise.
2. In Visual Studio (Code) open folder "Measurements" and then Tasks.qs. Or use the Measurements
    exercise in Quantum Katas Jupyter Notebook.
3. Look at Task 1.1. It only needs an operation M(q) to measure the state of the qubit q.
4. Now use M(q) to finish as many tasks as you can. These tasks need other gates you learned in this
    session to put the qubits into the states you can measure. Tasks 1.1-1.4 all follow the same process.
    Tasks 1.4. is also an interesting exercise as one can use the Bloch Sphere to visualize where the
    arbitrary state is relative to the |0⟩ state. Then use the rotation gate to move it back to the |0⟩
    basis. The later tasks require additional concepts that we have not covered. You can skip them or
    read further on your own.


### Interference

In the end of session 1.1, we introduced a generalized probability theory. The key is that probability is
equal to the _square of magnitude of amplitude_ , so the square of amplitude must be a positive number
between 0 and 1. Here, we're going to look at the idea of interference between different possibilities,
which is something that is typical of quantum mechanics, but not of classical probability theory.
Interference occurs because we use amplitudes, rather than probabilities, and amplitudes can be negative
or complex. Let's use a metaphorical example to illustrate this abstract idea.

Say Bob is someone who may like sports and/or computer games. He has a 70% chance of liking
sports (푆푆) and a 30% chance of not liking sports (푆푆̅). If he likes sports, there is an 80% chance that he likes
computer games (퐶퐶) and a 20% chance that he does not like computer games (퐶퐶̅). If he does not like sports,
there is a 10% chance he likes computer games, and a 90% chance that he doesn't. This situation is
depicted as a tree on the left of Figure 1.9.

What is the chance that Bob likes computer games? We can compute this by aid of the probability
tree. There are two paths we can go down the tree to end up at 퐶퐶: 푆푆→퐶퐶 and 푆푆̅→퐶퐶. We can multiply the
branching probabilities down each path, and then add the paths together. In this case, the probability of
퐶퐶 is given by

```
푃푃(퐶퐶)= 0.7 × 0.8 + 0.3 × 0.1 = 0. 59 , or 59%.
```
But what if Bob were a quantum system? In that case, we would work with amplitudes. The tree
on the right of Figure 1.9 shows one possible set of amplitudes, which give the same branching possibilities.
Instead of calculating the probability of Bob liking computer games, we'll first calculate the amplitude. If
we switch the word "probability" to "amplitude" in the above calculation, then everything is the same.
Because in a quantum system, the amplitude could be a positive, negative or a complex number, let's
assign a negative amplitude to one of the branches in Figure 1.9 to prove our point next. We find all the
paths to get to 퐶퐶, and multiply the amplitudes along the path, and then sum the amplitudes of the paths:

푎푎푐푐=√0.7×√0.8−√0.3×√0.1.

To get the probability, we take the modulus squared of the amplitude:

```
푃푃(퐶퐶)=|푎푎푐푐|^2 ≈0.548, or 54.8%.
```
The second path actually subtracts from the first path, causing the overall probability to decrease. Very
strangely, the fact that there's a second way for Bob to like computer games _decreases_ the probability
that he likes them! This is because the amplitude of the second path has the opposite sign from the
amplitude for the first path. We call this "destructive interference." If the amplitudes had the same sign,
the second path would reinforce the first, and we would get "constructive interference." Interference is
fundamentally caused by the fact that amplitudes can be negative, or even complex, allowing them to
cancel one another out. Interference is at the heart of much of the "strangeness" of quantum mechanics.
Conceptually, however, it's rather simple, as we can see from the trees in Figure 1.9.


Figure 1.9. Probability trees in classical probability theory according to 1-norm (left) and in quantum
mechanics according to 2-norm (right). We begin at the top of the tree, and ask, "Does Bob like sports (푆푆)
or not like sports (푆푆̅)?" Then we get to the next bifurcation, and ask, "Does Bob like computer games (퐶퐶).
or not like computer games (퐶퐶̅).?" On the left, we show the probabilities for each option. On the right, we
show the amplitudes.

In quantum mechanics, why do we multiply the amplitudes, rather than the probabilities? Let's
check with an arbitrary qubit state, |휓휓⟩=푓푓 0 |0⟩+푓푓 1 |1⟩. It has amplitude 푓푓 0 of being in |0⟩ and 푓푓 1 of being
in|1⟩. If we then want to measure the presence of |+⟩ and |−⟩ in |휓휓⟩, what probably will be measured?
Knowing 푓푓푗푗=〈휙휙푗푗|휓휓〉 from _Physics insert – Superposition_ in session 1.1, we would do an overlap integral
〈+|휓휓〉 and 〈−|휓휓〉 to get the corresponding amplitudes and square them to get the probabilities.

```
푓푓±=〈±|휓휓〉
```
```
=푓푓 0 〈±|0〉+푓푓 1 〈±|1〉.
```
```
푃푃(|±⟩) =�푓푓±�
2
.
```
(± means + or −.) The square happens after the amplitudes add up. This turns out to be equivalent to
multiplying down a 2-norm probability tree in Figure 1.10, consistent with our metaphorical example for
Bob above. Quantum states are intrinsically described with amplitudes.


```
Figure 1.2. 10 Multiplying amplitudes down the 2-norm probability tress is equivalent to calculating the
overlap integrals.
```
The 2-norm in quantum mechanics can reduce to 1-norm in classical probability theory when
constructive interference (paths with amplitudes of the same complex phase) dominates and destructive
interference (paths with amplitudes of different complex phases) eliminate each other. This is explained
very nicely in Richard Feynman's lecture on quantum electrodynamics. We are more likely to get a
particular measurement if there are many paths to it that constructively interfere.

Interference can also be seen in a gate operation (unitary matrix). As Scott Aaronson showed in
his lecture (https://www.scottaaronson.com/democritus/lec9.html ), a randomizing matrix

#### �

```
1
√ 2 −
```
```
1
√ 2
1
√^2
```
```
1
√^2
```
#### �.

can give equal probability of getting |0⟩ and |1⟩. But if the starting point is |0⟩, applying the matrix twice
would give positive amplitudes to both |1⟩ states in either path, but a negative amplitude to one of the
|0⟩ states. Thus, states |1⟩ constructively interfere, contributing to the outcome, while the states |0⟩
destructively interfere and cancel each other out (Figure 1.11).

```
Figure 1.2. 11 The outcome of applying randomizing matrix to the states twice depends on the
interference between the paths.
```


