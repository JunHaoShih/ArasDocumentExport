using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class TeamIdentity
{
    public string? Classification { get; set; }

    public string Id { get; set; } = null!;

    public string? KeyedName { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? ManagedById { get; set; }

    public string? OwnedById { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CurrentState { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? IsCurrent { get; set; }

    public string? MajorRev { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string ConfigId { get; set; } = null!;

    public string? NewVersion { get; set; }

    public string PermissionId { get; set; } = null!;

    public string? Behavior { get; set; }

    public string? TeamId { get; set; }

    public int? Generation { get; set; }

    public string? Css { get; set; }

    public string? TeamRole { get; set; }

    public string? RelatedId { get; set; }

    public int? SortOrder { get; set; }

    public string? SourceId { get; set; }

    public virtual Identity? Related { get; set; }

    public virtual Team? Source { get; set; }
}
