using System.Text.Json;
namespace MobilityBridge.Application.Ports;
public interface IAuditRepository{Task<JsonDocument?> FindAsync(Guid organizationId,Guid id,CancellationToken cancellationToken);Task<JsonDocument> SaveAsync(Guid organizationId,Guid id,JsonDocument value,CancellationToken cancellationToken);Task<IReadOnlyList<JsonDocument>> ListAsync(Guid organizationId,int limit,int offset,CancellationToken cancellationToken);}
