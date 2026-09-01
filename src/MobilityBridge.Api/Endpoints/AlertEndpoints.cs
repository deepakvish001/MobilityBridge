namespace MobilityBridge.Api.Endpoints;
public static class AlertEndpoints{public static IEndpointRouteBuilder MapAlertEndpoints(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/alert-endpoints",()=>Results.Ok(new{capability="alert endpoints",status="ready",tenantScoped=true}));return endpoints;}}
