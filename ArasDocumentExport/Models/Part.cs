using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Part
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

    public string? ControlType { get; set; }

    public decimal? Cost { get; set; }

    public string? CostBasis { get; set; }

    public string? Description { get; set; }

    public string? ExternalId { get; set; }

    public string? ExternalOwner { get; set; }

    public string? ExternalType { get; set; }

    public string? HasChangePending { get; set; }

    public string? MakeBuy { get; set; }

    public string? Name { get; set; }

    public string? Thumbnail { get; set; }

    public string? Unit { get; set; }

    public decimal? Weight { get; set; }

    public string? WeightBasis { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? Classification { get; set; }

    public string? MajorRev { get; set; }

    public string? State { get; set; }

    public DateTime? SupersededDate { get; set; }

    public virtual ICollection<BomSubstitute> BomSubstitutes { get; set; } = new List<BomSubstitute>();

    public virtual ICollection<PartAlternate> PartAlternateRelateds { get; set; } = new List<PartAlternate>();

    public virtual ICollection<PartAlternate> PartAlternateSources { get; set; } = new List<PartAlternate>();

    public virtual ICollection<PartAml> PartAmls { get; set; } = new List<PartAml>();

    public virtual ICollection<PartBom> PartBomRelateds { get; set; } = new List<PartBom>();

    public virtual ICollection<PartBom> PartBomSources { get; set; } = new List<PartBom>();

    public virtual ICollection<PartCad> PartCads { get; set; } = new List<PartCad>();

    public virtual ICollection<PartChange> PartChanges { get; set; } = new List<PartChange>();

    public virtual ICollection<PartDocument> PartDocuments { get; set; } = new List<PartDocument>();

    public virtual ICollection<PartGoal> PartGoals { get; set; } = new List<PartGoal>();

    public virtual ICollection<PartMultilevelBom> PartMultilevelBoms { get; set; } = new List<PartMultilevelBom>();

    public virtual ICollection<SimpleMcoPart> SimpleMcoParts { get; set; } = new List<SimpleMcoPart>();
}
