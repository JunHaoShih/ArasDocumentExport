using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Message
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

    public string Acknowledge { get; set; } = null!;

    public string? CustomHtml { get; set; }

    public string? ExitButtonLabel { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public int? Height { get; set; }

    public string? Icon { get; set; }

    public string? IsStandardTemplate { get; set; }

    public string? MessageNumber { get; set; }

    public string? OkButtonLabel { get; set; }

    public string Priority { get; set; } = null!;

    public string? ShowExitButton { get; set; }

    public string? ShowOkButton { get; set; }

    public string Target { get; set; } = null!;

    public string? Text { get; set; }

    public string? Title { get; set; }

    public string Type { get; set; } = null!;

    public string? Url { get; set; }

    public int? Width { get; set; }

    public virtual ICollection<MessageAcknowledgement> MessageAcknowledgements { get; set; } = new List<MessageAcknowledgement>();
}
