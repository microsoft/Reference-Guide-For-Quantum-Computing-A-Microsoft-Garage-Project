## 2.5 Simon's Algorithm

* [Q# exercise: Grover's algorithm]()

Simon's algorithm was conceived by Daniel Simon in 1994. The problem it solves is a specific one that
does not have any known practical value, but the quantum algorithm solution is exponentially faster than
any known classical solution. Simon's problem is this: There is a black box function with input 푥푥 and
output function 푓푓(푥푥), and there are values of 푥푥 that give the same 푓푓(푥푥). This happens specifically
according to a value 푝푝 such that the value of 푓푓(푥푥) is the same for 푥푥 and 푥푥⨁푝푝. That is, when 푝푝 is not 0,
two inputs corresponding to any one given output have bitwise XOR equal to _s_. When _s_ is zero, the inputs
correspond to unique outputs. Find the value 푝푝. Although Simon's algorithm by itself has little practical
value, it inspired future development for the Shor's algorithm in the next session.

```
Let's say we are given a black box that implements the following function:
```
```
풙풙 풚풚=풇풇(풙풙)
0000 0000
0001 0001
0010 0010
0011 0011
0100 0100
0101 0101
0110 0110
0111 0111
1000 0010
1001 0011
1010 0000
1011 0001
1100 0110
1101 0111
1110 0100
1111 0101
Table 2.5.1
```
As one can see, it is a 2-to-1 function (that is, two inputs map to the same output). The value of 푦푦 is the
same for 푥푥 and 푥푥⨁푝푝 (here 푝푝= 1010 ). Since it's a black box, we don't know the contents of this table and
value of 푝푝 beforehand; but we are free to execute this black box any number of times for different inputs
and check the outputs. Now, the problem is to identify the value of 푝푝. The direct way to solve this problem
is to start executing the black box with inputs 0000, 0001 and so on and the moment we see a repeated
output, we can do an ⨁ between the input strings that gave the same output and we will get the answer.
In this example, if we start from the beginning, the first repeated output is 0010 and from the inputs 0010
and 1000. We can calculate 푝푝= 0010 ⨁ 1000 = 1010. You can check that, for every 푥푥, the output will
be the same as that of the input 푥푥 ⨁푝푝 (푝푝= 1010 in this example).

However, if we tried executing the black box for all the inputs and we didn't get any repeated
outputs, it means that the black box that was given was a 1-to-1 function and 푝푝= 0000. The table looks
as follows:


#### 풙풙 풚풚=풇풇(풙풙)

#### 0000 0000

#### 0001 0001

#### 0010 0010

#### 0011 0011

#### 0100 0100

#### 0101 0101

#### 0110 0110

#### 0111 0111

#### 1000 1000

#### 1001 1001

#### 1010 1010

#### 1011 1011

#### 1100 1100

#### 1101 1101

#### 1110 1110

#### 1111 1111

```
Table 2.5.2
```
In this example, we have 푦푦=푓푓(푥푥)=푥푥; this needs not be the case always. we can have 푝푝= 0000 for a
different combination of inputs and outputs so long as there are no repetitions, i.e. for any 1-to-1 function.

Given any such 1-to-1 or 2-to-1 black box, we need to at maximum execute the given black box
for at most once more than half of the total number of possible input combinations to get a repetition.
The upper bound complexity will be trivially 퐶퐶(2푔푔). If we don't get a repetition even after that, we can
safely assume that 푝푝= 0000. Also, in the best-case scenario we might get a repetition just after two
iterations.

Let's consider a case where we are not that lucky. If 푓푓, is the number of bits, then the total number
of possible values of 푝푝 will be 2 푔푔. Let's say we execute the black box four times for the first four inputs,
e.g. the black box for 0000, 0001, 0010, 0011, and we don't find any repeated outputs. This means 푝푝 is
not an ⨁ between any 2 of these inputs. How many ways can we choose two values out of four? The
answer is 퐶퐶 24. This is a common formula in Permutations and Combinations, and you can find the proof
easily online. Following are the 6 possible combinations arising form 4 inputs:

```
0000 ⨁ 0001 = 0001
```
```
0000 ⨁ 0010 = 0010
```
```
0000 ⨁ 0011 = 0011
```
```
0001 ⨁ 0010 = 0011
```
```
0001 ⨁ 0011 = 0010
```
```
0010 ⨁ 0011 = 0001
```

As you can see, there are some repetitions. So the number 퐶퐶 24 will only give us the upper bound
of the number of eliminated possibilities rather than the exact number. Now, let's say 푞푞 is the number of
queries needed to cover 2 푔푔 possible values of 푝푝, then the following condition will be true:

```
퐶퐶 2 푞푞≥ 2 푔푔,
```
which can be expanded as

```
푞푞(푞푞−1)
2 ≥^2
```
#### 푔푔,

which can be written as

```
푞푞 ≳ 2 푔푔/^2.
```
Remember that this is Ω� 2 푔푔/^2 �, not 퐶퐶(2푔푔/^2 ), the best-case scenario (but it is not exactly the best case, as
the best case needs only 2 iterations; here we are calculating the lower-bound to eliminate all possible
values of 푝푝 to gain some further insight on the complexity). So, this is the lower bound complexity rather
than the upper bound complexity.

```
Math insert – complexity evaluation --------------------------------------------------------------------
```
```
Now, to gain some further insights, let's try to calculate the complexity using probability. We will
try to find the probability of getting a repetition at the 푘푘푡푡ℎ iteration. Since we are looking for
repetitions, we are considering the case when 푝푝≠ 0000. So, the initial total number of possible
values for 푝푝 will be 2 푔푔− 1.
```
```
We will use the following colored cells to visually represent the lists and indicate which
entry we are talking with the color code. After completing 푘푘− 1 iterations, we must have
eliminated at most (푘푘−1)(푘푘−2)/2 possible values of 푝푝 ( as deducted above in the previous
paragraphs):
```
```
풙풙 (Black box evaluated
for 푘푘− 1 values of 푥푥;
푘푘− 푑푑 1 푟푟푅푅 푏푏푓푓푥푥푅푅푝푝)
```
```
Eliminated possibilities
for 풔풔 (after 푘푘−
1 iterations; at most
(푘푘−1)(푘푘−2)/2;
marked in brown boxes)
```
```
Left over possibilities for 풔풔
(
2 푔푔− 1 −(푘푘−1)(푘푘−
2)/2; marked in green)
```
```
0000...000 0000...000
0000...001 0000...001
```
#### .... ...


#### 1111...111 1111...111

Since 푝푝 can have 2 푔푔− 1 total possible values, and because after 푘푘− 1 iterations we have
eliminated at most (푘푘−1)(푘푘−2)/2 possible values, the remaining possible values will be at
least:
2 푔푔− 1 −(푘푘−1)(푘푘−2)/2.

Now, in the 푘푘푡푡ℎ iteration (evaluating the blue cell), what is the probability that the output
will be the same as the box marked in yellow? It will be at most:

```
1
2 푛푛−1−(푘푘−1)(푘푘−2)/ 2.
```
Because, out of the green ones (remaining possibilities for 푝푝), at least one will be the same as
the yellow one. So, the above equation calculates the probability that the blue cell repeats the
yellow cell.

Now, what is the probability that there is a repetition with one of the red cells? It will be at
most (simple probability addition rule; add the above probability 푘푘− 1 times):

```
푘푘−1
2 푛푛−1−(푘푘−1)(푘푘−2)/ 2.
```
And calculating the upper bound of the above expression by ignoring the lower order terms
gives:
푘푘−1
2 푛푛−1−(푘푘−1)(푘푘−2)/ 2 ≤^

```
2푘푘
2 푛푛+1−푘푘^2.
```
This is the probability of getting a repetition on the 푘푘푡푡ℎ iteration. Now, let's say we have
executed 퐼퐼 iterations, this is the probability that we get a repetition for at least one of these
iterations:

#### �

#### 2 푘푘

#### 2 푔푔+1−푘푘^2

```
푚푚
```
```
푘푘=1
```
#### ,

and getting the upper bound by using 퐼퐼 in all the terms:

#### �

#### 2 푘푘

#### 2 푔푔+1−푘푘^2

```
푚푚
```
```
푘푘=1
```
#### ≤ �

#### 2 퐼퐼

#### 2 푔푔+1−퐼퐼^2

```
푚푚
```
```
푘푘=1
```
#### ,

getting the upper bound of the sum (hint: sum of first 퐼퐼 numbers = 퐼퐼(퐼퐼+ 1)/2):

#### �

#### 2 퐼퐼

#### 2 푔푔+1−퐼퐼^2

#### ≤

```
푚푚
```
```
푘푘= 1
```
#### 2 퐼퐼^2

#### 2 푔푔+1−퐼퐼^2

#### .


And if you want this probability to be at least
3
4 , then^

```
2 퐼퐼^2
2 푔푔+1−퐼퐼^2
```
#### ≥

#### 3

#### 4

#### ,

which becomes:

```
퐼퐼≥�
```
#### 6

#### 11

#### 2 푔푔.

Here, we again get 퐼퐼=Ω� 2 푔푔/^2 �. This the lower bound of iterations needed to get an answer

with probability higher than^34. Remember that this is Ω and not 퐶퐶.

The Simon's algorithm is represented by this circuit with 푈푈푓푓 being a black box.

```
Fig. 2.5.1
```
```
Math insert – test Simon's algorithm ------------------------------------------------------------------
```
If we consider 푓푓= 3, the initial state is

```
|000⟩⊗ | 000⟩.
```
H gates are applied on the first three qubits (refer to previous algorithms):

#### 1

#### √ 23

#### �(|푥푥⟩

```
23 −1
```
```
푥푥=0
```
#### ⊗ | 000 ⟩).

Now, apply the black box:

```
1
√ 23
```
#### �(|푥푥⟩

```
23 −1
```
```
푥푥=0
```
#### ⊗ |푓푓(푥푥)⟩).


Expending this:

```
1
```
√ 23

#### (| 000 ⟩⊗ |푓푓( 000 )⟩ + | 001 ⟩⊗ |푓푓( 001 )⟩ + | 010 ⟩⊗ |푓푓( 010 )⟩ + | 011 ⟩⊗ |푓푓( 011 )⟩ +

#### |100⟩⊗ |푓푓( 100 )⟩ + | 101 ⟩⊗ |푓푓( 101 )⟩ + | 110 ⟩⊗ |푓푓( 110 )⟩ + | 111 ⟩⊗ |푓푓( 111 )⟩).

Apply H gates on the first three qubits again:

```
1
√ 23
```
#### (�

#### |0⟩

#### √^2

#### +

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### +

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### +

#### |1⟩

#### √^2

#### � ⊗ |푓푓( 000 )⟩

#### + �

#### |0⟩

#### √ 2

#### +

#### |1⟩

#### √ 2

#### ��

#### |0⟩

#### √ 2

#### +

#### |1⟩

#### √ 2

#### ��

#### |0⟩

#### √ 2

#### −

#### |1⟩

#### √ 2

#### � ⊗|푓푓( 001 )⟩

#### + �

#### |0⟩

#### √^2

#### +

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### −

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### +

#### |1⟩

#### √^2

#### �⊗|푓푓( 010 )⟩

#### + �

#### |0⟩

#### √^2

#### +

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### −

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### −

#### |1⟩

#### √^2

#### �⊗ |푓푓( 011 )⟩

#### + �

#### |0⟩

#### √ 2

#### −

#### |1⟩

#### √ 2

#### ��

#### |0⟩

#### √ 2

#### +

#### |1⟩

#### √ 2

#### ��

#### |0⟩

#### √ 2

#### +

#### |1⟩

#### √ 2

#### � ⊗ |푓푓( 100 )⟩

#### + �

#### |0⟩

#### √^2

#### −

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### +

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### −

#### |1⟩

#### √^2

#### �⊗ |푓푓( 101 )⟩

#### + �

#### |0⟩

#### √^2

#### −

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### −

#### |1⟩

#### √^2

#### ��

#### |0⟩

#### √^2

#### +

#### |1⟩

#### √^2

#### � ⊗ |푓푓( 110 )⟩

#### + �

#### |0⟩

#### √ 2

#### −

#### |1⟩

#### √ 2

#### ��

#### |0⟩

#### √ 2

#### −

#### |1⟩

#### √ 2

#### ��

#### |0⟩

#### √ 2

#### −

#### |1⟩

#### √ 2

#### �⊗ |푓푓( 111 )⟩ ).

Expanding:

```
1
√ 23
```
#### (�

#### 1

#### √ 23

#### (| 000⟩⊗ |푓푓(000)⟩ + | 001 ⟩⊗ |푓푓(000)⟩ + | 010 ⟩⊗ |푓푓(000)⟩ + | 011 ⟩

#### ⊗ |푓푓(000)⟩ + | 100 ⟩⊗ |푓푓(000)⟩ + | 101 ⟩ ⊗ |푓푓(000)⟩+ | 110 ⟩

#### ⊗ |푓푓(000)⟩ + | 111 ⟩⊗ |푓푓(000)⟩)�

#### + �

#### 1

#### √ 23

#### (| 000⟩⊗|푓푓(001)⟩− | 001⟩⊗|푓푓(001)⟩ + | 010 ⟩⊗|푓푓(001)⟩− | 011⟩⊗|푓푓(001)⟩

#### + | 100 ⟩⊗|푓푓(001)⟩− | 101⟩⊗|푓푓(001)⟩ + | 110 ⟩⊗|푓푓(001)⟩− | 111⟩

#### ⊗|푓푓(001)⟩)�

#### + �

#### 1

#### √ 23

#### (| 000⟩⊗|푓푓(010)⟩ + | 001 ⟩⊗|푓푓(010)⟩− | 010⟩⊗|푓푓(010)⟩− | 011⟩

#### ⊗|푓푓(010)⟩ + | 100 ⟩⊗|푓푓(010)⟩ + | 101 ⟩⊗|푓푓(010)⟩− | 110⟩⊗|푓푓(010)⟩

#### − | 111⟩⊗|푓푓(010)⟩)�

#### + �

#### 1

#### √ 23

#### (| 000⟩⊗ |푓푓(011)⟩− | 001⟩⊗ |푓푓(011)⟩− | 010⟩⊗ |푓푓(011)⟩ + | 011 ⟩

#### ⊗ |푓푓(011)⟩ + | 100 ⟩⊗ |푓푓(011)⟩− | 101⟩⊗ |푓푓(011)⟩− | 110⟩

#### ⊗ |푓푓(011)⟩ + | 111 ⟩⊗ |푓푓(011)⟩)�


#### + �

#### 1

#### √ 23

#### (| 000⟩⊗ |푓푓(100)⟩ + | 001 ⟩⊗ |푓푓(100)⟩ + | 010 ⟩⊗ |푓푓(100)⟩ + | 011 ⟩

#### ⊗ |푓푓(100)⟩− | 100⟩⊗ |푓푓(100)⟩− | 101⟩⊗ |푓푓(100)⟩− | 110⟩

#### ⊗ |푓푓(100)⟩− | 111⟩⊗ |푓푓(100)⟩)�

#### +�

#### 1

#### √ 23

#### (| 000⟩⊗ |푓푓(101)⟩− | 001⟩⊗ |푓푓(101)⟩ + | 010 ⟩⊗ |푓푓(101)⟩− | 011⟩

#### ⊗ |푓푓(101)⟩− | 100⟩⊗ |푓푓(101)⟩ + | 101 ⟩⊗ |푓푓(101)⟩− | 110⟩

#### ⊗ |푓푓(101)⟩ + | 111 ⟩⊗ |푓푓(101)⟩)�

#### + �

#### 1

#### √ 23

#### (| 000⟩⊗ |푓푓(110)⟩ + | 001 ⟩⊗ |푓푓(110)⟩− | 010⟩⊗ |푓푓(110)⟩− | 011⟩

#### ⊗ |푓푓(110)⟩− | 100⟩⊗ |푓푓(110)⟩− | 101⟩⊗ |푓푓(110)⟩ + | 110 ⟩

#### ⊗ |푓푓(110)⟩ + | 111 ⟩⊗ |푓푓(110)⟩)�

#### + �

#### 1

#### √ 23

#### (| 000⟩⊗ |푓푓(111)⟩− | 001⟩⊗ |푓푓(111)⟩− | 010⟩⊗ |푓푓(111)⟩ + | 011 ⟩

#### ⊗ |푓푓(111)⟩− | 100⟩⊗ |푓푓(111)⟩ + | 101 ⟩⊗ |푓푓(111)⟩ + | 110 ⟩

#### ⊗ |푓푓(111)⟩− | 111⟩⊗ |푓푓(111)⟩)� ).

Refactoring as:
1
√ 23

#### (

#### 1

#### √ 23

#### |000⟩⊗(|푓푓(000)⟩+ |푓푓(001)⟩+ |푓푓(010)⟩+ |푓푓(011)⟩+ |푓푓(100)⟩+ |푓푓(101)⟩

#### + |푓푓(110)⟩+ |푓푓(111)⟩)

#### +

#### 1

#### √ 23

#### |001⟩⊗(|푓푓( 000 )⟩−|푓푓( 001 )⟩+ |푓푓( 010 )⟩−|푓푓( 011 )⟩+ |푓푓( 100 )⟩−|푓푓( 101 )⟩

#### + |푓푓( 110 )⟩−|푓푓(111)⟩)

#### +

#### 1

#### √ 23

#### |010⟩⊗(|푓푓( 000 )⟩+ |푓푓( 001 )⟩−|푓푓( 010 )⟩−|푓푓( 011 )⟩+ |푓푓( 100 )⟩+ |푓푓( 101 )⟩

#### −|푓푓( 110 )⟩−|푓푓(111)⟩)

#### +

#### 1

#### √ 23

#### |011⟩⊗(|푓푓( 000 )⟩−|푓푓( 001 )⟩−|푓푓( 010 )⟩+ |푓푓( 011 )⟩+ |푓푓( 100 )⟩−|푓푓( 101 )⟩

#### −|푓푓(110)⟩+ |푓푓(111)⟩)

#### +

#### 1

#### √ 23

#### |100⟩⊗(|푓푓( 000 )⟩+ |푓푓( 001 )⟩+ |푓푓( 010 )⟩+ |푓푓( 011 )⟩−|푓푓( 100 )⟩−|푓푓( 101 )⟩

#### −|푓푓( 110 )⟩−|푓푓(111)⟩)

#### +

#### 1

#### √ 23

#### |101⟩⊗(|푓푓( 000 )⟩−|푓푓( 001 )⟩+ |푓푓( 010 )⟩−|푓푓( 011 )⟩−|푓푓( 100 )⟩+ |푓푓( 101 )⟩

#### −|푓푓(110)⟩+ |푓푓(111)⟩)

#### +

#### 1

#### √ 23

#### |110⟩⊗(|푓푓( 000 )⟩+ |푓푓( 001 )⟩−|푓푓( 010 )⟩−|푓푓( 011 )⟩−|푓푓( 100 )⟩−|푓푓(101)⟩

#### + |푓푓(110)⟩+ |푓푓(111)⟩)

#### +

#### 1

#### √ 23

#### |111⟩⊗(|푓푓( 000 )⟩−|푓푓( 001 )⟩−|푓푓( 010 )⟩+ |푓푓( 011 )⟩−|푓푓( 100 )⟩+ |푓푓( 101 )⟩

#### + |푓푓( 110 )⟩−|푓푓(111)⟩)

#### ).


Which can be written as:

#### ∑ (|푦푦⟩⊗� 213 ∑^2 (−1)푥푥.푦푦

(^3) −1
푥푥=0 |푓푓(푥푥)⟩�
23 −1
푦푦=0 ) ,
where 푥푥.푦푦 = 푥푥1.푦푦1 + 푥푥2.푦푦2 + 푥푥3.푦푦 3. Also note that 푎푎⨁b⨁c⨁d =(a + b + c + d)%2 (푎푎
and 푏푏 are bits) and (−1)푥푥⨁푦푦= (−1)푥푥(−1)푦푦 if 푥푥 and 푦푦 are bits.
Now, let's calculate the probability for some state 푦푦:
�
1
23

