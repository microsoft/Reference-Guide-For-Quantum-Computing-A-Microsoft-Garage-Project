## 3.4 Trapped ions

Another way to utilize electron spin is by controlling ions. An ion is formed by removing or adding electrons
to an atom. This is called ionization. If we have one extra or one fewer electron, we can have an effective
spin up or spin down. We can then apply an electro-magnetic field to trap the ions into a row in a vacuum.
Their spin will align with the magnetic field initially.


In a simplified picture, each ion acts as a qubit. By illuminating focused laser beams onto individual
ions, we can tweak their spins to point in a different direction, hence manipulating the qubit state. This is
because lasers emit electro-magnetic waves, which generates forces to move the ions.

In fact, the interaction between the laser light and the ions is quite a bit more complex. Electrons
bound by atoms or ions are not free floating. There are discrete sets of energy levels for electrons to
occupy. Because electrons have spin, certain energy levels are for spin up electrons while others are for
spin down electrons. The set of energy levels to accommodate electron spins is called a _fine structure_ of
an atom or ion. There are also electromagnetic interactions between the electrons and nucleus. Some
energy levels further split. This is called a _hyperfine structure_. In trapped-ion quantum computing systems,
the fine structures are used as the qubit |0⟩ and |1⟩ states and the hyperfine structure is used to aid
transition between the states.

What the focused laser light does is not only moving the ions by force, it also can give electrons a
certain energy to enable transition from one energy level to another, effectively rotating the spin. That's
why the picture above shows a displacement of the ion's position as well as a spin flip. The gate operations
and entanglement are achieved by manipulating each ion with individual laser beams and letting nearby
ions interact through their electrons' spins and physical displacement. Note this is still a much-simplified
explanation.


While trapping and manipulating ions in vacuum provides a "clean" way to create qubits, the
complex optical setup is very difficult to scale. Current state-of -the-art of the number of ions that can be
trapped is around 20.
