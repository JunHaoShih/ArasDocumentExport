using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Statistic
{
    public string Id { get; set; } = null!;

    public DateTime CollectedOn { get; set; }

    public string State { get; set; } = null!;

    public string? Payload { get; set; }
}
