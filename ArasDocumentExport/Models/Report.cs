using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Report
{
    public string? IsCurrent { get; set; }

    public string? OwnedById { get; set; }

    public string? IsReleased { get; set; }

    public string? MajorRev { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? CurrentState { get; set; }

    public string ConfigId { get; set; } = null!;

    public string? NotLockable { get; set; }

    public string? State { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string Id { get; set; } = null!;

    public string? ManagedById { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? NewVersion { get; set; }

    public string? LockedById { get; set; }

    public string? Classification { get; set; }

    public string PermissionId { get; set; } = null!;

    public string? MinorRev { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string? KeyedName { get; set; }

    public string? Description { get; set; }

    public string? Label { get; set; }

    public string? Location { get; set; }

    public string? Method { get; set; }

    public string? ReportQuery { get; set; }

    public string? Target { get; set; }

    public string? Type { get; set; }

    public string? XslStylesheet { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ItemReport> ItemReports { get; set; } = new List<ItemReport>();
}
