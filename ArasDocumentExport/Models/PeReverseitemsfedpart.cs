using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class PeReverseitemsfedpart
{
    public string? ArasUniquenessHelper { get; set; }

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

    public DateTime? ReleaseDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? TeamId { get; set; }

    public decimal? Cost { get; set; }

    public string? HasChangePending { get; set; }

    public string? ItOpenIcon { get; set; }

    public string? ItemNumber { get; set; }

    public string? LinkStatus { get; set; }

    public string? Name { get; set; }

    public string? RealItName { get; set; }

    public string? Classification { get; set; }

    public string? State { get; set; }

    public DateTime? SupersededDate { get; set; }
}
