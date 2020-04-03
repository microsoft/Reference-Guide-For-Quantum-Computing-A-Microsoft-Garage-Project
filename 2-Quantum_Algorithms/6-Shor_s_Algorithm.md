## 2.6 Shor's Algorithm

Shor's algorithm was invented by Peter Shor in 1994 as a quantum computing algorithm to efficiently find
prime factors of an integer. It is an important algorithm because the current widely used RSA cryptography
scheme relies on the fact that large integers take unfeasible amount of time to factor on classical
computers. With Shor's algorithm implemented when quantum computers are ready, existing
cryptography will be broken.

Let's say there are two large prime numbers 푝푝 and 푞푞. You are given the product of them 푝푝.푞푞, not
the individual 푝푝 and 푞푞. If 푝푝.푞푞 is a small number, you can calculate possible values of 푝푝 and 푞푞. But if the
product is large, there is no classical algorithm invented so far to give the components 푝푝 and 푞푞 in
polynomial time. That is, if we try to factor a 2048 bit number which is a product of two large prime
numbers, it will take more than the age of the universe even if you use the fastest supercomputer.
However, using the Shor's algorithm, we can do it within in a few hours provided we have a quantum
computer with a few thousand qubits.

To demonstrate this algorithm, let's take 퐶퐶= 35 as the number we want to factorize, and we
want to know 푝푝 and 푞푞 that this 퐶퐶 is composed of.

**Step 1:**

Pick a random number 푎푎 between 2 and 퐶퐶− 1 and take the greatest common denominator (GCD) with
퐶퐶. We need to remember that GCD of large numbers can be found in polynomial time using Euclidean
algorithm. If the GCD does not equal to 1 (GCD != 1), then we can say that the GCD is one of the factor
and we find the solution. For example, if we had chosen 푎푎 = 10 , then GCD (10, 35) = 5. Since it is not


equal to 1, then 5 must be the factor. However, the probability of finding this random number to be the
solution is extremely low. If we took 푎푎 = 3, then GCD (3,35) = 1, i.e. 푎푎 and 퐶퐶 are co-primes.

**Step 2:**

Find some number 푄푄 = 2 푞푞 such that 푄푄 is the first power of 2 greater than or equal to 퐶퐶^2. In this example
퐶퐶^2 = 352 = 1225; so 푄푄 = 2048 and 푞푞 = 11.

**Step 3:**

Evaluate the expression 푎푎푥푥푀푀 푓푓푑푑 퐶퐶 for all 푥푥 ranging from 0 to 푄푄− 1.

```
풙풙 3 푥푥푀푀푓푓푑푑 35
0 1
1 3
2 9
3 27
4 11
5 33
6 29
7 17
8 16
9 13
10 4
11 12
12 1
13 3
14 9
15 27
16 11
17 33
18 29
19 17
20 16
21 13
22 4
23 12
24 1
25 3
26 9
```
..
..
..
2047 17
_Table 2.6.1_

**Step 4:**


As you can see in Step 3, the period, 푟푟, is 12 in this case.

**Step 5:**

We observe the following:

```
푎푎^0 푀푀푓푓푑푑 퐶퐶 = 30 푀푀 푓푓푑푑 35 = 푎푎푔푔푀푀푓푓푑푑 퐶퐶 = 312 푀푀 푓푓푑푑 35 = 1,
```
which means that 푎푎푔푔 is the first non-zero number when divided by 퐶퐶 gives the reminder 1. We can say
that 푎푎푔푔- 1 will be divisible by 퐶퐶. This is written as 퐶퐶 | 푎푎푔푔- 1 (read as 퐶퐶 divides 푎푎푔푔- 1). If r is even, then we
can rewrite it as follows:

```
퐶퐶 | 푎푎푔푔- 12
```
```
퐶퐶 | (푎푎푔푔/^2 )^2 - 12
```
```
퐶퐶 | (푎푎푔푔/^2 - 1) (푎푎푔푔/^2 + 1) ( because 푎푎^2 − 푏푏^2 = (푎푎−푏푏)(푎푎+푏푏) ).
```
If 푟푟 turns out to be odd, then we need to repeat Step 1 by picking another 푎푎. Also, if 퐶퐶 | (푎푎푔푔/^2 + 1), we
need to discard 푟푟 and repeat Step 1. It will be clear soon why we need to do these.

In addition, we clearly know that 퐶퐶 | (푎푎푔푔/^2 - 1) will never be the case because 푟푟 is the smallest
number with the property 퐶퐶 | (푎푎푔푔- 1) by definition.

