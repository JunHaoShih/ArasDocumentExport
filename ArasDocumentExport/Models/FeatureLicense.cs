using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class FeatureLicense
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

    public string? AvailableTo { get; set; }

    public int? ConcurrentUserCount { get; set; }

    public string? DatabaseEngineEdition { get; set; }

    public string? DatabaseServerName { get; set; }

    public string? Domain { get; set; }

    public string EnforcementMode { get; set; } = null!;

    public string? ExpirationDate { get; set; }

    public string Feature { get; set; } = null!;

    public string? FrameworkLicenseKey { get; set; }

    public string? InnovatorServerLocale { get; set; }

    public string? InnovatorServerName { get; set; }

    public string? IssuedTo { get; set; }

    public string? LicenseData { get; set; }

    public string? LicenseDescription { get; set; }

    public string? Login { get; set; }

    public string? MacAddress { get; set; }

    public string? NamedUserList { get; set; }

    public string? Password { get; set; }

    public string? StartDate { get; set; }

    public int? TotalUsers { get; set; }

    public string ActivationKey { get; set; } = null!;
}
