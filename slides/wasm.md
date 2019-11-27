
class: center, middle

![Wasm Logo](images/wasm.png)

# WebAssembly, The Good, The Bad, The Ugly


## A short introduction to WebAssembly and discover Blazor features in action.

???
Test

---

# Source

The slide and all materials of this lecuture can be access here in my GitHub:
<br />
<br />
<br />
https://github.com/0x414c49/wasm-blazor-lecture

---

# Contents

1. WASM
2. Why
3. Benchmarks! Benchmarks everywhere!
4. Blazor
5. Summary

---

# Introduction

- Introduction to WASM

    > WebAssembly (abbreviated Wasm) is a binary instruction format for a stack-based virtual machine. Wasm is designed as a portable target for compilation of high-level languages like C/C++/Rust, enabling deployment on the web for client and server applications.
     
    > -- https://webassembly.org/

    - Efficient and fast
    - Safe
    - Open and debuggable
    - Part of the open web platform

    And yes, WebAssembly 1.0 has shipped in 4 major browser engines!   

    ![Wasm Logo](images/browsers.png)

---

# Fast and efficient!

* Execute at native speed!
* The binary format is encoded in size and load-time efficient.

# Safe

* Memory Safe!
* Runs inside a sandbox
* It follows rules from JavaScript like same-origin and permissions.

# Open and debuggable

* Designed to be pretty-printed in a textual format
* The textual format will be used when viewing the source of Wasm modules (like source-maps)

---
# Part of the open web platform

* It's a web standard!

---
# Some sample of web-assembly

An astroid game written in RUST
https://m1el.github.io/wasm-asteroids/demo/demo.html

Funky Kards - A racing game written in CPP
https://www.funkykarts.rocks/demo.html