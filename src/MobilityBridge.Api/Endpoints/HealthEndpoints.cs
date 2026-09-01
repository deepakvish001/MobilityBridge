namespace MobilityBridge.Api.Endpoints;
public static class HealthEndpoints{public static IEndpointRouteBuilder MapHealthEndpoints(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/health-endpoints",()=>Results.Ok(new{capability="health endpoints",status="ready",tenantScoped=true}));return endpoints;}}
