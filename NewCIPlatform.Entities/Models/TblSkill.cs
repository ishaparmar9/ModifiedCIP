using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblSkill
{
    public long SkillId { get; set; }

    public string? SkillName { get; set; }

    public byte? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblMissionSkill> TblMissionSkills { get; set; } = new List<TblMissionSkill>();

    public virtual ICollection<TblUserSkill> TblUserSkills { get; set; } = new List<TblUserSkill>();
}
