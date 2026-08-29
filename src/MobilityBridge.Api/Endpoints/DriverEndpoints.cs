namespace MobilityBridge.Api.Endpoints;
public static class DriverEndpoints{public static IEndpointRouteBuilder MapDriverEndpoints(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/driver-endpoints",()=>Results.Ok(new{capability="driver endpoints",status="ready",tenantScoped=true}));return endpoints;}}
