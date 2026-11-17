# TRS Copilot guidance

Read [AGENTS.md](../AGENTS.md) for verified architecture, commands, standards,
security boundaries, and completion criteria. See [README](../README.md) for labs.

Use synthetic examples and C#/.NET for code. Ask before inventing requirements.
Keep changes small, test behavior, and document evidence and limitations.
For reviews, prioritize security and correctness over style; cite file/line,
impact, recommended fix, and a test. Do not claim a review proves security.

Path-specific C# guidance lives in `instructions/dotnet.instructions.md`.
Reusable tasks live in `prompts/`; multi-step procedures live in `skills/`.
Feature support varies by Copilot client: if an asset is not discovered, attach
the relevant file explicitly rather than assuming it was loaded.
