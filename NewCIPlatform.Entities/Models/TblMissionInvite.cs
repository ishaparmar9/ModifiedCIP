using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblMissionInvite
{
    public long MissionInviteId { get; set; }

    public long MissionId { get; set; }

    public long FromUserId { get; set; }

    public long ToUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblUser FromUser { get; set; } = null!;

    public virtual TblMission Mission { get; set; } = null!;

    public virtual TblUser ToUser { get; set; } = null!;
}