#### �(−1)푥푥.푦푦

```
23 − 1
```
```
푥푥=0
```
```
|푓푓(푥푥)⟩�
```
```
2
.
```
Note, i f the state of a system is 푎푎0|000⟩+ 푎푎1|001⟩+ 푎푎2|100⟩+ 푎푎3|101⟩, it can be written as

```
|0⟩(푎푎 0 | 00 ⟩+ 푎푎 1 | 01 ⟩) + |1⟩(푎푎 2 | 00 ⟩+ 푎푎 3 | 01 ⟩).
```
Consider the case where 푝푝= 000. The above expression becomes (for example if 푈푈푓푓 is a
function 푓푓(푥푥) = 푥푥):

```
�
```
```
1
23
```
#### �(−1)푥푥.푦푦

```
23 − 1
```
```
푥푥=0
```
```
|푥푥⟩�
```
```
2
```
#### =�

#### 1

#### 23

#### (−1)푥푥.푦푦|000⟩+

#### 1

#### 23

#### (−1)푥푥.푦푦|001⟩+

#### 1

#### 23

#### (−1)푥푥.푦푦|010⟩+

#### 1

#### 23

#### (−1)푥푥.푦푦|011⟩

#### +

#### 1

#### 23

#### (−1)푥푥.푦푦|100⟩+

