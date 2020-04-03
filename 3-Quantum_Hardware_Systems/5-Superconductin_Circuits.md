## 3.5 Superconducting circuits

One of the greatest technological advancements in the 20th century was the CMOS (complementary
metal–oxide–semiconductor) fabrication process. This is a method to fabricate integrated circuits by
stacking layers of materials on wafers repeatedly at large scale. Different materials can be layered onto
wafers at nanometer or micrometer precision to form circuit structures. The wafers are then cut into chips
to be mounted to a larger system (see "dilution refrigerator"). Quantum dots, in session 3.2, are also
fabricated this way.

Just like atomic levels where electrons occupy in an atom at different energies, we can create a
circuit on chip that behaves like an artificial atom – it has different energy levels the system can be at.
Now, if we can "isolate" the lowest two levels and assign them as states |0⟩ and |1⟩, perhaps we will be
able to make a qubit using these two levels. While a natural atom's energy levels are difficult to control,
an artificial atom created based on our design could be much more user-friendly.

It turns out that we can achieve this just by using an inductor-capacitor (LC) circuit. If you are
familiar with a generic LC circuit, you would recall that it behaves like a harmonic oscillator. The energy of
the circuit is a parabolic function of frequency. This is a classical behavior. But if we make the circuit small
enough and cool the circuit down to sub-Kelvin, we enter the quantum regime. (The specific criteria are:
effective length of the circuit is smaller than the electron scattering length in the circuit; and the
temperature is low enough. How cold is low enough? 푘푘퐶퐶<ħ휔휔, where 푘푘 is the Boltzmann constant, 퐶퐶 is

the temperature and 휔휔=√퐿퐿퐶퐶 is the natural frequency of the circuit. Typically, with small circuits we
make today, the temperature could be below liquid Helium temperature at 4K.)


In the quantum regime, the energy of the circuit splits into discrete levels, which are in
superposition. They are equally spaced by ħ휔휔. We could define the bottom two energy levels to be our
|0⟩ and |1⟩, but it would not be very useful because the energy required to change between |0⟩ and |1⟩
could as well induce transitions between other adjacent states. We must isolate the levels.

This problem can be solved by using a Josephson junction, a special type of inductor, instead of a
normal inductor. What it does here is to change the potential from a parabolic to a sinusoidal shape.
Interestingly, we can find this behavior in other systems, such as in a pendulum. Recall in _Physics insert –
artificial atom_ in session 3.2, the Hamiltonian of a superconducting circuit appears to have a very similar
form as the Hamiltonian of a pendulum. We can change the shape of a pendulum's energy function by
tweaking the value of gravitational acceleration, 푔푔, for example moving from Earth to Mars. With an
appropriate value of 푔푔, the potential of a pendulum can be a sinusoidal function, just as a superconducting
circuit with a Josephson junction can make the potential change from a parabolic to a sinusoidal shape.

Now that the energy levels are no longer equally spaced, we can use the bottom two levels as our
|0⟩ and |1⟩ states. We can fabricate many qubits next to each other to enable entanglement. To control
the states, i.e. to apply gates to them, we also use electromagnetic fields like in previous cases. However,


instead of shining light or applying external fields, we send microwave signals through the circuits on chip.
The sizes of the circuits are comparable with microwave wavelengths. Therefore, we can directly make
transmission lines on chip to guide the wave to the qubits.

```
Physics insert – superconductors ----------------------------------------------------------------------
```
```
In a conducting solid, the ions in the solid form a lattice. Electrons that are unbound by
ions, often called free electrons, flow in the material, conducting electricity. As
electrons flow through the material, they bump into the lattice and get scattered,
dissipating energy. This is what's causing resistance in a conductor.
```
```
Superconductors are conductors with little electrical resistance. This means
electrons in superconductors bump into the ion lattice much less than in normal
conductors. How does this happen?
```
```
(The curvatures are arbitrary and are only for illustration purposes. Not all conductors
have linear resistance to temperature and superconductors do not have the exact
resistance curve as drawn.)
```

We know that ions are positively charged, and electrons are negatively charged.
As an electron flows through a lattice of ions, it perturbs the lattice because the ions
around the electron move toward it due to the attractive forces between positive and
negative charges. If another electron comes along, instead of experiencing a repulsion
from the first electron, it experiences an attraction towards this local disturbance.
These two electrons are then bound together, forming a pair. This is called a Cooper
pair (named after physicist Leon Copper). The net effect of this many-body interaction
is that all the conducting electrons form Cooper pairs which moves inside the lattice
together without colliding with the ion lattice.

