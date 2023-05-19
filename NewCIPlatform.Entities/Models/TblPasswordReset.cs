using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblPasswordReset
{
    public string Email { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime? ExpirationTime { get; set; }

    public DateTime CreatedAt { get; set; }
}
