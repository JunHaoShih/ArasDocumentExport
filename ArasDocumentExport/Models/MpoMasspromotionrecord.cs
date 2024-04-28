using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class MpoMasspromotionrecord
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

    public string? AfterPromoteItemId { get; set; }

    public string BeforePromoteItemId { get; set; } = null!;

    public string? GotComment { get; set; }

    public string? IsPromoted { get; set; }

    public string ItemConfigId { get; set; } = null!;

    public string ItemKeyedName { get; set; } = null!;

    public string StateBefore { get; set; } = null!;

    public string StatusError { get; set; } = null!;

    public string? RelatedId { get; set; }

    public virtual MpoMasspromotion? Source { get; set; }
}
