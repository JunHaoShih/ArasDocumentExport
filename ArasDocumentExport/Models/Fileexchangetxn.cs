using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Fileexchangetxn
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

    public string? Comments { get; set; }

    public string? Data { get; set; }

    public string? Error { get; set; }

    public string? Package { get; set; }

    public string ServiceProvider { get; set; } = null!;

    public int? TransferAttempts { get; set; }

    public string TxnStatus { get; set; } = null!;

    public string TxnType { get; set; } = null!;

    public string? TxnNumber { get; set; }

    public virtual ICollection<Fileexchangetxnstate> Fileexchangetxnstates { get; set; } = new List<Fileexchangetxnstate>();
}
