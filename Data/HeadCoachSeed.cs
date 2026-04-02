using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Wirtualny_Kibic.Entities;

namespace Wirtualny_Kibic.Data;

public static class HeadCoachSeed
{
    public static async Task SeedHeadCoachesAsync(IServiceProvider services)
    {
        using var scope = services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        if (await context.StaffProfiles.AnyAsync())
            return;

        var coaches = new List<(string TeamName, string FirstName, string LastName, string Email, string Password)>
        {
            ("Arsenal", "Mikel", "Arteta", "HeadCoach@Arsenal.com", "Arsenal123!"),
            ("Aston Villa", "Unai", "Emery", "HeadCoach@AstonVilla.com", "Villa123!"),
            ("Bournemouth", "Andoni", "Iraola Sagarna", "HeadCoach@Bournemouth.com", "Bournemuth123!"),
            ("Brentford", "Keith", "Andrews", "HeadCoach@Brentford.com", "Brentford123!"),
            ("Brighton & Hove Albion", "Fabian", "Hürzeler", "HeadCoach@Brighton.com", "Brighton123!"),
            ("Burnley", "Scott", "Parker", "HeadCoach@Burnley.com", "Burnley123!"),
            ("Chelsea", "Liam", "Rosenior", "HeadCoach@Chelsea.com", "Chelsea123!"),
            ("Crystal Palace", "Olivier", "Glasner", "HeadCoach@CrystalPalace.com", "CrystalPalace123!"),
            ("Everton", "David", "Moyes", "HeadCoach@Everton.com", "Everton123!"),
            ("Fulham", "Marco", "Silva", "HeadCoach@Fulham.com", "Fulham123!"),
            ("Liverpool", "Arne", "Slot", "HeadCoach@Liverpool.com", "Liverpool123!"),
            ("Manchester City", "Pep", "Guardiola", "HeadCoach@ManchesterCity.com", "ManchesterCity123!"),
            ("Manchester United", "Michael", "Carrick", "HeadCoach@ManchesterUnited.com", "ManchesterUnited123!"),
            ("Newcastle United", "Eddie", "Howe", "HeadCoach@Newcastle.com", "Newcastle123!"),
            ("Nottingham Forest", "Vitor", "Pereira", "HeadCoach@Nottingham.com", "Nottingham123!"),
            ("Sunderland", "Regis", "Le Bris", "HeadCoach@Sunderland.com", "Sunderland123!"),
            ("Tottenham Hotspur", "Igor", "Tudor", "HeadCoach@Tottenham.com", "Tottenham123!"),
            ("West Ham United", "Nuno", "Espirito Santos", "HeadCoach@WestHam.com", "Westham123!"),
            ("Wolverhampton Wanderers", "Rob", "Edwards", "HeadCoach@Wolves.com", "Wolves123!"),
            ("Leeds United", "Daniel", "Farke", "HeadCoach@Leeds.com", "Leeds123")
        };

        foreach (var coach in coaches)
        {
            var team = await context.Teams.FirstOrDefaultAsync(t => t.Name == coach.TeamName);
            if (team == null)
                continue;

            var existingUser = await userManager.FindByEmailAsync(coach.Email);
            ApplicationUser user;

            if (existingUser == null)
            {
                user = new ApplicationUser
                {
                    UserName = coach.Email,
                    Email = coach.Email,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, coach.Password);
                if (!result.Succeeded)
                    continue;
            }
            else
            {
                user = existingUser;
            }

            var existingProfile = await context.StaffProfiles.FirstOrDefaultAsync(s => s.UserId == user.Id);
            if (existingProfile != null)
                continue;

            var profile = new StaffProfile
            {
                FirstName = coach.FirstName,
                LastName = coach.LastName,
                Role = "HeadCoach",
                UserId = user.Id,
                TeamId = team.Id
            };

            context.StaffProfiles.Add(profile);
        }

        await context.SaveChangesAsync();
    }
}