---
description: C# implementation and xUnit review guidance for the TRS sample.
applyTo: "src/**/*.cs,tests/**/*.cs"
---

- Keep nullable reference types enabled; validate required object arguments.
- Treat null, empty, and whitespace input consistently.
- Keep intake checks deterministic and separate from I/O.
- Do not equate nonblank text with approved, accurate, or complete requirements.
- Use xUnit facts/theories with explicit outcomes and independent edge cases.
- Avoid network calls, real data, time-dependent assertions, and unnecessary packages.
- Use the build, test, and formatting commands in the root AGENTS.md.
