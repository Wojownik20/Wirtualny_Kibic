namespace Wirtualny_Kibic.Entities;

public class Player
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Position { get; set; }

    public int Number { get; set; }

    public int Age { get; set; }

    public string Nationality { get; set; }

    public decimal MarketValue { get; set; }

    public string? InjuryStatus { get; set; }
    public string? Notes { get; set; }


    public int TeamId { get; set; }

    public Team Team { get; set; }
}