namespace MobilityBridge.Infrastructure.Operations;
public sealed class RabbitmqPublisher(ILogger<RabbitmqPublisher> logger)
{
 public async Task<int> ExecuteAsync(Guid organizationId,CancellationToken cancellationToken){if(organizationId==Guid.Empty)throw new ArgumentException("Organization required.");logger.LogInformation("rabbitmq publisher started for {OrganizationId}",organizationId);await Task.Yield();cancellationToken.ThrowIfCancellationRequested();return 1;}
}
