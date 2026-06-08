# Backend

ASP.NET Core 9 REST API built using Clean Architecture and CQRS.

## Projects

- `RetailPulse.Domain` — domain entities, domain events, and interfaces
- `RetailPulse.Application` — use cases, commands, queries, and validations
- `RetailPulse.Infrastructure` — EF Core, Kafka, MinIO, and Redis integrations
- `RetailPulse.Api` — controllers, middleware, and HTTP entry point
- `RetailPulse.Worker` — Kafka consumers and background services

## Run Locally

```bash
dotnet run --project RetailPulse.Api
```