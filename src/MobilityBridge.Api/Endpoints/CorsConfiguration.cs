namespace MobilityBridge.Api.Endpoints;
public static class CorsConfiguration{public static IEndpointRouteBuilder MapCorsConfiguration(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/cors-configuration",()=>Results.Ok(new{capability="cors configuration",status="ready",tenantScoped=true}));return endpoints;}}
