using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblCountry
{
    public long CountryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Iso { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblCity> TblCities { get; set; } = new List<TblCity>();

    public virtual ICollection<TblMission> TblMissions { get; set; } = new List<TblMission>();

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
