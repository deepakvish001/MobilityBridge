namespace MobilityBridge.Application.UseCases;
public sealed record FareServiceCommand(Guid OrganizationId,Guid ActorId,Guid TargetId,string Action);
public sealed record FareServiceResult(Guid TargetId,bool Accepted,string Reason);
public static class FareService{public static FareServiceResult Execute(FareServiceCommand c){if(c.OrganizationId==Guid.Empty||c.ActorId==Guid.Empty||string.IsNullOrWhiteSpace(c.Action))throw new ArgumentException("Invalid command scope.");return new(c.TargetId,true,"Validated for persistence.");}}
