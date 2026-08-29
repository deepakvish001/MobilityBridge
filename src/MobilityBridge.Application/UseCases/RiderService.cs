namespace MobilityBridge.Application.UseCases;
public sealed record RiderServiceCommand(Guid OrganizationId,Guid ActorId,Guid TargetId,string Action);
public sealed record RiderServiceResult(Guid TargetId,bool Accepted,string Reason);
public static class RiderService{public static RiderServiceResult Execute(RiderServiceCommand c){if(c.OrganizationId==Guid.Empty||c.ActorId==Guid.Empty||string.IsNullOrWhiteSpace(c.Action))throw new ArgumentException("Invalid command scope.");return new(c.TargetId,true,"Validated for persistence.");}}
