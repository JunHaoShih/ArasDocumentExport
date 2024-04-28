using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Ecr
{
    public DateTime? ReleaseDate { get; set; }

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

    public string? Basis { get; set; }

    public string? ChangeAdmin { get; set; }

    public string? ChangeType { get; set; }

    public string? Description { get; set; }

    public string? EcrComments { get; set; }

    public string? FastTrack { get; set; }

    public string? ImplementationPriority { get; set; }

    public string? ImplementationTiming { get; set; }

    public string? ItemNumber { get; set; }

    public string? LowNonrecurringCost { get; set; }

    public double? NonrecurringCost { get; set; }

    public string? Priority { get; set; }

    public string? ProblemStatus { get; set; }

    public string? ProposedSolution { get; set; }

    public double? RecurringCost { get; set; }

    public string? RecurringCostDirection { get; set; }

    public string? RequestedBy { get; set; }

    public string? Routing { get; set; }

    public string? Solution { get; set; }

    public string? Source { get; set; }

    public string? TechnicalReview { get; set; }

    public string? Title { get; set; }

    public string? State { get; set; }

    public virtual ICollection<EcnEcr> EcnEcrs { get; set; } = new List<EcnEcr>();

    public virtual ICollection<EcrAffectedItem> EcrAffectedItems { get; set; } = new List<EcrAffectedItem>();

    public virtual ICollection<EcrFile> EcrFiles { get; set; } = new List<EcrFile>();

    public virtual ICollection<EcrPr> EcrPrs { get; set; } = new List<EcrPr>();
}
