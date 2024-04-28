﻿using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Form
{
    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? Core { get; set; }

    public string? Description { get; set; }

    public int Height { get; set; }

    public string? Label { get; set; }

    public string? Stylesheet { get; set; }

    public int Width { get; set; }

    public string Name { get; set; } = null!;

    public string ConfigId { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? Css { get; set; }

    public string? CurrentState { get; set; }

    public int? Generation { get; set; }

    public string Id { get; set; } = null!;

    public string? IsCurrent { get; set; }

    public string? IsReleased { get; set; }

    public string? KeyedName { get; set; }

    public string? LockedById { get; set; }

    public string? MajorRev { get; set; }

    public string? ManagedById { get; set; }

    public string? MinorRev { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? NewVersion { get; set; }

    public string? NotLockable { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public string? State { get; set; }

    public virtual ICollection<Body> Bodies { get; set; } = new List<Body>();

    public virtual ICollection<FormEvent> FormEvents { get; set; } = new List<FormEvent>();

    public virtual ICollection<Frameset> Framesets { get; set; } = new List<Frameset>();

    public virtual ICollection<View> Views { get; set; } = new List<View>();
}
