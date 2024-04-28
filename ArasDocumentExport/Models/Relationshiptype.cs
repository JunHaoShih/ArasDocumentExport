using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Relationshiptype
{
    public int? Generation { get; set; }

    public string? RelatedOption { get; set; }

    public string? RelatedNotnull { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public string? IncRelatedKeyName { get; set; }

    public string ConfigId { get; set; } = null!;

    public string? NewVersion { get; set; }

    public string? ManagedById { get; set; }

    public int? DefaultPageSize { get; set; }

    public string Id { get; set; } = null!;

    public string? MinorRev { get; set; }

    public string? AutoSearch { get; set; }

    public string? CurrentState { get; set; }

    public string? HideInAll { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public int? MaxOccurs { get; set; }

    public string? Behavior { get; set; }

    public string? GridView { get; set; }

    public int? MinOccurs { get; set; }

    public string? IsReleased { get; set; }

    public string? CopyPermissions { get; set; }

    public string? CreateRelated { get; set; }

    public string? HelpItem { get; set; }

    public string? HelpUrl { get; set; }

    public string? IncRelKeyName { get; set; }

    public string? Description { get; set; }

    public string? Core { get; set; }

    public string? RelatedId { get; set; }

    public string? RelationshipId { get; set; }

    public string? NotLockable { get; set; }

    public string? NewShowRelated { get; set; }

    public string? SourceId { get; set; }

    public string? IsCurrent { get; set; }

    public string? IsListType { get; set; }

    public string? MajorRev { get; set; }

    public string? ModifiedById { get; set; }

    public string? KeyedName { get; set; }

    public string? LockedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? State { get; set; }

    public int? SortOrder { get; set; }

    public string? Label { get; set; }

    public string Name { get; set; } = null!;

    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? Css { get; set; }

    public virtual ICollection<Exclusion> ExclusionRelateds { get; set; } = new List<Exclusion>();

    public virtual ICollection<Exclusion> ExclusionSources { get; set; } = new List<Exclusion>();

    public virtual ICollection<HideIn> HideIns { get; set; } = new List<HideIn>();

    public virtual ICollection<HideRelatedIn> HideRelatedIns { get; set; } = new List<HideRelatedIn>();

    public virtual Itemtype? Related { get; set; }

    public virtual ICollection<RelationshipGridEvent> RelationshipGridEvents { get; set; } = new List<RelationshipGridEvent>();

    public virtual ICollection<RelationshipView> RelationshipViews { get; set; } = new List<RelationshipView>();

    public virtual Itemtype? Source { get; set; }
}
