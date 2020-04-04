<style TYPE="text/css">
code.has-jax {font: inherit; font-size: 100%; background: inherit; border: inherit;}
</style>
<script type="text/x-mathjax-config">
MathJax.Hub.Config({
    tex2jax: {
        inlineMath: [['$','$'], ['\\(','\\)']],
        skipTags: ['script', 'noscript', 'style', 'textarea', 'pre'] // removed 'code' entry
    }
});
MathJax.Hub.Queue(function() {
    var all = MathJax.Hub.getAllJax(), i;
    for(i = 0; i < all.length; i += 1) {
        all[i].SourceElement().parentNode.className += ' has-jax';
    }
});
</script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.4/MathJax.js?config=TeX-AMS_HTML-full"></script>


## 1.1 States

* [Vector notation]()
* [Classical bits]()
* [Quantum bits – qubits]()   
* [Superposition]()   
* [2-Norm approach]()
    * [Q# exercise: setup a Q# environment]()

### Vector notation

In physics, one describes the "condition" of a system as a "state". It may be understood as an indicator of
a system's status – is a switch "off" or "on"; is the temperature in a room "low" or "high"; is a light "red"
or "green", is a flipped coin "tail" or "head", etc. A state of a system does not necessarily need to be binary.
But these examples are chosen conveniently to be binary because historically computers are built on
binary systems. Mathematically, these states can be represented with two numbers: 0 and 1.

![Figure 1.1 states](states.png)

We denote a state with symbol | ⟩ (pronounced as "ket"; see _Physics insert - Dirac notation_ in section
1.2.4). With two numbers, one can write the two states using two [basis vectors](https://en.wikipedia.org/wiki/Basis_(linear_algebra)) as

```
|0⟩ = $\begin{bmatrix} 1 \\ 0 \end{bmatrix}$

|1⟩ = $\begin{bmatrix} 0 \\ 1 \end{bmatrix}$
```

This is the definition of |0⟩ and |1⟩ states. Note that the 0 and 1 in | ⟩ have a different meaning from the
ones in the vectors. We could give non-numerical labels to the states, such as |푎푎⟩ , |휓휓⟩, |푓푓푓푓푓푓푓푓푓푓푓푓푓푓푓푓⟩, etc.

### Classical bits

|0⟩ and |1⟩ states above are two single classical bits. We can represent multi-bit states with vectors as
well. Multi-bit states are tensor products of single bits. For example, state |00⟩ has two bits, both being


0. We obtain |00⟩ by doing a tensor product of two |0⟩ states, denoted as |0⟩⊗|0⟩ (see how to do tensor
product in _Math insert - Tensor product_ ). This yields

#### |00⟩= �^1

#### 0

#### �⊗�^1

#### 0

#### �= �

#### 1

#### 0

#### 0

#### 0

```
�. eq. (1.2)
```
Similarly,

#### |01⟩= �^1

#### 0

#### �⊗�^0

#### 1

#### �= �

#### 0

#### 1

#### 0

#### 0

```
� , eq. (1.3)
```
#### |10⟩= �^0

#### 1

#### �⊗�^1

#### 0

#### �= �

#### 0

#### 0

#### 1

#### 0

```
� , eq. (1.4)
```
```
and
```
#### |11⟩= �^0

#### 1

#### �⊗�^0

#### 1

#### �= �

#### 0

#### 0

#### 0

#### 1

```
�. eq. (1.5)
```
As can be seen, a complete set of two bits is represented with four basis vectors, each with four elements.
When a system has N bits, we will need 2N basis vectors each with 2N elements to describe it.

```
Math insert - Tensor product----------------------------------------------------------------------------
```
```
How does tensor product ⊗ work?
```
#### �

#### 푥푥 0

#### 푥푥 1 �⊗^ �

#### 푦푦 0

#### 푦푦 1 �= �

#### 푥푥 0 �

#### 푦푦 0

#### 푦푦 1 �

#### 푥푥 1 �

#### 푦푦 0

#### 푦푦 1 �

#### �= �

#### 푥푥 0 푦푦 0

#### 푥푥 0 푦푦 1

#### 푥푥 1 푦푦 0

#### 푥푥 1 푦푦 1

#### �

```
and
```

#### �

#### 푥푥 0

#### 푥푥 1 �⊗^ �

#### 푦푦 0

#### 푦푦 1 �⊗^ �

#### 푧푧 0

#### 푧푧 1 �=

#### ⎝

#### ⎜

#### ⎜

#### ⎜

#### ⎜

#### ⎛

#### 푥푥 0 푦푦 0 푧푧 0

#### 푥푥 0 푦푦 0 푧푧 1

#### 푥푥 0 푦푦 1 푧푧 0

#### 푥푥 0 푦푦 1 푧푧 1

#### 푥푥 1 푦푦 0 푧푧 0

#### 푥푥 1 푦푦 0 푧푧 1

#### 푥푥 1 푦푦 1 푧푧 0

#### 푥푥 1 푦푦 1 푧푧 1 ⎠

#### ⎟

#### ⎟

#### ⎟

#### ⎟

#### ⎞

```
and so on.
```
```
For example, the number 4 can be represented with a three-bit string 100.
We can write
```
#### |4⟩= | 100 ⟩= �^0

#### 1

#### �⊗�^1

#### 0

#### �⊗�^1

#### 0

#### �=

#### ⎝

#### ⎜

#### ⎜

#### ⎜

#### ⎜

#### ⎛

#### 0 0 0 0 1 0 0

#### 0 ⎠

#### ⎟

#### ⎟

#### ⎟

#### ⎟

#### ⎞

### Quantum bits – qubits

It turns out that |0⟩ and |1⟩ are just two special cases in quantum computing. Generally, when there is
one qubit, the system can be in a state |휓휓⟩ that has some portions of both |0⟩ and |1⟩ states in it.
Mathematically, |휓휓⟩ is a linear combination or **superposition** of |0⟩ and |1⟩, i.e.

```
|휓휓⟩ = �
```
#### 푎푎

```
푏푏�=푎푎|0⟩+ 푏푏|1⟩ , eq. (1.6)^
```
where 푎푎 and 푏푏 are two constants and can be complex numbers (see _Math insert – complex numbers_ ). 푎푎
and 푏푏 are essentially describing how much of |0⟩ and |1⟩ are in the system. They are the "weights" and in
fact amplitudes (see "wavefunction") of the |0⟩ and |1⟩ states. Their magnitude squared, |푎푎|^2 and |푏푏|^2 ,
give the probabilities of finding the system in |0⟩ and |1⟩, respectively. Therefore |푎푎|^2 and |푏푏|^2 can be
anything as long as the total probably sums up to 1, that is |푎푎|^2 + |푏푏|^2 = 1. This is referred to as the
normalization condition.


When the system has two qubits, there are four basis states the system can be in, where

```
|휓휓⟩ = �
```
#### 푎푎

#### 푏푏�⊗^ �

#### 푓푓

#### 푑푑�^

#### =�

#### 푎푎푓푓

#### 푎푎푑푑

#### 푏푏푓푓

#### 푏푏푑푑

#### �

```
=푎푎푓푓|0 0 ⟩+푎푎푑푑|0 1 ⟩+푏푏푓푓|1 0 ⟩+푏푏푑푑|1 1 ⟩. eq. (1.7)
```
The normalization condition writes as |푎푎푓푓|^2 + |푎푎푑푑|^2 + |푏푏푓푓|^2 + |푏푏푑푑|^2 = 1. With N qubits, there are 2N
possible states the system can be in.

```
Math insert – complex numbers ----------------------------------------------------------------------------------
```
```
A complex number has a linear form, 푧푧=푎푎+푏푏푓푓, where 푎푎 and 푏푏 are real numbers and
푓푓≡√− 1 is an imaginary number, so that a complex number has a real part 푅푅푅푅(푧푧) and an
imaginary part 퐼퐼퐼퐼(푧푧).
It is a mathematical convenience to ensure a square-root of a negative number to have
a solution, since there is no real-number solution. This is useful in quantum mechanics as wave
equations (below) will be easier to solve.
A complex number can also be represented in a polar form, 푧푧=푟푟푅푅푖푖푖푖, where 푟푟=
√푎푎^2 +푏푏^2 is the amplitude or the absolute value of 푧푧, and 휑휑 is the phase or argument of 푧푧. It
follows the relations 휑휑=푎푎푓푓푎푎푓푓 2 �퐼퐼퐼퐼(푧푧),푅푅푅푅(푧푧)�=tan−1�푏푏푎푎� and 푅푅푖푖푖푖=cos휑휑+푓푓sin휑휑.
A one-qubit state |휓휓⟩=푧푧 0 |0⟩+ 푧푧 1 |1⟩ can be written as
```
```
(푎푎 0 +푏푏 0 )|0⟩+ (푎푎 1 +푏푏 1 )|1⟩
```
#### = 푟푟 0 푅푅푖푖푖푖^0 |0⟩+ 푟푟 1 푅푅푖푖푖푖^1 |1⟩.


```
Therefore, the probability of finding state |0⟩ is �푟푟 0 푅푅푖푖푖푖^0 �
2
=푟푟 02. Similarly, for state |1⟩ it is 푟푟 12.
The probability is determined by the magnitude of amplitude and is independent from phase.
```
### Superposition

In math, superposition is just several functions linearly adding up as in eq. (6 & 7). Here, we are dealing
with states – one type of mathematical functions. Superposition of states is the fundamental factor that
makes quantum computing powerful. Because while a classical bit can only be in either |0⟩ or |1⟩, a qubit
can be in a state where |0⟩ and |1⟩ coexist – a complex linear combination between |0⟩ and |1⟩. Thus, if
we make a computing system that can leverage this quantum phenomenon, we can have a single qubit
that contains information where two classical bits would be needed. With N qubits, the system can
compute 2N classical bits of information.

```
Physics insert – wavefunction --------------------------------------------------------------------------
```
```
We introduced the concept of states without requiring any physics
background. However, it may be interesting for some readers to know how physics
describes a quantum system. Typically, physicists learn the subject in a chronological
order – how the field of Physics has developed through time. Because physicists were
used to classical phenomena, experimental results of quantum mechanical phenomena
appeared to be surprising when they were first observed (look up the "UV
Catastrophe", "photoelectric effect", "Compton Effect" and "interference of light at
low intensity"). Physicists in the early 1900s naturally attempted to explain the results
using classical methods.
```

These unexpected observations have led to the metaphors one often hears
about in popular science today. These metaphors tend to make quantum physics sound
mysterious and often hinder more than help one's understanding. Now that we are in
the 21st century, quantum concepts can be taught in a much more straight-forward
way, based on all the accumulated knowledge. This is the approach this tutorial takes
to teach quantum computing – giving readers direct and enough information to get
started with quantum computing while introducing historical facts from physics where
appropriate for context. This way, readers will not be confused through unnecessary
information overload but can still appreciate the thought physicists have put into
developing the field.
One of the historical approaches to describe quantum phenomena is using
wavefunctions. Physicists in the early 1900s found that quantum particles behave like
waves. This means a quantum system can be described using a wave equation - the
Schrödinger equation. Here is the Schrödinger equation for a non-relativistic particle in
an external potential:

#### −

```
ħ^2
2푚푚∇
```
(^2) 훹훹(풓풓,푓푓)+푉푉(풓풓,푓푓)훹훹(풓풓,푓푓)=푓푓ħ휕휕휕휕(풓풓,푡푡)
휕휕푡푡^ ,^
where 훹훹, called the "wavefunction," describes the state of the particle (technically,
|훹훹(푟푟,푓푓)|^2 is the probability of finding the particle at position _r_ at time _t_ ); ħ is Planck
constant (~1.05 x 10-34 Js/rad); _m_ is the mass of the quantum particle; and _V_ is an
external potential (such as an electric or gravitational field). ). In a system that doesn't
vary with time, the right-hand side of the equation equals 퐸퐸훹훹(풓풓,푓푓), with 퐸퐸 being the
energy of the system. The above equation reflects conservation of energy, as the first
and second parts on the left-hand side describe the kinetic energy and potential energy
in the system, respectively. Something that's very important to note is that in the above
equation, 훹훹(푟푟,푓푓) is a field that fills all of space and which evolves with time, which has
to do with the probability of finding the particle anywhere at a given time. This is very
different from classical mechanics, where we deal with the exact locations of particles.
Physicists have established a rigorous representation of quantum systems
using wavefunctions. However, an in-depth formalism with this approach is beyond the
scope of this tutorial and is not essential for a quantum computing introduction. Thus,
we avoid going into details of the "wave" approach but state its relevant outcomes
next.
_Physics insert – Dirac notation_ -------------------------------------------------------------------------
Manipulating wavefunctions usually involves a lot of integrals. It tends to look
messy. Paul Dirac came up with a compact and abstract notation. We've been using the
symbol | ⟩ to indicate states: |훹훹⟩ denotes "the state with wavefunction" 훹훹(풓풓,푓푓). It has
a counterpart representing its conjugate 훹훹∗(풓풓,푓푓)=⟨훹훹|. Together they form their
overlap integral or inner product defined as

#### ∫ 휙휙∗(푥푥)

```
+∞
−∞ 휓휓(푥푥)^ 푑푑푥푥≡〈휙휙|휓휓〉.
```

```
Evidently, the Dirac notation is much more concise. The inner product 〈 | 〉 is a
shorthand for an integral and is pronounced as "bracket". The symbols "bra", ⟨ | , and
"ket", | ⟩, are shorthand for wavefunctions. If 휓휓(푥푥) is normalized, 〈휓휓|휓휓〉= 1.
```
```
Physics insert – superposition --------------------------------------------------------------------------
```
```
The Schrödinger equation has a very interesting property called "linearity." If
we find two solutions 훹훹 1 and 훹훹 2 , then combinations of them are also a valid solution.
For example,
1
2 (훹훹^1 +훹훹^2 ) is a solution. For any system, physicists find a set of "basis
states", which are sufficient to fully describe the system. For example, there might be
one basis state for each position the particle can be in. But now, since the Schrödinger
equation is linear, the combination of multiple basis states is also a valid state. For
example, the combination of the states representing "particle is at position 0" and
"particle is at position 1" is valid and represents a state where the particle's position is
either 0 or 1. This is called the "superposition principle".
The superposition behavior is written as
```
```
휓휓(푥푥)=∑푖푖푓푓푖푖휙휙푖푖(푥푥) ,
```
```
where we're working in 1D (hence, x instead of r ) for simplicity. Here, 휙휙푖푖 is the i th basis
state in the system with coefficient 푓푓푖푖 being the "amplitude" of 휙휙푖푖. The amplitude
squared, |푓푓푖푖|^2 , gives the probability of the system being in the i th state, 휙휙푖푖. Any
wavefunction can be expanded in terms of the basis states, 휙휙푖푖(푥푥).
In terms of a qubit, the above equation is reflected by superposition of states,
such as in |휓휓⟩=푓푓 0 |0⟩+ 푓푓 1 |1⟩. We can see that a qubit system has only two basis
states.
To obtain the value of the coefficient of each possible basis state, one needs to
find how much overlap there is between each basis state 휙휙푗푗 and the overall state 휓휓.
```
#### ∫ 휙휙푗푗∗(푥푥)

```
+∞
−∞^ 휓휓(푥푥)푑푑푥푥= ∑푓푓푖푖푖푖 ∫ 휙휙푗푗(푥푥)
```
```
+∞ ∗
−∞^ 휙휙푖푖(푥푥)푑푑푥푥= 푓푓푗푗.
```
```
In Dirac notation, |휓휓⟩=∑푖푖푓푓푖푖|휙휙푖푖⟩ , where 푓푓푗푗=〈휙휙푗푗|휓휓〉.
```
### 2-Norm approach – an alternative way to teach and learn quantum mechanics

Now that we are in the 21st century, quantum phenomena are no longer so strange to physicists, given all
the knowledge we have accumulated from the past experiments. Perhaps there is a more straightforward
way to learn quantum mechanics, without needing to immediately think about wavefunctions. Scott


Aaronson, a theoretical computer scientist at University of Texas, uses a different approach to introduce
quantum mechanics: https://www.scottaaronson.com/democritus/lec9.html

Essentially, we can start by generalizing probability theory. In our experience, probabilities are
always positive and sum to 1. This is called the "1-norm" condition:

```
∑푝푝푖푖푖푖 = 1.
```
In quantum mechanics, we don't work directly with probabilities. Instead, we work with
"amplitudes." The square of an amplitude is a probability, so we require that _squares_ of the amplitudes
sum to 1. This is called the "2-norm" condition (where "2" refers to the fact that we're squaring the
amplitudes):

```
∑푖푖|푎푎푖푖|^2 = 1.
```
One thing to note here is that when we talk about "squaring" a number, we actually mean taking
the "modulus squared" (or the "square of the magnitude"), which is done by multiplying it by its complex
conjugate: |푎푎|^2 =푎푎∗푎푎. For a real number, taking the modulus squared and taking the square are the same
thing, but for a complex number, they're different.

Because of the 2-norm condition, an amplitude can be a positive, negative or even complex
number. In the examples earlier, we wrote the amplitudes as 푓푓푖푖. As seen in the normalization condition,
it is the square of _magnitudes_ of the amplitudes that sum to 1. Amplitudes are related to probabilities. If
we want to go from an amplitude to a probability, we take the square of the magnitude of the amplitude.
That's why the squares of the amplitudes must sum to 1.

The complex number 푓푓푖푖 can be written as 푟푟 0 푅푅푖푖푖푖^0 , with 푟푟 0 being the magnitude and 휑휑 0 the phase
(see earlier _Math insert – complex number_ ). Both 푟푟 0 and 휑휑 0 are real numbers. As we've seen in _Math
insert – complex numbers_ , probability only depends on the magnitude of the amplitude. For two
amplitudes, the normalization condition is

```
|푓푓 0 |^2 + |푓푓 1 |^2 =�푟푟 0 푅푅푖푖푖푖^0 �
2
+�푟푟 1 푅푅푖푖푖푖^1 �
2
=푟푟 02 +푟푟 12 = 1.
```
This alternative quantum mechanics introduction bypasses wavefunction derivations. It puts up
front that the universe behaves according to the 2-norm condition with a set of axioms. This allows us to
see some fundamental quantum mechanical behaviors without dealing with more complicated systems,
such as particles in an external potential. This is a useful fact when we talk about **measurements** in the
next session.

```
To read more rigorous mathematical derivations of the axioms in modern quantum theory:
```
- https://arxiv.org/abs/quant-ph/
- https://arxiv.org/abs/1011.
- https://arxiv.org/abs/quant-ph/

### Q# exercise: setup a Q# environment


Q# is a domain-specific programming language, developed by Microsoft, used for expressing quantum
algorithms. We will be using it to gain hands-on experience programming quantum computers. There are
several ways to exercise programming in Q#. The Microsoft Quantum Development Kit provides several
open-source options. In this tutorial book, we will be choosing exercises developed on VS Code, Jupyter
Notebooks and other tools. At the end of each session, we will familiarize ourselves by using a couple of
these tools and hands-on coding. (The goal of the below exercise is to set up the environment and to take
note of the katas, rather than to run a Q# program at the moment.)

1. Install and validate Quantum Development Kit (choose between Visual Studio or Visual Studio
    Code) according to the instructions
2. Download and clone Microsoft Quantum Developer Kit Samples and Libraries
3. Download QuantumComputingViaQSharpSolution developed by Pavan Kumar at The Garage –
    India
4. Look at the first script in 01_HelloQuantumWorld Operation.qs in Visual Studio (Code).
5. Take a look at the Quantum Katas developed on Jupyter Notebook. We will choose from these
    katas after learning the concepts at each session. You can run the katas online as a Jupyter
    Notebook. If you wish to run them locally, follow the instructions on the section labeled
    'Running the Katas Locally' to clone the repository onto your computer.

