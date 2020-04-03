## 1.6 The CHSH Game

* [Q# exercise: CHSH Game]()

The CHSH Game sheds more light on the nature of quantum entanglement and helps us understand that
entanglement really is "spooky action at a distance," as Albert Einstein called it. The CHSH Game is named
for four physicists who discovered the CSHS Inequality: John Clauser, Michael Horne, Abner Shimony, and
Richard Holt. In essence, the CHSH Game/Inequality illustrates that quantum entanglement cannot be
explained by a local hidden-variable theory. For quantum computing, this is another algorithm where we
can employ a feature of quantum mechanics to yield a solution that is more efficient than any classical
solution.

The game is played as follows:

Alice and Bob are physically separated and not allowed to communicate with one another, during
the game. (They are allowed to set a strategy together before the game begins and share entangled qubits,
however). The Referee sends a uniformly random bit 푥푥 to Alice and a uniformly random bit 푦푦 to Bob.
Then, Alice and Bob send back their respective answer bits, 푎푎 and 푏푏, based on the strategy they set ahead
of time.

Alice and Bob win the game if 푎푎⊕푏푏=푥푥∙푦푦_._ So, if either 푥푥 or 푦푦 is 0, then 푎푎 and 푏푏 should be the
same, but if 푥푥 and 푦푦 are both one, then 푎푎 and 푏푏 should be different.

If we look at the classical solution first, suppose Alice and Bob decide on a trivial strategy of always
returning 0 for both 푎푎 and 푏푏. Then, we can see that they will win at most 75% of the rounds of the game
(on average):

```
푥푥 푦푦 푥푥∙푦푦 푎푎 푏푏 푎푎⊕푏푏 result
0 0 0 0 0 0 Win
0 1 0 0 0 0 Win
1 0 0 0 0 0 Win
1 1 1 0 0 0 Loss
```

But if we dig into the classical case further, we can see that no matter what function of 푥푥 or 푦푦 that
we pick, to yield 푎푎 and 푏푏, we can't win more than 75% of the time, because of the difference between the
first three rows and the last row. What if we employ a quantum strategy, based on a shared pair of

entangled qubits that are in a Bell state |^00 ⟩+|^11 ⟩
√^2

#### ?

If 푥푥 = 0, then Alice measures her entangled qubit in the |0⟩ basis and if her measurement is |0⟩
then she returns 푎푎 = 0 and if her measurement is |1⟩ then she returns 푎푎 = 1. If 푥푥 = 1, then Alice
measures her entangled qubit in the | +⟩ basis and if her measurement is | +⟩ then she returns 푎푎 = 0
and if her measurement is |−⟩ then she returns 푎푎 = 1. If 푦푦 = 0, then Bob measures his entangled

qubit in the |푥푥⟩ basis, rotated by 휋휋 8 , and if his measurement is |휋휋 8 � then he returns 푏푏 = 0 and if his

measurement is |−휋휋 8 � then he returns 푏푏 = 1. If 푦푦 = 1, then Bob measures his entangled qubit in the

|푥푥⟩ basis, rotated by - 휋휋 8 ; and if his measurement is |−휋휋 8 � then he returns 푏푏 = 0 and if his measurement

is |
휋휋
8 � then he returns 푏푏 = 1, where |

```
휋휋
8 �=cos�
```
```
휋휋
8 �|0⟩ +sin�
```
```
휋휋
8 �|1⟩ and|−
```
```
휋휋
8 �=cos�−
```
```
휋휋
8 �|0⟩ +
```
sin�−휋휋 8 �|1⟩.

Let's take a look at how well this quantum strategy works. We can look at two different cases:
case(1) is the first three rows in the table above (where the classical 푎푎 = 푏푏 = 0 strategy wins all of the
time) and case(2) is the last row in the table, where the classical strategy loses all of the time.

Case(1):

Suppose that Alice has 푥푥 = 0 and she measures |0⟩ meaning that she will return 푎푎 = 0. So, they will
win if Bob outputs 푏푏 = 0. We know that Bob's qubit is in the |0⟩ state, because it is entangled with

Alice's which already measured |0⟩. So Bob will measure |0⟩ in a basis rotated by 휋휋 8 , and he outputs 푏푏 =

0 if he measures |휋휋 8 � and the probability that Bob does this is 푓푓푓푓푝푝^2 �휋휋 8 � ≈85%.

Case(2):

Now, Alice gets 푥푥 = 1 and measures her entangled qubit in the | +⟩ basis and suppose she gets | +⟩
meaning that she will return 푎푎 = 0. So, they will win if Bob outputs 푏푏 = 1. We know that Bob's qubit

is in the | +⟩ state, so Bob will measure | +⟩ in a basis rotated by - 휋휋 8 , because 푦푦 = 1 in this case. So, the

probability of getting |휋휋 8 � as a result of Bob's measurement is the angle between | +⟩ and |휋휋 8 � which is

푓푓푓푓푝푝^2 �
휋휋
8 �^ ≈85%^

If Alice and Bob employ the quantum strategy, their chances of winning the CHSH Game improve
by 10%, going up from 75% to 85%. Those are good odds!are 85% instead of 75%!


**CHSH Game example in Quirk**

If you open the CHSH Game example in Quirk, you will see this implementation:

The top wire is Alice's entangled qubit and the bottom wire is Bob's—which compute 푎푎 and 푏푏,
respectively. The second and the fourth wire are the Referee's qubits, 푥푥 and 푦푦, respectively. The
combination of the H gate and a measurement is a coin flip, so that is how the Referee sends random bits
to Alice and Bob. You can see that Alice's and Bob's computations don't communicate, because Alice's
and Bob's computations are carried out between the ellipses (...) on Alice's and Bob's wires and there are
no control wires linking those two wires. Finally, the controlled-Not gates after the final ellipses (...) are
how the results are scored. We see the 85% chance of winning with the Quantum solution (the classical
solution isn't represented here).

### Q# exercise: CHSH Game

There are also Q# Kata for the CHSH Game available here, for the Visual Studio/Visual Studio Code versions
and available here for the Binder Q# notebook version.

**_Further Reading_**

A Quantum computing lecture by John Watrous. A pair of lectures (here and here) by Scott Aaronson.
And an entry from the Quantum Gazette.

