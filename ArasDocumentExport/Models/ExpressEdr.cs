using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class ExpressEdr
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

    public string? ChangeReason { get; set; }

    public string? Description { get; set; }

    public string? ItemNumber { get; set; }

    public string? Priority { get; set; }

    public string Title { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? State { get; set; }

    public virtual ICollection<ExpressEcoEdr> ExpressEcoEdrs { get; set; } = new List<ExpressEcoEdr>();

    public virtual ICollection<ExpressEdrAffectedItem> ExpressEdrAffectedItems { get; set; } = new List<ExpressEdrAffectedItem>();

    public virtual ICollection<ExpressEdrFile> ExpressEdrFiles { get; set; } = new List<ExpressEdrFile>();

    public virtual ICollection<ExpressEdrSignoff> ExpressEdrSignoffs { get; set; } = new List<ExpressEdrSignoff>();
}
