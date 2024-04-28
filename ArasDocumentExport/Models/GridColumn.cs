using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class GridColumn
{
    public string Xpath { get; set; } = null!;

    public string? State { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? StartsNestedRow { get; set; }

    public string Id { get; set; } = null!;

    public string PermissionId { get; set; } = null!;

    public string? NotLockable { get; set; }

    public string Datatype { get; set; } = null!;

    public string? SelectMethod { get; set; }

    public string? KeyedName { get; set; }

    public string? MajorRev { get; set; }

    public string? RelatedId { get; set; }

    public string? LockedById { get; set; }

    public string? Classification { get; set; }

    public string? SourceForm { get; set; }

    public string Visible { get; set; } = null!;

    public int? Width { get; set; }

    public string? NewVersion { get; set; }

    public string? CurrentState { get; set; }

    public string? ManagedById { get; set; }

    public string? SourceId { get; set; }

    public string Property { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ModifiedById { get; set; }

    public int? Sort { get; set; }

    public string? IsReleased { get; set; }

    public string ConfigId { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public string? MinorRev { get; set; }

    public string? IsCurrent { get; set; }

    public string? Align { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? Behavior { get; set; }

    public int? SortOrder { get; set; }

    public string? Label { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public string? SelectQuery { get; set; }

    public int? Generation { get; set; }

    public virtual ICollection<ColumnEvent> ColumnEvents { get; set; } = new List<ColumnEvent>();

    public virtual Grid? Source { get; set; }
}
