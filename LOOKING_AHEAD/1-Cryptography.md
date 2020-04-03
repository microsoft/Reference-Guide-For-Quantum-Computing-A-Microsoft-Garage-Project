**Looking Ahead**

## Cryptography and Quantum Computing Looking Ahead

**Waldemir Cambiucci**

The word "cryptography" is associated with the need to treat information in a confidential way, providing
protection for a communication channel between two parties. This is a broad definition for cryptography,
a critical discipline for business today and area with great exposure to the eminent quantum revolution.

We can define an encryption algorithm as a reversible function that transforms an open message
(available to any reader) into an encrypted or protected message (available only to the recipient), using a
process based on an encryption algorithm and a key encryption. As an example, we can think of two
participants, Alice and Bob, planning a communication. Alice uses an encryption algorithm to send a
message to Bob. This encryption algorithm is based on an encryption function, which uses as a parameter
an encryption key previously agreed between them. Only with the correct key can Bob open the message
encrypted by Alice, thus decrypting the encrypted message by accessing Alice's original message. A third
party, here called Eve, may try to read the message during the communication between Alice and Bob.
Only if Eve has the correct encryption key will Alice open the encrypted message and access her
information. Not being expected that Eve reads the message, the coding of the message protects the
information of unwanted readers, thus making the message confidential.

Confidentiality is a great area of application of in cryptography, being applied for several fields of
communication. In fact, we can identify four major needs in the field of secure communication and data
protection these days:

1. **Integrity of information:** It is important to ensure the consistency of the information contained
in the message during a communication, and it is possible to identify if the message was sent
consistently, without changes between the parties;


2. **Confidentiality of information** : It is important to ensure that only the right communication
participants have access to the message in transit, thus preventing external users from accessing the
information contained in the message;
3. **Authentication of participants:** It is important to guarantee the identity of a participant in the
communication, preventing unauthorized external entities from accessing the information contained
in the messages;
4. **Non-repudiation of information:** Finally, it is important to ensure that participants in a
communication cannot deny their transactions, whether it is for transmission or for receiving
messages.

In order to support each of these needs, we have seen over the years numerous encryption
protocols being developed and adopted by the industry, based on different cryptographic techniques and
mathematical functions to embed greater resistances against attacks or malicious actions during
communication. In general, encryption breaks or security attacks involve malicious actions that try to
circumvent, or break encryption standards used to misuse critical messages or information about people
or companies, being a major challenge and risk to business today.

### Standard Algorithms for Cryptography

