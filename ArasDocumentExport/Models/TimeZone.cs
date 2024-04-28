using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class TimeZone
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int OffsetSeconds { get; set; }

    public virtual ICollection<TimeZoneHistory> TimeZoneHistories { get; set; } = new List<TimeZoneHistory>();
}
