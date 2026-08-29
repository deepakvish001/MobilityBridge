namespace MobilityBridge.Application.UseCases;
public sealed record CommandResultCommand(Guid OrganizationId,Guid ActorId,Guid TargetId,string Action);
public sealed record CommandResultResult(Guid TargetId,bool Accepted,string Reason);
public static class CommandResult{public static CommandResultResult Execute(CommandResultCommand c){if(c.OrganizationId==Guid.Empty||c.ActorId==Guid.Empty||string.IsNullOrWhiteSpace(c.Action))throw new ArgumentException("Invalid command scope.");return new(c.TargetId,true,"Validated for persistence.");}}