#### 1

#### 23

#### (−1)푥푥.푦푦|101⟩+

#### 1

#### 23

#### (−1)푥푥.푦푦|110⟩

#### +

#### 1

#### 23

#### (−1)푥푥.푦푦|111⟩�

```
2
.
```
The total probability of this subspace will be:

#### ( 213 (−1)푥푥.푦푦)^2 + ( 213 (−1)푥푥.푦푦)^2 + ( 213 (−1)푥푥.푦푦)^2 + ( 213 (−1)푥푥.푦푦)^2 + ( 213 (−1)푥푥.푦푦)^2 + ( 213 (−1)푥푥.푦푦)^2 +

#### ( 213 (−1)푥푥.푦푦)^2 + ( 213 (−1)푥푥.푦푦)^2 ,

which is

```
23
1
26 =
```
```
1
23
```
(for the generic case, it is 21 푛푛). The total probability will be the same even if we don't assume the

function is 푓푓(푥푥) = 푥푥, as long it is a 1-to-1 function, because only the order changes in that case
but not the final sum. Hence, for 푝푝= 000 , all the states are equally probable when we measure
the first three qubits.

```
Consider the case when 푝푝≠ 000. Let's rewrite the probability:
```

#### �

#### 1

#### 23

#### �(−1)푥푥.푦푦

