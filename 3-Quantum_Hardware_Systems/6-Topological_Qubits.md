## 3.6 Topological qubits

Different from other types of qubit systems, which rely on single electrons or single atoms (either natural
or artificial), a topological qubit is formed based on collective interactions of many electrons. Here's how
it can be set up.

Theoretically hypothesized by Ettore Majorana in 1937, the existence of an electron can be
mathematically described by a pair of symbols representing a real part and an imaginary part. Each part
is sometimes called a Majorana quasiparticle. They couple together as a pair to form an electron.


Electrons can be put in a row. This is practically achieved by using a semiconductor nanowire,
where electrons are confined in one-dimension.

The nanowire can be brought close to a superconductor. When this happens, the electromagnetic
field from the superconductor can affect the pairing of Majorana quasiparticles, exchanging their partners
with the adjacent electrons. This leaves the Majorana quasiparticles at each end of the nanowire alone.
These at the ends have a special name called "Majorana zero modes".

Now imagine the electrons can be emptied out from the nanowires. Where the Majorana
quasiparticles were, indicates the locations that are possible for electrons to occupy.


When some electrons are let into the nanowire, they will go to those locations and their Majorana
quasiparticles will pair with their neighbors. With the same number of electrons inside the nanowire,
there are two possible outcomes: the Majorana zero modes could be empty or occupied. These two
situations are respectively defined as the |0⟩ and |1⟩ states.

So, the entire system is used to define a qubit. Inside the nanowire, there can be any number of
electrons and it does not matter where they are. States |0⟩ and |1⟩ have the exact same number of
electrons in the nanowire except at the ends – they differ by only one electron. It takes a whole electron
to occupy the two Majorana zero modes. This difference of one electron can affect properties of the
nanowire, such as its conductance. These are global properties of the nanowire. Thus, by measuring a
global parameter defined by the total number of electrons of the nanowire, one could tell which state the
qubit is in.


To help enhance your understanding, let's use a metaphor to describe the system. Imagine the
nanowire is like a train and the superconductor next to it is like a train track. Inside the train, the
passengers come in pairs. All the seats are doubles. They can sit wherever they want, with their original
partners or exchange partners but they cannot sit alone. The train can have any even number of
passengers. It can run whether or not all passenger seats are occupied. The key is to have drivers. This
train has two driver seats, one on each end. It takes both driver seats to be occupied to operate. If the
driver seats on both ends are occupied, the train can run on the track in either direction. This is like
electricity can run in the nanowire, giving a conductance reading. If the driver seats are empty, the train
stays stationary. No conductivity can be observed. Looking at conductance to see if the Majorana zero
modes are occupied is like figuring out whether a train can run based on the presence or absence of its
drivers.

The measurement is not sensitive to the exact positions of the electrons. It only depends on if the
ends of the nanowire are occupied by the Majorana quasiparticle pair or not. This is the reason why it is
called a topological qubit – _local_ information about individual electrons is not needed; only _global_


parameters about the entire system are used. Therefore, a topological qubit is protected from noise
brought in from the environment that makes _local_ perturbation to the system.

_An often-used analogy: a teacup and a donut have the same topology. Locally we cannot distinguish them._

This is a much-simplified introduction to topological qubits. The actual architecture of a
topological quantum computer is complex and evolving.

```
Physics insert – quasiparticles ---------------------------------------------------------------------------
```
```
The concepts in this section require advanced graduate-level physics and mathematics,
which is beyond the general audience of this tutorial. We translate them into
illustrations instead.
```
```
The field of condensed matter physics, differing from astrophysics and particle
physics, is one that studies fundamental properties of materials. As materials are
formed by atoms, which consist of electrons and nuclei, we need to deal with
interactions between many of these microscopic particles. We have seen in the
previous inserts about conductors and superconductors, free electrons move in an ion
lattice to conduct electricity. Throughout their journey, they constantly bump into the
ions, attracted to the positively charged nuclei, repelled by other negatively charged
electrons, etc. All these happening together makes it very complicated dynamics to
handle. However, we can consider the overall experience of an electron. Its existence
is affecting all particles surrounding it. Its motion is carrying the effects with it as it
moves along. With all the collective interactions, it can approximately be described as
an unperturbed particle travelling in free space with an effective mass differing from
its original electron mass. An analogy would be a room full of people with some VIPs
entering. Everyone gathers around the VIPs and moves along with them. Effectively the
overall mass of everyone moves correlating to the VIPs. Equivalently, we can say a VIP
moves with an effective mass. Such a VIP electron and its effects placed on the entire
system is described as a "quasiparticle" or "collective excitation".
```

