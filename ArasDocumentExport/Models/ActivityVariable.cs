using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class ActivityVariable
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CurrentState { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? MajorRev { get; set; }

    public string? IsCurrent { get; set; }

    public string? MinorRev { get; set; }

    public string? NotLockable { get; set; }

    public string? IsReleased { get; set; }

    public string? SourceId { get; set; }

    public string? Behavior { get; set; }

    public string? RelatedId { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public string Datatype { get; set; } = null!;

    public string? DefaultValue { get; set; }

    public string? IsHidden { get; set; }

    public string? IsRequired { get; set; }

    public string? Label { get; set; }

    public string Name { get; set; } = null!;

    public int Sequence { get; set; }

    public string? Source { get; set; }

    public string ConfigId { get; set; } = null!;

    public int? Generation { get; set; }

    public string? ManagedById { get; set; }

    public string? NewVersion { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public int? SortOrder { get; set; }

    public virtual Activity? SourceNavigation { get; set; }
}