```
23 −1
```
```
푥푥=0
```
#### |푓푓(푥푥)⟩�

```
2
.
```
```
This can be written as
```
```
�
```
#### 1

#### 23

#### � (((− 1 )푥푥1.푦푦+ (−1)푥푥2.푦푦)|푧푧⟩)

```
푧푧∈퐴퐴
```
#### �

```
2
```
```
with 퐴퐴 defined as the range of the function 푓푓. It is 2-to-1 function and each state is repeated
twice for two different inputs.
```
```
This can be written as (because 푥푥2 =푥푥 1 ⨁푝푝; since 푝푝= 푥푥 1 ⨁푥푥 2 ) :
```
```
�
```
```
1
23
```
#### � (((− 1 )푥푥1.푦푦+(−1)(푥푥^1 ⨁푝푝).푦푦)|푧푧⟩)

```
푧푧∈퐴퐴
```
```
�
```
```
2
.
which becomes
�
1
23
```
#### � ((− 1 )푥푥1.푦푦(1 +(−1)푦푦.푝푝)|푧푧⟩)

```
푧푧∈퐴퐴
```
```
�
```
```
2
.
```
```
If 푦푦.푝푝 is an odd number, the above expression becomes 0. This means that, if we measure the
first three qubits, we will never get a value 푦푦, such that 푦푦.푝푝 is odd. I f 푦푦.푝푝 is even, then the above
expression becomes:
```
```
�
```
#### 1

