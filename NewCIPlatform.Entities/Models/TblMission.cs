using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblMission
{
    public long MissionId { get; set; }

    public long ThemeId { get; set; }

    public long? CityId { get; set; }

    public long? CountryId { get; set; }

    public string Title { get; set; } = null!;

    public string? ShortDescription { get; set; }

    public string? Description { get; set; }

    public string? Days { get; set; }

    public string? Image { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? RegistrationDeadline { get; set; }

    public string MissionType { get; set; } = null!;

    public bool? Status { get; set; }

    public string? OrganizationName { get; set; }

    public string? OrganizationDetail { get; set; }

    public string? Availability { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblCity? City { get; set; }

    public virtual TblCountry? Country { get; set; }

    public virtual ICollection<TblComment> TblComments { get; set; } = new List<TblComment>();

    public virtual ICollection<TblFavouriteMission> TblFavouriteMissions { get; set; } = new List<TblFavouriteMission>();

    public virtual ICollection<TblGoalMission> TblGoalMissions { get; set; } = new List<TblGoalMission>();

    public virtual ICollection<TblMissionApplication> TblMissionApplications { get; set; } = new List<TblMissionApplication>();

    public virtual ICollection<TblMissionDocument> TblMissionDocuments { get; set; } = new List<TblMissionDocument>();

    public virtual ICollection<TblMissionInvite> TblMissionInvites { get; set; } = new List<TblMissionInvite>();

    public virtual ICollection<TblMissionMedium> TblMissionMedia { get; set; } = new List<TblMissionMedium>();

    public virtual ICollection<TblMissionRating> TblMissionRatings { get; set; } = new List<TblMissionRating>();

    public virtual ICollection<TblMissionSkill> TblMissionSkills { get; set; } = new List<TblMissionSkill>();

    public virtual ICollection<TblStory> TblStories { get; set; } = new List<TblStory>();

    public virtual ICollection<TblTimesheet> TblTimesheets { get; set; } = new List<TblTimesheet>();

    public virtual TblMissionTheme Theme { get; set; } = null!;
}
