using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class MpMacpolicy
{
    public string? ArasUniquenessHelper { get; set; }

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

    public DateTime? ReleaseDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? TeamId { get; set; }

    public string? CanDelete { get; set; }

    public string? CanDiscover { get; set; }

    public string? CanGet { get; set; }

    public string? CanUpdate { get; set; }

    public string? Description { get; set; }

    public string? ShowPermissionsWarning { get; set; }

    public string Name { get; set; } = null!;

    public string? State { get; set; }

    public DateTime? SupersededDate { get; set; }

    public virtual ICollection<MpMaccondition> MpMacconditions { get; set; } = new List<MpMaccondition>();

    public virtual ICollection<MpMacpolicycontrolledtype> MpMacpolicycontrolledtypes { get; set; } = new List<MpMacpolicycontrolledtype>();

    public virtual ICollection<MpMacpolicyexemptidentity> MpMacpolicyexemptidentities { get; set; } = new List<MpMacpolicyexemptidentity>();
}
