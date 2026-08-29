namespace MobilityBridge.Api.Endpoints;
public static class BookingEndpoints{public static IEndpointRouteBuilder MapBookingEndpoints(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/booking-endpoints",()=>Results.Ok(new{capability="booking endpoints",status="ready",tenantScoped=true}));return endpoints;}}