Superconductors are materials with such conditions met. They behave like
normal conductors, where electrons bump into ion lattices, until temperature is cooled
below a certain critical point, _Tc_ , when Cooper pairs are formed. Not all materials have
a superconducting state. The search for relatively high-temperature superconductors
(high _Tc_ ) is an ongoing effort. The higher the critical temperature, the closer it is to
room temperature, which means it is easier for us to use in everyday life.


_Physics insert – Josephson junction_ -------------------------------------------------------------------

As described above, the behaviors of an electron in a superconductor correlate to all
other electrons. In other words, the electrons behave coherently. Mathematically, we
can find that Cooper pairs can be described by the same wavefunction with a constant
phase difference (see session 1.1 _Physics insert - wavefunction_ ). This contrasts with
regular conductors where all the electrons have different wavefunctions with
independent phases – they are incoherent. This is analogues to coherent photons from
a laser verses incoherent photons from other types of light source.

The significance of having coherent Cooper pair phases is that the wavefunctions
between two superconductors can interfere. When two superconductors with phases
휙휙 1 and 휙휙 2 are brought right next to each other, they can form a new superconductor
with a single wavefunction with a new phase 휙휙 3.


But if they are separated by a small barrier, quantum tunneling of wavefunctions
happens and they interfere with a phase difference 휃휃=휙휙 1 −휙휙 2. This phase difference
causes a supercurrent to flow through the junction with value

```
퐼퐼푠푠=퐼퐼푐푐sin휃휃,
```
where 퐼퐼푐푐 is called the critical current, which is the maximum value of supercurrent that
can flow through the junction. This was discovered by Brian Josephson in early 1960s.
Experimentally a Josephson junction is achieved by sandwiching an insulator in
between two superconductors.

As this effect is associated with the kinetics of electrons, an inductance can be
derived for the Josephson junctions.

#### 퐿퐿퐽퐽=

#### 퐿퐿 0

```
cos휃휃
```
#### =

#### 훷훷 0

```
2 휋휋퐼퐼푐푐cos휃휃
```
#### ,

where 훷훷 0 is the magnetic flux quantum
ℎ
2 푠푠. That is why the energy of the LC circuit
shown earlier in the chapter is a function of the phase difference 휃휃.

_Physics insert – low-temperature experiments_ -----------------------------------------------------

Most of the methods of building quantum computing hardware, from using
semiconducting circuits to making quantum dots to building topological qubits, which
will be discussed later, require the setup to be cooled to very low temperatures (milli-


Kelvin range). This is because temperature gives energy to everything in the system,
which makes the particles move around. We already saw in the case of conductors,
electrons bumping into atom lattice causes electrical resistance. The higher the
temperature, the more vibration and agitation the atoms have, making electrons more
likely to bump into them. When we investigate quantum properties of materials, this
kind of vibrations and agitations of particles result in noise that masks quantum
mechanical signals. When it comes to building a quantum computer requiring delicate
interactions between particles, temperature is our enemy.

A special cooling unit known as a dilution refrigerator, is built to cool materials
down to milli-Kelvin range. The "coolant" used in a dilution refrigerator is a mixture of
Helium-3 and Helium-4 isotopes and they are cooled in stages. First the cryostat is
immersed from room temperature into liquid nitrogen which is naturally at 77 K, inside
which there is a liquid Helium-4 bath at 4.2 K. Then He-3 gas is added into the cryostat
getting precooled to 4.2 K under pressure. The He-3 then enters a vacuum chamber
that is cooled to about 1 K by pumping He-4 bath. This makes the He-3 undergo phase
transition from gas to liquid. Then He-3 enters a still filled with He-4 superfluid. The
pressure in the still is pumped low which keeps superfluid He-4 at a few hundred mK.
The He-3 then enters a mixing chamber of a He-3 and He-4 mixture. The upper layer is
He-3 rich, which is a concentrated phase for He-3, while the lower layer is a diluted
phase for He-3. This phase transition is endothermic, meaning it absorbs heat from its
environment. The quantum computing setup is at the bottom of this mixing chamber,
which is the coolest area of the cryostat at typically 10-100 mK. Cryostat technology
has been an advancing field due to the many researches on quantum materials. The
description here is a typical dilution refrigerator but note there are many other ways
to achieve extremely low temperature.

