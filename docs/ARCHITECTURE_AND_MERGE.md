# MobilityBridge architecture and merge guide

MobilityBridge coordinates accessible trip requests, recurring rides, vehicle capability, drivers, dispatch and service recovery.

## Invariants

1. Every trip preserves mobility aids and assistance needs.
2. Vehicle assignment must satisfy accessibility requirements.
3. Driver qualifications and duty windows are validated before dispatch.
4. Pickup windows and maximum detour limits cannot be silently exceeded.
5. Sensitive rider, caregiver and medical metadata is redacted.
6. All records are organization-bound and protected by row-level security.
7. External events are emitted only through the transactional outbox.

Merge numeric branch prefixes: 001–024 domain, 025–048 rules/security, 049–072 ports/contracts, 073–096 API/UI, 097–108 tests, 109–118 infrastructure, 119 CI, 120 docs.
