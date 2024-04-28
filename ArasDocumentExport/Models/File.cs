using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class File
{
    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? CheckedoutPath { get; set; }

    public string? Checksum { get; set; }

    public string? Comments { get; set; }

    public decimal? FileSize { get; set; }

    public string? FileType { get; set; }

    public string Filename { get; set; } = null!;

    public string? Label { get; set; }

    public string? Mimetype { get; set; }

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

    public virtual ICollection<DocumentFile> DocumentFiles { get; set; } = new List<DocumentFile>();

    public virtual ICollection<EcnFile> EcnFiles { get; set; } = new List<EcnFile>();

    public virtual ICollection<EcrFile> EcrFiles { get; set; } = new List<EcrFile>();

    public virtual ICollection<ExpressDcoFile> ExpressDcoFiles { get; set; } = new List<ExpressDcoFile>();

    public virtual ICollection<ExpressEcoFile> ExpressEcoFiles { get; set; } = new List<ExpressEcoFile>();

    public virtual ICollection<ExpressEdrFile> ExpressEdrFiles { get; set; } = new List<ExpressEdrFile>();

    public virtual ICollection<Fileexchangepackagefile> Fileexchangepackagefiles { get; set; } = new List<Fileexchangepackagefile>();

    public virtual ICollection<FilegroupFile> FilegroupFiles { get; set; } = new List<FilegroupFile>();

    public virtual ICollection<FrRepresentationfile> FrRepresentationfiles { get; set; } = new List<FrRepresentationfile>();

    public virtual ICollection<FrRepresentation> FrRepresentations { get; set; } = new List<FrRepresentation>();

    public virtual ICollection<Located> Locateds { get; set; } = new List<Located>();

    public virtual ICollection<ManufacturerPartFile> ManufacturerPartFiles { get; set; } = new List<ManufacturerPartFile>();

    public virtual ICollection<PrFile> PrFiles { get; set; } = new List<PrFile>();

    public virtual ICollection<SimpleEcoFile> SimpleEcoFiles { get; set; } = new List<SimpleEcoFile>();

    public virtual ICollection<SimpleMcoFile> SimpleMcoFiles { get; set; } = new List<SimpleMcoFile>();
}
