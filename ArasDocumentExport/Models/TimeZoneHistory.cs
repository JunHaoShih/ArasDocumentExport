using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class TimeZoneHistory
{
    public int TzId { get; set; }

    public DateTime TransitionStart { get; set; }

    public DateTime TransitionEnd { get; set; }

    public int DeltaSeconds { get; set; }

    public bool Dst { get; set; }

    public virtual TimeZone Tz { get; set; } = null!;
}
