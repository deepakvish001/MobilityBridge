namespace MobilityBridge.Application.UseCases;
public sealed record ServiceAlertServiceCommand(Guid OrganizationId,Guid ActorId,Guid TargetId,string Action);
public sealed record ServiceAlertServiceResult(Guid TargetId,bool Accepted,string Reason);
public static class ServiceAlertService{public static ServiceAlertServiceResult Execute(ServiceAlertServiceCommand c){if(c.OrganizationId==Guid.Empty||c.ActorId==Guid.Empty||string.IsNullOrWhiteSpace(c.Action))throw new ArgumentException("Invalid command scope.");return new(c.TargetId,true,"Validated for persistence.");}}
