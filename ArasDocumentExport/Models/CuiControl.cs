using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class CuiControl
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

    public string? AdditionalData { get; set; }

    public string? AriaLabel { get; set; }

    public string ControlType { get; set; } = null!;

    public string? Label { get; set; }

    public string Name { get; set; } = null!;

    public string? Location { get; set; }

    public string? ParentControl { get; set; }

    public virtual ICollection<CuiControlcommandbaritem> CuiControlcommandbaritems { get; set; } = new List<CuiControlcommandbaritem>();

    public virtual ICollection<CuiControleventhandler> CuiControleventhandlers { get; set; } = new List<CuiControleventhandler>();

    public virtual ICollection<CuiWindowsectioncontrol> CuiWindowsectioncontrols { get; set; } = new List<CuiWindowsectioncontrol>();
}
