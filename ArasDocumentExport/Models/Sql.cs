using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Sql
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

    public int? ExecutionCount { get; set; }

    public string? ExecutionFlag { get; set; }

    public string? OldName { get; set; }

    public string? OracleBody { get; set; }

    public string? SqlserverBody { get; set; }

    public string? Stale { get; set; }

    public string? TransformFirst { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<SqlDependency> SqlDependencyRelateds { get; set; } = new List<SqlDependency>();

    public virtual ICollection<SqlDependency> SqlDependencySources { get; set; } = new List<SqlDependency>();
}