Now that we have established that 퐶퐶 | (푎푎푔푔/^2 - 1) (푎푎푔푔/^2 + 1) but is not divisible with either of the
terms separately, it can only mean that one of the factor, 푝푝, divides (푎푎푔푔/^2 - 1) and another factor, 푞푞, divides
(푎푎푔푔/^2 + 1).

```
So, p will be a common divisor of 퐶퐶 and (푎푎푔푔/^2 - 1), and q will be a common divisor of 퐶퐶 and (푎푎푔푔/^2 +
```
1). To get the values of 푝푝 and 푞푞, we simply need to find GCD( _N_ , (푎푎푔푔/^2 - 1)) to get _p_ and find GCD( _N_ , (푎푎푔푔/^2 +
1)) to get 푞푞.

```
In our example, since 푟푟 = 12 and 퐶퐶 = 35 ;
```
```
then 푎푎푔푔/^2 - 1 = 312 /^2 - 1 = 728
```
```
and 푎푎푔푔/^2 + 1 = 312 /^2 + 1 = 730.
```
```
Therefore, 푝푝 = GCD(35, 728) = 7
```
```
and 푞푞 = GCD(35, 730) = 5.
```
If you have read all the steps carefully, you will find that Step 3 is the elephant in the room. Since
in real world scenarios, _N_ will be so large that it is impossible to calculate 푎푎푥푥푀푀 푓푓푑푑 퐶퐶 for 푥푥 ranging from 0
to _Q_ -1 without waiting for billions of years even with the most powerful supercomputers. This is where
quantum computers will come to our rescue.


We have a quantum circuit that calculates 푎푎푥푥푀푀 푓푓푑푑 퐶퐶 for any given 푥푥. Though it is not easy to
create such a circuit, it is possible because we know that any classical circuit can be converted to a
quantum circuit using Toffoli gates. Instead of inputting each value of 푥푥 separately, we will give all the
possible values of 푥푥 to the circuit by taking 푞푞 qubits and applying H gates on all of them. The input 푞푞 qubits
will be in an equal superposition of |0⟩ to |푄푄− 1 ⟩. The bottom output qubits will be in a superposition of
all the possible outputs |푎푎^0 푀푀푓푓푑푑 퐶퐶⟩ to |푎푎푄푄−1 푀푀푓푓푑푑 퐶퐶⟩.

```
The system will be something like this (ignoring the normalization coefficients):
```
```
|0⟩|푎푎^0 푀푀푓푓푑푑 퐶퐶⟩ + |1⟩|푎푎^1 푀푀푓푓푑푑 퐶퐶⟩ + |2⟩|푎푎^2 푀푀푓푓푑푑 퐶퐶⟩ ... |Q− 1 ⟩|푎푎푄푄−1 푀푀푓푓푑푑 퐶퐶⟩.
```
Note that for multiple input qubit states there will be a common output state because 푎푎푥푥 푀푀푓푓푑푑 퐶퐶 is a
many-to-one function. Now, if we go ahead and measure the output qubits, out of several superimposed
outputs, only one of it will be obtained. Also, the input states will be affected in such a way that only those
states that could result in the measured output can remain. The probabilities of all the other states will
become zero.

From Table 5.1, we can conclude that all the states that will be present in the input qubits will be
separated by 푟푟. You must have noticed that we are closer to getting the answer because all we need is 푟푟
and we executed the circuit only once (exponential improvement must be obvious by now). But measuring
the 푞푞 qubits will not help much because we don't have any pattern yet to exploit. Moreover, the first
residue state might not be 0 and could be anything (called offset).

Next, we do something called Inverse quantum Fourier Transform (QFT), it does the following:

1. It removes the offset and gives some probability for state 0
2. It changes the period between the states from 푟푟 to 푄푄/푟푟

Now, if we measure the input 푞푞 qubits we are sure that we will get some multiple of 푄푄/푟푟 say 퐿퐿 ∗ 푄푄/푟푟.
The value we measured is 푣푣, so we get the following equation:


#### 푣푣 = 퐿퐿 ∗ 푄푄/푟푟.

Rewritten as

```
푣푣/푄푄 = 퐿퐿(1/푟푟).
```
Here, we know the values of 푣푣 and 푄푄. We can divide them until we get the smallest fraction. Now, the
denominator will either be 푟푟 or a factor of 푟푟.

```
Further details on QFT and the circuit implementation can be found here:
```
https://en.wikipedia.org/wiki/Quantum_Fourier_transform

The actual circuit for the 푎푎푥푥푀푀 푓푓푑푑 퐶퐶 is beyond the scope of this book and a dedicated reader can
get some help over here:

https://arxiv.org/abs/quant-ph/0205095

