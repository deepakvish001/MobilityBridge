namespace MobilityBridge.Domain.Security;
public static class OutboxEvent
{
 public static bool Allows(IReadOnlySet<string> granted,string required)=>granted.Contains("admin")||granted.Contains(required)||granted.Contains($"{required.Split(':')[0]}:*");
 public static string Redact(string key,string value)=>new[]{"password","token","authorization","phone","email","medical","caregiver"}.Any(x=>key.Contains(x,StringComparison.OrdinalIgnoreCase))?"[REDACTED]":value;
}
