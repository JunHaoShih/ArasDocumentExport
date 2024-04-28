using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Replicationrule
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

    public string? Behavior { get; set; }

    public int? SortOrder { get; set; }

    public string? TeamId { get; set; }

    public string? DoReplicate { get; set; }

    public string InitiatorType { get; set; } = null!;

    public string? IsActive { get; set; }

    public string? Label { get; set; }

    public string? MaxWait { get; set; }

    public string ReplicationMode { get; set; } = null!;

    public string? ReplicationTime { get; set; }

    public string? ReplicationType { get; set; }

    public string? RelatedId { get; set; }

    public string? SourceId { get; set; }

    public virtual Identity? Related { get; set; }

    public virtual ICollection<Replicationrulefiletype> Replicationrulefiletypes { get; set; } = new List<Replicationrulefiletype>();

    public virtual ICollection<Replicationruletargetvault> Replicationruletargetvaults { get; set; } = new List<Replicationruletargetvault>();

    public virtual Vault? Source { get; set; }
}
