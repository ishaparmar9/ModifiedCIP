using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblStoryInvite
{
    public long StoryInviteId { get; set; }

    public long StoryId { get; set; }

    public long FromUserId { get; set; }

    public long ToUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblUser FromUser { get; set; } = null!;

    public virtual TblStory Story { get; set; } = null!;

    public virtual TblUser ToUser { get; set; } = null!;
}
