using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Field
{
    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? BgColor { get; set; }

    public int? BorderWidth { get; set; }

    public string? ClipOverflow { get; set; }

    public string? ClipRectangle { get; set; }

    public string? Container { get; set; }

    public string? DefaultValue { get; set; }

    public int? DisplayLength { get; set; }

    public string? DisplayLengthUnit { get; set; }

    public string? FieldType { get; set; }

    public string? FontColor { get; set; }

    public string? FontFamily { get; set; }

    public string? FontSize { get; set; }

    public string? FontWeight { get; set; }

    public int? Height { get; set; }

    public string? HtmlCode { get; set; }

    public string? IsDisabled { get; set; }

    public string? IsVisible { get; set; }

    public string? Label { get; set; }

    public string? LabelPosition { get; set; }

    public string? Legend { get; set; }

    public string? ListNoBlank { get; set; }

    public int? ListboxSize { get; set; }

    public string? Name { get; set; }

    public string? Orientation { get; set; }

    public string? Positioning { get; set; }

    public string? PropertytypeId { get; set; }

    public int? TabIndex { get; set; }

    public string? TabStop { get; set; }

    public string? TextAlign { get; set; }

    public int? TextareaCols { get; set; }

    public int? TextareaRows { get; set; }

    public int? Width { get; set; }

    public int? X { get; set; }

    public int? XclassFieldWidth { get; set; }

    public int? XclassTextWidth { get; set; }

    public int? Y { get; set; }

    public int? ZIndex { get; set; }

    public string? Behavior { get; set; }

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

    public string? RelatedId { get; set; }

    public int? SortOrder { get; set; }

    public string SourceId { get; set; } = null!;

    public string? State { get; set; }

    public virtual ICollection<FieldEvent> FieldEvents { get; set; } = new List<FieldEvent>();

    public virtual Body Source { get; set; } = null!;
}
