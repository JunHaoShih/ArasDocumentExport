using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Forum
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

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

    public string? ForumType { get; set; }

    public string? Label { get; set; }

    public string Name { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public virtual ICollection<Forumitem> Forumitems { get; set; } = new List<Forumitem>();

    public virtual ICollection<Forummessagegroup> Forummessagegroups { get; set; } = new List<Forummessagegroup>();

    public virtual ICollection<Forummustviewby> Forummustviewbies { get; set; } = new List<Forummustviewby>();

    public virtual ICollection<Forumsearch> Forumsearches { get; set; } = new List<Forumsearch>();

    public virtual ICollection<Forumsharedwith> Forumsharedwiths { get; set; } = new List<Forumsharedwith>();

    public virtual ICollection<Forumwantviewby> Forumwantviewbies { get; set; } = new List<Forumwantviewby>();
}
