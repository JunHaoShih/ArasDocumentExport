using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Activeuser
{
    public string ArasSessionId { get; set; } = null!;

    public string LoginName { get; set; } = null!;

    public DateTime LoginTime { get; set; }

    public DateTime LastActivityTime { get; set; }
}
