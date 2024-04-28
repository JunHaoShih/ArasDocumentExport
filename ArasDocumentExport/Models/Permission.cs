using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Permission
{
    public string? Classification { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Id { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? State { get; set; }

    public string? CurrentState { get; set; }

    public string? LockedById { get; set; }

    public string? IsReleased { get; set; }

    public string? MinorRev { get; set; }

    public string? IsCurrent { get; set; }

    public string? MajorRev { get; set; }

    public string? NotLockable { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public string? KeyedName { get; set; }

    public string? IsPrivate { get; set; }

    public string Name { get; set; } = null!;

    public string ConfigId { get; set; } = null!;

    public int? Generation { get; set; }

    public string? ManagedById { get; set; }

    public string? NewVersion { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public virtual ICollection<Access> Accesses { get; set; } = new List<Access>();

    public virtual ICollection<AllowedPermission> AllowedPermissions { get; set; } = new List<AllowedPermission>();

    public virtual ICollection<CmfElementallowedpermission> CmfElementallowedpermissions { get; set; } = new List<CmfElementallowedpermission>();

    public virtual ICollection<CmfPropertyallowedpermission> CmfPropertyallowedpermissions { get; set; } = new List<CmfPropertyallowedpermission>();
}
