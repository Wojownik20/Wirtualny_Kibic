namespace Wirtualny_Kibic.DTOs;

public class ExternalFixtureDto
{
    public int ExternalApiId { get; set; }
    public DateTime MatchDate { get; set; }

    public int ExternalHomeTeamId { get; set; }
    public string HomeTeamName { get; set; } = string.Empty;

    public int ExternalAwayTeamId { get; set; }
    public string AwayTeamName { get; set; } = string.Empty;

    public string Competition { get; set; } = string.Empty;
    public string Stadium { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Round { get; set; } = string.Empty;

    public int? HomeScore { get; set; }
    public int? AwayScore { get; set; }
}