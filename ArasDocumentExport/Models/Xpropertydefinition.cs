using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Xpropertydefinition
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

    public string? ColumnAlignment { get; set; }

    public int? ColumnWidth { get; set; }

    public string? DataSource { get; set; }

    public string DataType { get; set; } = null!;

    public string? DefaultValue { get; set; }

    public string? IsIndexed { get; set; }

    public string? IsRequired { get; set; }

    public string? Label { get; set; }

    public string? Pattern { get; set; }

    public int? Prec { get; set; }

    public string PrivatePermissionBehavior { get; set; } = null!;

    public string? Readonly { get; set; }

    public int? Scale { get; set; }

    public int? StoredLength { get; set; }

    public string? TrackHistory { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<FrReptypeCharacteristic> FrReptypeCharacteristics { get; set; } = new List<FrReptypeCharacteristic>();

    public virtual ICollection<ItemtypeXpropertydefinition> ItemtypeXpropertydefinitions { get; set; } = new List<ItemtypeXpropertydefinition>();

    public virtual ICollection<XclassXpropertyFlatten> XclassXpropertyFlattens { get; set; } = new List<XclassXpropertyFlatten>();

    public virtual ICollection<XclassXpropertydefinition> XclassXpropertydefinitions { get; set; } = new List<XclassXpropertydefinition>();

    public virtual ICollection<Xitemtypeallowedproperty> Xitemtypeallowedproperties { get; set; } = new List<Xitemtypeallowedproperty>();
}
