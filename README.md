**Reference Guide for Quantum Computing, a Microsoft Garage project**

**A Hands-On Introduction to Quantum Computing**

**Authors: Kitty Yeung, Pavan Kumar, Michael Beverland, Ravindra Ramouthar,** 
**Alex Talarico, Delbert Murphy, Waldemir Cambiucci, Karl Tietze, Benjamin Tokgöz, Alexandra Schroeder**

**Q# exercise: Pavan Kumar, Mariia Mykhailova**

**Illustration: Kitty Yeung**

**Reviewers: the book is written by a community of quantum computing enthusiasts and reviewed by individuals at The Microsoft Garage and Quantum Systems teams**


## Introduction <a name="Introduction" /> ##

**Phase 1 – Quantum Computing Basic Concepts**

**Kitty Yeung, Ravindra Ramouthar, Alex Talarico, Delbert Murphy**

## 1.0 BACKGROUND

Now two decades into the new millennium, the field of quantum computing has developed
significantly at an industrial scale over the recent years and made tremendous progress in hardware and
software advancements. Companies and governments across the world are competing and investing
heavily to build the first scalable quantum computer to unlock the unprecedented powers promised by
harnessing the new technology. We often read news about its potential and promises and new discoveries
in the field. However, these articles rarely go beyond a major headline followed by a quick mention about
superposition and entanglement. On the other hand, comprehensive textbooks and research publications
often assume professional knowledge in physics and math, which makes it difficult for beginning hobbyists
to understand.

Our goal is to make quantum computing more accessible and easier to learn. Analogous to open-
source tutorials that helped democratize hardware electronics and programming, the tutorials in this
publication aim to achieve the same – helping anyone interested in the subject get started with the basic
concepts of quantum computing and quickly gain hands-on experience programming in a quantum
computing language. When a quantum computer is available, we would already have the necessary tools
and knowledge to utilize it effectively.

The subject is a combination of physics, math, hardware and software, which will all be discussed
holistically without deviating from the big picture. We will demonstrate concepts and definitions with
tools and representations and divide the contents into three phases. Phase 1 will introduce the basics,
such as quantum states, circuit representations, qubits, gates and measurements. If you do not yet know
these terminologies, do not worry. We will define and explain them – this is what this book is for! Phase
2 will use all the tools obtained from Phase 1 and derive step-by-step algorithms that laid milestone
foundations for quantum computing development. Every session in Phase 1 and 2 has corresponding
programming exercises we will present in Q# (Q-sharp) a domain-specific programming language used for
expressing quantum algorithms. The goal is for you to familiarize yourself with the concepts learned. We
will also cover state-of -the-art hardware systems and real-world applications of quantum computing in
Phase 3.

>_Math and Physics inserts_ ----------------------------------------------------------------------------------
>
>Throughout the book, you will find inserts. These are deeper sections than the
>main texts that function as expansions for interested readers. They can be skipped without
>affecting reading of the main texts.


Quantum computing is a practical subject – engineering applying quantum phenomena in building
a computing system that surpasses classical computing capabilities in certain tasks. It is a sub-field of
quantum information science and has its roots founded in the application of quantum mechanics which
is a physics theory describing nature at its smallest constituent scales of atoms and subatomic particles.
Other sub-fields of quantum information science include: quantum teleportation, quantum dense coding,
quantum communication complexity, quantum cryptography, quantum complexity theory, quantum
information theory and quantum error correction.

You may be familiar with the concept of bits in a classical computer, with each bit being in either
a 1 or 0 position, whereas i n a quantum computer, a sequence of qubits is maintained which can represent
a 1, a 0, or any quantum superposition of those two qubit states. A pair of qubits can be in any quantum
superposition of 4 states and three qubits in any superposition of 8 states, and so on. As a result, quantum
computers can store far more information than classical computers and yield the potential to compute at
speeds exponentially higher than classical computers while consuming much less energy. Elemental
particles such as electrons, photons or ions could be used to manifest a qubit, with either their charge or
polarization representing a 0 and/or 1 state.

The basic principles of a quantum computer take place through operations on its qubits via
quantum logic gates. Measurements are typically observed as a probability outcome, as quantum
algorithms are probabilistic. To run a quantum algorithm, the computer's qubits are first initialized, and
operations are performed on these qubits through a sequence of logic gates that take advantage of
quantum mechanics phenomena. Correct solutions manifest themselves through a favorable probability
result. If no measurement is yielded from the algorithm, we call this an unobserved quantum state. To
yield trusted outcomes, quantum computers must often run their algorithms multiples of time.
Specialized systems are designed to be fault-tolerant through higher quantum volume, namely having
more qubits. More qubits equate to more states that can be manipulated and stored and purposed for
error correction. As systems continue to increase their quantum volume, we can expect to see quantum
computers gain a significant advantage over classical counterparts.