_Physics insert – Majorana quasiparticles_ -------------------------------------------------------------

Let's introduce a few terms before we go further:

**Fermion** (named after Enrico Fermi): a particle with spins that are integer

multiples of^12. Fermions with the same spin cannot occupy the same energy level due

to Pauli exclusion principle, following Fermi-Dirac statistics. For example, an electron is

a fermion as it has spin^12. Each energy level can accommodate a maximum of two

electrons with opposite spins.
**Boson** (named after Satyendra Nath Bose): a particle with integer spin. For
example, a photon with spin 0 is a boson. Bosons can occupy the same energy level,
following Bose-Einstein statistics.
**Anyon** (named after Jean Anyon): a quasiparticle that is neither a fermion nor
a boson. They only appear in one- or two-dimensional systems. They follow the
braiding statistics (see later).


In 1937, Ettore Majorana theoretically suggested that a neutral spin^12 particle

can be its own antiparticle. They are called Majorana fermions, in contrast to Dirac
fermions which are not their own antiparticles. Majorana fermions can appear as
quasiparticle excitations and have zero charge. They can emerge in superconducting
materials due to electron-hole symmetry, enabling the quasiparticle excitations to be
their own antiparticles. As N. Read and Dmitry Green in 2008 theoretically proved, we
can use a 2-dimentional superconductor to physically realize this mathematical
construct in actual materials. It requires a broken time-reversal symmetry, and a p-
wave superconductor. If the superconductors have defects, then the Majorana
fermions can bound to the defects, forming Majorana zero modes. The Majorana zero
modes are no longer fermions. The statistics they obey is that of non-abelian anyons.

_Physics insert – non-abelian anyons_ ------------------------------------------------------------------

There are two kinds of anyons, abelian and non-abelian. The terminology comes from
group theory, in which an abelian group obeys commutative operations. This means
that when applying a group operation to two group elements in an abelian group, the
result does not depend on the order in which the elements are written. Interchanging
two elements is effectively adding an overall phase (can be complex) to the state, which
does not have a measurable effect. A non-abelian group, however, does depend on the
order of elements. An operation on a non-abelian group needs to be a unitary matrix.
Remember our quantum gates are unitary matrices. Interchanging two non-a belian
anyons is equivalent to applying a quantum gate to the state.


P-wave superconductors are hard to find in nature. Effectively we need to
construct it using commonly found s-wave superconductors and at the interface
between them and other materials, there can be Majorana zero modes. Examples of
the other materials include topological insulators, spin-orbit coupled semiconductors,
a chain of magnetic atoms or half-metals. Alaxei Yu. Kitaev in 2000 proposed that
nanowires can be made from these materials and be placed in proximity to a
superconductor. The ends of the nanowires bind Majorana zero modes. The nanowires
mentioned in the main sections are made this way. This combination of materials is
called a topological nanowire heterostructure, which is the architecture for quantum
computing adopted by industry so far. (Read more: A short introduction to topological
quantum computation by Ville T. Lahtinen and Jiannis K. Pachos.)

In such a nanowire heterostructure, electrons in the nanowire form a chain. Each
electron possesses two Majorana fermions which can be paired differently. One
configuration has no unpaired Majorana fermions at the ends, therefore no Majorana
zero modes (trivial phase), whereas the other configuration has (topological phase).
We can practically switch between the two configurations by adjusting the chemical
potential in the nanowire. The Hamiltonian of the system has a chemical potential term
and a kinetic term. When the chemical potential term dominates, the system is in the
trivial phase; when the kinetic term dominates, the system is in the topological phase.


Gate operations on the topological qubits are through braiding. To form
Majorana zero modes, we need at least four Majorana fermions, thus two electrons.
But to braid the zero modes, we need at least three pairs of them, thus three electrons.
Physically we can apply bias voltages onto the nanowires to change chemical potentials
regionally, creating at least three sections that host pairs of Majorana zero modes.


An example architecture is a T-junction made of nanowires. By adjusting the
chemical potential regionally, braiding can be achieved in the physical material.

