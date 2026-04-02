using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Wirtualny_Kibic.Entities;

namespace Wirtualny_Kibic.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

    public DbSet<Team> Teams => Set<Team>();
    public DbSet<Player> Players { get; set; }
    public DbSet<StaffProfile> StaffProfiles => Set<StaffProfile>();
    public DbSet<FormationPlan> FormationPlans { get; set; }
    public DbSet<FormationPlayer> FormationPlayers { get; set; }
    public DbSet<Fixture> Fixtures { get; set; }
    public DbSet<TrainingPlan> TrainingPlans { get; set; }
    public DbSet<TrainingExercise> TrainingExercises { get; set; }
}