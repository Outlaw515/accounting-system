# Technology stack (decision D10, approved 2026-10-22)

This file is checked against the real versions in CI (to be added in a later step).
Change a version only through a documented decision.

## Installed on the development machine (captured when the project was created)

| Component | Version |
|---|---|
| .NET SDK | 10.0.400 (pinned by global.json, roll-forward: latestPatch) |
| Node.js | v24.19.0 |
| Git | git version 2.55.0.windows.4 |
| PostgreSQL client (psql) | psql (PostgreSQL) 18.6 |

## Target pins (design document v3, section 12; not installed yet)

| Component | Target |
|---|---|
| ASP.NET Core / .NET | 10 (LTS, supported until 2028-11-14) |
| Entity Framework Core | 10.0.x (Microsoft.EntityFrameworkCore >= 10.0.4, < 11) |
| Npgsql.EntityFrameworkCore.PostgreSQL | 10.0.3 |
| PostgreSQL | minimum 16; CI tests 16 and 17; do NOT use PostgreSQL 18-only features |
| React | 19.3 |
| Vite | 8.x (needs Node 20.19+ or 22.12+) |
| Ant Design | 6.6.7 |
| TypeScript, TanStack Query, React Hook Form, Zod, Playwright | to be verified and pinned via lockfile when the web app is scaffolded |

## Rules
- UUIDs are generated in the application (Guid.CreateVersion7), not by a PostgreSQL function.
- Secrets never go into the repository.
- No real accounting or personal data in the free pilot environment.
