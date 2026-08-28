namespace MobilityBridge.Domain;
public sealed record CaregiverContact(Guid Id,Guid OrganizationId,string Reference,string Status,DateTimeOffset CreatedAt)
{
 public void Validate(){if(Id==Guid.Empty||OrganizationId==Guid.Empty||Id==OrganizationId)throw new ArgumentException("Invalid caregiver contact identity.");if(string.IsNullOrWhiteSpace(Reference)||string.IsNullOrWhiteSpace(Status))throw new ArgumentException("Reference and status are required.");}
}
