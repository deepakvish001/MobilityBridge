namespace MobilityBridge.Application.UseCases;
public sealed record TripRequestServiceCommand(Guid OrganizationId,Guid ActorId,Guid TargetId,string Action);
public sealed record TripRequestServiceResult(Guid TargetId,bool Accepted,string Reason);
public static class TripRequestService{public static TripRequestServiceResult Execute(TripRequestServiceCommand c){if(c.OrganizationId==Guid.Empty||c.ActorId==Guid.Empty||string.IsNullOrWhiteSpace(c.Action))throw new ArgumentException("Invalid command scope.");return new(c.TargetId,true,"Validated for persistence.");}}
