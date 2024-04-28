using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class CmfTabularviewcolumn
{
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

    public int ColOrder { get; set; }

    public string? ContentStyle { get; set; }

    public string? DatePattern { get; set; }

    public string? EditorDataSourceList { get; set; }

    public string? EditorDataSourceMethod { get; set; }

    public string? EditorHeader1ForListLabel { get; set; }

    public int? EditorHeader1Width { get; set; }

    public string? EditorHeader2ForListValue { get; set; }

    public int? EditorHeader2Width { get; set; }

    public string? EditorUseBoth { get; set; }

    public string? Header { get; set; }

    public string? HeaderStyle { get; set; }

    public int InitialWidth { get; set; }

    public string? RelatedId { get; set; }

    public string? Classification { get; set; }

    public string Property { get; set; } = null!;

    public virtual ICollection<CmfAdditionalpropertytype> CmfAdditionalpropertytypes { get; set; } = new List<CmfAdditionalpropertytype>();

    public virtual CmfTabularview? Source { get; set; }
}