_Math insert – braiding statistics_ ------------------------------------------------------------------------

As we have discussed, topological quantum computing does not rely on the local
properties of the system. As we are looking at the collective behavior of multiple
anyons, in our case Majorana zero modes, we use a process called anyon fusion to
govern the interaction principle between anyons. The fusion rules for an Ising anyon
model (there are other kinds of more complicated models) satisfy the following.


We've seen an example of the last fusion rule in the nanowires in the main text.
An electron, which is a fermion, can be described by two anyons. The two anyon states
can be occupied to make an electron or unoccupied to make a vacuum.

With the fusion rules established, we can represent qubits with anyons. Consider
a two-qubit system. It needs six anyons, which can fuse into two fermions or at most
three vacuum states, as follows.


The even number of anyons provides a restriction that pairwise fusion will result in a
vacuum globally.

Mathematically, the fusion process and braiding action are represented with
matrices. Fusing from left to right is effectively randomizing the basis, which is
governed by an F-matrix

#### 퐹퐹=

```
1
√^2 �
```
#### 1 1

#### 1 − 1

#### �.

A clockwise exchange of two left-most anyons uses an R-matrix

#### 푅푅=푅푅−푖푖

```
휋휋
```
(^8) �^10
0 푅푅푖푖
휋휋
2

#### �.


Note we are talking about left and right because the positions of the anyons are
important. The F and R matrices together define the direction and rotation of braiding.
If we use three anyons, when the left-most two exchange twice, we obtain the familiar
Z- gate:

#### 푅푅^2 =푅푅−푖푖

```
휋휋
```
(^4) �^10
0 푅푅푖푖휋휋

#### �

#### =푅푅−푖푖

```
휋휋
```
(^4) �^10
0 − 1

#### �∝푍푍,

whereas when the two right-most anyons among three anyons exchange twice, we
obtain the X gate:

#### 퐹퐹−1푅푅^2 퐹퐹 ∝�−^1 −^1

#### − 1 1

#### ��^10

#### 0 푅푅푖푖휋휋

#### ��^11

#### 1 − 1

#### �

#### ∝�^01

#### 1 0

#### �=푋푋.


We can also create a Hadamard gate and other gates by braiding different anyons. The
Hadamard gate needs braiding of all three anyons as

#### 푅푅퐹퐹−1푅푅퐹퐹푅푅 ∝�

#### 1 0

#### 0 푅푅푖푖

```
휋휋
2
```
#### ��−^1 −^1

#### − 1 1

#### ��

#### 1 0

#### 0 푅푅푖푖

```
휋휋
2
```
#### ��^11

#### 1 − 1

#### ��

#### 1 0

#### 0 푅푅푖푖

```
휋휋
2
```
#### �

#### ∝�^11

#### 1 − 1

#### �∝퐻퐻.


We draw six anyons even though some of the operations only involve three anyons
because we need even numbers of anyons to fuse into fermions or vacuum. The
minimum number of fermions or vacuum states would be two to make four anyons,
which makes one qubit. We show six anyons, therefore three fermions of vacuum
states, for generality.

Apart from providing the physical realization of the mathematical construct of a
topological quantum state, superconductors in the system provide another purpose –
to protect the topological states from being destroyed by the environmental
perturbations. The formation of Cooper pairs in a superconductor makes two electrons
(fermions) into bosons. Thus, all Copper pairs can lie on a ground state. It takes a certain
amount of energy to transition a material from its superconducting state to a normal
conductor. Hence, there is an energy gap Δ in superconducting materials. Within this
gap, our constructed system is protected because it needs more than Δ to break the
Cooper pairs and destroy our qubit setup. The energy gap suppresses thermal

fluctuations at least as 푅푅

```
−2푘푘Δ퐵퐵푇푇
```
. The value of Δ scales with the superconductor's critical
temperature 퐶퐶푐푐. At absolute zero, Δ(T = 0 K)= 1. 764 푘푘퐵퐵퐶퐶푐푐. The critical temperature
is a material property of the superconductor, therefore so is Δ. To keep the
superconductor at its superconducting state, we need to cool it down below 퐶퐶푐푐. It has
been a holy grail in condensed matter physics to find high-퐶퐶푐푐 superconductors. This will
also help us find superconductors with larger energy gap Δ, making the topological
qubits more robust to temperature fluctuations.

