namespace MobilityBridge.Api.Contracts;
public sealed record ApplicationError<T>(T? Data,object? Meta=null,ApiProblem? Error=null);
public sealed record ApiProblem(string Code,string Message,string? RequestId=null,IReadOnlyDictionary<string,string>? Fields=null);
