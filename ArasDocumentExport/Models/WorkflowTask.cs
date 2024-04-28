using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class WorkflowTask
{
    public string Id { get; set; } = null!;

    public string? AssignedTo { get; set; }

    public string? Item { get; set; }

    public string? ItemTypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Instructions { get; set; }

    public string MyAssignment { get; set; } = null!;

    public string? Name { get; set; }

    public string Container { get; set; } = null!;

    public string ContainerTypeId { get; set; } = null!;

    public string? Status { get; set; }

    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string? CurrentState { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? IsCurrent { get; set; }

    public string? MajorRev { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public string? PermissionId { get; set; }

    public string? TeamId { get; set; }

    public string? Icon { get; set; }

    public string LanguageCodeFilter { get; set; } = null!;
}
