using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblMissionApplication
{
    public long MissionApplicationId { get; set; }

    public long MissionId { get; set; }

    public long UserId { get; set; }

    public DateTime AppliedAt { get; set; }

    public string ApprovalStatus { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblMission Mission { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
