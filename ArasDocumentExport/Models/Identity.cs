using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Identity
{
    public string? TeamId { get; set; }

    public string? Description { get; set; }

    public string? IsAlias { get; set; }

    public string? Label { get; set; }

    public int? MaximumPwdAge { get; set; }

    public int? PwdHistoryLength { get; set; }

    public string Name { get; set; } = null!;

    public string? Classification { get; set; }

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

    public virtual ICollection<AccessExplicitdefine> AccessExplicitdefines { get; set; } = new List<AccessExplicitdefine>();

    public virtual ICollection<AccessItemclassification> AccessItemclassifications { get; set; } = new List<AccessItemclassification>();

    public virtual ICollection<AccessPropertyvalue> AccessPropertyvalues { get; set; } = new List<AccessPropertyvalue>();

    public virtual ICollection<Access> Accesses { get; set; } = new List<Access>();

    public virtual ICollection<ActivityAssignment> ActivityAssignments { get; set; } = new List<ActivityAssignment>();

    public virtual ICollection<ActivityTemplateAssignment> ActivityTemplateAssignments { get; set; } = new List<ActivityTemplateAssignment>();

    public virtual ICollection<Alias> Aliases { get; set; } = new List<Alias>();

    public virtual ICollection<CanAdd> CanAdds { get; set; } = new List<CanAdd>();

    public virtual ICollection<Favoritemustviewby> Favoritemustviewbies { get; set; } = new List<Favoritemustviewby>();

    public virtual ICollection<Member> MemberRelateds { get; set; } = new List<Member>();

    public virtual ICollection<Member> MemberSources { get; set; } = new List<Member>();

    public virtual ICollection<MpMacpolicyexemptidentity> MpMacpolicyexemptidentities { get; set; } = new List<MpMacpolicyexemptidentity>();

    public virtual ICollection<RelationshipView> RelationshipViews { get; set; } = new List<RelationshipView>();

    public virtual ICollection<Replicationrule> Replicationrules { get; set; } = new List<Replicationrule>();

    public virtual ICollection<Securemessagevisibilityfilter> Securemessagevisibilityfilters { get; set; } = new List<Securemessagevisibilityfilter>();

    public virtual ICollection<Selfservicereportsharedwith> Selfservicereportsharedwiths { get; set; } = new List<Selfservicereportsharedwith>();

    public virtual ICollection<StateDistribution> StateDistributions { get; set; } = new List<StateDistribution>();

    public virtual ICollection<StateNotification> StateNotifications { get; set; } = new List<StateNotification>();

    public virtual ICollection<TeamIdentity> TeamIdentities { get; set; } = new List<TeamIdentity>();

    public virtual ICollection<TocAccess> TocAccesses { get; set; } = new List<TocAccess>();

    public virtual ICollection<TocView> TocViews { get; set; } = new List<TocView>();

    public virtual ICollection<TransitionDistribution> TransitionDistributions { get; set; } = new List<TransitionDistribution>();
}
