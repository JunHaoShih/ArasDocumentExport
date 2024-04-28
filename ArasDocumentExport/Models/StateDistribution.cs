using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class StateDistribution
{
    public string? IsCurrent { get; set; }

    public string? KeyedName { get; set; }

    public string? ManagedById { get; set; }

    public string SourceId { get; set; } = null!;

    public string? MajorRev { get; set; }

    public string? State { get; set; }

    public string? NotLockable { get; set; }

    public string? OwnedById { get; set; }

    public int? SortOrder { get; set; }

    public string? MinorRev { get; set; }

    public string? ModifiedById { get; set; }

    public string ConfigId { get; set; } = null!;

    public string? IsReleased { get; set; }

    public string? PermissionId { get; set; }

    public string? Behavior { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? Label { get; set; }

    public string? LockedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? Generation { get; set; }

    public string? RelatedId { get; set; }

    public string Id { get; set; } = null!;

    public string? NewVersion { get; set; }

    public string? CurrentState { get; set; }

    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? Css { get; set; }

    public virtual Identity? Related { get; set; }

    public virtual StateEmail Source { get; set; } = null!;
}
