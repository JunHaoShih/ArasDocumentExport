using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class LifeCycleState
{
    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? HistoryTemplate { get; set; }

    public string? Image { get; set; }

    public string? ItemBehavior { get; set; }

    public string? Label { get; set; }

    public string? SetIsReleased { get; set; }

    public string? SetNotLockable { get; set; }

    public string? StatePermissionId { get; set; }

    public string? Workflow { get; set; }

    public int? X { get; set; }

    public int? Y { get; set; }

    public string Name { get; set; } = null!;

    public string? Behavior { get; set; }

    public string ConfigId { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? Css { get; set; }

    public string? CurrentState { get; set; }

    public int? Generation { get; set; }

    public string Id { get; set; } = null!;

    public string? IsCurrent { get; set; }

    public string? IsReleased { get; set; }

    public string? KeyedName { get; set; }

    public string? LockedById { get; set; }

    public string? MajorRev { get; set; }

    public string? ManagedById { get; set; }

    public string? MinorRev { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? NewVersion { get; set; }

    public string? NotLockable { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public string? RelatedId { get; set; }

    public int? SortOrder { get; set; }

    public string SourceId { get; set; } = null!;

    public string? State { get; set; }

    public virtual LifeCycleMap Source { get; set; } = null!;

    public virtual ICollection<StateEmail> StateEmails { get; set; } = new List<StateEmail>();

    public virtual ICollection<StateNotification> StateNotifications { get; set; } = new List<StateNotification>();

    public virtual ICollection<Wmsettinglcstate> Wmsettinglcstates { get; set; } = new List<Wmsettinglcstate>();
}
