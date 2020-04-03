
**Phase 3 – Current Hardware Systems**

**Kitty Yeung, Michael Beverland**

To build a quantum computer, we need to have a physical system consisting of two values, to represent
|0⟩ and |1⟩ states. Different from the two states ("on" and "off") built using a transistor in a classical
computer, we also need to be able to put these states in superposition. There are natural systems that
act as qubits, such as electrons with two different spin states; and there are systems we can artificially
build to behave like qubits. We will explore a few approaches that have been pursued in academia and
industry, each having pros and cons that we will briefly mention.

The field is rapidly developing with hardware architectures changing as we speak. Therefore, we
will not be comparing their widescale feasibility just yet. In addition, we are only highlighting the
underlying principles here and do not delve into details of measurement and error corrections.

# 3.1 NATURAL QUBITS

Let's start with the simplest example of a qubit. Otto Stern and Walther Gerlach created an experimental
method in 1922 that helped discover a property of fundamental particles. This method was used to fire a
beam of hydrogen atoms (each with a single electron, so effectively it was an electron beam) through a
uniform magnetic field. It was assumed that the magnetic field would deviate the electron beam to one
direction due to their negative charge. But surprisingly, two beams emerged. This unexpected outcome
would only be possible if the elections possessed an intrinsic non-classical non-orbital angular momentum

- a magnetic moment, which we call _spin_ , was discovered through this experiment.


```
The two beams in the Stern-Gerlach experiment are caused by two spin types of an electron. It
```
can be calculated that there is a spin with magnitude +
1
2 ħ and another with −

1
2 ħ ( while ħ is a constant
number call the "Planck constant"). Graphically they can be represented on a sphere in 3D with its radius

equals to √ 23 ħ. Indicated by the directions projected onto the z-axis, they are simply called "spin-up" and

"spin-down", each with spin value one-half. If we could isolate electrons and control their spins, we could
make a qubit with one of the spins being state |0⟩ and the other |1⟩.

```
Physics insert – classical hardware----------------------------------------------------------
```
```
Modern classical computers are built on transistors, which are tiny switches
made of stacks of semiconductors, metals and insulators. Depending on the voltage
applied to the fate, electrical current can flow from source to drain, or not. Thus acting
like a switch flipping between "on" or "off", representing "1"s and "0"s.
```
```
This kind of operation does not allow any superposition of states. The building
blocks of quantum computers are very different.
```
