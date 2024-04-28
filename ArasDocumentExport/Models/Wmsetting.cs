using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Wmsetting
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

    public string? DefaultWmSet { get; set; }

    public string Name { get; set; } = null!;

    public string ItemType { get; set; } = null!;

    public virtual ICollection<Wmsettingcontent> Wmsettingcontents { get; set; } = new List<Wmsettingcontent>();

    public virtual ICollection<Wmsettinglcstate> Wmsettinglcstates { get; set; } = new List<Wmsettinglcstate>();
}
