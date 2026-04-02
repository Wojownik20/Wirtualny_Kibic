using Wirtualny_Kibic.Entities;

namespace Wirtualny_Kibic.Data;

public static class TeamSeed
{
    public static async Task SeedTeams(ApplicationDbContext context)
    {
        if (context.Teams.Any())
            return;

        var teams = new List<Team>
        {
            new() { Name="Arsenal", ShortName="ARS", City="London", Stadium="Emirates Stadium"},
            new() { Name="Aston Villa", ShortName="AVL", City="Birmingham", Stadium="Villa Park"},
            new() { Name="Burnley", ShortName = "BUR",City="Burnley", Stadium = "Turf Moor" },
            new() { Name="Bournemouth", ShortName="BOU", City="Bournemouth", Stadium="Vitality Stadium"},
            new() { Name="Brentford", ShortName="BRE", City="London", Stadium="Gtech Community Stadium"},
            new() { Name="Brighton & Hove Albion", ShortName="BHA", City="Brighton", Stadium="Amex Stadium"},
            new() { Name="Chelsea", ShortName="CHE", City="London", Stadium="Stamford Bridge"},
            new() { Name="Crystal Palace", ShortName="CRY", City="London", Stadium="Selhurst Park"},
            new() { Name="Everton", ShortName="EVE", City="Liverpool", Stadium="Goodison Park"},
            new() { Name="Fulham", ShortName="FUL", City="London", Stadium="Craven Cottage"},
            new() { Name="Liverpool", ShortName="LIV", City="Liverpool", Stadium="Anfield"},
            new() { Name="Leeds United", ShortName = "LEE", City="Leeds", Stadium = "Elland Road" },
            new() { Name="Sunderland", ShortName = "SUN", City="Sunderland", Stadium = "Stadium of Light" },
            new() { Name="Manchester City", ShortName="MCI", City="Manchester", Stadium="Etihad Stadium"},
            new() { Name="Manchester United", ShortName="MUN", City="Manchester", Stadium="Old Trafford"},
            new() { Name="Newcastle United", ShortName="NEW", City="Newcastle", Stadium="St James' Park"},
            new() { Name="Nottingham Forest", ShortName="NFO", City="Nottingham", Stadium="City Ground"},
            new() { Name="Tottenham Hotspur", ShortName="TOT", City="London", Stadium="Tottenham Hotspur Stadium"},
            new() { Name="West Ham United", ShortName="WHU", City="London", Stadium="London Stadium"},
            new() { Name="Wolverhampton Wanderers", ShortName="WOL", City="Wolverhampton", Stadium="Molineux"},
        };

        context.Teams.AddRange(teams);
        await context.SaveChangesAsync();
    }
}