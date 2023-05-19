using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblMissionDocument
{
    public long MissionDocumentId { get; set; }

    public long MissionId { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentPath { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblMission Mission { get; set; } = null!;
}
