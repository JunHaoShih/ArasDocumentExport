using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Ecn
{
    public DateTime? ReleaseDate { get; set; }

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

    public string? Basis { get; set; }

    public string? CustomerApproval { get; set; }

    public string? Description { get; set; }

    public DateTime? EffectivityDate { get; set; }

    public string? ImplementationPlan { get; set; }

    public string? ItemNumber { get; set; }

    public string? Priority { get; set; }

    public string? SpecialInstructions { get; set; }

    public string? Title { get; set; }

    public string? State { get; set; }

    public virtual ICollection<EcnAffectedItem> EcnAffectedItems { get; set; } = new List<EcnAffectedItem>();

    public virtual ICollection<EcnEcr> EcnEcrs { get; set; } = new List<EcnEcr>();

    public virtual ICollection<EcnFile> EcnFiles { get; set; } = new List<EcnFile>();
}
