**Phase 2 Quantum Algorithms**

**Pavan Kumar, Kitty Yeung**

In phase 1, we learned about the components of quantum computing – qubits, gates and
measurements, which can be put together to form algorithms. An algorithm takes in information from
qubit inputs, conducts a manipulation on the qubits, and then outputs desired results. We will be learning
about a few algorithms that were developed as foundations to quantum computing logics in a historical
order: Deutsch's algorithm, Deutsch-Jozsa algorithm, Grover's algorithm, Simon's algorithm and Shor's
algorithm. These algorithms solve certain problems more efficiently than classical algorithms. (There are
many other quantum algorithms. For the interested and curious readers, take a look at
[http://quantumalgorithmzoo.org/](http://quantumalgorithmzoo.org/) ) Before going deeper into the algorithms, we need to start with a
concept called "Quantum Oracle" which is an operation that is used as an input to another algorithm. In
each session, we will practice our understanding with a Q# exercise.

## 2.1 Quantum Oracles PHASE 2 Quantum Algorithms

* [Q# exercise: Oracles]()

An oracle can be thought of as a black box that takes some inputs and gives some outputs. It can be
represented using a circuit diagram below.

```
Figure 2.1.1 A generic oracle represented by a circuit diagram.
```
As an example, this diagram can be an oracle that takes a three-bit integer and returns the reminder when
it is divided by 4 with these possible outputs:

```
풙풙 풚풚=풇풇(풙풙)=풙풙 % ퟒퟒ
0 0
1 1
2 2
3 3
4 0
5 1
6 2
7 3
```
```
Table 2.1.1 Input and output table for a particular oracle as an example.
```

We could build such a circuit using classical computing gates. But there are quantum algorithms
proven to be more efficient than classical ones. We need a quantum oracle that can do the above function
to build quantum algorithms, with a limitation that all the quantum gates need to be unitary (session 1.2).

Let's say that the initial number is encoded in a 3-qubit quantum state, 푥푥. And the function 푓푓(푥푥)
is implemented as a unitary quantum gate 퐴퐴 so that

```
푦푦=푓푓(푥푥)=퐴퐴푥푥.
```
Since 퐴퐴 is unitary, 퐴퐴−1 exists and it should be the same as 퐴퐴†. This implies

```
퐴퐴†(푦푦)=퐴퐴−1(푦푦)= 퐴퐴−1(퐴퐴푥푥)=푥푥.
```
This means that given any output, applying 퐴퐴† should revert to the corresponding input. However, as seen
in Table 2.1, both 푓푓( 3 ) and 푓푓( 7 ) equal to 3. Applying a unitary gate 퐴퐴† on 푓푓( 3 ) and 푓푓( 7 ) would not
return distinguishable results. Our assumption that such a matrix 퐴퐴 can exist is wrong. This is a common
problem for designing quantum oracles. Yet, there is a work-around if we use some extra qubits.

For the same function, consider the following quantum circuit:

```
Figure 2.1.2 Quantum Oracle.
```
Inputs 푥푥 and 푦푦 can contain multiple numbers of qubits. As one can see, this circuit leaves the input 푥푥 intact,
but it does an XOR on 푦푦 with 푓푓(푥푥) (in this example 푓푓(푥푥)=푥푥 % 4). Here we are assuming that 푥푥 and 푦푦 are
encoded using three qubits each. The size of the input state will therefore be 64 (2^6 ). The dimension of
the unitary matrix 푈푈 will be 64 x 64. Don't worry about the exact contents of 푈푈 right now. We are
assuming that such a unitary matrix exists and test if we arrive at any contradictions.

Let's evaluate this circuit for 푥푥= 3 = | 011 ⟩, with 푦푦 initialized to 0 = | 000 ⟩ and refer to Table 2.1
for results of 푓푓(푥푥):

```
푈푈(| 011⟩,| 000 ⟩)= (| 011 ⟩, | 000⟩ ⨁ 푓푓(| 011⟩) = (| 011 ⟩, | 000⟩ ⨁| 011 ⟩)= (| 011 ⟩,| 011 ⟩),
```
It has the following circuit representation:


Since we have initialized 푦푦 to 0, the output we need will be in the bottom 3 qubits (because 푦푦 ⨁ 푓푓(푥푥)=
푓푓(푥푥), if y = 0). Take the outputs of the above circuit and apply the same circuit again on them:

```
푈푈(| 011⟩,| 011 ⟩)= (| 011 ⟩, | 011⟩ ⨁ 푓푓(| 011⟩) = (| 011 ⟩, | 011⟩ ⨁| 011 ⟩)= (| 011 ⟩,| 000 ⟩).
```
It has a circuit representation:

This demonstrates that applying the same gate 푈푈 on the outputs of the first circuit recovers the original
inputs.

```
Now, let's evaluate the quantum oracle for 푥푥= 7 = | 111 ⟩, with 푦푦 initialized to 0 = | 000 ⟩ :
```
```
푈푈(| 111⟩,| 000 ⟩)= (| 111 ⟩, | 000⟩ ⨁ 푓푓(| 111⟩) = (| 111 ⟩, | 000⟩ ⨁| 011 ⟩)= (| 111 ⟩,| 011 ⟩).
```
It has the following circuit representation:

Take the output of the circuit and apply the same circuit again,

```
푈푈(| 111⟩,| 011 ⟩)= (| 111 ⟩, | 011⟩ ⨁ 푓푓(| 111⟩) = (| 111 ⟩, | 011⟩ ⨁| 011 ⟩)= (| 111 ⟩,| 000 ⟩),
```
with this circuit representation:

The original inputs are again recovered. And we can distinguish input results between 푓푓( 3 ) and 푓푓( 7 ).

```
In fact, the circuit is designed in such a way that 푈푈 is not only unitary but also its own inverse.
```
```
푈푈=푈푈−1.
```
Applying the circuit back to back:

```
푈푈(푈푈(|푥푥⟩,|푦푦⟩)) =푈푈(|푥푥⟩, |푦푦 ⨁푓푓(푥푥)⟩)
```
```
= (|푥푥⟩,��푦푦 ⨁푓푓(푥푥)�⨁푓푓(푥푥)��
```
```
= (|푥푥⟩, |푦푦 ⨁(푓푓(푥푥)⨁푓푓(푥푥))
```
```
= (|푥푥⟩, |푦푦 ⨁ 0 ⟩) = (|푥푥⟩, |푦푦⟩).
```

This proof is self-consistent. We can now create quantum oracles that are implemented using unitary
gates that are self-inverse. We will be using these quantum oracles in many algorithms like Deutsch,
Deutsch-Jozsa, Grover's algorithms, etc.

### Q# exercise: Oracles

1. Go to the Quantum Katas: https://github.com/Microsoft/QuantumKatas.
2. In Visual Studio (Code) open folder "DeutschJoszaAlgorithm" and Task.qs. Or use the Jupyter
    Notebook. Part 1 tasks focus on familiarize ourselves with oracles.
