namespace MobilityBridge.Api.Endpoints;
public static class SecurityConfiguration{public static IEndpointRouteBuilder MapSecurityConfiguration(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/security-configuration",()=>Results.Ok(new{capability="security configuration",status="ready",tenantScoped=true}));return endpoints;}}
