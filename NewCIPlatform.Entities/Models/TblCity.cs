using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblCity
{
    public long CityId { get; set; }

    public long CountryId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblCountry Country { get; set; } = null!;

    public virtual ICollection<TblMission> TblMissions { get; set; } = new List<TblMission>();

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
