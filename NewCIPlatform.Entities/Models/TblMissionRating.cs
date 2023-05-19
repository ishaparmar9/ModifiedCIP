using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblMissionRating
{
    public long MissionRatingId { get; set; }

    public long UserId { get; set; }

    public long MissionId { get; set; }

    public int Rating { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblMission Mission { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
