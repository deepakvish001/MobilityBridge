namespace MobilityBridge.Api.Endpoints;
public static class DispatchEndpoints{public static IEndpointRouteBuilder MapDispatchEndpoints(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/dispatch-endpoints",()=>Results.Ok(new{capability="dispatch endpoints",status="ready",tenantScoped=true}));return endpoints;}}
