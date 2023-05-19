using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblComment
{
    public long CommentId { get; set; }

    public string Comment { get; set; } = null!;

    public long UserId { get; set; }

    public long MissionId { get; set; }

    public string ApprovalStatus { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblMission Mission { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
