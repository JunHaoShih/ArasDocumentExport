using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Property
{
    public string? PermissionId { get; set; }

    public string? NotLockable { get; set; }

    public string? ClassPath { get; set; }

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public string? ForeignProperty { get; set; }

    public string? IsReleased { get; set; }

    public int? Generation { get; set; }

    public string? ItemBehavior { get; set; }

    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public string SourceId { get; set; } = null!;

    public string? RelatedId { get; set; }

    public int? SortOrder { get; set; }

    public string? IsHidden { get; set; }

    public int? OrderBy { get; set; }

    public string? DefaultSearch { get; set; }

    public string? IsRequired { get; set; }

    public string? IsIndexed { get; set; }

    public string? IsHidden2 { get; set; }

    public int? ColumnWidth { get; set; }

    public string? Behavior { get; set; }

    public string? MajorRev { get; set; }

    public string? KeyedName { get; set; }

    public string? IsCurrent { get; set; }

    public string? Readonly { get; set; }

    public string? State { get; set; }

    public string? IsMultiValued { get; set; }

    public string? MinorRev { get; set; }

    public string Id { get; set; } = null!;

    public int? MinRange { get; set; }

    public string CreatedById { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public string? CurrentState { get; set; }

    public string? RangeInclusive { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? MaxRange { get; set; }

    public string? ModifiedById { get; set; }

    public string? LockedById { get; set; }

    public string? ColumnAlignment { get; set; }

    public string? DataSource { get; set; }

    public int? StoredLength { get; set; }

    public int? Prec { get; set; }

    public int? Scale { get; set; }

    public int? CategoryBy { get; set; }

    public int? KeyedNameOrder { get; set; }

    public string? Pattern { get; set; }

    public string IsKeyed { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? HelpTooltip { get; set; }

    public string? Label { get; set; }

    public string? TrackHistory { get; set; }

    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? Css { get; set; }

    public string? HelpText { get; set; }

    public string? DefaultValue { get; set; }

    public string DataType { get; set; } = null!;

    public string? IsFederated { get; set; }

    public virtual ICollection<GridEvent> GridEvents { get; set; } = new List<GridEvent>();

    public virtual Itemtype Source { get; set; } = null!;
}
