## 1.4 Teleportation

* [Q# exercise: Teleportation]()
* [Q# exercise: Another Teleportation Exercise]()

You have now learned all the tools you need to conduct teleportation! Not on yourself for now, but on
qubits. Like superdense coding, teleportation also utilizes the innate correlation between entangled pairs.
While superdense coding sends one qubit to transmit two classical bits of information, teleportation uses
two classical bits of information to pass along a qubit. When one qubit in the pair is manipulated, the
other qubit indefinitely far away can somehow "feel" this manipulation. Doing measurement on one qubit
tells us about the other qubit. Therefore, information can be transmitted. The word "teleportation"
indicates information about a qubit is instantaneously transferred from one place to another without
physically exchanging the qubit.

```
Here is the circuit diagram to construct a teleportation:
```

```
Figure 1.4.1 Circuit diagram of teleportation.
```
At the beginning of the circuit, Alice and Bob prepare an entangled pair of states |퐴퐴⟩ and |퐴퐴⟩ using the H
and CNOT gates. They are then separated. If Alice wishes to send let Bob know about her other state |퐴퐴′⟩,
she can use the state |퐴퐴⟩ in her possession. After a series of operations on both sides as defined by the
circuit, Bob obtains |퐴퐴′⟩.

Let's take it apart.

Say the pre-prepared Bell state after Alice and Bob entangle their qubits is |휙휙+⟩=|^00 ⟩+|^11 ⟩
√^2

. They

each take half of the pair with them and go separate ways. Alice has the first qubit and Bob has the second
qubit.

```
Figure 1.4.2 Alice and Bob entangle their states to each obtain a Bell state.
```
Alice then wishes to tell Bob about |퐴퐴′⟩ but she cannot physically give it to Bob. It is an unknown state and
can take the form 훼훼| 0 ⟩+훽훽| 1 ⟩ ,훼훼| 1 ⟩+훽훽| 0 ⟩, 훼훼| 0 ⟩−훽훽| 1 ⟩ or 훼훼| 1 ⟩−훽훽| 0 ⟩. What she can do is to entangle
her qubit in the Bell state with |퐴퐴′⟩. Say |퐴퐴′⟩=훼훼| 0 ⟩+훽훽| 1 ⟩ as an example, without loss of generality. First,
Alice applies a CNOT with control |퐴퐴′⟩ and her qubit in |휙휙+⟩. The input is |퐴퐴′⟩|휙휙+⟩ :

```
|퐴퐴′⟩|휙휙+⟩=훼훼| 0 ⟩+훽훽| 1 ⟩
| 00 ⟩+| 11 ⟩
√^2
```
```
=
1
√^2 (훼훼
```
#### | 000 ⟩+훼훼| 011 ⟩+훽훽|100⟩+훽훽|111⟩).

The CNOT gate is applied to the first two qubits with the first qubit being the control and the second qubit
being the target:

```
퐶퐶퐶퐶퐶퐶퐶퐶|퐴퐴′⟩|휙휙+⟩=^1
√^2
(훼훼| 000 ⟩+훼훼| 011 ⟩+훽훽|110⟩+훽훽|101⟩). eq. (12.1)
```
```
Figure 1.4.3 Alice applies CNOT using |퐴퐴′⟩ as control and her qubit in the Bell state as target.
```

Next, Alice applies a H gate to |퐴퐴′⟩. The first qubit in eq. (12.1) changes accordingly:

```
1
√ 2 �훼훼�
```
```
| 0 ⟩+| 1 ⟩
√ 2 �|00⟩+훼훼�
```
```
| 0 ⟩+| 1 ⟩
√ 2 �|11⟩+훽훽�
```
```
| 0 ⟩−| 1 ⟩
√ 2 �|10⟩+훽훽�
```
```
| 0 ⟩−| 1 ⟩
√ 2 �|01⟩�^
```
```
=
```
#### 1

#### 2

#### [훼훼(|0⟩+ |1⟩)|00⟩+훼훼(|0⟩+ |1⟩)|11⟩+훽훽(|0⟩−|1⟩)|10⟩+훽훽(|0⟩−|1⟩)|01⟩]

#### =

#### 1

#### 2

#### [훼훼(|000⟩+ | 100 ⟩)+훼훼(|011⟩+ | 111 ⟩)+훽훽(|010⟩−|110⟩)+훽훽(|001⟩−|101⟩)]

#### =

```
1
2 [|00⟩(훼훼|^0 ⟩+훽훽|^1 ⟩) + |^01 ⟩(훼훼|1⟩+훽훽|0⟩) + |^10 ⟩(훼훼|^0 ⟩−훽훽|^1 ⟩) + |^11 ⟩(훼훼|1⟩−훽훽|0⟩)]. eq (12.2)^
```
The last step is taking out the first qubits Alice has and rearranging the equation into a format easier to
use later. It looks complicated, but the math is very simple. Try to derive this yourself.

```
Figure 1.4.4 After Alice entangles her Bell state qubit and the state she wishes to communicate.
```
So far, all the information is contained in quantum states. Alice needs to tell Bob something about
the interactions she did to the Bell state so that Bob can reproduce |퐴퐴′⟩. Some classical information needs
to be shared. Alice does measurements on the two states in Figure 12.3. Remember she has the first two
qubits and Bob has the last qubit. With two qubits, the outcome of measurements would be |00⟩, |01⟩,
|10⟩ or |11⟩. If the first qubit is 0, the state in eq. (12.2) after measurement becomes

```
1
2 [|00⟩(훼훼|^0 ⟩+훽훽|^1 ⟩) + |^01 ⟩(훼훼|1⟩+훽훽|0⟩)].
```
If then another measurement is done on the second qubit and it is 0, the state becomes

```
1
2 [|00⟩(훼훼|^0 ⟩+훽훽|^1 ⟩)].
```

```
Figure 1.4.5 Measurements on the first and then the second qubits provide a list of possible results.
```
This also tells us that the third qubit is in state [훼훼| 0 ⟩+훽훽| 1 ⟩]. Similarly, we can write out the possible
states of the third qubit based on measurement results of the first three qubits:

```
First two qubits Third qubit Alice tells Bob to
00 [훼훼| 0 ⟩+훽훽| 1 ⟩] do nothing
01 [훼훼| 1 ⟩+훽훽| 0 ⟩] apply X
10 [훼훼| 0 ⟩−훽훽| 1 ⟩] apply Z
11 [훼훼| 1 ⟩−훽훽| 0 ⟩] apply X and Z
```
Remember Bob has the third qubit and [훼훼| 0 ⟩+훽훽| 1 ⟩] is the state, |퐴퐴′⟩ , Alice wanted Bob to get. Alice can
call Bob and tell him her result is '00', and that Bod needs to do nothing. He already has |퐴퐴′⟩. If Alice
measures '01', she can tell Bob that. Bob applies a X gate to [훼훼| 1 ⟩+훽훽| 0 ⟩], thus obtaining |퐴퐴′⟩. If Alice
measures '10', Bob applies Z. If she measures '11', Bob applies X and Z. In other words, if the first qubit is
1, Bob applies Z to his state; if the second qubit is 1, he applies X to his state. Therefore, the complete
circuit diagram is constructed as shown in Figure 12. Teleportation of |퐴퐴′⟩ is achieved via communication
of two bits of classical information.


A common mistake people make when talking about entanglement is the misconception that
there were instantaneous interactions between entangled states.


Alice and Bob know the state of one another's qubits, even without having to send a classical
signal between themselves. Have they communicated any information? Could this process be used to
violate the law that information can never travel faster than the speed of light? The answer to both
questions is "no". When Alice measures her qubit in step 2, she randomly observes |0⟩ or |1⟩. Although
she instantly knows the state of Bob's qubit, there is no way to use this knowledge to communicate a
message to Bob. If Alice were somehow able to force nature to pick the state |0⟩|0⟩ or |1⟩|1⟩, then she
could use this power to transmit a |0⟩ or |1⟩ to Bob. Bob could then look at his qubit and know which state
Alice wanted to communicate to him. But Alice does not have this power – nature randomly chooses
|0⟩|0⟩ or |1⟩|1⟩. Alice and Bob get the same random state, but they cannot use this to send a signal.


That's not to say that knowing which random state the other person observed isn't useful. It can
be very useful! Alice and Bob can use this procedure to generate a shared random encryption key. Alice
can use the key to encrypt a message, which she can send to Bob over a classical channel. Bob can use the
key to decrypt the message. They can't communicate faster than light, but at least they can communicate
securely.

### Q# exercise: Teleportation

1. Go to QuantumComputingViaQSharpSolution introduced in session 1.1.
2. Open 20 _Demo Teleportation Operation.qs in Visual Studio (Code).
3. Lines 29-33 is setting up a sourceQubit, |퐴퐴′⟩ , to be an arbitrary state. It has a 25% probability of
    being |0⟩. Use Rx to make the qubit have the right angle on the Bloch sphere. You can change this
    probability, hence the angle on the Bloch sphere, to anything you want later.
4. The lines that follow next are straightforward. The logics is a step-by-step code representation of
    Figures 12.0. – 12.4.
5. Run the script. The result "countZero" should be close to 250 and "countOne" close to 750,
    indicating the 25% probability of being |0⟩. This is what we set |퐴퐴′⟩ to be at the beginning.
6. Change to a different state and test the teleportation algorithm again.
7. Go to the Quantum Katas: https://github.com/Microsoft/QuantumKatas.
8. In Visual Studio (Code) open folder "Teleportation" and Task.qs. Or use the Jupyter Notebook
    version as in the previous exercise. This exercise sets up the Teleportation circuit step by step.
    Tasks 1.1-1.6 set up the operations. Later tasks are variations of the Teleportation setup.


### Q# exercise: Another Teleportation Exercise

The Quantum Development Kit (QDK) has a sample test using Teleportation as the "Hello World" for Q#.

1. Clone and open the Teleportation exercise

git clone https://github.com/Microsoft/Quantum.git

cd Quantum

cd Samples/src/Teleportation/

2. "Here" and "there" represent the two initial states. "msg" is the message qubit to be teleported.
3. Lines 92-120 sets up the circuit so that
    /// If `true`, the source qubit (`here`) is prepared in the
    /// |1〉 state, otherwise the source qubit is prepared in |0〉.
    ///
4. Command "dotnet run" gives results
    Round 0: Sent True, got True.
    Teleportation successful!!
    Round 1: Sent False, got False.
    Teleportation successful!!
    ...
    Round 6: Sent True, got True.
    Teleportation successful!!
    Round 7: Sent False, got False.
    Teleportation successful!!

This setup only gives a "True" or "False" binary output. The TeleportationSample.qs in the
QuantumComputingViaQSharpSolution exercise, however, allows us to use any message qubit.


**Go to Quirk**

Open Quantum Teleportation example. Watch how the Bloch spheres reflect the input and output
qubits. The qubit retrieved matches exactly the message qubit.
