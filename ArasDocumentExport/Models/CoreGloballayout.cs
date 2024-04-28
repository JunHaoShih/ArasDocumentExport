using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class CoreGloballayout
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

    public string? CoreAppendItems { get; set; }

    public string? CoreDebug { get; set; }

    public int? CoreDefaultDownloadLocation { get; set; }

    public string? CoreInBasketHistory { get; set; }

    public int? CorePopupmessageTimeout { get; set; }

    public string? CoreShowItemProperties { get; set; }

    public string? CoreShowLabels { get; set; }

    public string? CoreShowScanButtonForFile { get; set; }

    public string? CoreStructureLayout { get; set; }

    public string? CoreSuccessmessageType { get; set; }

    public string? CoreTabsState { get; set; }

    public string? CoreTearOff { get; set; }

    public string? CoreTocPinned { get; set; }

    public string? CoreTocSortingType { get; set; }

    public string? CoreUseWildcards { get; set; }

    public string? RelatedId { get; set; }

    public virtual Preference? Source { get; set; }
}
