using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblMissionTheme
{
    public long MissionThemeId { get; set; }

    public string? Title { get; set; }

    public byte Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblMission> TblMissions { get; set; } = new List<TblMission>();
}