#### 23

#### � ((− 1 )푥푥1.푦푦(2)|푧푧⟩)

```
푧푧∈퐴퐴
```
#### �

```
2
,
which is
```
```
�
```
#### 1

#### 2 3−1

#### � ((− 1 )푥푥1.푦푦|푧푧⟩)

```
푧푧∈퐴퐴
```
#### �

```
2
.
```
```
It can be written as
2 3−1(
```
#### 1

#### 2 3−1

#### )^2 =

#### 1

#### 2 3−1

```
(for the generic case, it is
1
2 푛푛−1). Because we have only half of the states to sum; each state 푧푧 is
repeated twice. This means that if we measure the first three qubits, we will get only those states
where 푦푦.푝푝 = even, with equal probability.
```
Let's reiterate our findings:

1. When 푝푝= 000 , if we measure the first three qubits, we will get all the states with equal
    probability.
2. When 푝푝≠ 000 , if we measure the first three qubits, we will never get a state that satisfies 푦푦.푝푝 =
    odd and we can get any state that satisfies 푦푦.푝푝 = even with equal probability.


Let's say we execute the circuit (for 푓푓 = 4) and get the following output when we measured the first
four qubits:

```
푦푦 = 1011.
```
It means that this 푦푦 satisfies 푦푦.푝푝 = even. This means

