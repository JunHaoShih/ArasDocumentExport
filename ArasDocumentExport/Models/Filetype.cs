using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Filetype
{
    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? Description { get; set; }

    public string Extension { get; set; } = null!;

    public string? Label { get; set; }

    public string Mimetype { get; set; } = null!;

    public string? Pattern { get; set; }

    public int? PatternOffset { get; set; }

    public int? Priority { get; set; }

    public string? RegularExpression { get; set; }

    public string? RuleType { get; set; }

    public string? UseMagicBytes { get; set; }

    public string? UseRegularExpression { get; set; }

    public string? Name { get; set; }

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

    public virtual ICollection<Conversionrulefiletype> Conversionrulefiletypes { get; set; } = new List<Conversionrulefiletype>();

    public virtual ICollection<FrRepresentationtype> FrRepresentationtypes { get; set; } = new List<FrRepresentationtype>();

    public virtual ICollection<FrSupportedfiletype> FrSupportedfiletypes { get; set; } = new List<FrSupportedfiletype>();

    public virtual ICollection<Replicationrulefiletype> Replicationrulefiletypes { get; set; } = new List<Replicationrulefiletype>();

    public virtual ICollection<ViewWith> ViewWiths { get; set; } = new List<ViewWith>();
}
