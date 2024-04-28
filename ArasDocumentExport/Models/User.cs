using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class User
{
    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string? Cell { get; set; }

    public string? CompanyName { get; set; }

    public string? DefaultVault { get; set; }

    public string? Email { get; set; }

    public string? Esignature { get; set; }

    public string? Fax { get; set; }

    public string? FirstName { get; set; }

    public string? HomePhone { get; set; }

    public string? Label { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public string? LastName { get; set; }

    public string? LogonEnabled { get; set; }

    public string? MailStop { get; set; }

    public string? Manager { get; set; }

    public string? Pager { get; set; }

    public string? Password { get; set; }

    public string? Picture { get; set; }

    public DateTime? PwdIsSetOn { get; set; }

    public string? StartingPage { get; set; }

    public string? Telephone { get; set; }

    public string? UserNo { get; set; }

    public string? WorkingDirectory { get; set; }

    public string LoginName { get; set; } = null!;

    public string ConfigId { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? Css { get; set; }

    public string? CurrentState { get; set; }

    public int? Generation { get; set; }

    public string Id { get; set; } = null!;

    public string? IsCurrent { get; set; }

    public string? IsReleased { get; set; }

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

    public virtual ICollection<Alias> Aliases { get; set; } = new List<Alias>();

    public virtual ICollection<Discussion> Discussions { get; set; } = new List<Discussion>();

    public virtual ICollection<Lockeditem> Lockeditems { get; set; } = new List<Lockeditem>();

    public virtual ICollection<MessageAcknowledgement> MessageAcknowledgements { get; set; } = new List<MessageAcknowledgement>();

    public virtual ICollection<OldPassword> OldPasswords { get; set; } = new List<OldPassword>();

    public virtual ICollection<Readpriority> Readpriorities { get; set; } = new List<Readpriority>();

    public virtual ICollection<Runreportbyuser> Runreportbyusers { get; set; } = new List<Runreportbyuser>();
}