```
푦푦0.푝푝 0 ⨁ 푦푦1.푝푝 1 ⨁ 푦푦2.푝푝 2 ⨁ 푦푦3.푝푝 3 = 0,
```
which means

```
1.푝푝 0 ⨁ 0.푝푝 1 ⨁ 1.푝푝 2 ⨁ 1.푝푝 3 = 0.
```
If we execute the circuit again and get the following output:

```
푦푦 = 1110.
```
It means

1. 푝푝 0 ⨁ 1.푝푝 1 ⨁ 1.푝푝 2 ⨁ 0.푝푝 3 = 0.

If we execute the circuit again and we get

```
푦푦 = 0110.
```
It means

0. 푝푝 0 ⨁ 1.푝푝 1 ⨁ 1.푝푝 2 ⨁ 0.푝푝 3 = 0.

By solving these three equations we can find the value of s to be 0111 and 0000.

Now, we should try to execute the black box for 0000 and 0111 (i.e. 0000 ⨁ 01 11), if we get the
same output then we can safely say that s = 0111. If the output is not the same, then we can conclude
that the black box represents and 1 to 1 function and s = 0000.

Note that though we have a 4-variable problem, we needed only three simultaneous equations,
because we know that s = 0000 will always be a solution of those equations. Another important note is
that, we should always need linearly independent equations to get a solution. For example, if we get the
following three measurements:

