---
description: Draft evidence-based documentation and focused xUnit tests.
---

Ask which symbol or change to cover if none is supplied. Inspect its callers,
existing tests, AGENTS.md, and README before proposing edits.

First return a behavior/test matrix (normal, null, empty, whitespace, and invalid
inputs), documentation gaps, and assumptions. Wait for approval before editing.
Then add focused xUnit tests using existing packages; avoid redundant tests or
changing production behavior just to satisfy an assertion.
Draft a technical summary, an onboarding example, and public-contract documentation
appropriate to this console application. There is no HTTP API: do not invent endpoints.
Run focused tests first, then the documented checks. Report actual results and
coverage gaps; do not claim a coverage percentage without measuring it.
