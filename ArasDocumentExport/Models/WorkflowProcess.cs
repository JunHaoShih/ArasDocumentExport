using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class WorkflowProcess
{
    public string? State { get; set; }

    public string? Classification { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CurrentState { get; set; }

    public string? LockedById { get; set; }

    public string? MinorRev { get; set; }

    public string? IsCurrent { get; set; }

    public string? MajorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public string? KeyedName { get; set; }

    public DateTime? ActiveDate { get; set; }

    public DateTime? ClosedDate { get; set; }

    public string? CopiedFrom { get; set; }

    public string? CopiedFromString { get; set; }

    public string? Description { get; set; }

    public string? Label { get; set; }

    public string Name { get; set; } = null!;

    public string? NodeBgColor { get; set; }

    public string? NodeLabel1Color { get; set; }

    public string? NodeLabel1Font { get; set; }

    public string? NodeLabel2Color { get; set; }

    public string? NodeLabel2Font { get; set; }

    public string? NodeNameColor { get; set; }

    public string? NodeNameFont { get; set; }

    public string? NodeSize { get; set; }

    public string? ProcessOwner { get; set; }

    public string? SubOf { get; set; }

    public string? TransitionLineColor { get; set; }

    public string? TransitionNameColor { get; set; }

    public string? TransitionNameFont { get; set; }

    public string ConfigId { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public int? Generation { get; set; }

    public string? ManagedById { get; set; }

    public string? NewVersion { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public virtual ICollection<WorkflowProcessActivity> WorkflowProcessActivities { get; set; } = new List<WorkflowProcessActivity>();

    public virtual ICollection<WorkflowProcessVariable> WorkflowProcessVariables { get; set; } = new List<WorkflowProcessVariable>();

    public virtual ICollection<Workflow> Workflows { get; set; } = new List<Workflow>();
}
