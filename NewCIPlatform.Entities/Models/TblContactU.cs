using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblContactU
{
    public long MessageId { get; set; }

    public long UserId { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }
}
