using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class RbTreegridviewdefinition
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

    public string? Description { get; set; }

    public int? MaxChildItems { get; set; }

    public int? MaxQueryDepth { get; set; }

    public int? MaxQueryDepthIsOnload { get; set; }

    public string QueryDefinition { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<RbColumndefinition> RbColumndefinitions { get; set; } = new List<RbColumndefinition>();

    public virtual ICollection<RbLocalstyle> RbLocalstyles { get; set; } = new List<RbLocalstyle>();

    public virtual ICollection<RbParameterviewmodel> RbParameterviewmodels { get; set; } = new List<RbParameterviewmodel>();

    public virtual ICollection<RbQuerydefinitionparametermap> RbQuerydefinitionparametermaps { get; set; } = new List<RbQuerydefinitionparametermap>();

    public virtual ICollection<RbTreerowdefinition> RbTreerowdefinitions { get; set; } = new List<RbTreerowdefinition>();

    public virtual ICollection<RbTreerowreference> RbTreerowreferences { get; set; } = new List<RbTreerowreference>();

    public virtual ICollection<RbUiCelleditor> RbUiCelleditors { get; set; } = new List<RbUiCelleditor>();
}
