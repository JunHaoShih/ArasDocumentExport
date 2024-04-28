using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Wmitemtype
{
    public int? Classification { get; set; }

    public int? KeyedName { get; set; }

    public int? Id { get; set; }

    public int? CreatedOn { get; set; }

    public int? CreatedById { get; set; }

    public int? OwnedById { get; set; }

    public int? ManagedById { get; set; }

    public int? ModifiedOn { get; set; }

    public int? ModifiedById { get; set; }

    public int? CurrentState { get; set; }

    public int? State { get; set; }

    public int? LockedById { get; set; }

    public int? IsCurrent { get; set; }

    public int? MajorRev { get; set; }

    public int? MinorRev { get; set; }

    public int? IsReleased { get; set; }

    public int? NotLockable { get; set; }

    public int? Css { get; set; }

    public int? Generation { get; set; }

    public int? NewVersion { get; set; }

    public int? ConfigId { get; set; }

    public int? PermissionId { get; set; }

    public int? TeamId { get; set; }

    public int? Itemtype { get; set; }
}
