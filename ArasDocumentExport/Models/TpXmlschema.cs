using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class TpXmlschema
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

    public string Application { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string? EditorConfiguration { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TpStylesheet> TpStylesheets { get; set; } = new List<TpStylesheet>();

    public virtual ICollection<TpXmlschemaelement> TpXmlschemaelements { get; set; } = new List<TpXmlschemaelement>();

    public virtual ICollection<TpXmlschemaoutputsetting> TpXmlschemaoutputsettings { get; set; } = new List<TpXmlschemaoutputsetting>();
}
