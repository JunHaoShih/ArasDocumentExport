using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Itemtype
{
    public string? PermissionId { get; set; }

    public string? ManagedById { get; set; }

    public string ConfigId { get; set; } = null!;

    public string? InstanceData { get; set; }

    public string? NewVersion { get; set; }

    public string? OwnedById { get; set; }

    public string? HelpItem { get; set; }

    public int? Generation { get; set; }

    public string? Classification { get; set; }

    public string? ImplementationType { get; set; }

    public string? Core { get; set; }

    public string? IsVersionable { get; set; }

    public string? IsDependent { get; set; }

    public string? IsRelationship { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? HideWhereUsed { get; set; }

    public string? NotLockable { get; set; }

    public string? MajorRev { get; set; }

    public string? MinorRev { get; set; }

    public string? Revisions { get; set; }

    public string? CurrentState { get; set; }

    public string? AutoSearch { get; set; }

    public int? DefaultPageSize { get; set; }

    public string Id { get; set; } = null!;

    public string? State { get; set; }

    public string? ModifiedById { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? IsReleased { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? IsCurrent { get; set; }

    public string? LockedById { get; set; }

    public string? LargeIcon { get; set; }

    public string? UnlockOnLogout { get; set; }

    public string? CloseIcon { get; set; }

    public string? UseSrcAccess { get; set; }

    public string? OpenIcon { get; set; }

    public string? AllowPrivatePermission { get; set; }

    public int? Maxrecords { get; set; }

    public string? ShowParametersTab { get; set; }

    public string? LabelPlural { get; set; }

    public string? Label { get; set; }

    public string? HelpUrl { get; set; }

    public string? EnforceDiscovery { get; set; }

    public string Name { get; set; } = null!;

    public string? HistoryTemplate { get; set; }

    public string? TeamId { get; set; }

    public string? CacheQuery { get; set; }

    public string? ClassStructure { get; set; }

    public string? Css { get; set; }

    public string? Description { get; set; }

    public string? ImplementationDdl { get; set; }

    public string? ManualVersioning { get; set; }

    public string StructureView { get; set; } = null!;

    public string? KeyedName { get; set; }

    public virtual ICollection<AllowedPermission> AllowedPermissions { get; set; } = new List<AllowedPermission>();

    public virtual ICollection<AllowedWorkflow> AllowedWorkflows { get; set; } = new List<AllowedWorkflow>();

    public virtual ICollection<CanAdd> CanAdds { get; set; } = new List<CanAdd>();

    public virtual ICollection<ClientEvent> ClientEvents { get; set; } = new List<ClientEvent>();

    public virtual ICollection<Commandbarsectiondependency> Commandbarsectiondependencies { get; set; } = new List<Commandbarsectiondependency>();

    public virtual ICollection<CoreSearchcountmodeexception> CoreSearchcountmodeexceptions { get; set; } = new List<CoreSearchcountmodeexception>();

    public virtual ICollection<Coresearchgridenabledediting> Coresearchgridenablededitings { get; set; } = new List<Coresearchgridenabledediting>();

    public virtual ICollection<CwsItemtypereference> CwsItemtypereferences { get; set; } = new List<CwsItemtypereference>();

    public virtual ICollection<Discussiontemplate> Discussiontemplates { get; set; } = new List<Discussiontemplate>();

    public virtual ICollection<EffsScopeItemtype> EffsScopeItemtypes { get; set; } = new List<EffsScopeItemtype>();

    public virtual ICollection<GnGraphviewitemtype> GnGraphviewitemtypes { get; set; } = new List<GnGraphviewitemtype>();

    public virtual ICollection<Implement> Implements { get; set; } = new List<Implement>();

    public virtual ICollection<InheritedServerEvent> InheritedServerEvents { get; set; } = new List<InheritedServerEvent>();

    public virtual ICollection<ItemAction> ItemActions { get; set; } = new List<ItemAction>();

    public virtual ICollection<ItemReport> ItemReports { get; set; } = new List<ItemReport>();

    public virtual ICollection<ItemtypeLifeCycle> ItemtypeLifeCycles { get; set; } = new List<ItemtypeLifeCycle>();

    public virtual ICollection<ItemtypeXpropertydefinition> ItemtypeXpropertydefinitions { get; set; } = new List<ItemtypeXpropertydefinition>();

    public virtual ICollection<Itpresentationconfiguration> Itpresentationconfigurations { get; set; } = new List<Itpresentationconfiguration>();

    public virtual ICollection<Morphae> MorphaeRelateds { get; set; } = new List<Morphae>();

    public virtual ICollection<Morphae> MorphaeSources { get; set; } = new List<Morphae>();

    public virtual ICollection<MpMacpolicycontrolledtype> MpMacpolicycontrolledtypes { get; set; } = new List<MpMacpolicycontrolledtype>();

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();

    public virtual ICollection<Relationshiptype> RelationshiptypeRelateds { get; set; } = new List<Relationshiptype>();

    public virtual ICollection<Relationshiptype> RelationshiptypeSources { get; set; } = new List<Relationshiptype>();

    public virtual ICollection<ServerEvent> ServerEvents { get; set; } = new List<ServerEvent>();

    public virtual ICollection<TocAccess> TocAccesses { get; set; } = new List<TocAccess>();

    public virtual ICollection<TocView> TocViews { get; set; } = new List<TocView>();

    public virtual ICollection<View> Views { get; set; } = new List<View>();

    public virtual ICollection<XclassificationtreeItemtype> XclassificationtreeItemtypes { get; set; } = new List<XclassificationtreeItemtype>();

    public virtual ICollection<Xitemtypeallowedproperty> Xitemtypeallowedproperties { get; set; } = new List<Xitemtypeallowedproperty>();
}
