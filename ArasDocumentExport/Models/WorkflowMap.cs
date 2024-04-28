using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class WorkflowMap
{
    public string? ArasUniquenessHelper { get; set; }

    public string ConfigId { get; set; } = null!;

    public string? NewVersion { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public int? Generation { get; set; }

    public string? Comments { get; set; }

    public string? Description { get; set; }

    public string? Label { get; set; }

    public string? NodeBgColor { get; set; }

    public string? NodeLabel1Color { get; set; }

    public string? NodeLabel1Font { get; set; }

    public string? NodeLabel2Color { get; set; }

    public string? NodeLabel2Font { get; set; }

    public string? NodeNameColor { get; set; }

    public string? NodeNameFont { get; set; }

    public string? NodeSize { get; set; }

    public string? ProcessOwner { get; set; }

    public string? TransitionLineColor { get; set; }

    public string? TransitionNameColor { get; set; }

    public string? TransitionNameFont { get; set; }

    public string Name { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? Css { get; set; }

    public string? CurrentState { get; set; }

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

    public string? NotLockable { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public string? State { get; set; }

    public DateTime? SupersededDate { get; set; }

    public virtual ICollection<AllowedWorkflow> AllowedWorkflows { get; set; } = new List<AllowedWorkflow>();

    public virtual ICollection<WorkflowMapActivity> WorkflowMapActivities { get; set; } = new List<WorkflowMapActivity>();

    public virtual ICollection<WorkflowMapVariable> WorkflowMapVariables { get; set; } = new List<WorkflowMapVariable>();
}
