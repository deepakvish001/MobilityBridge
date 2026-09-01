namespace MobilityBridge.Api.Endpoints;
public static class TripEndpoints{public static IEndpointRouteBuilder MapTripEndpoints(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/trip-endpoints",()=>Results.Ok(new{capability="trip endpoints",status="ready",tenantScoped=true}));return endpoints;}}