Classical computers based on transistor bits have been used to simulate the laws of physics in
hopes to better understand how the universe works. We can simulate how far a ball will go based on
where it starts and how fast it is thrown. Programming the laws of physics into classical computers, albeit
obsolete ones by today's standards, is ultimately what got us on the moon. But using bits to simulate
physics doesn't always make sense, as the laws of physics at the smallest scale are rooted in the rules of
quantum mechanics. Classical computing simply breaks down and cannot process information fast or
efficiently enough to solve or simulate real world nondeterministic models. Quantum computing takes a
giant leap forward from today's technology – one that will forever alter our economic, industrial, academic,
and societal landscape. In just hours or days, a quantum computer will be able to solve complex problems
that would otherwise take billions of years for today's computers to solve. This yields multi-, inter- and
trans-disciplinary implications for research in healthcare, energy, environmental systems, smart materials,
and more. For example, simulations of quantum interactions between chemical molecules, elementary
particles or materials can help us find solutions in pharmaceutical, agricultural or renewable energy
applications. Quantum computing algorithms that solve certain mathematic problems more efficiently
than classical computing can assist with optimization and cryptography.

Quantum computing was incubated in the early 1980s when Richard Feynman and Yuri Manin
postulated that a quantum computer could perform simulations that a classical computer could not. In
1994, Peter Shor published a cryptography algorithm which could efficiently solve some problems
considered hard for classical computers. A quantum computer can be implemented through analog or
digital means through qubits or quantum bits; analog manifestations include quantum simulation,
quantum annealing and adiabatic quantum computation, whilst digital approaches use quantum logic
gates to perform computation.

You may be surprised to learn that the first-generation quantum computers, were not what we
would call computers or new devices at all. Remarkably, it all began with physicists tinkering with
mathematics and biochemistry equipment for curiosity's sake. "It was not motivated in any way by making
better computers," Neil Gershenfeld, director of MIT's Center for Bits and Atoms and a member of one of
the two teams that first experimentally realized quantum algorithms says. "It was understanding whether
the universe computes, and how the universe computes. (Quote from [The Unlikely Origins of the First
Quantum Computer](https://gizmodo.com/the-unlikely-origins-of-the-first-quantum-computer-1831054476))"

Several independent groups realized that the medical and biochemistry industry had long been
using a 'quantum computer' in research: Nuclear Magnetic Resonance (NMR) spectrometers. This is the
technology behind Magnetic Resonance Imaging (MRI), which commonly consists of a molecule of interest
dissolved in a liquid solvent, placed in a strong magnetic field. The nuclei of the atoms in these molecules
have an innate quantum mechanical property called "spin," which can be in either of two states, "up" or
"down" as we will explore later. These spins align with the direction of the field when hit with additional
smaller oscillating magnetic fields ( radio-frequency pulses) causing the atoms to release characteristic
signals that offer physical information about the molecule. MRI machines use this signal to create a picture,
but the physicists realized by the late 1990's that they could treat certain molecules in this magnetic field
as quantum computers, where the nuclei served as qubits, the spin states were qubit values, and the
radio-frequency pulses were both the instructions and controllers. These are the operations of quantum
computers, also called logic gates as they are in classical computers.

We don't often hear about NMR quantum computers today, because even then, physicists knew
that the technique had its limits. The techniques relied on special workarounds such that each additional
qubit would make it harder to pick the signal out of the background noise, unable to not scale beyond a
few qubits. Despite notable shortcomings, the experiments gave the field the credibility needed to prove
quantum computing hardware viability and pave the way for research and development investments in a
hardware of the future for quantum computing.

At the time of this writing, nearly 20 years after the NMR experiments, we have seen several
companies heavily invested in the development and promotion of commercially available quantum
computing hardware, luring software developers with the promise to most efficiently compute quantum
circuits and algorithms. Companies across the board are periodically joining the quantum race, as
Honeywell recently announced its own quantum computing program for niche industries (see [Investing
in Quantum Computing – The TQD Guide](https://thequantumdaily.com/2020/01/13/investing-in-quantum-computing-the-tqd-guide/)).

Not all quantum computers are created equal, as you might expect, especially in such a fast-paced
landscape. Some manufacturers, namely IBM and Rigetti, claim their systems are truly universal quantum
computers, also known as Quantum Turing Machines (QTM), capable of handling any quantum algorithm.

Other manufacturers, such as D-Wave Systems, focus strictly on optimization problems – travelling
salesman, for example – and are thereby limited to what sorts of processing they can perform.

Although every hardware manufacturer brings forward a unique architecture to their quantum
computing hardware, one common theme emerges: classical computing is not going to be replaced
anytime soon. For the foreseeable future, we will be using a hybrid of classical computing and quantum
computers as each is optimal for different tasks. We leverage our classical computing investments to setup
algorithms and quantum circuits that are then passed along for the quantum computer to resolve and
produce an output our classical computers can then make sense of and display.

As we have seen throughout history, sometimes technological breakthroughs occur by tinkering
with existing equipment. The technology to build a quantum computer today is certain to evolve over the
next decades, as we have just begun to scratch the surface of hardware design.