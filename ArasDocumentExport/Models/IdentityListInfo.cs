using System;
using System.Collections.Generic;

namespace ArasDocumentExport.Models;

public partial class IdentityListInfo
{
    public string IdentityListId { get; set; } = null!;

    public DateTime LastActivityTime { get; set; }

    public string IdentityList { get; set; } = null!;
}
