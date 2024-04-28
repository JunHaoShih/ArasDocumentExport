using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class ManufacturerPart
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

    public string? Description { get; set; }

    public string? HasFiles { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? Name { get; set; }

    public string? Unit { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? State { get; set; }

    public string? Manufacturer { get; set; }

    public virtual ICollection<ManufacturerPartFile> ManufacturerPartFiles { get; set; } = new List<ManufacturerPartFile>();

    public virtual ICollection<ManufacturerPartPart> ManufacturerPartParts { get; set; } = new List<ManufacturerPartPart>();

    public virtual ICollection<PartAml> PartAmls { get; set; } = new List<PartAml>();

    public virtual ICollection<VendorPart> VendorParts { get; set; } = new List<VendorPart>();
}
