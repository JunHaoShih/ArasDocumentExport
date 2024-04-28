using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class AffectedItem
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string? CurrentState { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? IsCurrent { get; set; }

    public string? MajorRev { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public string PermissionId { get; set; } = null!;

    public string? TeamId { get; set; }

    public string? Action { get; set; }

    public string? Grouping { get; set; }

    public string? InBuildDisposition { get; set; }

    public string? InServiceDisposition { get; set; }

    public string? Interchangeable { get; set; }

    public string? IsCondition { get; set; }

    public string? ItemAction { get; set; }

    public string? Relationshiptype { get; set; }

    public string? WasCondition { get; set; }

    public string? AffectedId { get; set; }

    public string? NewItemId { get; set; }

    public virtual ICollection<AffectedItemProperty> AffectedItemProperties { get; set; } = new List<AffectedItemProperty>();

    public virtual ICollection<AffectedItemRelationship> AffectedItemRelationships { get; set; } = new List<AffectedItemRelationship>();

    public virtual ICollection<EcnAffectedItem> EcnAffectedItems { get; set; } = new List<EcnAffectedItem>();

    public virtual ICollection<EcrAffectedItem> EcrAffectedItems { get; set; } = new List<EcrAffectedItem>();

    public virtual ICollection<ExpressDcoAffectedItem> ExpressDcoAffectedItems { get; set; } = new List<ExpressDcoAffectedItem>();

    public virtual ICollection<ExpressEcoAffectedItem> ExpressEcoAffectedItems { get; set; } = new List<ExpressEcoAffectedItem>();

    public virtual ICollection<ExpressEdrAffectedItem> ExpressEdrAffectedItems { get; set; } = new List<ExpressEdrAffectedItem>();

    public virtual ICollection<SimpleEcoAffectedItem> SimpleEcoAffectedItems { get; set; } = new List<SimpleEcoAffectedItem>();
}
