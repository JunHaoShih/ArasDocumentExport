using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class MpoMasspromotion
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

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

    public string Idlist { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string ItemTypeId { get; set; } = null!;

    public string ItemtypeName { get; set; } = null!;

    public string LifeCycleMapId { get; set; } = null!;

    public string LifeCycleMapName { get; set; } = null!;

    public string PromotedById { get; set; } = null!;

    public string TargetState { get; set; } = null!;

    public string? TransitionComment { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<MpoMasspromotionrecord> MpoMasspromotionrecords { get; set; } = new List<MpoMasspromotionrecord>();
}
