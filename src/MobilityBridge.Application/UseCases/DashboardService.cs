namespace MobilityBridge.Application.UseCases;
public sealed record DashboardServiceCommand(Guid OrganizationId,Guid ActorId,Guid TargetId,string Action);
public sealed record DashboardServiceResult(Guid TargetId,bool Accepted,string Reason);
public static class DashboardService{public static DashboardServiceResult Execute(DashboardServiceCommand c){if(c.OrganizationId==Guid.Empty||c.ActorId==Guid.Empty||string.IsNullOrWhiteSpace(c.Action))throw new ArgumentException("Invalid command scope.");return new(c.TargetId,true,"Validated for persistence.");}}
