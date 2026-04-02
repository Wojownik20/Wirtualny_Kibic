namespace Wirtualny_Kibic.Entities;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Stadium { get; set; } = string.Empty;
    public string LogoUrl { get; set; } = string.Empty;
    public ICollection<Player> Players { get; set; }

    public int? ExternalApiTeamId { get; set; }
}