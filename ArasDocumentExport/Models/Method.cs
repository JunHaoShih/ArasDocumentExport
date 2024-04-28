using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Method
{
    public string? ArasUniquenessHelper { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? Comments { get; set; }

    public string? Core { get; set; }

    public string ExecutionAllowedTo { get; set; } = null!;

    public string? Label { get; set; }

    public string? MethodCode { get; set; }

    public string? MethodLocation { get; set; }

    public string? MethodType { get; set; }

    public string? Template { get; set; }

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

    public DateTime? SupersededDate { get; set; }

    public virtual ICollection<ActivityMethod> ActivityMethods { get; set; } = new List<ActivityMethod>();

    public virtual ICollection<ActivityTemplateMethod> ActivityTemplateMethods { get; set; } = new List<ActivityTemplateMethod>();

    public virtual ICollection<ClientEvent> ClientEvents { get; set; } = new List<ClientEvent>();

    public virtual ICollection<ColumnEvent> ColumnEvents { get; set; } = new List<ColumnEvent>();

    public virtual ICollection<ConfigurableGridEvent> ConfigurableGridEvents { get; set; } = new List<ConfigurableGridEvent>();

    public virtual ICollection<Conversionruleeventhandler> Conversionruleeventhandlers { get; set; } = new List<Conversionruleeventhandler>();

    public virtual ICollection<Conversionruleeventtemplate> Conversionruleeventtemplates { get; set; } = new List<Conversionruleeventtemplate>();

    public virtual ICollection<Conversiontaskeventhandler> Conversiontaskeventhandlers { get; set; } = new List<Conversiontaskeventhandler>();

    public virtual ICollection<CuiControleventhandler> CuiControleventhandlers { get; set; } = new List<CuiControleventhandler>();

    public virtual ICollection<CwsMethodreference> CwsMethodreferences { get; set; } = new List<CwsMethodreference>();

    public virtual ICollection<FieldEvent> FieldEvents { get; set; } = new List<FieldEvent>();

    public virtual ICollection<FormEvent> FormEvents { get; set; } = new List<FormEvent>();

    public virtual ICollection<GridEvent> GridEvents { get; set; } = new List<GridEvent>();

    public virtual ICollection<QryQuerydefinitionevent> QryQuerydefinitionevents { get; set; } = new List<QryQuerydefinitionevent>();

    public virtual ICollection<RelationshipGridEvent> RelationshipGridEvents { get; set; } = new List<RelationshipGridEvent>();

    public virtual ICollection<ServerEvent> ServerEvents { get; set; } = new List<ServerEvent>();

    public virtual ICollection<Systemeventhandler> Systemeventhandlers { get; set; } = new List<Systemeventhandler>();

    public virtual ICollection<WorkflowMapPathPost> WorkflowMapPathPosts { get; set; } = new List<WorkflowMapPathPost>();

    public virtual ICollection<WorkflowMapPathPre> WorkflowMapPathPres { get; set; } = new List<WorkflowMapPathPre>();

    public virtual ICollection<WorkflowProcessPathPost> WorkflowProcessPathPosts { get; set; } = new List<WorkflowProcessPathPost>();

    public virtual ICollection<WorkflowProcessPathPre> WorkflowProcessPathPres { get; set; } = new List<WorkflowProcessPathPre>();
}
