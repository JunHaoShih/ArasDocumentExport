using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Cad
{
    public string? ArasUniquenessHelper { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public string? IsCurrent { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? Css { get; set; }

    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public string PermissionId { get; set; } = null!;

    public DateTime? ReleaseDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? TeamId { get; set; }

    public string? AuthoringTool { get; set; }

    public string? AuthoringToolVersion { get; set; }

    public string? Description { get; set; }

    public string? ExternalId { get; set; }

    public string? ExternalOwner { get; set; }

    public string? ExternalType { get; set; }

    public string? HasChangePending { get; set; }

    public string? IsStandard { get; set; }

    public string? IsTemplate { get; set; }

    public string? MonolithicModelFile { get; set; }

    public string? Name { get; set; }

    public string? NativeFile { get; set; }

    public string? Thumbnail { get; set; }

    public string? ViewFile { get; set; }

    public string? ViewableFile { get; set; }

    public double? XMax { get; set; }

    public double? XMin { get; set; }

    public double? YMax { get; set; }

    public double? YMin { get; set; }

    public double? ZMax { get; set; }

    public double? ZMin { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? Classification { get; set; }

    public string CreatedById { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? CurrentState { get; set; }

    public int? Generation { get; set; }

    public string? LockedById { get; set; }

    public string? MajorRev { get; set; }

    public string? ManagedById { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? OwnedById { get; set; }

    public string? State { get; set; }

    public DateTime? SupersededDate { get; set; }

    public string? FromTemplate { get; set; }

    public virtual ICollection<CadChange> CadChanges { get; set; } = new List<CadChange>();

    public virtual ICollection<CadParent> CadParents { get; set; } = new List<CadParent>();

    public virtual ICollection<CadPart> CadParts { get; set; } = new List<CadPart>();

    public virtual ICollection<CadStructure> CadStructureRelateds { get; set; } = new List<CadStructure>();

    public virtual ICollection<CadStructure> CadStructureSources { get; set; } = new List<CadStructure>();

    public virtual ICollection<Cadfile> Cadfiles { get; set; } = new List<Cadfile>();

    public virtual ICollection<PartCad> PartCads { get; set; } = new List<PartCad>();
}
