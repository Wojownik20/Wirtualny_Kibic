using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wirtualny_Kibic.Entities;

public class StaffProfile
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    [Required]
    public string Role { get; set; } = string.Empty;

    public string UserId { get; set; } = string.Empty;

    public int TeamId { get; set; }

    public ApplicationUser User { get; set; } = null!;

    public Team Team { get; set; } = null!;
}