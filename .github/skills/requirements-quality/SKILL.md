---
name: requirements-quality
description: Analyze ambiguous portfolio intake, separate facts from assumptions, and produce clarifying questions, provisional acceptance criteria, and testing considerations. Use for requirements discovery or an intake quality review.
---

# Requirements quality procedure

1. Confirm the supplied request is synthetic or approved for this environment.
   If it contains restricted data, stop and request a redacted version.
2. Extract only stated goals, users, constraints, deadlines, and success measures.
3. Build a facts / assumptions / open decisions table. Quote short supporting excerpts.
4. Ask at most eight prioritized questions, each with its risk, rationale, and answering
   role. Cover ownership, outcome, scope, dependencies, access, retention, and audit needs.
5. Draft measurable Given/When/Then criteria. Label all unconfirmed thresholds as
   proposals; do not make up policy, service levels, or regulatory requirements.
6. Map each criterion to happy-path, failure, boundary, security/privacy, and
   accessibility tests where relevant. Identify missing test data or environments.
7. Return a handoff: blockers, decisions, suggested next owner, and human sign-off.
   Discovery readiness is not funding, eligibility, or production approval.

Acceptance check: every assumption is labeled, every blocker has a question,
and every proposed criterion has a test scenario.
