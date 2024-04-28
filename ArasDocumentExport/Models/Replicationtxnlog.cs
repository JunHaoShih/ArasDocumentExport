using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Replicationtxnlog
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

    public DateTime? EndTime { get; set; }

    public string? ErrorMsg { get; set; }

    public int ExecutionAttempt { get; set; }

    public string? FileId { get; set; }

    public string? FromVault { get; set; }

    public string? ReplicationRule { get; set; }

    public string? ReplicationStatus { get; set; }

    public DateTime? StartTime { get; set; }

    public string? ToVault { get; set; }

    public string? UserId { get; set; }
}
