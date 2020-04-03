## 2.4 Grover's Algorithm

* [Q# exercise: Grover's algorithm]()

Grover's algorithm is used to search for an item in an unordered list more efficiently than a classical
computer. It finds with high probability the unique input to a black box function that produces a particular
output value.

We have a black box that takes 3 bits as input and returns one bit as output. The black box is built
in such a way that it returns 1 only for one combination of inputs and returns 0 for all the other
combinations. Below is an example of one such black box that returns 1 only when the input bits are 110:

#### 풙풙 풚풚=풇풇(풙풙)

#### 000 0

#### 001 0

#### 010 0

#### 011 0

#### 100 0

#### 101 0

#### 110 1

#### 111 0


```
Table 2.4.1
```
For a 3-bit system, we can create eight different black boxes, each returning 1 for a different
combination of bits. If you were given one such a black box without being informed which one, how many
times do you need to run that black box (with different combinations of inputs) to find out which one was
given? On average, you will need to run four times. In the worst case, it will be seven. A classical black box
takes n-bits as input and returns 1 only for one of the possible 2 푔푔 inputs and returns 0 for all the remaining
inputs. We don't know for which combination it returns 1. In the worst case we might have to execute the
black box 2 푔푔 times. If we randomly choose the combination, and if we are lucky we may find it in the first
iteration itself; and if we are unlucky we may have to run it for all possible combinations ( 2 푔푔). On average
it might take about 2 푔푔/2 times. As the input size increases, the number of iterations increases by O( 2 푔푔).
Using Grover's algorithm, however, we can decrease this complexity to O(√ 2 푔푔).

Before proceeding with the actual algorithm, we need to establish black boxes that can be used
in a quantum computer. Since those black boxes need to be reversible, we use the logic similar to the
black boxes used in the Deutsch-Jozsa algorithm.

```
Figure. 2.4.1
```
As shown, Figure. 2.3.1 implements the quantum black box for the function in Table 2.3.1. If we initialize
y to 0, it will remain 0 at the end of the circuit for all the combinations of the inputs except for 110. When
the input is 110, the first X gate will change the inputs to 111 and the Controlled X gate (which flips the
last qubit only if all the first three qubits are 1s) flips y from 0 to 1. Later we revert the last input by applying
the X gate again to restore its original state to 110.

Similarly, we can implement the _Black Box 010_ as follows:

The output will be 1 only when input is 010.

Similarly, the _Black Box 111_ :


As one can see, the pattern here is to put X gates before and after the application of Controlled X for the
0 qubit.

Now that we know how to create the black boxes, let's proceed with the actual algorithm. We will
do a walkthrough of the algorithm with three qubits using a black box for 101.

**Step 1:**

Take a 3-qubit system in ground state:

```
|000⟩,
```
In vector form:

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 1 0 0 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ,

which has 2^3 elements. If we try to represent it graphically, we can plot:

**Step 2:**

Generate equal probability for all eight basis states by applying H gate on all the three qubits:

```
(퐻퐻⊗퐻퐻⊗퐻퐻)(|0⟩⊗|0⟩⊗|0⟩)
```

#### =�

#### |0⟩

#### √ 2

#### +

#### |1⟩

#### √ 2

#### �⊗�

#### |0⟩

#### √ 2

#### +

#### |1⟩

#### √ 2

#### �⊗�

#### |0⟩

#### √ 2

#### +

#### |1⟩

#### √ 2

#### �

#### =

#### 1

#### √^8

#### (| 000 ⟩ + | 001 ⟩ + | 010 ⟩ + | 011 ⟩ + | 100 ⟩ + | 101 ⟩ + | 110 ⟩ + | 111 ⟩)

#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8
1
√^8
1
√^8
1
√ 8
1
√^8
1
√^8
1
√ 8
1
√^8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

Graphically it can be plotted as (all the bars with equal height of √^18 ):

**Step 3:**

This step is to show you the effect of a black box. If we know the black box is 101, we highlight the state
that is represented by the black box (101 in the current example) by making its amplitude negative.

```
1
√^8
```
```
| 000⟩ +
```
```
1
√^8
```
```
| 001⟩ +
```
```
1
√^8
```
```
| 010⟩ +
```
```
1
√^8
```
```
| 011⟩ +
```
```
1
√^8
```
```
| 100⟩−
```
```
1
√^8
```
```
| 101⟩ +
```
```
1
√^8
```
```
| 110⟩ +
```
```
1
√^8
```
#### | 111⟩


#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8
1
√^8
1
√^8
1
√ 8
1
√^8
−
1
√^8
1
√ 8
1
√^8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

Graphically:

We haven't seen the circuit that does this negation operation yet. We will explain in the next section.

**Step 4:**

We calculate the mean of all the amplitudes:

Mean = (√^18 + √^18 + √^18 + √^18 + √^18 − (^) √^18 + √^18 + √^18 )/8 = 0.26,
denoting it as a blue line in the plot:


Now, if we could flip the amplitudes over to the other side of the mean value, the plot visually will
change to:


How to achieve this mathematically?

Given any number 퐼퐼 ( which can be the mean value) and a value 푥푥 1 , one can find a value 푥푥 2. Visually it
looks like "flipping" 푥푥 1 over the mean. In mathematical terms, it is known as the reflection of 푥푥 1 over 퐼퐼
to be 푥푥 2 via

```
푥푥 2 = 2 ×퐼퐼−푥푥 1.
```
We need to perform this reflection over mean for all the amplitudes:

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡^2 ∗0.26−

```
1
√ 8
2 ∗0.26−
1
√^8
2 ∗0.26−
1
√^8
2 ∗0.26−√^18
```
```
2 ∗0.26−
1
√^8
2 ∗0.26+
1
√^8
2 ∗0.26−^1
√^8
2 ∗0.26−
1
√^8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0.18

#### 0.18

#### 0.18

#### 0.18

#### 0.18

#### 0.88

#### 0.18

#### 0.18⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

Here again, we didn't show the circuit that does this reflection over mean. We will cover that in the next
sections.

This is the first iteration of the Grover's algorithm. The amplitude of the state represented by our
black box (101) is 0.88 (getting closer to 1) and the amplitudes of the other states is 0.18 (getting closer
to 0).

Now, let's repeat Step 3 and negate the amplitude of the state represented by the black box once
more:

0. 18 | 000 ⟩ + 0. 18 | 001⟩ + 0.18 | 010 ⟩ + 0. 18 | 011⟩ + 0. 18 | 100⟩− 0. 88 | 101⟩ + 0. 18 | 110⟩ + 0. 18 | 111⟩.

Graphically:


Repeat Step 4. First, we need to calculate the new mean:

```
Mean = (0.18 + 0.18 + 0.18 + 0.18 + 0.18 - 0.88 + 0.18 + 0.18)/8 = 0.04.
```
Drawing the new mean line:

Now, performing reflection over mean of all the amplitudes:


#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 2 ∗0.04−0.18

#### 2 ∗0.04−0.18

#### 2 ∗0.04−0.18

#### 2 ∗0.04−0.18

#### 2 ∗0.04−0.18

#### 2 ∗0.04+ 0. 88

#### 2 ∗0.04−0.18

#### 2 ∗0.04−0.18 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

```
=
```
#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### −0.09

#### −0.09

#### −0.09

#### −0.09

#### −0.09

#### 0.97

#### −0.09

#### −0.09⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

Graphically:

The amplitude of the state represented by the black box is very close to 1 and all the other
amplitudes are very close 0. We can stop making further iterations and measure the three qubits and we
will get 101 with very high probability. We were able to find which black box was given by just making two
iterations, rather than about four iterations that might have been needed had it been a classical search.
In later sections we will also discuss on how to find the exact number of iterations that are needed.

```
Math insert – Grover's algorithm circuit construction --------------------------------------------
```
```
Above is the to show an intuition of what a Grover's algorithm does. A Grover's
algorithm is represented with the following circuit. Let's try to build it step by step in and gain
insights on how to mathematically construct the above.
```

```
Let's first build the circuit that implements Step 3 from earlier. Here we need to negate
the amplitude of the state represented by the black box.
```
```
Consider the following circuit:
```
```
Figure 2.3.2
```
```
Let's compute the state for each phase of the circuit. Here we take four qubits with
an initial state:
|0000⟩,
which can be written as:
|000⟩|0⟩.
```
Applying X gate on the last qubit:
|000⟩|1⟩.
Apply H gate on all the four qubits:

```
�|√^02 ⟩+|√^12 ⟩�⊗�|√^02 ⟩+|√^12 ⟩�⊗�|√^02 ⟩+|√^12 ⟩�⊗�|√^02 ⟩−|√^12 ⟩�,
which can be written as (doing tensor product on only the first three qubits):
```
```
1
√^8
```
#### �|000⟩⊗�|√^02 ⟩−|√^12 ⟩� + | 001 ⟩⊗�|√^02 ⟩−|√^12 ⟩� + | 010 ⟩⊗�|√^02 ⟩−|√^12 ⟩� + | 011 ⟩⊗�|√^02 ⟩−|√^12 ⟩� +

#### | 100⟩⊗�

```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 � + |^101
```
#### ⟩⊗�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 � + |^110
```
#### ⟩⊗�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 � + |^111
```
#### ⟩⊗�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 ��.
```
```
Now, applying the black box 101. This black box affects all the eight parts. It flips the last qubit
only when the state of the first three qubits are 101.
```
```
So, the state becomes:
1
√ 8 �|000⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 � + |^001 ⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 � + |^010 ⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 � + |^011 ⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 � +
| 100⟩⊗�|^0 ⟩
√^2
```
#### −|^1 ⟩

```
√^2
```
#### � + | 101 ⟩⊗�−|^0 ⟩

```
√^2
```
#### +|^1 ⟩

```
√^2
```
#### � + | 110 ⟩⊗�|^0 ⟩

```
√^2
```
#### −|^1 ⟩

```
√^2
```
#### � + | 111 ⟩⊗�|^0 ⟩

```
√^2
```
#### −|^1 ⟩

```
√^2
```
#### ��


#### =√^18 �|000⟩⊗�|√^02 ⟩−|√^12 ⟩� + | 001 ⟩⊗�|√^02 ⟩−|√^12 ⟩� + | 010 ⟩⊗�|√^02 ⟩−|√^12 ⟩� + | 011 ⟩⊗�|√^02 ⟩−|√^12 ⟩� +

#### | 100⟩⊗�|0√ 2 ⟩−|1√ 2 ⟩�− | 101 ⟩⊗�|√^02 ⟩−|√^12 ⟩� + | 110 ⟩⊗�|0√ 2 ⟩−|1√ 2 ⟩� + | 111 ⟩⊗�|0√ 2 ⟩−|1√ 2 ⟩��

=�√^18 | 000⟩ + √^18 | 001⟩ + √^18 | 010⟩ + √^18 | 011⟩ + √^18 | 100⟩− (^) √^18 | 101 ⟩ + √^18 | 110⟩ + √^18 |111⟩ �⊗
�|0√ 2 ⟩−|1√ 2 ⟩�

#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8
1
√^8
1
√^8
1
√ 8
1
√^8
−
1
√^8
1
√^8
1
√^8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ⊗�

```
1
√ 2
−
1
√^2
```
#### �.

```
This technique can be used to negate the amplitude of the state represented by the black box.
The highlights keep track of the terms that to | 101 ⟩.
```
```
Now, we need to build a circuit that does the reflection over the mean value (of all the
amplitudes of all the states). Consider the following circuit:
```
```
Figure 2.3.3
```
Here the symbol |−⟩ is used to stand for �

```
1
√^2
−√^12
```
```
� as we did in Phase 1.
```
```
The unitary matrix created by the three H gates in the beginning of this circuit
퐻퐻⊗퐻퐻⊗퐻퐻
```
#### =�

```
1
√^2
```
```
1
√^2
1
√^2 −
```
```
1
√^2
```
#### �⊗�

```
1
√^2
```
```
1
√^2
1
√^2 −
```
```
1
√^2
```
#### �⊗�

```
1
√^2
```
```
1
√^2
1
√^2 −
```
```
1
√^2
```
#### �.

```
The result is a unitary matrix with the first column:
```

#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√ 8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

```
And the first row:
�
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
... ... ... ... ... ... ... √...^8 �.
```
```
(Readers are encouraged to derive the full matrix. They can also find the result in the appendix
below.)
```
```
Now, consider the part of the circuit enclosed in the box, what kind of unitary matrix
does it represent? The input to this part is a generic superposition of three qubits and |−⟩:
```
```
(푎푎 0 |000⟩ + 푎푎 1 | 001⟩ + 푎푎 2 |010⟩ + 푎푎 3 |011⟩ +푎푎 4 |100⟩+푎푎 5 |101⟩ + 푎푎 6 |110⟩ + 푎푎 7 | 111 ⟩)⊗
�|√^02 ⟩−|√^12 ⟩�.
```
```
Apply the X gate to the last qubit as shown in the box:
```
```
(푎푎 0 |000⟩ + 푎푎 1 | 001⟩ + 푎푎 2 |010⟩ + 푎푎 3 |011⟩ +푎푎 4 |100⟩+푎푎 5 |101⟩ + 푎푎 6 |110⟩ + 푎푎 7 | 111 ⟩)⊗
�−
| 0 ⟩
√^2 +
```
| 1 ⟩
√^2 �^
=−푎푎 0 | 000⟩⊗�|^0
⟩
√ 2 −

```
| 1 ⟩
√ 2 �−^ 푎푎^1 |001⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−^ 푎푎^2 |010⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
| 1 ⟩
√ 2 �−^ 푎푎^3 |011⟩⊗
�|^0 ⟩
√^2

#### −|^1 ⟩

```
√^2
```
#### �− 푎푎 4 |100⟩⊗�|^0 ⟩

```
√^2
```
#### −|^1 ⟩

```
√^2
```
#### �−푎푎 5 |101⟩⊗�|^0 ⟩

```
√^2
```
#### −|^1 ⟩

```
√^2
```
#### �− 푎푎 6 |110⟩⊗�|^0 ⟩

```
√^2
```
#### −|^1 ⟩

```
√^2
```
#### �− 푎푎 7 |111⟩⊗

#### �

```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �.
```
```
The Controlled X and X gates in the remaining part of the circuit in the box flips only those
amplitudes where all the first three qubits are 0:
```
#### −푎푎 0 | 000⟩⊗�−

```
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 �−^ 푎푎^1 |001
```
#### ⟩⊗�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 �−^ 푎푎^2 |010
```
#### ⟩⊗�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 �−^ 푎푎^3 |011
```
#### ⟩⊗

#### �|^0

```
⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−^ 푎푎^4 |100⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−푎푎^5 |101⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−^ 푎푎^6 |110⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−^ 푎푎^7 |111⟩⊗
�|^0 ⟩
√^2
```
#### −|^1 ⟩

```
√^2
```
#### �

#### =푎푎 0 | 000⟩⊗�

```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �−^ 푎푎^1 |001
```
#### ⟩⊗�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 �−^ 푎푎^2 |010
```
#### ⟩⊗�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 �−^ 푎푎^3 |011
```
#### ⟩⊗

#### �|^0

```
⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−^ 푎푎^4 |100⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−푎푎^5 |101⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−^ 푎푎^6 |110⟩⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �−^ 푎푎^7 |111⟩⊗
�|√^02 ⟩−|√^12 ⟩�
```

#### = (푎푎 0 | 000 ⟩− 푎푎 1 |001⟩− 푎푎 2 |010⟩− 푎푎 3 |011⟩− 푎푎 4 |100⟩−푎푎 5 |101⟩− 푎푎 6 |110⟩− 푎푎 7 | 111 ⟩)⊗�|√^02 ⟩−|√^12 ⟩�.

```
Basically, what the circuit in the box did is to negate all the amplitudes except that of |000⟩.
This fact needs to be noted because we will be using this later.
```
```
Now, what is the unitary matrix that makes
```
#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 푎푎 0

#### 푎푎 1

#### 푎푎 2

#### 푎푎 3

#### 푎푎 4

#### 푎푎 5

#### 푎푎 6

#### 푎푎 7 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

```
change to
```
#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 푎푎 0

#### −푎푎 1

#### −푎푎 2

#### −푎푎 3

#### −푎푎 4

#### −푎푎 5

#### −푎푎 6

#### −푎푎 7 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ?

```
The answer is
```
#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 1 0 0 0 0 0 0 0

#### 0 − 1 0 0 0 0 0 0

#### 0 0 − 1 0 0 0 0 0

#### 0 0 0 − 1 0 0 0 0

#### 0 0 0 0 − 1 0 0 0

#### 0 0 0 0 0 − 1 0 0

#### 0 0 0 0 0 0 − 1 0

#### 0 0 0 0 0 0 0 − 1 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

```
Combining all the three sections of this circuit:
```
#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 1 0 0 0 0 0 0 0

#### 0 − 1 0 0 0 0 0 0

#### 0 0 − 1 0 0 0 0 0

#### 0 0 0 − 1 0 0 0 0

#### 0 0 0 0 − 1 0 0 0

#### 0 0 0 0 0 − 1 0 0

#### 0 0 0 0 0 0 − 1 0

#### 0 0 0 0 0 0 0 − 1 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

```
Rewriting:
```

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√ 8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗(

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 2 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### −

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 1 0 0 0 0 0 0 0

#### 0 1 0 0 0 0 0 0

#### 0 0 1 0 0 0 0 0

#### 0 0 0 1 0 0 0 0

#### 0 0 0 0 1 0 0 0

#### 0 0 0 0 0 1 0 0

#### 0 0 0 0 0 0 1 0

#### 0 0 0 0 0 0 0 1 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### )∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√ 8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗(

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 2 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### − 퐼퐼)∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗(

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 2 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### − 퐼퐼)∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤


#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√ 8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗(

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 2 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√ 8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### −

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√ 8 ...
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### )

#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 2 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### −

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 2 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0

#### 0 0 0 0 0 0 0 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### −퐼퐼

(because 퐻퐻 ∗ 퐻퐻 = 퐼퐼).

Now, multiplying the first two matrices (it must be obvious now why only the first column of
the first matrix matters):


#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
2
√ 8 0 0 0 0 0 0 0
2
√^80000000
2
√^80000000
2
√^8
```
#### 0 0 0 0 0 0 0

```
2
√^80000000
2
√ 8 0 0 0 0 0 0 0
2
√^8
```
#### 0 0 0 0 0 0 0

```
2
√^80000000 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ∗

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8 ...
1
√^8 ...
1
√^8 ...
1
√^8
```
#### ...

```
1
√^8 ...
1
√ 8 ...
1
√^8
```
#### ...

```
1
√^8 ...⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### −퐼퐼.

```
Since all the entries in the first row and first column of (퐻퐻⊗퐻퐻⊗퐻퐻) will be
1
√^8 (proven in the
previous sections), following will be the result:
```
#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### −퐼퐼 =

```
⎣
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎡
```
```
2
8 −^1
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8 −^1
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8 −^1
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8 −^1
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8 −^1
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8 −^1
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8 −^1
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8 −^1 ⎦
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎤
```
```
Now, what happens if we multiply this with some generic state:
```
```
⎣
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎡
```
```
2
```
### 8 −^1

```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
```
### 8 −^1

```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
```
### 8 −^1

```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
```
### 8 −^1

```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
```
### 8 −^1

```
2
8
```
```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
```
### 8 −^1

```
2
8
```
```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
```
### 8 −^1

```
2
8
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
8
```
```
2
```
### 8 −^1 ⎦

```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎤
```
```
*
```
#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 푎푎 0

#### 푎푎 1

#### 푎푎 2

#### 푎푎 3

#### 푎푎 4

#### 푎푎 5

#### 푎푎 6

#### 푎푎 7 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ?

```
The first entry in the resultant matrix:
```

#### 푎푎 0 ∗�

#### 2

#### 8

#### − 1 �+푎푎 1 ∗

#### 2

#### 8

#### +푎푎 2 ∗

#### 2

#### 8

#### +푎푎 3 ∗

#### 2

#### 8

#### +푎푎 4 ∗

#### 2

#### 8

#### +푎푎 5 ∗

#### 2

#### 8

#### +푎푎 6 ∗

#### 2

#### 8

#### +푎푎 7 ∗

#### 2

#### 8

#### =푎푎 0 ∗�

#### 2

#### 8

#### �−푎푎 0 +푎푎 1 ∗

#### 2

#### 8

#### +푎푎 2 ∗

#### 2

#### 8

#### +푎푎 3 ∗

#### 2

#### 8

#### +푎푎 4 ∗

#### 2

#### 8

#### +푎푎 5 ∗

#### 2

#### 8

#### +푎푎 6 ∗

#### 2

#### 8

#### +푎푎 7 ∗

#### 2

#### 8

```
=�
```
#### 2

#### 8

#### �(푎푎 0 +푎푎 1 +푎푎 2 +푎푎 3 +푎푎 4 +푎푎 5 +푎푎 6 +푎푎 7 )−푎푎 0

#### = 2∗(푎푎 0 +푎푎 1 +푎푎 2 +푎푎 3 +푎푎 4 +푎푎 5 +푎푎 6 +푎푎 7 )/8−푎푎 0

#### = 2 푅푅푎푎푓푓∗퐼퐼 −푎푎 1.

Similarly, the second row will become:

```
2 푅푅푎푎푓푓∗퐼퐼 −푎푎 1
```
Hence, the final result will be:

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 2 푅푅푎푎푓푓∗퐼퐼 −푎푎 0

#### 2 푅푅푎푎푓푓∗퐼퐼 −푎푎 1

#### 2 푅푅푎푎푓푓∗퐼퐼 −푎푎 2

#### 2 푅푅푎푎푓푓∗퐼퐼 −푎푎 3

#### 2 푅푅푎푎푓푓∗퐼퐼 −푎푎 4

#### 2 푅푅푎푎푓푓∗퐼퐼 −푎푎 5

#### 2 푅푅푎푎푓푓∗퐼퐼 −푎푎 6

#### 2 푅푅푎푎푓푓∗퐼퐼 −푎푎 7 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

Hence, we achieved the desired result of reflection over the mean value.
Finally, we can combine both the circuits and write final circuit as follows (any black
box can be used instead of Black Box 101).

Af ter the initialization, the circuit in the bigger box (including the black box and reflection) will
be executed multiple times based on the number of qubits. The exact number of times it
needs to be iterated over will be covered in the appendix below. This iteration count will be in
the order of O(√ 2 푔푔) instead of the classical O( 2 푔푔). Measuring the first 3 qubits will give the bit
combination associated with the black box.


### Q# exercise: Grover's algorithm

1. Go to QuantumComputingViaQSharpSolution introduced in session 1.1.
2. Open 23_Demo Grover's Algorithm Operation.qs in Visual Studio (Code).
3. The black boxes are defined by lines 23-48, just as how we constructed the circuit diagrams.

operation GenericFlip(qubits: Qubit[], controlString: Bool[], extraBit:
Qubit, n: Int ): ()
{
body
{
//Changing the qubits to 1 whereever we have 0
for(i in 0 ..n- 1)
{
if(controlString[i] == false)
{
X(qubits[i]);
}
}

//Flipping the extraBit; Now, X will be applieed only if bits match
the controlString
(Controlled X)(qubits, extraBit);

//Undoing the changes we made in the first for loop
for(i in 0 ..
{
if(controlString[i] == false)
{
X(qubits[i]);
}
}
}
}

4. Reflection over mean is implemented by lines 52-69.


operation GenericReflectionAboutMean(qubits: Qubit[], extraBit: Qubit): ()
{
body
{
//Change of bases so that |00000> aligns with H*H*H*H*H(|00000>)
ApplyToEach(H, qubits);

//Flip the extraBit only for the states != |00000>
ApplyToEach(X, qubits);//This will make |00000> to |11111>
X(extraBit);//This will always flip the extraBit
(Controlled X)(qubits, extraBit);//This will flip only if the state
is |11111>, this step and above step will effectively
//ensure that except for |00000>, all other states's amplitudes will
be negated
ApplyToEach(X, qubits);//This will undo the above ApplyToEach

//Undoing the basis change
ApplyToEach(H, qubits);
}
}

5. The rest of the script puts the circuit together. "MultiM()" measures multiple qubit values.
    let results = MultiM(qubits);
"Pattern" is the number to find. The default is set to "10100" in the driver.cs.

using (var simulator = new QuantumSimulator())
{
//We are trying to simulate the Grover's algo for a 5 qubit
system.
var pattern = new
Microsoft.Quantum.Simulation.Core.QArray<bool >(5 );
// We are trying to find 10100
// If we measure the system at the end of the algorithem, we
should get 10100
pattern[0] = true;
pattern[1] = false;
pattern[2] = true;
pattern[3] = false;
pattern[4] = false;


var result = GenericGroversAlgo.Run (simulator, 5,
pattern). Result;
}

6. By running the Operation.qs via dotnet run, we will get output:

"State of the system at the end of 3 iterations:

10100"

7. Change the pattern to a different string in the driver.cs and rerun the simulation.
8. More Grover's algorithm exercise can be found in Quantum Katas.

Appendix

**Iteration Count**

Before going into the calculations on how to find the number of iterations, let's see how to graphically
visualize the state vector.

Let's say we have a 3-qubit system. There are eight basis states:

```
|000⟩, | 001⟩, | 010⟩, | 011⟩, | 100⟩, | 101⟩, | 110⟩, | 111⟩
```
The state vector will have eight elements:

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 1 0 0 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ,

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 1 0 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ,

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 1 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ,

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 1 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ,

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 1 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ,

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 0 1 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ,

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 0 0 1

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ,

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 0 0 0

#### 1 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

A sample state might look as follows:

```
푎푎 0 |000⟩+ 푎푎 1 |001⟩+ 푎푎 2 |010⟩+ 푎푎 3 |011⟩+ 푎푎 4 |100⟩+푎푎 5 |101⟩+ 푎푎 6 |110⟩+ 푎푎 7 |110⟩.
```
In the vector form it will look as:


#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 푎푎 0

#### 푎푎 1

#### 푎푎 2

#### 푎푎 3

#### 푎푎 4

#### 푎푎 5

#### 푎푎 6

#### 푎푎 7 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### =푎푎 0

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 1 0 0 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 1

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 1 0 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 2

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 1 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 3

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 1 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 4

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 1 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 5

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 0 1 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 6

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 0 0 1

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 7

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 0 0 0

#### 1 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

Here, we can see that each basis state is orthogonal to every other basis state (dot product will be zero).
The length of a generic state vector will always be 1. Each basis state is a unite vector with the length 1.
We also know that any unitary operation will change the values of this generic state vector into a different
state vector but will always retain its length of 1. So, we can imagine a hyperspace of 8 dimensions where
each axis is perpendicular to every other and each basis state is a unit vector along one of the axes. In this
scheme, our generic state vector will be a vector whose length will always be 1 and keeps moving around
in this hyperspace whenever a unitary operation is performed on it.

Let's start with a single qubit system.

As shown above, since a single qubit system has only two basis states, we can represent them with two
orthogonal axes. Now, if we consider a single qubit in state |0⟩, the state of this qubit will be aligned with
the horizontal axis towards the right (white arrow):


Applying an X gate on this state will make it |1⟩:

How will the state 퐻퐻(|0⟩) look like? The vector form of it is �

```
1
√ 2
1
√^2
```
```
�. Graphically, it will be a 2D - vector with
```
both the components set to
1
√^2 :

As shown, the head of this white arrow will move in a circle with radius 1 in this 2D-space. One thing to
be noticed here is that, the 2D-plane in which this state vector rotates is not real but complex.

In a 3-qubit system, the basis states are visualized:


In reality, a 3-qubit system has 8 dimensions. Unfortunately, as humans, we can visualize only 3
dimensions, in this picture we are showing only the first three orthogonal basis states and leaving the
other 5 for user's imagination. Here again we are still cheating because, in reality these three dimensions
are complex but we are showing them with lines of real numbers. Nevertheless, this will still help us gain
some really useful intuition of the state of a quantum system.

In the Q# exercise earlier, the number of iterations is calculated in lines 8-19 via an angle
between the basis vector and the axis of the multi-dimensional space of the qubit system.

operation GetNumberOfIterations (n: Double): (Double)
{
body
{
mutable root = 1.0;
set root = 1.0/Sqrt(n);
mutable angle = 1.0;
mutable pi = PI();
set angle = (PI()/(4.0* ArcSin(root))) - 0.5;
return angle;
}
}

```
Initialization
```
In this scheme, the state |000⟩ looks like (white arrow):


How will the state (퐻퐻⊗퐻퐻⊗퐻퐻)(| 000 ⟩) look like? Applying H gate on all the three qubits which are in
the ground state:

#### �

```
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 �⊗�
```
```
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 �=
```
#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
1
√^8
1
√ 8
1
√^8
1
√^8
1
√^8
1
√^8
1
√ 8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

Showing only the first three dimensions of this 8-dimensional vector above:

This is a very important state in our discussion, so we will mark it permanently in the space using a yellow
arrow:


Take a generic state,

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 푎푎 0

#### 푎푎 1

#### 푎푎 2

#### 푎푎 3

#### 푎푎 4

#### 푎푎 5

#### 푎푎 6

#### 푎푎 7 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### ,

graphically:

Do the reflection of this state over the |000⟩ axis:


Taking the reflection over |000⟩ is same as keeping 푎푎 0 intact but negating all the other components, thus
flipping vector di rection.

Now the unitary operation (퐻퐻⊗퐻퐻⊗퐻퐻):

```
⎣
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎡
```
#### 1

#### √ 2

#### 1

#### √ 2

#### 1

#### √ 2

```
−
```
#### 1

#### √ 2 ⎦

```
⎥
```
```
⎥
```
```
⎥
```
```
⎤
⊗
⎣
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎡
```
#### 1

#### √ 2

#### 1

#### √ 2

#### 1

#### √ 2

```
−
```
#### 1

#### √ 2 ⎦

```
⎥
```
```
⎥
```
```
⎥
```
```
⎤
⊗
⎣
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎡
```
#### 1

#### √ 2

#### 1

#### √ 2

#### 1

#### √ 2

```
−
```
#### 1

#### √ 2 ⎦

```
⎥
```
```
⎥
```
```
⎥
```
```
⎤
```
```
=
```
```
⎣
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎢
```
```
⎡
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 ⎦
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎥
```
```
⎤
```
```
.
```
Multiplying this with the generic state vector:

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8
1
√^8 −
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
1
√^8
```
#### −^1

```
√^8
```
#### −^1

```
√^8
```
```
1
√^8
```
```
1
√^8
```
#### −^1

```
√^8
```
#### −^1

```
√^8
```
```
1
√^8
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
1
√^8
```
```
1
√^8
```
#### −^1

```
√^8
```
#### −^1

```
√^8
```
#### −^1

```
√^8
```
#### −^1

```
√^8
```
```
1
√^8
```
```
1
√^8
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### *

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 푎푎 0

#### 푎푎 1

#### 푎푎 2

#### 푎푎 3

#### 푎푎 4

#### 푎푎 5

#### 푎푎 6

#### 푎푎 7 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤


#### =

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
1
√^8
```
#### −^1

```
√^8
```
```
1
√^8
```
#### −^1

```
√^8
```
```
1
√^8
```
#### −^1

```
√^8
```
```
1
√^8
```
#### −^1

```
√^8
1
√^8
```
```
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
1
√^8
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8
1
√^8 −
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8
```
```
1
√^8
1
√ 8
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8 −
```
```
1
√ 8
```
```
1
√ 8
```
```
1
√ 8
1
√^8 −
```
```
1
√^8 −
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8
```
```
1
√^8
```
```
1
√^8 −
```
```
1
√^8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### * (푎푎 0

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 1 0 0 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 1

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 1 0 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 2

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 1 0 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 3

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 1 0 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 4

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 1 0 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +

#### 푎푎 5

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 0 1 0

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 6

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 0 0 1

#### 0 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 7

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

#### 0 0 0 0 0 0 0

#### 1 ⎦

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### )

#### =푎푎 0

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
1
√^8
1
√^8
1
√^8
1
√ 8
1
√^8
1
√^8
1
√ 8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 1

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
−
1
√^8
1
√^8
−
1
√^8
1
√ 8
−^1
√^8
1
√^8
−√^18 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 2

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
1
√^8
−^1
√^8
−
1
√^8
1
√ 8
1
√^8
−
1
√^8
−√^18 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 3

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
−
1
√^8
−^1
√^8
1
√^8
1
√ 8
−^1
√^8
−
1
√^8
1
√ 8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 4

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
1
√^8
1
√^8
1
√^8
−√^18
−^1
√^8
−
1
√^8
−√^18 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 5

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
−
1
√^8
1
√^8
−
1
√^8
−√^18
1
√^8
−
1
√^8
1
√ 8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 6

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
1
√^8
−^1
√^8
−
1
√^8
−√^18
−^1
√^8
1
√^8
1
√ 8 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### +푎푎 7

#### ⎣

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎢

#### ⎡

```
1
√^8
−
1
√^8
−^1
√^8
1
√^8
−√^18
1
√^8
1
√^8
−√^18 ⎦
```
#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎥

#### ⎤

#### .

Applying the unitary matrix (퐻퐻⊗퐻퐻⊗퐻퐻) on a generic state vector can also be thought as simple change
of basis, because each column in the (퐻퐻⊗퐻퐻⊗퐻퐻) unitary matrix is a unit vector and all the columns are
orthogonal to each other. (Try doing a dot product of any two columns; you will get 0 as the result). This
rule is true for any unitary matrix. Its application is equivalent to a change of basis and each new basis
vector will be one of the columns of the unitary matrix. The first basis state in this new basis states is the
same as (퐻퐻⊗퐻퐻⊗퐻퐻)| 000⟩ and is represented by the yellow vector we saw earlier in the hyper space.
You can also see that the second basis in this new basis is the same as (퐻퐻⊗퐻퐻⊗퐻퐻)| 001⟩ and so on.

**Reflection over mean**

In the _Reflection over mean_ part of the circuit, the first step is to apply H gate on all the qubits.
This is basically changing the basis. The first new basis is (퐻퐻⊗퐻퐻⊗퐻퐻)| 000⟩, which is represented by the


yellow arrow in the diagram below. The gates after that are negating all the amplitudes except for the
first basis state, which is same as reflecting the state about the first basis state. A pplying (퐻퐻⊗퐻퐻⊗퐻퐻)
again will undo the basis change.

We have shown above that, reflection over mean is the same as reflecting the state over the
(퐻퐻⊗퐻퐻⊗퐻퐻)| 000⟩ state (yellow vector). We have changed the basis into new basis states where the
first basis is the yellow vector itself and then used the circuit to negate all the amplitudes except of the
first one, effectively reflecting the state vector over the yellow vector and finally did the basis change.

In the above image, the white vector shows the state before reflection and the black vector shows the
state after the reflection over the yellow vector.

```
Black box – amplitude negation
```
For the sake of simplicity, let's assume now that the black box is for |000⟩. The black box is simply negating
the amplitude of this state and leaves all the others unchanged. This can be graphically represented as:

Effectively the algorithm is doing

1. Take the initial state as |000⟩.
2. Apply H gate on all the qubits and aligning it with the yellow vector.


3. Change the sign of the state that we are looking for.
4. Reflecting the state over the yellow vector.
5. Repeat 3 and 4 until the state vector reaches the desired state of |001⟩ (example take in these
    images).

In the beginning the state vector is at |000⟩, i.e aligned to the right-pointing arrow:

Applying H gates on all the qubits, aligns the state with the yellow vector:

Now, this state vector makes an angle θ with the red and blue plane and π/2-θ with |001⟩ (the state of
the black box that we are considering now). After the application of the black box, the state vector will go
θ below the red and blue plane because it will negate only the amplitude of | 001 ⟩ and retains the others:


The angle now between the yellow and white vectors is 2θ. The next step is to reflect the white vector
over the yellow vector. This will bring the white vector close to the green vector by 2θ:

Here the angle between the yellow vector and the white vector is 2θ. We should do it nIter-times so that,
at the end, the white vector coincides with the |001⟩. In the beginning the angle between the white vector
and the |001⟩ vector was π/2-θ and in every iteration this angle is decreased by 2θ. Therefore, assuming
we find the solution after n iterations:

```
nIter * 2θ = π/2-θ.
```
Solving this we get, nIter = (π/(4θ)) – ½


Also, we need to know θ. In the beginning, sin(θ) = opposite side / hypotenuse of the yellow vector. The

opposite side is the vector component of the yellow vector in the |001⟩ direction which is nothing but
1
√^8.
And we know that the length of the hypotenuse of the yellow vector is one. So, generically speaking:

```
Sin(θ) =
1
√^2 푛푛^
```
```
θ = ArcSin(
1
√ 2 푛푛)
```
By putting this θ in the previous equation we will get the exact number of iterations that are needed. In
this example, where we have 3 qubits, θ = 0.36 radians.

Hence, nIter = 2 (after rounding). After two iterations the state looks as follows:

Now, measuring this will yield the result |001⟩ with very high probability.

To calculate the number of counts, we know that as the number of qubits increases, the number of states

increases. The value of √^12 푛푛 becomes smaller. We know that for small angles Sin(θ) = θ (you can search

online for this proof, it is very simple based on the definition of a radian).

```
nIter = (π/(4∗√^12 푛푛)) – ½.
```
By simplifying it and removing the constant terms and constant multipliers we will be left with O(√ 2 푔푔).
