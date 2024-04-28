using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class ExpressEco
{
    public DateTime? ReleaseDate { get; set; }

    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? ManagedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string? CurrentState { get; set; }

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

    public DateTime? ChangeEffectiveDate { get; set; }

    public string? ChangeReason { get; set; }

    public string? Description { get; set; }

    public string? ItemNumber { get; set; }

    public string? Priority { get; set; }

    public string Title { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? State { get; set; }

    public virtual ICollection<ExpressEcoAffectedItem> ExpressEcoAffectedItems { get; set; } = new List<ExpressEcoAffectedItem>();

    public virtual ICollection<ExpressEcoEdrGrouping> ExpressEcoEdrGroupings { get; set; } = new List<ExpressEcoEdrGrouping>();

    public virtual ICollection<ExpressEcoEdr> ExpressEcoEdrs { get; set; } = new List<ExpressEcoEdr>();

    public virtual ICollection<ExpressEcoFile> ExpressEcoFiles { get; set; } = new List<ExpressEcoFile>();

    public virtual ICollection<ExpressEcoImpactMatrix> ExpressEcoImpactMatrices { get; set; } = new List<ExpressEcoImpactMatrix>();

    public virtual ICollection<ExpressEcoSignoff> ExpressEcoSignoffs { get; set; } = new List<ExpressEcoSignoff>();
}
