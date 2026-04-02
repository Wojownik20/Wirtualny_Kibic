namespace Wirtualny_Kibic.DTOs;

public class PlayerDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Number { get; set; }

    public string Position { get; set; } = string.Empty;

    public int Age { get; set; }

    public string Nationality { get; set; } = string.Empty;

    public string? InjuryStatus { get; set; }

    public string? Notes { get; set; }
}
