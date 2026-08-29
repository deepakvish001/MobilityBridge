namespace MobilityBridge.Application.UseCases;
public sealed record ReferenceGeneratorCommand(Guid OrganizationId,Guid ActorId,Guid TargetId,string Action);
public sealed record ReferenceGeneratorResult(Guid TargetId,bool Accepted,string Reason);
public static class ReferenceGenerator{public static ReferenceGeneratorResult Execute(ReferenceGeneratorCommand c){if(c.OrganizationId==Guid.Empty||c.ActorId==Guid.Empty||string.IsNullOrWhiteSpace(c.Action))throw new ArgumentException("Invalid command scope.");return new(c.TargetId,true,"Validated for persistence.");}}
