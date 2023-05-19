using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblStory
{
    public long StoryId { get; set; }

    public long UserId { get; set; }

    public long MissionId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int Views { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? PublishedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblMission Mission { get; set; } = null!;

    public virtual ICollection<TblStoryInvite> TblStoryInvites { get; set; } = new List<TblStoryInvite>();

    public virtual ICollection<TblStoryMedium> TblStoryMedia { get; set; } = new List<TblStoryMedium>();

    public virtual TblUser User { get; set; } = null!;
}
