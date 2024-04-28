using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class ActivityTemplate
{
    public string? Classification { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? State { get; set; }

    public string? CurrentState { get; set; }

    public string? MajorRev { get; set; }

    public string? IsCurrent { get; set; }

    public string? LockedById { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public string? KeyedName { get; set; }

    public string? CanDelegate { get; set; }

    public string? CanRefuse { get; set; }

    public string? ConsolidateOndelegate { get; set; }

    public string? EscalateTo { get; set; }

    public int? ExpectedDuration { get; set; }

    public string? Icon { get; set; }

    public string? IsAuto { get; set; }

    public string? IsEnd { get; set; }

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

    public virtual ICollection<ActivityTemplateAssignment> ActivityTemplateAssignments { get; set; } = new List<ActivityTemplateAssignment>();

    public virtual ICollection<ActivityTemplateEmail> ActivityTemplateEmails { get; set; } = new List<ActivityTemplateEmail>();

    public virtual ICollection<ActivityTemplateMethod> ActivityTemplateMethods { get; set; } = new List<ActivityTemplateMethod>();

    public virtual ICollection<ActivityTemplateTask> ActivityTemplateTasks { get; set; } = new List<ActivityTemplateTask>();

    public virtual ICollection<ActivityTemplateTransition> ActivityTemplateTransitions { get; set; } = new List<ActivityTemplateTransition>();

    public virtual ICollection<ActivityTemplateVariable> ActivityTemplateVariables { get; set; } = new List<ActivityTemplateVariable>();

    public virtual ICollection<WorkflowMapActivity> WorkflowMapActivities { get; set; } = new List<WorkflowMapActivity>();
}
