# Affine Cipher

## Description

**Affine Cipher** is a classic encryption algorithm that uses a linear transformation to encode letters. It combines multiplicative and additive ciphers with two keys (`a` and `b`) and works on a standard 26-letter English alphabet.

- **Encryption:** C = (a * P + b) mod 26
- **Decryption:** P = a_inverse * (C - b) mod 26

Where `a_inverse` is the multiplicative inverse of `a` modulo 26.

## Features

- Case-insensitive encryption
- Ignores spaces and punctuation
- Supports both encryption and decryption
- Validates keys (ensures `a` is coprime with 26)

**Example**:
![example](/example.png)