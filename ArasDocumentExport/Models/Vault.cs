using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Vault
{
    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? Label { get; set; }

    public string VaultUrlPattern { get; set; } = null!;

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

    public virtual ICollection<Conversionserverpriority> Conversionserverpriorities { get; set; } = new List<Conversionserverpriority>();

    public virtual ICollection<Located> Locateds { get; set; } = new List<Located>();

    public virtual ICollection<Readpriority> Readpriorities { get; set; } = new List<Readpriority>();

    public virtual ICollection<Replicationrule> Replicationrules { get; set; } = new List<Replicationrule>();

    public virtual ICollection<Replicationruletargetvault> Replicationruletargetvaults { get; set; } = new List<Replicationruletargetvault>();
}
