# MobilityBridge

MobilityBridge coordinates accessible public transport and paratransit for riders with mobility, sensory and assistance needs.

## Stack

- ASP.NET Core and C# on .NET 9
- Orleans virtual actors for long-running rider and trip coordination
- PostgreSQL with PostGIS for spatial search
- RabbitMQ for durable operational events
- Redis for idempotency and short-lived coordination
- Blazor WebAssembly for the accessible operations console
- .NET Aspire, OpenTelemetry and Docker

Merge feature work by numeric branch prefix.
