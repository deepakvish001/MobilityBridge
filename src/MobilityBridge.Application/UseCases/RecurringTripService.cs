namespace MobilityBridge.Application.UseCases;
public sealed record RecurringTripServiceCommand(Guid OrganizationId,Guid ActorId,Guid TargetId,string Action);
public sealed record RecurringTripServiceResult(Guid TargetId,bool Accepted,string Reason);
public static class RecurringTripService{public static RecurringTripServiceResult Execute(RecurringTripServiceCommand c){if(c.OrganizationId==Guid.Empty||c.ActorId==Guid.Empty||string.IsNullOrWhiteSpace(c.Action))throw new ArgumentException("Invalid command scope.");return new(c.TargetId,true,"Validated for persistence.");}}
