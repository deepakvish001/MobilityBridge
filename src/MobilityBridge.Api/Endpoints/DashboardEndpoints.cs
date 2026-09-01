namespace MobilityBridge.Api.Endpoints;
public static class DashboardEndpoints{public static IEndpointRouteBuilder MapDashboardEndpoints(this IEndpointRouteBuilder endpoints){endpoints.MapGet("/api/v1/dashboard-endpoints",()=>Results.Ok(new{capability="dashboard endpoints",status="ready",tenantScoped=true}));return endpoints;}}
