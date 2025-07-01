using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;

public class User
{
    public long UserId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
    public string Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string Username { get; set; }

    public string PasswordHash { get; set; }
    public DateTime? DateOfBirth { get; set; }

    public Gender? Gender { get; set; }

    public string? ProfileImageUrl { get; set; }

    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}