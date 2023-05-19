using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblMissionSkill
{
    public long MissionSkillId { get; set; }

    public long SkillId { get; set; }

    public long? MissionId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblMission? Mission { get; set; }

    public virtual TblSkill Skill { get; set; } = null!;
}
