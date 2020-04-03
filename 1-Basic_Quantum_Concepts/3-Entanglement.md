## 1.3 Entanglement

* [Bell states]()
* [Entanglement]()
* [Creating a Bell state]()
* [Q# exercise: Bell States]()
* [Greenberger – Horne – Zeilinger]()
    * [Q# exercise: GHZ]()
* [Superdense coding]()
    * [Q# exercise: Superdense Coding]()
    * [Quirk]()

### Bell states

In a two-qubit state, there are a set of special states called the Bell states, named after John S. Bell. Bell
states are formed with a pair of qubits as follows

|휑휑±�=|^01 ⟩±|^10 ⟩
√^2
and |휙휙±�=|^00 ⟩±|^11 ⟩
√^2
These four states each is a superposition of two basis states with equal probability. Within a Bell
state, the first qubits between the two basis states are different and the second qubits between the two
basis states are also different. For example, in |휑휑+⟩ the first qubit in |01⟩ is 0 but the first qubit in |10⟩ is 1. The second qubits in them also differ. Check the other three Bell states as an exercise. This gives the
Bell states a special property.

Take |휙휙+⟩ as an example, upon measuring the first qubit, one obtains two possible results:

1. First qubit is 0, get a state |휙휙′⟩= | 00 ⟩ with probability ½.
2. First qubit is 1, get a state |휙휙′′⟩= | 11 ⟩ with probability ½.

If the second qubit is measured, the result is the same as the above. This means that measuring one qubit
tells us what the other qubit is. The measurement outcomes are correlated. There is a correlation between
results of measurements on the first and the second qubits. These qubits are said to be entangled.
Entanglement is powerful because by knowing information on one qubit, one gains knowledge about
other qubits.


```
Math insert – entangled states cannot be factored back to individual qubits --------------
```
```
Remember in section 1.1, a two-qubit state can be obtained by doing a tensor product
of two individual one-qubit states. However, a Bell state cannot be factored back into
two individual qubits. For example,
```
#### |휙휙±�=|^00 ⟩±|^11 ⟩

```
√^2
```
#### =

#### ⎝

#### ⎜

#### ⎛

```
1
√ 2
0
0
1
√^2 ⎠
```
#### ⎟

#### ⎞

```
If we want to factor it back to two separate qubits as in �
```
#### 푎푎

#### 푏푏�⊗�

#### 푓푓

```
푑푑� , then this set of
equations need to be simultaneously satisfied
```
#### 푎푎푓푓=

```
1
√^2 ,^ 푎푎푑푑= 0,푏푏푓푓= 0^ and^ 푏푏푑푑=
```
```
1
√^2. Unfortunately, it is impossible. This set of
equations has no solution. It can only be 50% chance of getting |00⟩= �^1
0
```
#### �⊗�^1

#### 0

```
� or
```
```
|11⟩=�^0
1
```
#### �⊗�^0

#### 1

#### �.

### Creating a Bell state

Now that we know Bell states are made of entangled qubits, we will show them being used in almost if
not all of the applications and algorithms later. Before doing so, how do we practically create a Bell state?
It turns out that all we need is a CNOT gate and a H gate, which we learned in previous sessions.

```
Figure 1.3.1 Circuit to create a Bell state.
```
The |푥푥⟩ and |푦푦⟩ states can either be |0⟩ or |1⟩. Take |푥푥푦푦⟩= | 10 ⟩ as an example. The H gate first

puts |1⟩ into a superposition state |−⟩=√^12 (|0⟩−|1⟩). Then CNOT flips the target qubit |0⟩ based on the


control qubit |−⟩, giving √^12 (| 00⟩−|11⟩), which is one of the Bell states. Readers should practice proving

with |푥푥푦푦⟩= | 00 ⟩, |01⟩ and |11⟩. In summary, the output

```
|훽훽푥푥,푦푦�=|^0 ,푦푦⟩+(−1)
```
```
푥푥| 1 ,푦푦⟩
√ 2 ,
```
where 푦푦 means the negation of 푦푦.

The process is reversible. If one has a Bell state, by applying a CNOT followed by an H operation,
one obtains the original values for 푥푥 and 푦푦.

```
Figure 1.3.2 Inputs of an entangled two-qubit pair with their corresponding Bell-state outputs. The
process is reversible. Figure copied from Book by Nelson and Chaung, Quantum Computation and
Quantum Information – 10 th Anniversary Edition.
```
If one has a Bell states and wishes to know the starting states before entanglement, they can do
a CNOT gate on the pair followed by an H gate on the first qubit (reverting Figure 1.12.). Try this as an
exercise and check that you get the inputs and outputs in reverse to Figure 1.13.

### Q# exercise: Bell States

1. Go to QuantumComputingViaQSharpSolution introduced in session 1.1.
2. Open 19 _Demo Entanglement Operation.qs in Visual Studio (Code) and run dotnet run.
3. MultiM(qubits);
    measures multiple qubits.
4. Try running the script multiple times, you will find that the output can only be 0-0 or 1-1. The
    number of times for either result is random. But the result can never be 0-1 or 1-0 because the
    starting state qubit[0] is |0⟩.
5. Try changing the control and target qubits and observe the corresponding results.
6. Go to the Superposition exercise in Quantum Katas Jupyter Notebook. Tasks 1-5 practice concepts
    learned in previous chapters with a focus on Superposition. For Bell states specific exercises, go
    to Task 6 and 7. By firstly creating a Bell state from |00⟩, the other Bell states can be created by
    applying a Z or X gate.


### Greenberger – Horne – Zeilinger

The Bell states is a set of states made of two entangled qubits. Similar principles can apply to more qubits.
These are called Greenberger – Horne – Zeilinger (GHZ) states. The simplest has three qubits:

```
|퐺퐺퐻퐻푍푍⟩푠푠 푠푠푠푠푠푠푖푖푚푚푠푠 푡푡=
| 000 ⟩+| 111 ⟩
√^2.
```
It can be generalized into N qubits:

|퐺퐺퐻퐻푍푍⟩푔푔 푠푠푠푠푔푔푠푠푔푔푎푎 =|^0
⟩⊗N+| 1 ⟩⊗N
√ 2.
Imagine there are N entangled qubits. Because they are correlated, by measuring one qubit, we
know the result of another qubit. If N = 500, there are 2^500 possible states in the system - more than the
number of atoms in the universe. Imagine all that number of atoms in the universe entangled with each
other. The outcomes of all the interactions between the entangled atoms are results of the universe's
calculations. This is the power of nature that quantum computing utilizes.

### Q# exercise: GHZ

1. Go to the Quantum Katas: https://github.com/Microsoft/QuantumKatas introduced in session 1.2.
2. In Visual Studio (Code) open folder "Superposition". The GHZ exercise is in Tasks.qs. Or use the
    Jupyter Notebook version as in the previous exercise.
3. Complete Task 8. **Hint** : the method is like creating a Bell state. Here, instead of having only two
    qubits, in GHZ there are N qubits. The first qubit is the control qubit.
4. Can you draw a circuit diagram representing the creation of a GHZ state? Use Figure 1.12. as a
    reference.
5. Try other tasks and see how many you can pass.

### Superdense coding

One of the applications of Bell states is superdense coding. It is a method to transmit two classical bits of
information using only one qubit.


```
To start with, two people, Alice and Bob, each possess a qubit. These two qubits have been already
```
prepared to be entangled. Together they form one of the four Bell states, e.g. |휙휙+⟩=
| 00 ⟩+| 11 ⟩
√^2. One of the
qubits is sent to Alice and the other is sent to Bob. They can be separated far apart. Now, if Alice wants to
send a '00' classical two-bit string to Bob, she does nothing to her qubit but sends the qubit to Bob. Bob
has now two qubits and needs to decode what classical information Alice intended. He performs a CNOT
operation on the part followed by an H gate on the qubit Alice sent him. The entangled state becomes
|00⟩, according to Figure 1. 14. And Bob understands that it is '00' Alice intended. While classically Alice
would have sent two bits, she only needed to send one qubit.

```
If Alice wishes to send '01', she applies an X gate to her qubit so the first qubit flips. The entangled
```
state becomes |휑휑+⟩=|^01 ⟩√+ 2 |^10 ⟩. To send '10', she applies a Z gate to do a phase flip, giving |휙휙−⟩=
| 00 ⟩−| 11 ⟩
√^2. For '11', she uses an 푓푓Y gate or a Z * X gate to make |휑휑

#### −⟩=|^01 ⟩−|^10 ⟩

√^2. Try obtaining these results
as an exercise.


```
Figure 1.3.3. Superdense coding circuit. Image copied from Wikipedia.
```
### Q# exercise: Superdense Coding

1. Go to the Quantum Katas: https://github.com/Microsoft/QuantumKatas.
6. In Visual Studio (Code) open folder "SuperdenseCoding" and Task.qs. Or use the Jupyter Notebook
    version as in the previous exercise.
2. Input code that correspond to the stages in Figure 1.14: prepare entangled Bell states; apply
    appropriate gate on Alice's qubit, corresponding the classical message; decode by reversing the
    entanglement with Bob's qubit.
3. The last step is to use the above operations as "functions" to do a superdense coding in one go.

### Introducing Quirk

Now that we've seen a few circuit representations and gates, we can construct some algorithms using a
circuit diagram. Go to the open-source project Quirk. It's a neat tool that shows what's going on with each
qubit as we construct circuits. There is a tutorial video inside "Menu". You can also click on any of the
example circuits. Here we'll look at the topic we just learned - Superdense Coding.


The circuit in Figure 1.14 is constructed using the Quirk tools. A Bell pair is prepared with the third and
the last lines representing |0⟩ states. The third line belongs to Alice until after she applies X and/or Z gates
based on the classical information and sends it. It becomes the sixth line. Bob uses the sixth line and the
last line to decode with CNOT and H gates. Measuring the two qubits after decoding, he obtains the two
classical bits of information Alice intended. The fourth and fifth lines are not used. On/Off indicates 1/0.
The Bloch spheres' down/up represents |1⟩/|0⟩.