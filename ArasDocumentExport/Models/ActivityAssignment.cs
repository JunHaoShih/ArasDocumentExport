using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class ActivityAssignment
{
    public string? KeyedName { get; set; }

    public string? Classification { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Id { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CurrentState { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? IsCurrent { get; set; }

    public string? IsReleased { get; set; }

    public string? MajorRev { get; set; }

    public string? MinorRev { get; set; }

    public string? NotLockable { get; set; }

    public string? RelatedId { get; set; }

    public string? SourceId { get; set; }

    public int? SortOrder { get; set; }

    public string? Behavior { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public string? ClaimedBy { get; set; }

    public string? ClosedBy { get; set; }

    public DateTime? ClosedOn { get; set; }

    public string? Comments { get; set; }

    public string? EscalateTo { get; set; }

    public string? ForAllMembers { get; set; }

    public string? IsDisabled { get; set; }

    public string? IsOverdue { get; set; }

    public string? IsRequired { get; set; }

    public string? Path { get; set; }

    public int? RemindersSent { get; set; }

    public int VotingWeight { get; set; }

    public string ConfigId { get; set; } = null!;

    public int? Generation { get; set; }

    public string? ManagedById { get; set; }

    public string? NewVersion { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public virtual ICollection<ActivityTaskValue> ActivityTaskValues { get; set; } = new List<ActivityTaskValue>();

    public virtual ICollection<ActivityVariableValue> ActivityVariableValues { get; set; } = new List<ActivityVariableValue>();

    public virtual Identity? Related { get; set; }

    public virtual Activity? Source { get; set; }
}
