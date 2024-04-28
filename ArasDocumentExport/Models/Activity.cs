using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Activity
{
    public string? Classification { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public string? CurrentState { get; set; }

    public string? ModifiedById { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? MinorRev { get; set; }

    public string? MajorRev { get; set; }

    public string? IsCurrent { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public string? KeyedName { get; set; }

    public DateTime? ActiveDate { get; set; }

    public string? CanDelegate { get; set; }

    public string? CanRefuse { get; set; }

    public string? ClonedAs { get; set; }

    public DateTime? ClosedDate { get; set; }

    public string? ConsolidateOndelegate { get; set; }

    public string? EscalateTo { get; set; }

    public int? ExpectedDuration { get; set; }

    public string? Icon { get; set; }

    public string? IsAuto { get; set; }

    public string? IsEnd { get; set; }

    public string? IsEscalated { get; set; }

    public string? IsStart { get; set; }

    public string? Label { get; set; }

    public string? Message { get; set; }

    public string Name { get; set; } = null!;

    public int? Priority { get; set; }

    public int? ReminderCount { get; set; }

    public int? ReminderInterval { get; set; }

    public string? Role { get; set; }

    public string? Subflow { get; set; }

    public int? TimeoutDuration { get; set; }

    public string? WaitForAllInputs { get; set; }

    public string? WaitForAllVotes { get; set; }

    public int? X { get; set; }

    public int? Y { get; set; }

    public string ConfigId { get; set; } = null!;

    public int? Generation { get; set; }

    public string? ManagedById { get; set; }

    public string? NewVersion { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public virtual ICollection<ActivityAssignment> ActivityAssignments { get; set; } = new List<ActivityAssignment>();

    public virtual ICollection<ActivityEmail> ActivityEmails { get; set; } = new List<ActivityEmail>();

    public virtual ICollection<ActivityMethod> ActivityMethods { get; set; } = new List<ActivityMethod>();

    public virtual ICollection<ActivityTask> ActivityTasks { get; set; } = new List<ActivityTask>();

    public virtual ICollection<ActivityTransition> ActivityTransitions { get; set; } = new List<ActivityTransition>();

    public virtual ICollection<ActivityVariable> ActivityVariables { get; set; } = new List<ActivityVariable>();

    public virtual ICollection<WorkflowProcessActivity> WorkflowProcessActivities { get; set; } = new List<WorkflowProcessActivity>();
}