```
1011
```
```
1110
```
```
0101
```
the last value is nothing but 1011 ⨁ 1110. Such measurements are useless because they will not help in
finding a unique solution. So, if we have an _n_ -bit problem, we need 푓푓− 1 linearly independent equations
to solve them. We need to execute the circuit several times until we get 푓푓− 1 linearly independent values
while we measure the _n_ qubits. 0000 is linearly dependent on every value, so it is also not useful.

Let's see in more depth with an example on how to identify linearly dependent values. Say we
have the following values so far:


#### 1011

#### 1110

#### 0110

The following is the list of linearly dependent values:

Given values:

```
1011
```
```
1110
```
```
0110
```
XOR of any two values:

```
0101
```
```
1101
```
```
1000
```
XOR of any three values:

```
0011
```
Also, 0000 is linearly dependent on any value. In total we have 8 values. The generic formula is that if we
have _n_ linearly independent values, then we can make 2 푔푔 linearly dependent values out of them.

If we have an _n_ -qubit system and we have executed the black box 푓푓− 1 times, let's calculate the
probability that all of them are linearly independent (consider the case where 푝푝≠ 0 푔푔). In the first iteration
we can get any value except 0 푔푔; because it is linearly dependent on all the values. The probability of
getting 0 푔푔 is

```
1
2 푔푔−1
```
#### .

