using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class SsvcPreference
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

    public string? SourceId { get; set; }

    public string? Behavior { get; set; }

    public int? SortOrder { get; set; }

    public string? TeamId { get; set; }

    public string DefaultBookmark { get; set; } = null!;

    public int DefaultFlaggedByNumber { get; set; }

    public int DefaultRepliesNumber { get; set; }

    public string? DescDigestNotifications { get; set; }

    public string? DescSingleNotifications { get; set; }

    public string EnableEmailDigestNotification { get; set; } = null!;

    public string EnableImmediateNotifications { get; set; } = null!;

    public string EnableInAppNotifications { get; set; } = null!;

    public DateTime? LastScheduledDigestTimeDate { get; set; }

    public int MessagesMaxLines { get; set; }

    public string? PrefixForHighlightTextMarkup { get; set; }

    public string? SubjectDigestNotifications { get; set; }

    public string? SubjectSingleNotifications { get; set; }

    public int TimeDigestInterval { get; set; }

    public string? UseLegacy3dViewFiles { get; set; }

    public string? UseStandardToolbarForViewers { get; set; }

    public string? ZoomToCursorForMonolithic { get; set; }

    public string? RelatedId { get; set; }

    public virtual Preference? Source { get; set; }
}
