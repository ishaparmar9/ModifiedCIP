using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblBanner
{
    public long BannerId { get; set; }

    public string Image { get; set; } = null!;

    public string? Text { get; set; }

    public int? SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }
}
