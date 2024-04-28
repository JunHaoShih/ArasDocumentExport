using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class View
{
    public string? PermissionId { get; set; }

    public string ConfigId { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? NewVersion { get; set; }

    public string? ManagedById { get; set; }

    public int? Generation { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? SortOrder { get; set; }

    public string? MajorRev { get; set; }

    public string? Behavior { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string? LockedById { get; set; }

    public string? Role { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public string? Label { get; set; }

    public string? Type { get; set; }

    public string? IsCurrent { get; set; }

    public string? MinorRev { get; set; }

    public string? CurrentState { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? State { get; set; }

    public string? RelatedId { get; set; }

    public string SourceId { get; set; } = null!;

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? FormClassification { get; set; }

    public int? DisplayPriority { get; set; }

    public string? Method { get; set; }

    public string? Url { get; set; }

    public string? Client { get; set; }

    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? Css { get; set; }

    public string? ShowSsvc { get; set; }

    public virtual Form? Related { get; set; }

    public virtual Itemtype Source { get; set; } = null!;
}
