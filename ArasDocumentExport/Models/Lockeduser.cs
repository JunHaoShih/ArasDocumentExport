using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class Lockeduser
{
    public string LoginName { get; set; } = null!;

    public string Key { get; set; } = null!;

    public int FailedAttempts { get; set; }

    public DateTime? ExpiredOn { get; set; }
}
