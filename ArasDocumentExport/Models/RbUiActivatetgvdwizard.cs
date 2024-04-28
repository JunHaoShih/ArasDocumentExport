using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class RbUiActivatetgvdwizard
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

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

    public string PermissionId { get; set; } = null!;

    public string? TeamId { get; set; }

    public string? AccessIdentity { get; set; }

    public string? IsStartcondition { get; set; }

    public string? ItemType { get; set; }

    public string? Label { get; set; }

    public string? NewExistList { get; set; }

    public string? RelationshipName { get; set; }

    public string? RelationshipNames { get; set; }

    public string? TargetUsage { get; set; }
}
