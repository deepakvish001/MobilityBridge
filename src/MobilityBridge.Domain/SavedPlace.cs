namespace MobilityBridge.Domain;
public sealed record SavedPlace(Guid Id,Guid OrganizationId,string Reference,string Status,DateTimeOffset CreatedAt)
{
 public void Validate(){if(Id==Guid.Empty||OrganizationId==Guid.Empty||Id==OrganizationId)throw new ArgumentException("Invalid saved place identity.");if(string.IsNullOrWhiteSpace(Reference)||string.IsNullOrWhiteSpace(Status))throw new ArgumentException("Reference and status are required.");}
}
