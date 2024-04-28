using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Variable1
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
