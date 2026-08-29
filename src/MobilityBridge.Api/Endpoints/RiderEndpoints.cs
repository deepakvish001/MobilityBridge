namespace MobilityBridge.Api.Endpoints;
public static class RiderEndpoints{public static IEndpointRouteBuilder MapRiderEndpoints(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/rider-endpoints",()=>Results.Ok(new{capability="rider endpoints",status="ready",tenantScoped=true}));return endpoints;}}
