using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class CmfPropertytype
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

    public string? SourceId { get; set; }

    public string? Behavior { get; set; }

    public int? SortOrder { get; set; }

    public string? TeamId { get; set; }

    public int? DataLength { get; set; }

    public string DataType { get; set; } = null!;

    public string? DefaultPermission { get; set; }

    public string? GeneratedType { get; set; }

    public string? UiComputedProperty { get; set; }

    public string? RelatedId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CmfComputedproperty> CmfComputedproperties { get; set; } = new List<CmfComputedproperty>();

    public virtual ICollection<CmfComputedpropertydependency> CmfComputedpropertydependencies { get; set; } = new List<CmfComputedpropertydependency>();

    public virtual ICollection<CmfPropertyallowedpermission> CmfPropertyallowedpermissions { get; set; } = new List<CmfPropertyallowedpermission>();

    public virtual CmfElementtype? Source { get; set; }
}
