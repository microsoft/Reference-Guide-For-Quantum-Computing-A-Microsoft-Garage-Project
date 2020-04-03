## 2.3 Deutsch-Jozsa Algorithm

* [Q# exercise: Grover's algorithm]()

Deutsch-Jozsa algorithm can be thought of as a general case of Deutsch's algorithm for 푓푓-qubits. It was
proposed by David Deutsch and Richard Jozsa in 1992, which inspired the later development of Simon's
algorithm and Shor's algorithm. Let's start with three qubits. We have a black box that takes in three bits
and outputs one bit:


As in the Deutsch's algorithm, we can define two kinds of black boxes like this – _Constant_ and _Balanced_.
The truth table for a black box that always returns 0 no matter the input:

```
풙풙 풚풚=풇풇(풙풙)
000 0
001 0
010 0
011 0
100 0
101 0
110 0
111 0
```
```
Table 2.3.1 Constant 0
```
The truth table for a black box that always returns 1 no matter the input:

```
풙풙 풚풚=풇풇(풙풙)
000 1
001 1
010 1
011 1
100 1
101 1
110 1
111 1
```
```
Table 2.3.2 – Constant 1
```
The truth table for a black box that returns 0 for half of the inputs and returns 1 for the remaining half:

```
풙풙 풚풚=풇풇(풙풙)
000 0
001 0
010 0
011 0
100 1
101 1
110 1
111 1
```

```
Table 2.3.3 – Balanced
```
The truth table for another black box that returns 0 for half of the inputs and returns 1 for the remaining
half:

```
풙풙 풚풚=풇풇(풙풙)
000 0
001 1
010 0
011 1
100 0
101 1
110 0
111 1
```
```
Table 2.3.4 – Balanced
```
It is apparent there are exactly two _Constant_ black boxes ( _Constant_ 0 and _Constant_ 1), but many possible
_Balanced_ black boxes.

If one is given such a black box and a constraint that the black box will be either _Constant_ or
_Balanced_ but not any other random output, how many times does one have to execute that black box
(obviously with different inputs for each iteration) to identify whether the black box is _Constant_ or
_Balanced_? Like Deustch's algorithm, it is only needed to identify if the given black box is _Constant_ or
_Balanced_ and not the exact black box. In general, using classical computing, for 푓푓-bit inputs, the count will

be
2 푛푛
2 + 1 = 2

```
푔푔−1+ 1 (one more than half of the number of possible inputs). The 3-bit example will yield
```
a count of 5 (= 4 + 1) - this is the count for the worst-case scenario. If you are lucky you may be able to
find it by just two executions (for some _Balanced_ black boxes). However, using the Deutsch-Jozsa
algorithm, a quantum computer can solve this problem with just one execution, no matter how large 푓푓
might be! Let's see how.

Before proceeding with the algorithm, we need to create such black boxes (a.k.a. Quantum
Oracles) that work on a quantum computer (as discussed in the previous sessions).

Truth table for _Constant_ 0:

풙풙 |풙풙ퟎퟎ⟩ |풙풙ퟏퟏ⟩ |풙풙ퟐퟐ⟩ (^) |풚풚⟩ 풇풇(풙풙) |풚풚 ⨁풇풇(풙풙)⟩
0 | 0 ⟩ | 0 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩
0 | 0 ⟩ | 0 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩
1 | 0 ⟩ | 0 ⟩ | 1 ⟩ | 0 ⟩ 0 | 0 ⟩
1 | 0 ⟩ | 0 ⟩ | 1 ⟩ | 1 ⟩ 0 | 1 ⟩
2 | 0 ⟩ | 1 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩


#### 2 | 0 ⟩ | 1 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩

#### 3 | 0 ⟩ | 1 ⟩ | 1 ⟩ | 0 ⟩ 0 | 0 ⟩

#### 3 | 0 ⟩ | 1 ⟩ | 1 ⟩ | 1 ⟩ 0 | 1 ⟩

#### 4 | 1 ⟩ | 0 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩

#### 4 | 1 ⟩ | 0 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩

#### 5 | 1 ⟩ | 0 ⟩ | 1 ⟩ | 0 ⟩ 0 | 0 ⟩

(^5) | 1 ⟩ | 0 ⟩ | 1 ⟩ | 1 ⟩ 0 | 1 ⟩
6 | 1 ⟩ | 1 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩
6 | 1 ⟩ | 1 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩
7 | 1 ⟩ | 1 ⟩ | 1 ⟩ | 0 ⟩ 0 | 0 ⟩
7 | 1 ⟩ | 1 ⟩ | 1 ⟩ | 1 ⟩ 0 | 1 ⟩
For every 푥푥 value, there are two possible states for |풚풚⟩ (|0⟩ or |1⟩). The circuit for the above truth table _:_
The truth table for _Constant_ 1:
풙풙 |풙풙ퟎퟎ⟩ |풙풙ퟏퟏ⟩ |풙풙ퟐퟐ⟩ (^) |풚풚⟩ 풇풇(풙풙) |풚풚 ⨁풇풇(풙풙)⟩
0 | 0 ⟩ | 0 ⟩ | 0 ⟩ | 0 ⟩ 1 | 1 ⟩
0 | 0 ⟩ | 0 ⟩ | 0 ⟩ | 1 ⟩ 1 | 0 ⟩
1 | 0 ⟩ | 0 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩
1 | 0 ⟩ | 0 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩
2 | 0 ⟩ | 1 ⟩ | 0 ⟩ | 0 ⟩ 1 | 1 ⟩
2 | 0 ⟩ | 1 ⟩ | 0 ⟩ | 1 ⟩ 1 | 0 ⟩
3 | 0 ⟩ | 1 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩
3 | 0 ⟩ | 1 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩
4 | 1 ⟩ | 0 ⟩ | 0 ⟩ | 0 ⟩ 1 | 1 ⟩
4 | 1 ⟩ | 0 ⟩ | 0 ⟩ | 1 ⟩ 1 | 0 ⟩
5 | 1 ⟩ | 0 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩
5 | 1 ⟩ | 0 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩
6 | 1 ⟩ | 1 ⟩ | 0 ⟩ | 0 ⟩ 1 | 1 ⟩
6 | 1 ⟩ | 1 ⟩ | 0 ⟩ | 1 ⟩ 1 | 0 ⟩
7 | 1 ⟩ | 1 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩
7 | 1 ⟩ | 1 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩
The circuit for the above truth table (same as _Constant_ 0, but with an X gate; compare the last columns in
both truth tables) _:_


The truth table for one possible _Balanced_ black box:

풙풙 |풙풙ퟎퟎ⟩ |풙풙ퟏퟏ⟩ |풙풙ퟐퟐ⟩ (^) |풚풚⟩ 풇풇(풙풙) |풚풚 ⨁풇풇(풙풙)⟩
0 | 0 ⟩ | 0 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩
0 | 0 ⟩ | 0 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩
1 | 0 ⟩ | 0 ⟩ | 1 ⟩ | 0 ⟩ 0 | 0 ⟩
1 | 0 ⟩ | 0 ⟩ | 1 ⟩ | 1 ⟩ 0 | 1 ⟩
2 | 0 ⟩ | 1 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩
2 | 0 ⟩ | 1 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩
3 | 0 ⟩ | 1 ⟩ | 1 ⟩ | 0 ⟩ 0 | 0 ⟩
3 | 0 ⟩ | 1 ⟩ | 1 ⟩ | 1 ⟩ 0 | 1 ⟩
4 | 1 ⟩ | 0 ⟩ | 0 ⟩ | 0 ⟩ 1 | 1 ⟩
4 | 1 ⟩ | 0 ⟩ | 0 ⟩ | 1 ⟩ 1 | 0 ⟩
5 | 1 ⟩ | 0 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩
5 | 1 ⟩ | 0 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩
6 | 1 ⟩ | 1 ⟩ | 0 ⟩ | 0 ⟩ 1 | 1 ⟩
6 | 1 ⟩ | 1 ⟩ | 0 ⟩ | 1 ⟩ 1 | 0 ⟩
7 | 1 ⟩ | 1 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩
7 | 1 ⟩ | 1 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩
Circuit for the above truth table (because the last column is the same as |풚풚⟩ except when |풙풙ퟎퟎ⟩= |1⟩, the
values are flipped):
Truth table for another possible _Balanced_ black box:
풙풙 |풙풙ퟎퟎ⟩ |풙풙ퟏퟏ⟩ |풙풙ퟐퟐ⟩ (^) |풚풚⟩ 풇풇(풙풙) |풚풚 ⨁풇풇(풙풙)⟩
0 | 0 ⟩ | 0 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩
0 | 0 ⟩ | 0 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩
1 | 0 ⟩ | 0 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩
1 | 0 ⟩ | 0 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩
2 | 0 ⟩ | 1 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩
2 | 0 ⟩ | 1 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩
3 | 0 ⟩ | 1 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩


#### 3 | 0 ⟩ | 1 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩

#### 4 | 1 ⟩ | 0 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩

#### 4 | 1 ⟩ | 0 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩

#### 5 | 1 ⟩ | 0 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩

#### 5 | 1 ⟩ | 0 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩

#### 6 | 1 ⟩ | 1 ⟩ | 0 ⟩ | 0 ⟩ 0 | 0 ⟩

(^6) | 1 ⟩ | 1 ⟩ | 0 ⟩ | 1 ⟩ 0 | 1 ⟩
7 | 1 ⟩ | 1 ⟩ | 1 ⟩ | 0 ⟩ 1 | 1 ⟩
7 | 1 ⟩ | 1 ⟩ | 1 ⟩ | 1 ⟩ 1 | 0 ⟩
Circuit for the above truth table (because the last column is the same as |풚풚⟩ but is flipped when |풙풙ퟐퟐ⟩=
|1⟩):
We can build several _Balanced_ black boxes in the same way.
Once any such unknown black box ( _U_ ) is given, we use it in the following Deutsch-Jozsa algorithm:
We follow these steps as shown in the circuit:

1. Start with |0⟩ for all the four qubits;
2. Make the last one |1⟩ by applying an X gate;
3. Apply H gate to all the qubits;
4. Run the given black box;
5. Apply H gate again only to the input qubits – the first three qubits;
6. Measure only the input qubits.

After executing the circuit, if we measure "0" in all the three input qubits, then we can conclude that the
given black box is a _Constant_ one ( _Constant_ 0 or _Constant_ 1). For any other combination, we can conclude
that the given black box is a _Balanced_ one (could be any of the many possible _Balanced_ black boxes).

Here's the proof. Let's take the generic case where we have 푓푓-qubits instead of three. The initial
state of the system will be:

```
|0 00 ... 0 (푓푓−푞푞푓푓푏푏푓푓푓푓푝푝)⟩|0⟩.
```
Applying X gate on the last qubit:


#### |0 00 ... 0 (푓푓−푞푞푓푓푏푏푓푓푓푓푝푝)⟩|1⟩,

which can be rewritten as:

```
|0⟩⊗|0⟩⊗|0⟩... (푓푓−푞푞푓푓푏푏푓푓푓푓푝푝)⊗|1⟩.
```
Applying H gate on all the qubits:

```
�|^0
⟩
√ 2 +
```
```
| 1 ⟩
√ 2 �⊗�
```
```
| 0 ⟩
√ 2 +
```
```
| 1 ⟩
√ 2 �⊗�
```
```
| 0 ⟩
√ 2 +
```
```
| 1 ⟩
√ 2 �^ ... (푓푓−푓푓푓푓퐼퐼푅푅푝푝) ...⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �,
```
which can be rewritten as:

```
1
√ 2 푛푛∑ |푥푥⟩
```
```
2 푛푛−1
푥푥=0 ⊗�
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 �.
```
```
Math insert – proof of above -----------------------------------------------------------------------------
```
```
Using three qubits with H gates applied on them as an example, without loss of
generality,
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
√^2 �^
=
```
#### 1

#### √ 23

#### (| 000 ⟩ + | 001 ⟩ + | 010 ⟩ + | 011 ⟩ + | 100 ⟩ + | 101 ⟩ + | 110 ⟩ + | 111 ⟩)

#### =

#### 1

#### √ 23

#### (|0⟩ + |1⟩ + |2⟩ + |3⟩ + |4⟩ + |5⟩ + |6⟩ + |7⟩)

#### =

```
1
√2^3
```
#### ∑^2 푥푥=0^3 −1|푥푥⟩.

Now, apply the black box on this state, the new state will become

```
1
√ 2 푛푛∑ |푥푥⟩
```
```
2 푛푛−1
푥푥=0 ⊗�
```
```
|0⨁푓푓(푥푥)⟩
√ 2 −
```
```
|1⨁푓푓(푥푥)⟩
√ 2 �^
```
```
=
1
√ 2 푛푛
```
#### ∑^2 푥푥=0푛푛−1|푥푥⟩⊗�|푓푓(푥푥)⟩

#### √^2 −

```
|푓푓(푥푥)�
√^2 �.
```
We know that 푓푓(푥푥) has only two possible outputs - 0 or 1. Hence the above state can be written as

```
1
√ 2 푛푛∑ |푥푥⟩
```
(^2) 푥푥=0푛푛−1 ⊗(−1)푓푓(푥푥)�|^0 ⟩
√ 2 −
| 1 ⟩
√ 2 �^
=√^12 푛푛∑^2 (−1)푓푓(푥푥)|푥푥⟩
푛푛−1
푥푥=0 ⊗�
| 0 ⟩
√^2

#### −|^1 ⟩

```
√^2
```
#### �.

```
Math insert – implementation of the above ----------------------------------------------------------
```

To understand it more concretely, let's put 푓푓 = 3:
1
√2^3

#### ∑^2 푥푥=0^3 −1(−1)푓푓(푥푥)|푥푥⟩⊗�|^0 ⟩

#### √^2 −

| 1 ⟩
√^2 �.
This becomes:
1
√2^3 ((−1)

#### 푓푓( 0 )|000⟩ + (−1)푓푓( 1 )|001⟩ + (−1)푓푓( 2 )|010⟩ + (−1)푓푓( 3 )|011⟩ +

#### (−1)푓푓(^4 )|100⟩ + (−1)푓푓(^5 )|101⟩ + (−1)푓푓(^6 )|110⟩ + (−1)푓푓(^7 )|111⟩) ⊗�

```
| 0 ⟩
√^2 −
```
| 1 ⟩
√^2 �^
.
Apply H gate on all the qubits except on the last one:
1
√2^3 ((−^1 )

#### 푓푓( 0 )�|^0 ⟩

#### √ 2 +

```
| 1 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 +
```
```
| 1 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 +
```
```
| 1 ⟩
√ 2 � + (−1)
```
#### 푓푓( 1 )�|^0 ⟩

#### √ 2 +

```
| 1 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 +
```
```
| 1 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 −
| 1 ⟩
√ 2 � + (−1)
```
#### 푓푓( 2 )�|^0 ⟩

#### √ 2 +

```
| 1 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 −
```
```
| 1 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 +
```
```
| 1 ⟩
√ 2 � + (−1)
```
#### 푓푓( 3 )�|^0 ⟩

#### √ 2 +

```
| 1 ⟩
√ 2 ��
```
```
| 0 ⟩
√ 2 −
| 1 ⟩
√^2 ��
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 � + (−1)
```
#### 푓푓( 4 )�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 ��
```
```
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 ��
```
```
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 � + (−1)
```
#### 푓푓( 5 )�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 ��
```
```
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 ��
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 � + (−1)
```
#### 푓푓( 6 )�|^0 ⟩

#### √^2 −

```
| 1 ⟩
√^2 ��
```
```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 ��
```
```
| 0 ⟩
√^2 +
```
```
| 1 ⟩
√^2 � +
(−1)푓푓(^7 )�|√^02 ⟩−|√^12 ⟩��|√^02 ⟩−|√^12 ⟩��|√^02 ⟩−|√^12 ⟩� ) ⊗�|√^02 ⟩−|√^12 ⟩�
```
```
=
```
#### 1

#### √ 23

#### ×

#### ((− 1 )푓푓(^0 )�

```
1
√2^3 (| 000
```
#### ⟩ + | 001 ⟩ + | 010 ⟩ + | 011 ⟩ + | 100 ⟩ + | 101 ⟩ + | 110 ⟩ +

#### | 111⟩)�

#### + (− 1 )푓푓(^1 )�√2^13 (| 000⟩− | 001⟩ + | 010 ⟩− | 011⟩ + | 100 ⟩− | 101⟩ + | 110 ⟩−

#### | 111⟩)�

#### + (− 1 )푓푓(^2 )�√2^13 (| 000⟩ + | 001 ⟩− | 010⟩− | 011⟩ + | 100 ⟩ + | 101 ⟩− |110⟩−

#### | 111⟩)�

#### + (− 1 )푓푓(^3 )�

```
1
√2^3 (| 000⟩− | 001⟩− | 010⟩ + |^011 ⟩ + |^100 ⟩− | 101⟩− | 110⟩ +
| 111⟩)�
+ (− 1 )푓푓(^4 )�
1
√2^3 (| 000
```
#### ⟩ + | 001 ⟩ + | 010 ⟩ + | 011 ⟩− | 100⟩− | 101⟩− | 110⟩−

#### | 111⟩)�

#### + (− 1 )푓푓(^5 )�√2^13 (| 000⟩− | 001⟩ + | 010 ⟩− | 011⟩− | 100⟩ + | 101 ⟩− | 110⟩ +

#### | 111⟩)�

#### + (− 1 )푓푓(^6 )�√2^13 (| 000⟩ + | 001 ⟩− | 010⟩− | 011⟩− | 100⟩− | 101⟩ + | 110 ⟩ +

#### | 111⟩)�

#### + (− 1 )푓푓(^7 )�

#### 1

#### √ 23

#### (| 000⟩− | 001⟩− | 010⟩ + | 011 ⟩− | 100⟩ + | 101 ⟩ + | 110 ⟩

#### − | 111⟩)� )

#### ⊗�

```
| 0 ⟩
√^2 −
```
```
| 1 ⟩
√^2 �^
```
After refactoring:


```
1
√ 23
```
```
(
1
√ 23
```
```
((− 1 )푓푓(^000 )+(− 1 )푓푓(^001 )+(− 1 )푓푓(^010 )+(− 1 )푓푓(^011 )+(− 1 )푓푓(^100 )+(− 1 )푓푓(^101 )
+(− 1 )푓푓(^110 )+(− 1 )푓푓(^111 ) )| 000 ⟩
+
```
```
1
√ 23
```
```
((− 1 )푓푓(^000 )−(− 1 )푓푓(^001 )+(− 1 )푓푓(^010 )−(− 1 )푓푓(^011 )+(− 1 )푓푓(^100 )−(− 1 )푓푓(^101 )
+(− 1 )푓푓(^110 )−(− 1 )푓푓(^111 ) )| 001 ⟩
+
1
√ 23
```
```
((− 1 )푓푓(^000 )+(− 1 )푓푓(^001 )−(− 1 )푓푓(^010 )−(− 1 )푓푓(^011 )+(− 1 )푓푓(^100 )+(− 1 )푓푓(^101 )
−(− 1 )푓푓(^110 )−(− 1 )푓푓(^111 ) )| 010 ⟩
+
```
```
1
√ 23
```
```
((− 1 )푓푓(^000 )−(− 1 )푓푓(^001 )−(− 1 )푓푓(^010 )+(− 1 )푓푓(^011 )+(− 1 )푓푓(^100 )−(− 1 )푓푓(^101 )
−(− 1 )푓푓(^110 )+(− 1 )푓푓(^111 ) )| 011 ⟩
+
```
```
1
√ 23
```
```
((− 1 )푓푓(^000 )+(− 1 )푓푓(^001 )+(− 1 )푓푓(^010 )+(− 1 )푓푓(^011 )−(− 1 )푓푓(^100 )−(− 1 )푓푓(^101 )
−(− 1 )푓푓(^110 )−(− 1 )푓푓(^111 ) )| 100 ⟩
+
```
```
1
√ 23
```
```
((− 1 )푓푓(^000 )−(− 1 )푓푓(^001 )+(− 1 )푓푓(^010 )−(− 1 )푓푓(^011 )−(− 1 )푓푓(^100 )+(− 1 )푓푓(^101 )
−(− 1 )푓푓(^110 )+(− 1 )푓푓(^111 ) )| 101 ⟩
+
```
```
1
√ 23
```
```
((− 1 )푓푓(^000 )+(− 1 )푓푓(^001 )−(− 1 )푓푓(^010 )−(− 1 )푓푓(^011 )−(− 1 )푓푓(^100 )−(− 1 )푓푓(^101 )
+(− 1 )푓푓(^110 )+(− 1 )푓푓(^111 ) )| 110 ⟩
+
```
```
1
√ 23
```
```
((− 1 )푓푓(^000 )−(− 1 )푓푓(^001 )−(− 1 )푓푓(^010 )+(− 1 )푓푓(^011 )−(− 1 )푓푓(^100 )+(− 1 )푓푓(^101 )
+(− 1 )푓푓(^110 )−(− 1 )푓푓(^111 ) )| 111 ⟩
) ⊗�
```
```
|0⟩
√^2
```
```
−
```
```
|1⟩
√^2
```
#### �

#### =

```
1
� 23
```
```
1
� 23
```
#### ∑ �∑^2 (−1)푓푓(푥푥)(−1)푥푥.푥푥′

(^3) −1
푥푥=0 �|푥푥′⟩
23 −1
푦푦=0 ⊗�
| 0 ⟩
√^2 −
| 1 ⟩
√^2 �,
where 푥푥.푦푦= 푥푥 0 푥푥′ 0 ⨁ 푥푥 1 푥푥′ 1 ⨁ 푥푥 2 푥푥′ 2.
This becomes:
1
23 ∑ �∑ (−1)

#### 23 − 1 푓푓(푥푥)(−1)푥푥.푥푥′

#### 푥푥=0 �|푥푥′⟩

```
23 − 1
푦푦=0 ⊗�
```
```
|0⟩
√ 2 −
```
```
|1⟩
√ 2 �.
```
In this state of the system, what is the probability of getting |000⟩ when we measure the first three qubits?
We can obtain this by putting 푥푥′= 0 (i.e : | 000⟩)

#### �

```
1
23 ∑ (−1)
```
(^2) 푥푥=0^3 −1 푓푓(푥푥)(−1)푥푥. (^0) �^2

#### =� 213 ∑^2 (−1)푓푓(푥푥)

(^3) −1
푥푥=0 �
2
.
If 푓푓(푥푥) turns out to be _Constant_ 0, then the probability becomes:

#### � 213 ∑^21

(^3) −1
푥푥=0 �
2


#### =�

```
23
23 �
```
```
2
,
```
which is 1.

If 푓푓(푥푥) turns out to be _Constant_ 1, then the probability becomes:

```
�
1
23 ∑ −^1
```
(^2) 푥푥=0^3 −1 �^2

#### =�−^2

```
3
23 �
```
```
2
,
```
which is 1.

Hence, we have proven that, as long as the given black box is either _Constant_ 0 or _Constant_ 1,
we will always obtain | 000 ⟩ when measuring the first three qubits, i.e. Pr (| 000 ⟩) = 1.

What happens when the black box is a _Balanced_ one?

#### �

```
1
23 ∑ (−1)
```
(^2) 푥푥=0^3 −1 푓푓(푥푥)�^2.
In this equation, if 푓푓(푥푥) is _Balanced_ , half of the time (−1)푓푓(푥푥) will evaluate to 1 and the remaining half of
the time it will evaluate to -1. So the net sum will always be 0. That means Pr (| 000 ⟩) = 0, which implies
that we will never get 0 = | 000 ⟩ if the given black box is a _Balanced_ one.
In summary, we have proven that after executing the Deutsch-Jozsa algorithm circuit and
measuring the first three qubits (or 푓푓-qubits in the generic case), if we get |000⟩, we conclude that the
given black box is a _Constant_ one ( _Constant_ 0 or _Constant_ 1); if we get any other value, we conclude that
the given black box is one of the _Balanced_ ones.

### Q# exercise: Deutsch-Josza algorithm

1. Go to QuantumComputingViaQSharpSolution introduced in session 1.1.
2. Open 26_Demo Deutsch_Josza Algorithm Operation.qs in Visual Studio (Code).
3. Similar to Deutsch's algorithm, the black boxes are defined at the bottom of the script, starting
    from line 56, just as how we constructed the circuit diagrams.



4. Lines 95 – 151 define other random _Balanced_ black boxes. Try putting one in line 26 to see and
    run the script. You should be getting expected outputs.
5. More Deutsch-Josza Algorithm exercise can be found on Quantum Katas.
6. In Visual Studio (Code) open folder "DeutschJoszaAlgorithm" and Task.qs. Or use the Jupyter
    Notebook. Go to Part II tasks.
7. As will be used in many of the algorithms, to apply H gate to each qubit input register, we can
    simply use
    ApplyToEach(H, x);
