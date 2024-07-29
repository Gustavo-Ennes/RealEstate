using RealEstate.Domain.Enums;

namespace RealEstate.Domain.Entities;

public class Document
{
    public int? Id { get; set; }
    public EDocumentType Type { get; set; }
    public EDocumentOwnerType OwnerType { get; set; }
    public int OwnerId { get; set; }
    public string Path { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; }
}
