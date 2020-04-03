## 2.2 Deutsch's Algorithm

* [Q# exercise: Deutsch-Josza algorithm]()

This is one of the first algorithms to demonstrate the power of quantum computers. Developed by David
Deutsch in the mid 80s, it determines if a function 푓푓(푥푥) is _Balanced_ (푓푓(0)≠푓푓(1), which is 1-to-1) or
_Constant_ (푓푓( 0 )=푓푓( 1 ), which is 2-to-1). Although it has no known applications, it serves as a starting
point of future quantum algorithm developments.

As we mentioned that quantum oracles (black boxes) are used in algorithms, let's begin by looking
at four black boxes.

_Constant 0_ black box (this will always return 0, whatever might be the input):

_Constant 1_ black box (this will always return 1, whatever might be the input):

_Balanced Same_ black box (the output will be the same as the input):


_Balanced Reverse_ black box (the output will be the reverse of the input):

Out of these four black boxes (two _Constant_ and two _Balanced_ ), you are given one without being informed
which one it is. Your task is to identify whether it is a _Constant_ or a _Balanced_ one. This is what Deutsch's
algorithm solves. You don't have to find which specific _Constant_ or _Balanced_ black box is given to you.

To solve this problem classically, you need to apply the black box twice to tell with 100%
confidence whether it is a _Constant_ or a _Balanced_ one. Let's say you input a "0" to the black box. If it
returns "0", the black box would have been _Constant 0_ or _Balanced Same_. You need run the black box
again with input "1". If you get "0" as the output, then you can be sure that the black box is _Constant 0_ ;
whereas if you get 1, you can be sure that the black box is _Balanced Same_.

The same problem can be solved by just one execution of the black box using a quantum computer.
First, we need to construct black boxes that are compatible with quantum logic. From the previous
sections, we know that any quantum gate that implements a black box must be unitary (therefore
reversible). Let's consider the truth table for _Constant 0_ black box:

```
풙풙 Constant 0 : 풇풇(풙풙)=ퟎퟎ
0 0
1 0
```
It is apparent that it is impossible to construct any unitary matrix that takes "0" or "1" as input and gives
"0" as the output because it is not reversible. However, we can construct a quantum oracle using the
techniques discussed in the previous session:

Here 푥푥 and 푦푦 are each encoded with one qubit. Then the truth table for the above circuit for the _Constant_
0 black box becomes:


#### |푥푥⟩ |푦푦⟩ 푓푓(푥푥) |푦푦 ⨁푓푓(푥푥)⟩

#### | 0 ⟩ | 0 ⟩ 0 | 0 ⟩

#### | 0 ⟩ | 1 ⟩ 0 | 1 ⟩

#### | 1 ⟩ | 0 ⟩ 0 | 0 ⟩

#### | 1 ⟩ | 1 ⟩ 0 | 1 ⟩

|푦푦⟩ and |푦푦⨁푓푓(푥푥)⟩ are exactly the same (this happens to be the case only for _Constant 0_ scenario because
푓푓(푥푥)= 0 always). So, the final quantum oracle for _Constant 0_ looks like:

Now, let's construct the truth table for the _Constant_ 1 black box:

```
|푥푥⟩ |푦푦⟩ 푓푓(푥푥) |푦푦 ⨁푓푓(푥푥)⟩
| 0 ⟩ | 0 ⟩ 1 | 1 ⟩
| 0 ⟩ | 1 ⟩ 1 | 0 ⟩
| 1 ⟩ | 0 ⟩ 1 | 1 ⟩
| 1 ⟩ | 1 ⟩ 1 | 0 ⟩
```
In this case, |푦푦 ⨁푓푓(푥푥)⟩ is the reverse of |푦푦⟩. From the previous sessions of this book, you have learned
that this can be achieved by applying a Pauli X gate. So, we can construct the quantum oracle circuit as:

Next, the truth table for _Balanced Same_ black box:

```
|푥푥⟩ |푦푦⟩ 푓푓(푥푥) |푦푦 ⨁푓푓(푥푥)⟩
| 0 ⟩ | 0 ⟩ 0 | 0 ⟩
| 0 ⟩ | 1 ⟩ 0 | 1 ⟩
| 1 ⟩ | 0 ⟩ 1 | 1 ⟩
| 1 ⟩ | 1 ⟩ 1 | 0 ⟩
```
You can observe here that |푦푦 ⨁푓푓(푥푥)⟩ is matching with |푦푦⟩ when 푥푥= 0 and is opposite to |푦푦⟩ when 푥푥=
1. This can be achieved by simply putting a CNOT between 푥푥 and 푦푦. We can construct the quantum oracle:


For the _Balanced Reverse_ black box:

```
|푥푥⟩ |푦푦⟩ 푓푓(푥푥) |푦푦 ⨁푓푓(푥푥)⟩
| 0 ⟩ | 0 ⟩ 1 | 1 ⟩
| 0 ⟩ | 1 ⟩ 1 | 0 ⟩
| 1 ⟩ | 0 ⟩ 0 | 0 ⟩
| 1 ⟩ | 1 ⟩ 0 | 1 ⟩
```
This truth table is exactly the opposite to that of _Balanced Same._ So, we can use the same circuit we
created for _Balanced Same_ and add an X gate at the end:

Now that we have created all the four quantum black boxes, let's get into the actual Deutsch's
algorithm. Consider an unknown (one of the four) black box and we construct the following circuit:

```
Figure 2.1.3 Circuit representation of Deutsch's algorithm.
```
We prove in the insert below that by measuring just one qubit, we will know what kind of black box
( _Constant_ or _Balanced_ ) it is.

```
Math insert – Proof of Deutsch's algorithm for Constant black boxes--------------------------
```
```
The two-qubit system has an input |0⟩|0⟩. After applying X gate on the second qubit, the
system changes to |0⟩|1⟩. Applying H gates on both the qubits brings the state to
�
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �^
=�|√^02 ⟩��|√^02 ⟩�−�|√^02 ⟩��|√^12 ⟩�+�|√^12 ⟩��|√^02 ⟩�−�|√^12 ⟩��|√^12 ⟩�.
Applying the black box (applying |푥푥⟩|푦푦⟩=> |푥푥⟩|푦푦⨁푓푓(푥푥)⟩ on all the four parts
in the superposition):
```
```
�|0
⟩
√^2
��|0⨁푓푓(0)
⟩
√^2
�−�|0
⟩
√^2
��|1⨁푓푓(0)
⟩
√^2
�+�|1
⟩
√^2
��|0⨁푓푓(1)
⟩
√^2
�−�|1
⟩
√^2
��|1⨁푓푓(1)
⟩
√^2
```
#### �

#### =�

```
| 0 ⟩
√^2 ��
```
```
|푓푓( 0 )⟩
√^2 �−�
```
```
| 0 ⟩
√^2 ��
```
```
|1⨁푓푓( 0 )⟩
√^2 �+�
```
```
| 1 ⟩
√^2 ��
```
```
|푓푓( 1 )⟩
√^2 �−�
```
```
| 1 ⟩
√^2 ��
```
```
|1⨁푓푓( 1 )⟩
√^2 �^
(because 0 ⨁푓푓( 0 )=푓푓( 0 ) and 0 ⨁푓푓( 1 )=푓푓(1))
=�
| 0 ⟩
√^2 ��
```
```
|푓푓( 0 )⟩
√^2 �−�
```
```
| 0 ⟩
√^2 ��
```
```
|푓푓( 0 )�
√^2 �+�
```
```
| 1 ⟩
√^2 ��
```
```
|푓푓( 1 )⟩
√^2 �−�
```
```
| 1 ⟩
√^2 ��
```
```
|푓푓( 1 )�
√^2 � eq.(2.2.1)^
```

```
(because 1 ⨁푓푓( 0 )=푓푓(0) and 1 ⨁푓푓( 1 )=푓푓(1)).
```
```
Let's evaluate the above result if the black box is Constant 0 (푓푓.푅푅 푓푓( 0 )= 0 and
푓푓( 1 )= 0):
```
#### �|^0 ⟩

```
√^2
```
#### ��|^0 ⟩

```
√^2
```
#### �−�|^0 ⟩

```
√^2
```
#### ��|^0 �

```
√^2
```
#### �+�|^1 ⟩

```
√^2
```
#### ��|^0 ⟩

```
√^2
```
#### �−�|^1 ⟩

```
√^2
```
#### ��|^0 �

```
√^2
```
#### �

#### =�

```
| 0 ⟩
√^2 ��
```
```
| 0 ⟩
√^2 �−�
```
```
| 0 ⟩
√^2 ��
```
```
| 1 ⟩
√^2 �+�
```
```
| 1 ⟩
√^2 ��
```
```
| 0 ⟩
√^2 �−�
```
```
| 1 ⟩
√^2 ��
```
```
| 1 ⟩
√^2 �.
Refactoring above:
�
| 0 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �+�
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �^
=�
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �.
Now, apply H gate on the first qubit:
|0⟩⊗�
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �.
We prove that if the given black box is Constant 0, executing the above circuit and
measuring the first qubit will give 0. But we haven't proven the converse - if we get 0
after measuring the first qubit, does it mean that Constant 0 black box is used?
So, let's evaluate eq.(2.2.1) for Constant 1 (푓푓.푅푅 푓푓( 0 )= 1 and 푓푓( 1 )= 1):
�|^0
⟩
√ 2 ��
```
```
|푓푓( 0 )⟩
√ 2 �−�
```
```
| 0 ⟩
√ 2 ��
```
```
|푓푓( 0 )�
√ 2 �+�
```
```
| 1 ⟩
√ 2 ��
```
```
|푓푓( 1 )⟩
√ 2 �−�
```
```
| 1 ⟩
√ 2 ��
```
```
|푓푓( 1 )�
√ 2 �^
=�
| 0 ⟩
√ 2 ��
```
```
| 1 ⟩
√ 2 �−�
```
```
| 0 ⟩
√ 2 ��
```
```
| 1 �
√ 2 �+�
```
```
| 1 ⟩
√ 2 ��
```
```
| 1 ⟩
√ 2 �−�
```
```
| 1 ⟩
√ 2 ��
```
```
| 1 �
√ 2 �^
=�
| 0 ⟩
√ 2 ��
```
```
| 1 ⟩
√ 2 �−�
```
```
| 0 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 �+�
```
```
| 1 ⟩
√ 2 ��
```
```
| 1 ⟩
√ 2 �−�
```
```
| 1 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 �.^
After refactoring:
�
| 0 ⟩
√^2 �⊗�
```
```
| 1 ⟩
√^2 −
```
```
| 0 ⟩
√^2 �+�
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 1 ⟩
√^2 −
```
```
| 0 ⟩
√^2 �^
=�|√^02 ⟩+|√^12 ⟩�⊗�|√^12 ⟩−|√^02 ⟩�
=�
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 �⊗−�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �^
=−�|^0
⟩
√ 2 +
```
```
| 1 ⟩
√ 2 �⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �^
Applying H gate on the first qubit:
−|0⟩⊗�
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �.
Here, if we measure the first qubit, it is 100% certain that we will still get |0⟩, because
probability is the square of the amplitude (-1 in this case). So, we just proved that if the
given black box is Constant 1, executing the above circuit and measuring the first qubit
will give 0.
```
We proved that for both scenarios ( _Constant_ 0 and _Constant_ 1), we will always get |0⟩ at the end
of the circuit if we measure the first qubit. This is what Deutsch's algorithm does. We can achieve it by
just one execution of the black box (unlike classical black boxes for which two executions are needed). If
we get 0, that means we have a _Constant_ black box. This is possible because of the superposition principle
and gate execution on both states in parallel.


However, we cannot be sure which exact black box it is because for the first scenario the first
qubit is in |0⟩ state and in the second scenario the first qubit is in −|0⟩ state. It is impossible to distinguish
these amplitudes (1 or -1). This is the limitation of the algorithm.

Let's proceed with the remaining two black boxes.

```
Math insert – Proof of Deutsch's algorithm for Balanced black boxes--------------------------
```
```
For Balanced Same (푓푓.푅푅 푓푓( 0 )= 0 and 푓푓( 1 )= 1) black box, eq. (2.2.1) becomes
�
| 0 ⟩
√ 2 ��
```
```
|푓푓( 0 )⟩
√ 2 �−�
```
```
| 0 ⟩
√ 2 ��
```
```
|푓푓( 0 )�
√ 2 �+�
```
```
| 1 ⟩
√ 2 ��
```
```
|푓푓( 1 )⟩
√ 2 �−�
```
```
| 1 ⟩
√ 2 ��
```
```
|푓푓( 1 )�
√ 2 �^
=�
| 0 ⟩
√^2
��
| 0 ⟩
√^2
�−�
| 0 ⟩
√^2
��
| 0 �
√^2
�+�
| 1 ⟩
√^2
��
| 1 ⟩
√^2
�−�
| 1 ⟩
√^2
��
| 1 �
√^2
�
=�|0
⟩
√ 2 ��
```
```
|0⟩
√ 2 �−�
```
```
|0⟩
√ 2 ��
```
```
|1⟩
√ 2 �+�
```
```
|1⟩
√ 2 ��
```
```
|1⟩
√ 2 �−�
```
```
|1⟩
√ 2 ��
```
```
|0⟩
√ 2 �^
Refactoring:
�
| 0 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �+�
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 1 ⟩
√^2 −
```
```
| 0 ⟩
√^2 �^
=�
| 0 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �+�
```
```
| 1 ⟩
√^2 �⊗−�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �^
=�|^0
⟩
√ 2 �⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−�
```
```
| 1 ⟩
√ 2 �⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �^
=�
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �^
Applying H gate on the first qubit:
|1⟩⊗�|√^02 ⟩−|√^12 ⟩�.
We proved that if the given black box is Balanced Same , executing the above circuit and
measuring the first qubit will give 1.
For Balanced Reverse (푓푓.푅푅 푓푓( 0 )= 1 and 푓푓( 1 )= 0):
�
| 0 ⟩
√^2
��
|푓푓( 0 )⟩
√^2
�−�
| 0 ⟩
√^2
��
|푓푓( 0 )�
√^2
�+�
| 1 ⟩
√^2
��
|푓푓( 1 )⟩
√^2
�−�
| 1 ⟩
√^2
��
|푓푓( 1 )�
√^2
�
```
```
=�
| 0 ⟩
√ 2 ��
```
```
| 1 ⟩
√ 2 �−�
```
```
| 0 ⟩
√ 2 ��
```
```
| 1 �
√ 2 �+�
```
```
| 1 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 �−�
```
```
| 1 ⟩
√ 2 ��
```
```
| 0 �
√ 2 �^
=�
|0⟩
√ 2 ��
```
```
|1⟩
√ 2 �−�
```
```
|0⟩
√ 2 ��
```
```
|0⟩
√ 2 �+�
```
```
|1⟩
√ 2 ��
```
```
|0⟩
√ 2 �−�
```
```
|1⟩
√ 2 ��
```
```
|1⟩
√ 2 �^
Refactoring:
�|√^02 ⟩�⊗�|√^12 ⟩−|√^02 ⟩�+�|√^12 ⟩�⊗�|√^02 ⟩−|√^12 ⟩�
=�
| 0 ⟩
√^2 �⊗−�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �+�
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �^
=−�
| 0 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �+�
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �^
=�−|^0
⟩
√ 2 +
```
```
| 1 ⟩
√ 2 �⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �^
=−�
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �^
Applying H gate on the first qubit:
−|1⟩⊗�|√^02 ⟩−|√^12 ⟩�.
We proved that if the given black box is Balanced Reverse , executing the above circuit
and measuring the first qubit will always give 1.
```

This behavior is similar to the case of _Constant_ 0 and _Constant_ 1 black boxes - if the given black
box is either _Balanced Same_ or _Balanced Reverse_ , executing the circuit and the first qubit will always result
in |1⟩.

To sum it up, by executing this circuit only once, if the measured output of the first qubits is 0, we
can conclude that the given black box was either _Constant_ 0 or _Constant_ 1; and if the output is 1 then the
given black box was either _Balanced Same_ or _Balanced Reverse_. The limitation with this algorithm is that
it can tell if the given black box was _Constant_ or _Balanced_ but cannot tell the exact black box.

### Q# exercise: Deutsch's algorithm

1. Go to QuantumComputingViaQSharpSolution introduced in session 1.1.
2. Open 21_Demo Deutsch's Algorithm Operation.qs in Visual Studio (Code).
3. The black boxes are defined at the bottom of the script, starting from line 59, just as how we
    constructed the circuit diagrams.

```
operation BlackBoxConstant0(qubits:Qubit[]):()
{
body
{
```
#### }

#### }

```
operation BlackBoxConstant1(qubits:Qubit[]):()
{
body
{
X(qubits[1]);
}
}
```

```
operation BlackBoxBalancedSame(qubits:Qubit[]):()
{
body
{
CNOT (qubits[0],qubits[1]);
}
}
```
```
operation BlackBoxBalancedDifferent(qubits:Qubit[]):()
{
body
{
X(qubits[0]);
CNOT (qubits[0],qubits[1]);
}
}
```
4. Line 27-30 allows us to choose which black box to use. Select one of the black boxes by
    commenting out the other three. Do dotnet run to check the results.
    //Apply the blackbox
    //blackbox will set y = f(x) XOR y; which is same as
    CNOT(f(x),y)
    //BlackBoxConstant0(qubits);
    //BlackBoxConstant1(qubits);
    //BlackBoxBalancedSame(qubits);
    BlackBoxBalancedDifferent(qubits);