The probability of not getting it is

#### 1 −

#### 1

#### 2 푔푔−1

#### .

Say we completed 퐼퐼− 1 iterations and we have that many linearly independent values. We can make
2 푚푚−1 linearly dependent values out of them so the probability that the next value will be linearly
dependent will be 2 푚푚−1/2푔푔−1. After 푓푓− 1 iterations, the probability that all of them are linearly
independent is

```
Pr = � 1 −
1
2 푛푛−1��^1 −
```
```
2
2 푛푛−1�...�^1 −
```
```
2 푛푛−2
2 푛푛−1�.^
```
We need some advanced knowledge of a series called _q_ -series to find this value. The reader should feel
free to explore. It is more of a mathematical problem than a quantum computing problem. The output
will be around 0.288 (i.e. > ¼).


Using C# code to help evaluate:
static void Main(string[] args)
{

double n = 1000;
double product = 1.0;
for (double i = 0.0; i < n-1.0; i++)
{
double tempProduct = 1.0;
tempProduct = 1.0 - (Math.Pow(2.0, i) / Math.Pow(2.0, n-1.0));
product = product * tempProduct;
Console.WriteLine(product);
}
Console.WriteLine($"\nfinal: {product}");
Console.WriteLine("Done");
Console.ReadLine();
}

The probability of success above is ½.

For the remaining terms:

= � 1 −
1
2 n−1��^1 −

```
2
2 n−1�...�^1 −
```
```
2 n−3
2 n−1�^
```
= � 1 −
1
2 n−1��^1 −

```
2
2 n−1�...�^1 −
```
```
2 n−4
2 n−1��^1 −
```
```
2 n−3
2 n−1�^
```
Reversing the order:

� 1 −^2

```
n−3
2 n−1��^1 −
```
```
2 n−4
2 n−1�...�^1 −
```
```
2
2 n−1��^1 −
```
```
1
2 n−1�^
```
Because 1 −푎푎−푏푏 ≤ (1−푎푎)(1−푏푏) , if 0 ≤푎푎,푏푏≤1, we can write as follows:

Probability ≥� 1 −^2

```
n−3
2 n−1−
```
```
2 n−4
2 n−1...−
```
```
2
2 n−1−
```
```
1
2 n−1�^
```
≥� 1 −�^14 �(1 +^12 +^14 ... )�

#### ≥ 1 −�

```
1
4 �(2)(because the maximum value of the above series is 2)^
```
≥�
1
2 �^

So, multiplying this with the ½ we had in the last step gives

```
Probability ≥�^14 �.
```
Though this probability is slightly less than the accurate one culculation using _q_ -series, it was easier to
prove.

¼ might seem like a small probability but bear in mind that this is the probability after performing
only 푓푓− 1 iterations (increasing linearly with the number of qubits), whereas classically we might have to


do about 2

```
푛푛
```
(^2) (increasing exponentially with the number of qubits) iterations for the solution. Performing
the iterations a few times or even a few multiple times more than 푓푓− 1 will yield a solution with very
high probability.

### Q# exercise: Simon's algorithm

1. Go to QuantumComputingViaQSharpSolution introduced in session 1.1.
2. Open 27_Demo Simon's Algorithm Operation.qs in Visual Studio (Code).
3. The exercise uses 푓푓 = 4 as an example. Lines 8-43 set up the Simon's algorithm circuit as
    introduced in the session.
4. Example black boxes 0000 and 1010 are defined in lines 113-198 following the below circuits.


5. Run the script via _dotnet run_. You'll find the 20 input iterations and testing results for 0000,
    1010, 1110 and 0100.
6. More Simon's algorithm exercise can be found in Quantum Katas.
