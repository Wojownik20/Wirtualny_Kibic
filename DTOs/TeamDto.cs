namespace Wirtualny_Kibic.DTOs;

public class TeamDto
{
    public int Id { get; set; }

    public string TeamName { get; set; } = string.Empty;

    public string Stadium { get; set; } = string.Empty;

    public int PlayersCount { get; set; }

    public int InjuredPlayersCount { get; set; }
}
