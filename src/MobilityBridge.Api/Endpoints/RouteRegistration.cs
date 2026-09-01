namespace MobilityBridge.Api.Endpoints;
public static class RouteRegistration{public static IEndpointRouteBuilder MapRouteRegistration(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/route-registration",()=>Results.Ok(new{capability="route registration",status="ready",tenantScoped=true}));return endpoints;}}