A major challenge in the application of cryptography in business environments is to ensure
communication between systems in an interoperable way, allowing integration between different parties
and platforms. Thus, the National Institute of Standards and Technology (https://www.nist.gov/) has been
the main coordinator for the standardization of techniques.
The **National Institute of Standards and Technology** is a physical sciences laboratory, and a non-
regulatory agency of the United States Department of Commerce. Its mission is to promote innovation
and industrial competitiveness. NIST's activities are organized into laboratory programs that include
nanoscale science and technology, engineering, information technology, neutron research, material
measurement, cybersecurity, standards, and physical measurement.
In the link below, NIST is consolidating all the work around cryptographic technology, as circuit
complexity, elliptic curve cryptography, lightweight cryptography, pairing-based cryptography, and post-
quantum cryptography.

https://csrc.nist.gov/Groups/Computer-Security-Division/Cryptographic-Technology

In fact, we have much more standards and projects running at NIST and it is critical for us to be
aware of them, tracking developments, launches, and new standards for our systems. In the picture below
we have a great landscape of standards around cryptography and how they apply for each scenario and
application:


The impact on crypto with Quantum Computing – list of standards. Source: The NIST Post-Quantum
Crypto "Competition", Dustin Moody, NIST, 2017. _https://csrc.nist.gov/CSRC/media/Projects/Post-
Quantum-Cryptography/documents/asiacrypt-2017-moody-pqc.pdf_

From this picture, we can see three different areas with international standards for security, that
companies around the world are using to protect communications among participants. In fact, all the
discussions around cryptography is about to control the information, and the ability to control who is
assigned to read the data, or to send the data in a transaction.

In this intent, standards for cryptography are very important because without them, it would be
impossible to integrate different systems, separated by regions or regulations, communicating by internet,
for example.

So we have a list of standard based in **Public Key** , as used for signatures (FIPS 186) or Key
establishment (800-56 A/B/C); in the same way, use have standards based on **Symmetric Keys** , as AES
(FIPS 197), TDEA (800-67), MODES OF OPERATIOS (800 38A 38G), SHA-1/2 (FIPS 180), SHA-3 (FIPS 202),
RANDOMIZE HASH (800-106), HMAC (FIPS 198); finally, we have **Guidelines from NIST** as TRANSITION
(800-131A), KEY GENERATIONS, and KEY MANAGEMENT.

In fact, for each group of standards we have different approaches used to create how to discover
a key or a secret used to encrypt the message. According to the algorithm used for this encryption, we
have a specific amount of effort needed to break security and decrypt the message, getting the
information we are targeting.


## The impact of Quantum Computing on Cryptography

In this tutorial on quantum computing, we saw discussions about the impact of quantum computers and
how they can change the _status quo_ for many industries, while solving problems today we can't do using
classical computers. We saw discussions around _quantum speedup_ , and the exponential advantage
quantum computers can show up while running specific algorithms for different problems.

Two specific algorithms in quantum computing have an impact for security: **Grover** and **Shor**.

1. As we saw in Phase 2, **Grover's algorithm** is used to search for an item in an unordered list more
efficiently than a classical computer. It finds with high probability the unique input to a black box
function that produces an output value. Another possibility is to apply Grover to break specific
standards of algorithm based on Symmetric Key, like AES, for example. The advantage of Grover's
algorithm can change an effort from 2N to 2N/2. So, for a specific key of 128 bits, used in AES, applying
Grover's algorithm can create a scenario equivalent to 64 bits, which is not strong enough for today's
standards.

```
Grover's algorithm. Source: Wikipedia. https://en.wikipedia.org/wiki/Grover%27s_algorithm
```
2. With **Shor's algorithm** we saw a great application to find period for odd numbers. Given an integer
N, it is possible to find its prime factors using this quantum algorithm. In this case, as demonstrated
by Peter Shor, it would be possible to find a period for great numbers, discovering the secret key for
a scenario of public key security. It creates direct impact for RSA and DH standards for security today.

Shor's algorithm. Source: Wikipedia. https://en.wikipedia.org/wiki/Shor%27s_algorithm

Since the 90s, we have a great action in the academia and standard to study the impact of
Quantum Computing for cryptography. Mainly because of Shor's algorithm, much of the hype around


Quantum Computing was created, calling the attention from companies, institutes, academia, and
governs about the future impact with a quantum computer.

In fact, we can say that for a set of standards based in Public Key as RSA, for example, a quantum
computer can break the key and access the message. For example, a 1024-bit key could be broken with a
quantum computer of 5124 qubits in 4.5 minutes. That's right, as soon as we have a quantum computer
of 5K qubits, 1024-bit keys can be factored in minutes. The same goes for 2048-bit keys. 4096-bit keys
would be broken in hours, using quantum 20K qubit computers.

The impact on Crypto – standards with critical impact. Source: The NIST Post-Quantum Crypto
"Competition", Dustin Moody, NIST, 2017. _https://csrc.nist.gov/CSRC/media/Projects/Post-
Quantum-Cryptography/documents/asiacrypt-2017-moody-pqc.pdf_

From NIST, we already have the list of standards suffering impact from quantum attacks:

Impact for Public key crypto: FIPS 186-4, SP 800-56A/56B

3. RSA
4. Elliptic Curve Cryptography (ECDSA)
5. Finite Field Cryptography (DSA)
6. Diffie-Hellman key exchange
Impact for Symmetric key crypto: FIPS 197, SP 800- 57
1. AES
2. Triple DES

Impact for Hash functions: FIPS 180-4, FIPS 202

1. SHA-1, SHA-2 and SHA-3

For each one of these groups or standards we already have recommendations from NIST, as
follow:


Impact for Public key crypto: FIPS 186-4, SP 800-56A/56B

7. RSA (WE MUST REPLACE THIS STANDARD)
8. Elliptic Curve Cryptography (ECDSA) (WE MUST REPLACE THIS STANDARD)
9. Finite Field Cryptography (DSA) (WE MUST REPLACE THIS STANDARD)
10. Diffie-Hellman key exchange (WE MUST REPLACE THIS STANDARD)

Impact for Symmetric key crypto: FIPS 197, SP 800- 57

3. AES (WE NEED LARGER KEYS AS A SOLUTION)
4. Triple DES (WE NEED LARGER KEYS AS A SOLUTION)

Impact for Hash functions: FIPS 180-4, FIPS 202

2. SHA-1, SHA-2 and SHA-3 (WE NEED TO USE LONGER OUTPUT)

From these recommendations, we can see that we don't need to panic for complete, but we need
to take a closer look in every system, to understand the impact and exposition against the different
standards we are using today.

You can check the complete discussion from NIST around the standard here in these links:
https://csrc.nist.gov/CSRC/media//Projects/Post-Quantum-Cryptography/documents/pqcrypto-2016-
presentation.pdf
https://csrc.nist.gov/CSRC/media//Projects/Post-Quantum-Cryptography/documents/asiacrypt-2017-
moody-pqc.pdf

## How Shor's algorithm can affect cryptography?

Modern cryptography is a foundation for critical needs today, mainly for the protection of information
and economic security, creating conditions for secure communication between organizations, individuals,
businesses, and governments. We can divide cryptosystems in two classes: symmetric-key and
asymmetric-key.

**Symmetric-key cryptography** – or just symmetric key algorithms are algorithms for cryptography
that use the same cryptographic key for both encryption and decryption of a message. The keys may be
identical or there may be a simple transformation to go between the two keys. In fact, the keys represent
a shared secret between two or more parties that can be used to maintain a private information channel
for communication and data exchange.

**Asymmetric-key cryptography** – or just public-key cryptography – can use a public key and a
private key to encode and decode a message. The two distinct keys are mathematically related via a one-
way function, which is computationally efficient to calculate in one direction, but not in the inverse
direction. This means that is easy to calculate the key based in two co-prime numbers, but it is difficult to
factor the product between the two co-prime numbers, to find the original key.


The workhorse of public-key encryption schemes is the RSA cryptosystem, which can be work into
four steps:

1. key generation, a public key and a private key for use;
2. public key distribution;
3. message encryption (a message "m" and a ciphertext "c") and transmission;
4. message decryption;

To understand the entire process and how Shor's algorithm can impact RSA cryptosystems, let's
simulate the encryption and decryption for a message, as follow:

**Step 1. Key generation – create the key** 푵푵 **as the product of two prime numbers** 풑풑 **and** 풒풒 **:**

Let's work with two prime numbers for exercise, for example, 푝푝 = 101 and 푞푞 = 113. The values of 푝푝
and 푞푞 result a modulus 퐶퐶 and also a number call 푟푟, where 푟푟 = (푝푝 – 1)(푞푞 – 1 ). This 푟푟 is called the period
between 푝푝 and 푞푞 and we can use it to find the original 퐶퐶, as we will see soon. In fact, we need to find two
numbers 푅푅 and 푑푑 whose product is a number equal to 1 퐼퐼푓푓푑푑 푟푟. For our exercise, 퐶퐶 = 푝푝 ∗ 푞푞 = 101 ∗
113 = 11413 , and 푟푟 = (푝푝 – 1)(푞푞 – 1) = ( 101 – 1)( 113 – 1) = 11200.

**Step 2. Find a number equal to** ퟏퟏ 풎풎풎풎풎풎 풓풓 **which can be factored.**

```
For our exercise, we can work in our exercise with 푘푘 = 13.
```
**Step 3. Find two numbers** 풆풆 **and** 풎풎 **that are relatively prime to** 푵푵 **and for which** 풆풆 ∗ 풎풎 = ퟏퟏ 풎풎풎풎풎풎 풓풓

```
In our exercise, we can use the factorization info to factor 퐾퐾 into two numbers, 푅푅 and 푑푑.
```
```
Therefore, we have:
```
```
푅푅 = 13
```
```
푑푑 = 9477
```
```
퐶퐶 = 11413
```
```
푟푟 = 11200
```
```
푅푅 ∗ 푑푑 = 123201
```
```
푅푅 ∗ 푑푑 퐼퐼푓푓푑푑 푟푟 = 1,
```
```
where, 푅푅 and 푟푟 are relatively prime; 푑푑 and 푟푟 are relatively prime.
```
**Step 4. Finally, we can use** 풆풆 **and** 풎풎 **to encode and decode a message.**


```
In this case, our Message can be a number, like 123.
```
```
For 퐼퐼푝푝푔푔 = 123
```
```
Encrypted message = cipher = (퐼퐼푝푝푔푔)^푅푅 퐼퐼푓푓푑푑 퐶퐶 = ( 123 )^13 퐼퐼푓푓푑푑 1 1413 = 5790
```
```
We can see this using the WolframAlpha, here:
```
```
https://www.wolframalpha.com/input/?i=(123)%5E13+mod+11413
```
```
Decrypted message = 퐼퐼푝푝푔푔 = (푓푓푓푓푝푝ℎ푅푅푟푟)^푑푑 퐼퐼푓푓푑푑 퐶퐶 = 5790 ^9477 퐼퐼푓푓푑푑 1 1413 = 123
```
```
We can see this using the WolframAlpha, here:
```
```
https://www.wolframalpha.com/input/?i=5790%5E9477+mod+11413
```
For our exercise we used very small prime numbers, but for commercial systems, we apply big
prime numbers, which increase the difficult to factoring those numbers in scenarios of attack.

## How do the quantum circuits for Shor's algorithm work?

As we know, **Shor's Algorithm** and period finding can be used to calculate prime numbers 푝푝 and 푞푞, and
thus calculating the private decryption key and compromise the RSA cryptosystem. As we have seen above,
this is possible because 퐶퐶, our private key for RSA, is the product of 푝푝 and 푞푞. Assuming 푝푝 and 푞푞 are co-
prime, we can image them as sine waves. There is a point where the harmony of 푝푝 overlaps with and
repeats itself. This we can call "period". The Shor's algorithm is based in this question: what's the period
between 푝푝 and 푞푞, called 푟푟. As we saw, we can calculate 푟푟 as the product of (푝푝 – 1) 푥푥 (푞푞 – 1). If we test
the point 퐶퐶 then the phase of 푝푝 and 푞푞 should be 0 if they are factors of 퐶퐶. If not, there would be a
remainder of the division of 퐶퐶/푞푞 or 퐶퐶/푝푝. With Shor's algorithm, we test whether the phase of 푝푝 is equal
to the phase of 푞푞 and they are zero at point 퐶퐶. Doing this, Shor's algorithm can find 푟푟, creating the
conditions to break the RSA crypto.

Shor's algorithm is a quantum algorithm for finding the prime factors of an integer 퐶퐶, product of
푝푝 and 푞푞. 퐶퐶 is a very large integer, so the process of factoring is not be applied via brute force during an
attack. So instead of guessing the factors around 퐶퐶, what is the most efficient way is finding 푟푟, considering
the hint that 퐶퐶 is one prime factorizable and 푟푟 is periodic, i.e. 푓푓(푥푥) =푓푓(푥푥+푟푟). So, you should find 푟푟 for
a 푓푓(푥푥) that has a repeating pattern. And for this process, we can use fourier tranforms on periodic
functions.

Here is where Shor's algorithm can play. It uses a method called the Quantum Discrete Fourier
transform (QFT) to find the period 푟푟, so we can call as period finding algorithm. A Discrete Fourier
Transform transforms a set of numbers into a set of sines and cosines. A QFT instead generates a list of
the "probability amplitudes" for the given list of qubit states.

While we have issues with this approach using classical computers, a quantum computer can
perform this task because:


1. A quantum computer can 'exist' in many states simultaneously, which enables it to evaluate the periodic
function 푓푓(푥푥) at all points simultaneously;

2. A QFT is computed by a quantum circuit which uses two parts: a Hadamard transform, mapping 푓푓 qubits
to a superposition of 2 푔푔 orthogonal states; and a quantum gates.

At the end, for a particular 'possible' value of the period 푟푟, the quantum computer can exist in
different states and in some way contribute to the value of 푟푟. Finally, these states cancel out each other.
However, only for the correct value of 푟푟 do the states add up along the same direction. Shor's algorithm
is probabilistic by nature and its performance improves with a number of repetitions.

## How Grover's algorithm can affect cryptography?

Grover's algorithm can search an unordered list of length 퐶퐶 in time square 퐶퐶. Applied to cryptography
this means that it can recover 푓푓 bit keys and find preimages for 푓푓 bit hashes with cost 2 푔푔/^2. So, for a
system using a key with 128 bits, the Grover's algorithm can create a condition of 64 bits for the key,
decreasing the effort for an attack.

## How do the quantum circuits for Grover's algorithm work?

Like other quantum algorithms, Grover's begins by putting the machine into an equal superposition of all

possible 2 푔푔 states of the 푓푓-qubit register. So it means there is an equal amplitude of �
1
√^2 �

```
푔푔
associated with
```
every possible configuration of qubits in the system, and an equal probability of �^12 �

```
푔푔
that the system will
```
be in any of the 2 푔푔 states.

All of the possible states correspond to all the possible entries in Grover's database, and so
starting with equal amplitudes assigned to each element in the search space, every element can be
considered at once in a quantum superposition, and amplitudes can be manipulated from there to

produce the correct entry in the database with a probability of "at least"^12. For further information about

Quantum algorithms, we can check the forum here: https://quantumcomputing.stackexchange.com/

## Encryption in the post-Quantum era

As you may already know, private communication between people and companies is often protected
online through encryption. Encryption protects our information in transit or persisted in the network. But
from success with quantum computing, a new cryptography must be adopted. In this context, Quantum
Cryptography aims to create security methods and protocols based on quantum physics and physics


phenomena, which makes communication breakdown virtually impossible. And the most interesting thing
about this process is that we can prove mathematically the impossibility of breaking quantum keys.
For example, _QKD - Quantum Key Distribution_ is a secure communication method that involves
cryptographic key distribution protocols, ensuring peer communication through quantum systems.
Protocols such as BB84 and E91 are examples of QKD. In the table below, we have a representation of the
information exchanged through the QKD protocol, in different communication scenarios.

BB84 – A Quantum Key Distribution protocol. Source: International Conference on Computer, Bangalore,
India, 1984. Quantum Cryptography: Public Key Distribution and Coin Tossing., Charles Bennett & Gilles
Brassard. https://researcher.watson.ibm.com/researcher/files/us-bennetc/BB84highest.pdf

QKD still faces technical challenges for its adoption by the market. It is still necessary to evolve
the technology to support larger communication distances between the pairs, new transmission and
reception components must be developed for the cheapness in the communication systems (photons are
currently used as data persistence elements in the transmission), achieve a higher sending speed during
communication, as well as new tests for different types of attacks; but it is already a method widely
explored by academia.

## Mosca's Inequality equation

It is easy to realize the impact for data and systems not prepared for attacks using quantum computers.
In fact, we already have an equation putting in numbers this timeline for the first's incidents in the
cyberspace.

Michele Mosca is a co-founder and deputy director of the Institute for Quantum Computing at
the University of Waterloo, researcher and founding member of the Perimeter Institute for Theoretical
Physics, and professor of mathematics in the department of Combinatorics & Optimization at the
University of Waterloo. He has held a Tier 2 Canada Research Chair in Quantum Computation since
January 2002 and has been a scholar for the Canadian Institute for Advanced Research since September

2003. Mosca's principal research interests concern the design of quantum algorithms, but he is also known
for his early work on NMR quantum computation together with Jonathan A. Jones. We had the equation
called _Mosca's Inequality equation_ about the impact for crypto versus the availability of quantum
computers in the market, to be used in cyber-attacks.


```
퐷퐷+퐶퐶>푄푄푓푓.
```
This equation states that we need to start worrying about the impact of quantum computers
when "D" (the amount of time that we wish our data to be secure for), when added to "T" (the time it will
take for our security systems to transition from classical to post-quantum), is greater than "Qc" (the time
it will take for quantum processors to have reached a scale where they can breach existing encryption
protocols).

```
Theorem Mosca. Source: Managing the quantum risk to cybersecurity. Global Risk Institute, 2016.
https://globalriskinstitute.org/wp-content/uploads/2017/07/Quantum-Security-Michele-Mosca-
2016.pdf
```
In one of his talks on quantum cryptography, Mosca points out that, "we are less likely to have
access to timely updates on research and development in the engineering side of quantum computers
from those who are building these machines. As more and more of the resource that has come into the
sector is sourced from commercial organizations or ventures backed by large volumes of risk capital,
competitive pressures now dictate against the publication of results in the public domain. "

Thinking about a specific reference architecture to be applied for a PaaS system in Azure, we can
verify many security standards and components today to be compliance with a NIST Special Publication
800 -171, for example. You can check this complete picture in the link below:


```
Azure Security and Compliance Blueprint - PaaS Web Application for NIST Special Publication 800-171
ht tps://docs.microsoft.com/en-us/azure/security/blueprints/nist171-paaswa-overview
```
The impact here is to create a roadmap to move parts of this architecture for a new stage,
protected against quantum attacks. In fact, our challenge today is already to think how our systems can
be protected using _post-quantum cryptography_ methods or standards before a real quantum computer is
ready and available in the market.

## Microsoft and Quantum Cryptography

Microsoft has been conducting research on quantum computing since 2005 through Microsoft Research.
The company's main approach is the construction of a complete development stack, including the
implementation of hardware for the persistence of a fermion-based quantum topological computer (or
Majorana quasiparticles for the implementation of the expected quantum phenomena of a qubit), as well
as tools for error correction, simulation and scalability. Thus, Microsoft maintains a team of researchers
around _quantum cryptography_ , or _post-quantum cryptography_.

Among the foci of study, a new cryptography must consider numerous factors, such as:

- the size of the encryption and signing keys;
- the time required to encrypt or decrypt a message, or to sign and verify a signature;
- the amount of data sent over the network required to encrypt and decrypt a message;

In the context of Quantum Computing, several new analytics and validity testing tools are needed
for both cryptanalysis and exploitation of weaknesses and potential new security holes. An interesting
aspect in this context is the sense of urgency. In fact, labs around the world do not know when we will
have classical cryptography broken by the announcement of a complete first quantum computer, which
can happen at any time.

That's why Microsoft is working on four candidate cryptography systems at the same time, to
work with both quantum capabilities and to support existing protocols.


**FrodoKEM** : is based on the Problem Learning problem
· https://www.microsoft.com/en-us/research/project/frodokem/
**SIKE - Supersingular Isogeny Key Encapsulation** : uses arithmetic operations in elliptic curves, for the
construction of keys
· https://www.microsoft.com/en-us/research/project/sike/
**Picnic** : is a digital signature algorithm for public key, based on symmetric key systems
· https://www.microsoft.com/en-us/research/project/picnic/
**qTESLA** : is a post-quantum signature scheme based on Ring Learning with Errors (R-LWE)
· https://www.microsoft.com/en-us/research/project/qtesla/

Each of these studies is fast paced, generating libraries and new directions for the development
of new software stacks. What has been interesting in this process is the maturation and application of
new approaches, including for methods in classical computer architecture, which has been understood as
a byproduct of quantum research for our day-to-day life. These four projects are just part of a complete
initiative NIST is running since 2016, for the _Post Quantum Cryptography Standardization._
https://csrc.nist.gov/Presentations/2016/Announcement-and-outline-of -NIST-s-Call-for-Submis

During this process, 82 submissions, 69 projects accepted, 2 rounds and 26 projects already in this
current second round. The list of standards is expected for 2020. In the next table you have a complete
list of projects in this process.

Post Quantum Cryptography Standardization: projects in the second round by July 2019. Source:
https://csrc.nist.gov/projects/post-quantum-cryptography/round-2-submissions

In the end, NIST does not expect to "pick a winner", ideally, per se, instead several algorithms will
emerge as 'good choices'. In fact, they decided it is the time to investigate standardization, as part of the
quantum journey, and while NIST is managing this process for the post quantum crypto standardization,
a community consensus in a transparent and timely manner is a target, by 2020.


## Post-Quantum Cryptography VPN

Finally, the impact of post-quantum cryptography is also expanding for communication and the
networking environment. Microsoft is also developing the so-called _Post-Quantum Cryptography
VPN_. The VPNs establish a secure network between remote computers and organizations, applying
encryption tools that should also evolve in an environment with surrounding quantum computers.
https://www.microsoft.com/en-us/research/project/post-quantum-crypto-vpn/
