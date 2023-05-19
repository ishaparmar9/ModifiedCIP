using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblUserSkill
{
    public long UserSkillId { get; set; }

    public long UserId { get; set; }

    public long SkillId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblSkill Skill { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
