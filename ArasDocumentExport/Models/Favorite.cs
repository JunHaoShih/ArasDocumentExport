using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Favorite
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

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

    public string? AdditionalData { get; set; }

    public string Category { get; set; } = null!;

    public string? ContextType { get; set; }

    public int? FavoriteOrder { get; set; }

    public string? Label { get; set; }

    public string? QuickAccessFlag { get; set; }

    public string OwnedById { get; set; } = null!;

    public string? FolderId { get; set; }

    public virtual ICollection<Favoritemustviewby> Favoritemustviewbies { get; set; } = new List<Favoritemustviewby>();
}
