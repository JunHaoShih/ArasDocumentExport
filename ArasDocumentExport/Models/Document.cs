using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Document
{
    public string? ArasUniquenessHelper { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string? CurrentState { get; set; }

    public string? LockedById { get; set; }

    public string? IsCurrent { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public string PermissionId { get; set; } = null!;

    public DateTime? ReleaseDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? TeamId { get; set; }

    public string? AuthoringTool { get; set; }

    public string? AuthoringToolVersion { get; set; }

    public string? Description { get; set; }

    public string? DrawingSize { get; set; }

    public string? ExternalId { get; set; }

    public string? ExternalOwner { get; set; }

    public string? ExternalType { get; set; }

    public string? HasChangePending { get; set; }

    public string? HasFiles { get; set; }

    public string? IsTemplate { get; set; }

    public string? Name { get; set; }

    public string? Scale { get; set; }

    public string? SpecificationType { get; set; }

    public string? Thumbnail { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? Classification { get; set; }

    public string? MajorRev { get; set; }

    public string? State { get; set; }

    public DateTime? SupersededDate { get; set; }

    public string? FromTemplate { get; set; }

    public string? ClassifyStr { get; set; }

    public string? DocumentVersion { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? RecordType { get; set; }

    public virtual ICollection<DocumentChange> DocumentChanges { get; set; } = new List<DocumentChange>();

    public virtual ICollection<DocumentFile> DocumentFiles { get; set; } = new List<DocumentFile>();

    public virtual ICollection<PartDocument> PartDocuments { get; set; } = new List<PartDocument>();
}
