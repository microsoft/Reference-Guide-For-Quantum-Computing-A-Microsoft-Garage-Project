## 1.5 The No-Cloning Theorem

The No-Cloning theorem states that we cannot copy an arbitrary quantum state from one qubit (or set of
qubits) to another qubit (or set of qubits). The No-Cloning theorem was first proven by James Park in
1970 and then re-discovered by Wootters and Zurek and Dieks in 1982. Classical programmers are
accustomed to making copies of state to execute various algorithms, but the nature of quantum
mechanics makes this impossible for quantum computing.

For an arbitrary state, let's say for one qubit, |휓휓⟩=훼훼|0⟩+ 훽훽|1⟩. A copy function would act like
this: Copy ( |휓휓⟩ ⊗ |0⟩ ) would produce |휓휓⟩ ⊗ |휓휓⟩ where we copy the state |휓휓⟩ over the |0⟩ state. Can
this Copy function exist? (Recall from the discussion above, that in order to be a quantum operator, this
Copy function must be unitary).

There are many different proofs of the No-Cloning Theorem and all of them follow the same
pattern - assume we have such a Copy function like this one and then prove that in order for the function
to exist, it would have to be non-Unitary, which is a contradiction. The proof below is due to the Brilliant
Quantum Computing course.

```
Math insert – Proof of No-Cloning Theorem-------------------------------------------------------------------
```
```
Assume we have a function, Copy, such that:
```
```
Copy ( |휓휓⟩ ⊗ |0⟩ ) = |휓휓⟩ ⊗ |휓휓⟩,
```
```
which would expand out to (substituting for |휓휓⟩):
```
```
= (훼훼|0⟩+ 훽훽|1⟩ ) ⊗ (훼훼|0⟩+ 훽훽|1⟩ )
```

#### = 훼훼^2 | 00 ⟩+ 훽훽^2 | 11 ⟩+ 훼훼훽훽( | 01 ⟩+ | 10 ⟩ ). (1)

```
You can also evaluate the Copy function by expanding |휓휓⟩ first:
```
```
Copy ( |휓휓⟩ ⊗ |0⟩ ) = Copy ( 훼훼|0⟩ ⊗|0⟩+ 훽훽|1⟩ ⊗ |0⟩ )
```
```
= 훼훼 ( Copy |00⟩ ) + 훽훽 ( Copy |10⟩ )
```
```
= α|00⟩+ 훽훽|11⟩. (2)
```
```
Here we have our contradiction, because both (1) and (2) cannot be true at the same time for
an arbitrary state.
```
An alternative formulation of the No-Cloning Theorem can be found in Physics, Topology, Logic
and Computation: A Rosetta Stone, on page 19. Here is a brief quote:

_In the case of Set, this says that every point of the set X × X′ comes from a point of X and a point of X′. In
physics, this would say that every state g of the combined system X_ ⊗ _X′ is built by combining states of the
systems X and X′. Bell's theorem says that is not true in quantum theory. The reason is that quantum theory
uses the non-Cartesian monoidal category Hilb! Also, in quantum theory we cannot freely duplicate or
delete information. Wootters and Zurek proved a precise theorem to this effect, focused on duplication:
the 'no-cloning theorem'. One can also prove a 'no deletion theorem'. Again, these results rely on the non-
Cartesian tensor product in Hilb._ (Note that Hilb is the Category corresponding to Hilbert Space)

**Additional material:** Scott Aaronson has asked an interesting question: what if the No-Cloning Theorem
is not just a by-product of quantum physics, but what if the privacy of quantum mechanical events is part
of the fundamental nature of the universe? His entertaining and thought-provoking talk is posted on his
blog. There is also a video version.
