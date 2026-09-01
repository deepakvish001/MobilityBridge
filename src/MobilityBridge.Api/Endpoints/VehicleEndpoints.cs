namespace MobilityBridge.Api.Endpoints;
public static class VehicleEndpoints{public static IEndpointRouteBuilder MapVehicleEndpoints(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/vehicle-endpoints",()=>Results.Ok(new{capability="vehicle endpoints",status="ready",tenantScoped=true}));return endpoints;}}
