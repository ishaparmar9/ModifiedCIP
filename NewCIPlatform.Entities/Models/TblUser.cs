using System;
using System.Collections.Generic;

namespace NewCIPlatform.Entities.Models;

public partial class TblUser
{
    public long UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public string? Avatar { get; set; }

    public string? WhyIVolunteer { get; set; }

    public string? EmployeeId { get; set; }

    public string? Manager { get; set; }

    public string? Department { get; set; }

    public long? CityId { get; set; }

    public long? CountryId { get; set; }

    public string? ProfileText { get; set; }

    public string? Availability { get; set; }

    public string Role { get; set; } = null!;

    public string? LinkedInUrl { get; set; }

    public string? Title { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblCity? City { get; set; }

    public virtual TblCountry? Country { get; set; }

    public virtual ICollection<TblComment> TblComments { get; set; } = new List<TblComment>();

    public virtual ICollection<TblFavouriteMission> TblFavouriteMissions { get; set; } = new List<TblFavouriteMission>();

    public virtual ICollection<TblMissionApplication> TblMissionApplications { get; set; } = new List<TblMissionApplication>();

    public virtual ICollection<TblMissionInvite> TblMissionInviteFromUsers { get; set; } = new List<TblMissionInvite>();

    public virtual ICollection<TblMissionInvite> TblMissionInviteToUsers { get; set; } = new List<TblMissionInvite>();

    public virtual ICollection<TblMissionRating> TblMissionRatings { get; set; } = new List<TblMissionRating>();

    public virtual ICollection<TblStory> TblStories { get; set; } = new List<TblStory>();

    public virtual ICollection<TblStoryInvite> TblStoryInviteFromUsers { get; set; } = new List<TblStoryInvite>();

    public virtual ICollection<TblStoryInvite> TblStoryInviteToUsers { get; set; } = new List<TblStoryInvite>();

    public virtual ICollection<TblTimesheet> TblTimesheets { get; set; } = new List<TblTimesheet>();

    public virtual ICollection<TblUserSkill> TblUserSkills { get; set; } = new List<TblUserSkill>();
}
