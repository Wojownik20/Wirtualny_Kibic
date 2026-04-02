namespace Wirtualny_Kibic.Entities;

public class Fixture
{
    public int Id { get; set; }

    public int ExternalApiId { get; set; }

    public DateTime MatchDate { get; set; }

    public int HomeTeamId { get; set; }
    public Team HomeTeam { get; set; } = null!;

    public int AwayTeamId { get; set; }
    public Team AwayTeam { get; set; } = null!;

    public string Competition { get; set; } = string.Empty;
    public string Stadium { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Round { get; set; } = string.Empty;

    public int? HomeScore { get; set; }
    public int? AwayScore { get; set; }
}