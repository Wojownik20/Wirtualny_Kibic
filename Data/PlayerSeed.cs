using Wirtualny_Kibic.Entities;

namespace Wirtualny_Kibic.Data;

public static class PlayerSeed
{
    public static async Task SeedPlayersAsync(ApplicationDbContext context)
    {
        if (context.Players.Any())
            return;

        var teams = context.Teams.ToList();

        if (!teams.Any())
            return;

        var arsenal = teams.FirstOrDefault(t => t.Name == "Arsenal");
        var chelsea = teams.FirstOrDefault(t => t.Name == "Chelsea");
        var liverpool = teams.FirstOrDefault(t => t.Name == "Liverpool");
        var manCity = teams.FirstOrDefault(t => t.Name == "Manchester City");
        var manUnited = teams.FirstOrDefault(t => t.Name == "Manchester United");
        var newcastle = teams.FirstOrDefault(t => t.Name == "Newcastle United");
        var tottenham = teams.FirstOrDefault(t => t.Name == "Tottenham Hotspur");
        var brighton = teams.FirstOrDefault(t => t.Name == "Brighton & Hove Albion");
        var astonVilla = teams.FirstOrDefault(t => t.Name == "Aston Villa");
        var brentford = teams.FirstOrDefault(t => t.Name == "Brentford");
        var fulham = teams.FirstOrDefault(t => t.Name == "Fulham");
        var wolves = teams.FirstOrDefault(t => t.Name == "Wolverhampton Wanderers");
        var nottingham = teams.FirstOrDefault(t => t.Name == "Nottingham Forest");
        var everton = teams.FirstOrDefault(t => t.Name == "Everton");
        var leeds = teams.FirstOrDefault(t => t.Name == "Leeds United");
        var westHam = teams.FirstOrDefault(t => t.Name == "West Ham United");
        var crystalPalace = teams.FirstOrDefault(t => t.Name == "Crystal Palace");
        var bournemouth = teams.FirstOrDefault(t => t.Name == "AFC Bournemouth");
        var burnley = teams.FirstOrDefault(t => t.Name == "Burnley");
        var sunderland = teams.FirstOrDefault(t => t.Name == "Sunderland");


        var players = new List<Player>();

        if (arsenal != null)
        {
            players.AddRange(new List<Player>
            {
                new Player { FirstName = "David", LastName = "Raya", Position = "GK", Number = 1, Age = 29, Nationality = "Spain", MarketValue = 35m, TeamId = arsenal.Id },
                new Player { FirstName = "Kepa", LastName = "Arrizabalaga", Position = "GK", Number = 13, Age = 31, Nationality = "Spain", MarketValue = 7m, TeamId = arsenal.Id },
                new Player { FirstName = "Ben", LastName = "White", Position = "RB", Number = 4, Age = 28, Nationality = "English", MarketValue = 30m, TeamId = arsenal.Id },
                new Player { FirstName = "Jurriën", LastName = "Timber", Position = "RB", Number = 12, Age = 24, Nationality = "Netherlands", MarketValue = 70m, TeamId = arsenal.Id },
                new Player { FirstName = "William", LastName = "Saliba", Position = "CB", Number = 2, Age = 24, Nationality = "France", MarketValue = 90m, TeamId = arsenal.Id },
                new Player { FirstName = "Gabriel", LastName = "Magalhães", Position = "CB", Number = 6, Age = 28, Nationality = "Brazil", MarketValue = 75m, TeamId = arsenal.Id },
                new Player { FirstName = "Piero", LastName = "Hincapié", Position = "CB", Number = 5, Age = 24, Nationality = "Ecuador", MarketValue = 50m, TeamId = arsenal.Id },
                new Player { FirstName = "Christian", LastName = "Mosquera", Position = "CB", Number = 3, Age = 21, Nationality = "Colombia", MarketValue = 35m, TeamId = arsenal.Id },
                new Player { FirstName = "Riccardo", LastName = "Calafiori", Position = "LB", Number = 33, Age = 23, Nationality = "Italy", MarketValue = 50m, TeamId = arsenal.Id },
                new Player { FirstName = "Myles", LastName = "Lewis-Skelly", Position = "LB", Number = 49, Age = 19, Nationality = "England", MarketValue = 40m, TeamId = arsenal.Id },
                new Player { FirstName = "Martin", LastName = "Zubimendi", Position = "CDM", Number = 36, Age = 27,Nationality = "Spain", MarketValue = 75m, TeamId = arsenal.Id },
                new Player { FirstName = "Christian", LastName = "Nørgaard", Position = "CDM", Number = 16, Age = 31, Nationality = "Denmark", MarketValue = 9m, TeamId = arsenal.Id },
                new Player { FirstName = "Declan", LastName = "Rice", Position = "CM", Number = 41, Age = 27, Nationality = "England", MarketValue = 120m, TeamId = arsenal.Id },
                new Player { FirstName = "Mikel", LastName = "Merino", Position = "CM", Number = 23, Age = 29, Nationality = "Spain", MarketValue = 30m, TeamId = arsenal.Id },
                new Player { FirstName = "Martin", LastName = "Ødegaard", Position = "CAM", Number = 8, Age = 27, Nationality = "Norway", MarketValue = 75m, TeamId = arsenal.Id },
                new Player { FirstName = "Eberechi", LastName = "Eze", Position = "CAM", Number = 10, Age = 27, Nationality = "England", MarketValue = 65m, TeamId = arsenal.Id },
                new Player { FirstName = "Gabriel", LastName = "Martinelli", Position = "LW", Number = 11, Age = 24, Nationality = "Brazil", MarketValue = 45m, TeamId = arsenal.Id },
                new Player { FirstName = "Leonardo", LastName = "Trossard", Position = "LW", Number = 11, Age = 31, Nationality = "Belgium", MarketValue = 20m, TeamId = arsenal.Id },
                new Player { FirstName = "Bukayo", LastName = "Saka", Position = "RW", Number = 7, Age = 24, Nationality = "English", MarketValue = 130m, TeamId = arsenal.Id },
                new Player { FirstName = "Noni", LastName = "Madueke", Position = "RW", Number = 7, Age = 23, Nationality = "English", MarketValue = 50m, TeamId = arsenal.Id },
                new Player { FirstName = "Max", LastName = "Dwoman", Position = "RW", Number = 56, Age = 16, Nationality = "English", MarketValue = 20m, TeamId = arsenal.Id },
                new Player { FirstName = "Kai", LastName = "Havertz", Position = "ST", Number = 29, Age = 26, Nationality = "German", MarketValue = 55m, TeamId = arsenal.Id },
                new Player { FirstName = "Viktor", LastName = "Gyökeres", Position = "ST", Number = 14, Age = 27, Nationality = "Swedish", MarketValue = 70m, TeamId = arsenal.Id },
                new Player { FirstName = "Gabriel", LastName = "Jesus", Position = "ST", Number = 9, Age = 28, Nationality = "Brazil", MarketValue = 20m, TeamId = arsenal.Id }
            });
        }

        if (chelsea != null)
        {
            players.AddRange(new List<Player>
            {
                new Player { FirstName = "Robert", LastName = "Sanchez", Position = "GK", Number = 1, Age = 28, Nationality = "Spain", MarketValue = 22m, TeamId = chelsea.Id },
                new Player { FirstName = "Filip", LastName = "Jørgensen", Position = "GK", Number = 12, Age = 23, Nationality = "Denmark", MarketValue = 15m, TeamId = chelsea.Id },
                new Player { FirstName = "Gabriel", LastName = "Slonina", Position = "GK", Number = 44, Age = 21, Nationality = "USA", MarketValue = 3.5m, TeamId = chelsea.Id },
                new Player { FirstName = "Reece", LastName = "James", Position = "RB", Number = 24, Age = 26, Nationality = "English", MarketValue = 50m, TeamId = chelsea.Id },
                new Player { FirstName = "Malo", LastName = "Gusto", Position = "RB", Number = 27, Age = 22, Nationality = "France", MarketValue = 35m, TeamId = chelsea.Id },
                new Player { FirstName = "Josh", LastName = "Acheampong", Position = "RB", Number = 34, Age = 19, Nationality = "England", MarketValue = 20m, TeamId = chelsea.Id },
                new Player { FirstName = "Levi", LastName = "Colwill", Position = "CB", Number = 6, Age = 23, Nationality = "England",  MarketValue = 50m, TeamId = chelsea.Id },
                new Player { FirstName = "Trevoh", LastName = "Chalobah", Position = "CB", Number = 23, Age = 26, Nationality = "England",  MarketValue = 35m, TeamId = chelsea.Id },
                new Player { FirstName = "Wesley", LastName = "Fofana", Position = "CB", Number = 29, Age = 25, Nationality = "France",  MarketValue = 28m, TeamId = chelsea.Id },
                new Player { FirstName = "Mamadou", LastName = "Sarr", Position = "CB", Number = 19, Age = 20, Nationality = "Senegal",  MarketValue = 25m, TeamId = chelsea.Id },
                new Player { FirstName = "Tosin", LastName = "Adrabioyo", Position = "CB", Number = 4, Age = 27, Nationality = "England",  MarketValue = 20m, TeamId = chelsea.Id },
                new Player { FirstName = "Benoît", LastName = "Badiashile", Position = "CB", Number = 5, Age = 23, Nationality = "France",  MarketValue = 18m, TeamId = chelsea.Id },
                new Player { FirstName = "Marc", LastName = "Cucurella", Position = "LB", Number = 3, Age = 27, Nationality = "Spain",  MarketValue = 50m, TeamId = chelsea.Id },
                new Player { FirstName = "Jorrel", LastName = "Hato", Position = "LB", Number = 21, Age = 20, Nationality = "Netherlands",  MarketValue = 35m, TeamId = chelsea.Id },
                new Player { FirstName = "Caleb", LastName = "Wiley", Position = "LB", Number = 99, Age = 21, Nationality = "USA",  MarketValue = 8m, TeamId = chelsea.Id },
                new Player { FirstName = "Enzo", LastName = "Fernandez", Position = "CM", Number = 8, Age = 25, Nationality = "Argentina", MarketValue = 85m, TeamId = chelsea.Id },
                new Player { FirstName = "Andrey", LastName = "Santos", Position = "CM", Number = 17, Age = 21,Nationality = "Brazil", MarketValue = 40m, TeamId = chelsea.Id },
                new Player { FirstName = "Moises", LastName = "Caicedo", Position = "CDM", Number = 25, Age = 24, Nationality = "Ecuador", MarketValue = 110m, TeamId = chelsea.Id },
                new Player { FirstName = "Romeo", LastName = "Lavia", Position = "CDM", Number = 45, Age = 22, Nationality = "Belgium", MarketValue = 30m, TeamId = chelsea.Id },
                new Player { FirstName = "Dario", LastName = "Essugo", Position = "CDM", Number = 14, Age = 20, Nationality = "Portugal", MarketValue = 20m, TeamId = chelsea.Id },
                new Player { FirstName = "Cole", LastName = "Palmer", Position = "CAM", Number = 20, Age = 23, Nationality= "England", MarketValue = 120m, TeamId = chelsea.Id },
                new Player { FirstName = "Alejandro", LastName = "Garnacho", Position = "LW", Number = 49, Age = 21, Nationality= "Argentina", MarketValue = 45m, TeamId = chelsea.Id },
                new Player { FirstName = "Jamie", LastName = "Gittens", Position = "LW", Number = 17, Age = 21, Nationality= "England", MarketValue = 40m, TeamId = chelsea.Id },
                new Player { FirstName = "Estêvão", LastName = "", Position = "RW", Number = 41, Age = 18, Nationality= "Brazil", MarketValue = 80m, TeamId = chelsea.Id },
                new Player { FirstName = "Pedro", LastName = "Neto", Position = "RW", Number = 7, Age = 25, Nationality= "Brazil", MarketValue = 60m, TeamId = chelsea.Id },
                new Player { FirstName = "João", LastName = "Pedro", Position = "ST", Number = 20, Age = 24,Nationality = "Brazil", MarketValue = 65m, TeamId = chelsea.Id },
                new Player { FirstName = "Liam", LastName = "Delap", Position = "ST", Number = 9, Age = 23,Nationality = "England", MarketValue = 35m, TeamId = chelsea.Id },
                new Player { FirstName = "Marc", LastName = "Guiu", Position = "ST", Number = 38, Age = 19,Nationality = "Spain", MarketValue = 12m, TeamId = chelsea.Id },
            });
        }

        if (liverpool != null)
        {
            players.AddRange(new List<Player>
            {
                new Player { FirstName = "Alisson", LastName = "Becker", Position = "GK", Number = 1, Age = 33, Nationality = "Brazil", MarketValue = 17m, TeamId = liverpool.Id },
                new Player { FirstName = "Giorgi", LastName = "Mamardashvili", Position = "GK", Number = 25, Age = 25, Nationality = "Georgia", MarketValue = 28m, TeamId = liverpool.Id },
                new Player { FirstName = "Freddie", LastName = "Woodman", Position = "GK", Number = 28, Age = 29, Nationality = "England", MarketValue = 3m, TeamId = liverpool.Id },
                new Player { FirstName = "Harvey", LastName = "Davies", Position = "GK", Number = 95, Age = 22, Nationality = "England", MarketValue = 0.5m, TeamId = liverpool.Id },
                new Player { FirstName = "Jeremie", LastName = "Frimpong", Position = "RB", Number = 30, Age = 25, Nationality = "Netherlands", MarketValue = 38m, TeamId = liverpool.Id },
                new Player { FirstName = "Conor", LastName = "Bradley", Position = "RB", Number = 12, Age = 22, Nationality = "Northern Ireland", MarketValue = 30m, TeamId = liverpool.Id },
                new Player { FirstName = "Calvin", LastName = "Ramsay", Position = "RB", Number = 47, Age = 22, Nationality = "Scotland", MarketValue = 1.5m, TeamId = liverpool.Id },
                new Player { FirstName = "Virgil", LastName = "van Dijk", Position = "CB", Number = 4, Age = 34, Nationality = "Netherlands", MarketValue = 18m, TeamId = liverpool.Id },
                new Player { FirstName = "Ibrahima", LastName = "Konate", Position = "CB", Number = 5, Age = 26, Nationality = "France", MarketValue = 50m, TeamId = liverpool.Id },
                new Player { FirstName = "Giovanni", LastName = "Leoni", Position = "CB", Number = 15, Age = 19, Nationality = "Italy", MarketValue = 25m, TeamId = liverpool.Id },
                new Player { FirstName = "Joe", LastName = "Gomez", Position = "CB", Number = 2, Age = 28, Nationality = "England", MarketValue = 15m, TeamId = liverpool.Id },
                new Player { FirstName = "Rhys", LastName = "Williams", Position = "CB", Number = 46, Age = 25, Nationality = "England", MarketValue = 0.5m, TeamId = liverpool.Id },
                new Player { FirstName = "Andrew", LastName = "Robertson", Position = "LB", Number = 26, Age = 31, Nationality = "Scotland", MarketValue = 12m, TeamId = liverpool.Id },
                new Player { FirstName = "Milos", LastName = "Kerkez", Position = "LB", Number = 6, Age = 22, Nationality = "Hungary", MarketValue = 40m, TeamId = liverpool.Id },
                new Player { FirstName = "Alexis", LastName = "Mac Allister", Position = "CM", Number = 10, Age = 27, Nationality = "Argentina", MarketValue = 85m, TeamId = liverpool.Id },
                new Player { FirstName = "Curtis", LastName = "Jones", Position = "CM", Number = 17, Age = 25, Nationality = "England", MarketValue = 40m, TeamId = liverpool.Id },
                new Player { FirstName = "Trey", LastName = "Nyoni", Position = "CM", Number = 42, Age = 18, Nationality = "England", MarketValue = 6m, TeamId = liverpool.Id },
                new Player { FirstName = "Dominik", LastName = "Szoboszlai", Position = "CAM", Number = 8, Age = 25, Nationality = "Hungary", MarketValue = 85m, TeamId = liverpool.Id },
                new Player { FirstName = "Florian", LastName = "Wirtz", Position = "CAM", Number = 7, Age = 22, Nationality = "Germany", MarketValue = 110m, TeamId = liverpool.Id },
                new Player { FirstName = "Ryan", LastName = "Gravenberch", Position = "CDM", Number = 38, Age = 23, Nationality = "Netherlands", MarketValue = 90m, TeamId = liverpool.Id },
                new Player { FirstName = "Stefan", LastName = "Bajcetic", Position = "CDM", Number = 43, Age = 21, Nationality = "Spain", MarketValue = 7m, TeamId = liverpool.Id },
                new Player { FirstName = "Wataru", LastName = "Endo", Position = "CDM", Number = 3, Age = 33, Nationality = "Japan", MarketValue = 5m, TeamId = liverpool.Id },
                new Player { FirstName = "Cody", LastName = "Gakpo", Position = "LW", Number = 18, Age = 26, Nationality = "Netherlands", MarketValue = 70m, TeamId = liverpool.Id },
                new Player { FirstName = "Rio", LastName = "Ngumoha", Position = "LW", Number = 73, Age = 17, Nationality = "England", MarketValue = 15m, TeamId = liverpool.Id },
                new Player { FirstName = "Mohamed", LastName = "Salah", Position = "RW", Number = 11, Age = 33, Nationality = "Egypt", MarketValue = 30m, TeamId = liverpool.Id },
                new Player { FirstName = "Federico", LastName = "Chiesa", Position = "RW", Number = 14, Age = 28, Nationality = "Italy", MarketValue = 18m, TeamId = liverpool.Id },
                new Player { FirstName = "Alexander", LastName = "Isak", Position = "ST", Number = 9, Age = 26, Nationality = "Sweden", MarketValue = 120m, TeamId = liverpool.Id },
                new Player { FirstName = "Hugo", LastName = "Ekitiké", Position = "ST", Number = 22, Age = 23,Nationality = "France", MarketValue = 85m, TeamId = liverpool.Id }
            });
        }

        if (manCity != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Gianluigi", LastName = "Donnarumma", Position = "GK", Number = 25, Age = 27, Nationality = "Italy", MarketValue = 45m, TeamId = manCity.Id },
        new Player { FirstName = "James", LastName = "Trafford", Position = "GK", Number = 1, Age = 23, Nationality = "England", MarketValue = 25m, TeamId = manCity.Id },
        new Player { FirstName = "Marcus", LastName = "Bettinelli", Position = "GK", Number = 13, Age = 33, Nationality = "England", MarketValue = 0.5m, TeamId = manCity.Id },
        new Player { FirstName = "Josko", LastName = "Gvardiol", Position = "CB", Number = 24, Age = 24, Nationality = "Croatia", MarketValue = 70m, TeamId = manCity.Id },
        new Player { FirstName = "Ruben", LastName = "Dias", Position = "CB", Number = 3, Age = 28, Nationality = "Portugal", MarketValue = 60m, TeamId = manCity.Id },
        new Player { FirstName = "Marc", LastName = "Guéhi", Position = "CB", Number = 15, Age = 25, Nationality = "England", MarketValue = 55m, TeamId = manCity.Id },
        new Player { FirstName = "Abdukodir", LastName = "Khusanov", Position = "CB", Number = 45, Age = 22, Nationality = "Uzbekistan", MarketValue = 35m, TeamId = manCity.Id },
        new Player { FirstName = "John", LastName = "Stones", Position = "CB", Number = 5, Age = 31, Nationality = "England", MarketValue = 18m, TeamId = manCity.Id },
        new Player { FirstName = "Nathan", LastName = "Aké", Position = "CB", Number = 6, Age = 31, Nationality = "Netherlands", MarketValue = 18m, TeamId = manCity.Id },
        new Player { FirstName = "Max", LastName = "Alleyne", Position = "CB", Number = 68, Age = 20, Nationality = "England", MarketValue = 0.8m, TeamId = manCity.Id },
        new Player { FirstName = "Rayan", LastName = "Ait-Nouri", Position = "LB", Number = 21, Age = 24, Nationality = "Algeria", MarketValue = 40m, TeamId = manCity.Id },
        new Player { FirstName = "Nico", LastName = "O'Reilly", Position = "LB", Number = 33, Age = 20, Nationality = "England", MarketValue = 40m, TeamId = manCity.Id },
        new Player { FirstName = "Matheus", LastName = "Nunes", Position = "RB", Number = 27, Age = 27, Nationality = "Portugal", MarketValue = 38m, TeamId = manCity.Id },
        new Player { FirstName = "Rico", LastName = "Lewis", Position = "RB", Number = 82, Age = 21, Nationality = "England", MarketValue = 35m, TeamId = manCity.Id },
        new Player { FirstName = "Rodri", LastName = "", Position = "CDM", Number = 16, Age = 29, Nationality = "Spain", MarketValue = 75m, TeamId = manCity.Id },
        new Player { FirstName = "Nico", LastName = "González", Position = "CDM", Number = 14, Age = 24, Nationality = "Spain", MarketValue = 45m, TeamId = manCity.Id },
        new Player { FirstName = "Tijjani", LastName = "Reijnders", Position = "CM", Number = 4, Age = 27, Nationality = "Netherlands", MarketValue = 65m, TeamId = manCity.Id },
        new Player { FirstName = "Mateo", LastName = "Kovacic", Position = "CM", Number = 8, Age = 31, Nationality = "Croatia", MarketValue = 15m, TeamId = manCity.Id },
        new Player { FirstName = "Sverre", LastName = "Nypan", Position = "CM", Number = 41, Age = 19, Nationality = "Norway", MarketValue = 15m, TeamId = manCity.Id },
        new Player { FirstName = "Phil", LastName = "Foden", Position = "CAM", Number = 47, Age = 25, Nationality = "England", MarketValue = 80m, TeamId = manCity.Id },
        new Player { FirstName = "Rayan", LastName = "Cherki", Position = "CAM", Number = 10, Age = 22, Nationality = "France", MarketValue = 50m, TeamId = manCity.Id },
        new Player { FirstName = "Bernardo", LastName = "Silva", Position = "CAM", Number = 20, Age = 31, Nationality = "Portugal", MarketValue = 27m, TeamId = manCity.Id },
        new Player { FirstName = "Jérémy", LastName = "Doku", Position = "LW", Number = 11, Age = 23, Nationality = "Belgium", MarketValue = 65m, TeamId = manCity.Id },
        new Player { FirstName = "Savinho", LastName = "", Position = "LW", Number = 26, Age = 21, Nationality = "Brazil", MarketValue = 45m, TeamId = manCity.Id },
        new Player { FirstName = "Antoine", LastName = "Semenyo", Position = "RW", Number = 42, Age = 26, Nationality = "Ghana", MarketValue = 65m, TeamId = manCity.Id },
        new Player { FirstName = "Erling", LastName = "Haaland", Position = "ST", Number = 9, Age = 25, Nationality = "Norway", MarketValue = 200m, TeamId = manCity.Id },
        new Player { FirstName = "Omar", LastName = "Marmoush", Position = "ST", Number = 7, Age = 27, Nationality = "Egypt", MarketValue = 65m, TeamId = manCity.Id }
    });
        }

        if (manUnited != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Senne", LastName = "Lammens", Position = "GK", Number = 31, Age = 23, Nationality = "Belgium", MarketValue = 25m, TeamId = manUnited.Id },
        new Player { FirstName = "Altay", LastName = "Bayindir", Position = "GK", Number = 1, Age = 27, Nationality = "Turkey", MarketValue = 7m, TeamId = manUnited.Id },
        new Player { FirstName = "Tom", LastName = "Heaton", Position = "GK", Number = 22, Age = 39, Nationality = "England", MarketValue = 0.15m, TeamId = manUnited.Id },
        new Player { FirstName = "Leny", LastName = "Yoro", Position = "CB", Number = 15, Age = 20, Nationality = "France", MarketValue = 55m, TeamId = manUnited.Id },
        new Player { FirstName = "Matthijs", LastName = "de Ligt", Position = "CB", Number = 4, Age = 26, Nationality = "Netherlands", MarketValue = 40m, TeamId = manUnited.Id },
        new Player { FirstName = "Lisandro", LastName = "Martinez", Position = "CB", Number = 6, Age = 28, Nationality = "Argentina", MarketValue = 35m, TeamId = manUnited.Id },
        new Player { FirstName = "Harry", LastName = "Maguire", Position = "CB", Number = 5, Age = 33, Nationality = "England", MarketValue = 10m, TeamId = manUnited.Id },
        new Player { FirstName = "Ayden", LastName = "Heaven", Position = "CB", Number = 26, Age = 19, Nationality = "England", MarketValue = 10m, TeamId = manUnited.Id },
        new Player { FirstName = "Tyler", LastName = "Fredricson", Position = "CB", Number = 33, Age = 21, Nationality = "England", MarketValue = 3m, TeamId = manUnited.Id },
        new Player { FirstName = "Patrick", LastName = "Dorgu", Position = "LB", Number = 13, Age = 21, Nationality = "Denmark", MarketValue = 30m, TeamId = manUnited.Id },
        new Player { FirstName = "Luke", LastName = "Shaw", Position = "LB", Number = 23, Age = 30, Nationality = "England", MarketValue = 10m, TeamId = manUnited.Id },
        new Player { FirstName = "Tyrell", LastName = "Malacia", Position = "LB", Number = 12, Age = 26, Nationality = "Netherlands", MarketValue = 5m, TeamId = manUnited.Id },
        new Player { FirstName = "Diego", LastName = "León", Position = "LB", Number = 35, Age = 18, Nationality = "Paraguay", MarketValue = 4m, TeamId = manUnited.Id },
        new Player { FirstName = "Diogo", LastName = "Dalot", Position = "RB", Number = 2, Age = 26, Nationality = "Portugal", MarketValue = 28m, TeamId = manUnited.Id },
        new Player { FirstName = "Noussair", LastName = "Mazraoui", Position = "RB", Number = 3, Age = 28, Nationality = "Morocco", MarketValue = 22m, TeamId = manUnited.Id },
        new Player { FirstName = "Manuel", LastName = "Ugarte", Position = "CDM", Number = 25, Age = 24, Nationality = "Uruguay", MarketValue = 30m, TeamId = manUnited.Id },
        new Player { FirstName = "Casemiro", LastName = "", Position = "CDM", Number = 18, Age = 34, Nationality = "Brazil", MarketValue = 8m, TeamId = manUnited.Id },
        new Player { FirstName = "Kobbie", LastName = "Mainoo", Position = "CM", Number = 37, Age = 20, Nationality = "England", MarketValue = 40m, TeamId = manUnited.Id },
        new Player { FirstName = "Bruno", LastName = "Fernandes", Position = "CAM", Number = 8, Age = 31, Nationality = "Portugal", MarketValue = 40m, TeamId = manUnited.Id },
        new Player { FirstName = "Mason", LastName = "Mount", Position = "CAM", Number = 7, Age = 27, Nationality = "England", MarketValue = 32m, TeamId = manUnited.Id },
        new Player { FirstName = "Bryan", LastName = "Mbeumo", Position = "RW", Number = 19, Age = 26, Nationality = "Cameroon", MarketValue = 75m, TeamId = manUnited.Id },
        new Player { FirstName = "Amad", LastName = "Diallo", Position = "RW", Number = 16, Age = 23, Nationality = "Ivory Coast", MarketValue = 50m, TeamId = manUnited.Id },
        new Player { FirstName = "Matheus", LastName = "Cunha", Position = "ST", Number = 10, Age = 26, Nationality = "Brazil", MarketValue = 70m, TeamId = manUnited.Id },
        new Player { FirstName = "Benjamin", LastName = "Sesko", Position = "ST", Number = 30, Age = 22, Nationality = "Slovenia", MarketValue = 60m, TeamId = manUnited.Id },
        new Player { FirstName = "Chido", LastName = "Obi", Position = "ST", Number = 32, Age = 18, Nationality = "Denmark", MarketValue = 5m, TeamId = manUnited.Id }
    });
        }

        if (newcastle != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Aaron", LastName = "Ramsdale", Position = "GK", Number = 32, Age = 27, Nationality = "England", MarketValue = 12m, TeamId = newcastle.Id },
        new Player { FirstName = "Nick", LastName = "Pope", Position = "GK", Number = 1, Age = 33, Nationality = "England", MarketValue = 7m, TeamId = newcastle.Id },
        new Player { FirstName = "Mark", LastName = "Gillespie", Position = "GK", Number = 29, Age = 33, Nationality = "England", MarketValue = 0.15m, TeamId = newcastle.Id },
        new Player { FirstName = "John", LastName = "Ruddy", Position = "GK", Number = 26, Age = 39, Nationality = "England", MarketValue = 0.10m, TeamId = newcastle.Id },
        new Player { FirstName = "Malick", LastName = "Thiaw", Position = "CB", Number = 12, Age = 24, Nationality = "Germany", MarketValue = 40m, TeamId = newcastle.Id },
        new Player { FirstName = "Sven", LastName = "Botman", Position = "CB", Number = 4, Age = 26, Nationality = "Netherlands", MarketValue = 35m, TeamId = newcastle.Id },
        new Player { FirstName = "Fabian", LastName = "Schär", Position = "CB", Number = 5, Age = 34, Nationality = "Switzerland", MarketValue = 6m, TeamId = newcastle.Id },
        new Player { FirstName = "Dan", LastName = "Burn", Position = "CB", Number = 33, Age = 33, Nationality = "England", MarketValue = 5m, TeamId = newcastle.Id },
        new Player { FirstName = "Lewis", LastName = "Hall", Position = "LB", Number = 3, Age = 21, Nationality = "England", MarketValue = 32m, TeamId = newcastle.Id },
        new Player { FirstName = "Alex", LastName = "Murphy", Position = "LB", Number = 37, Age = 21, Nationality = "Ireland", MarketValue = 0.3m, TeamId = newcastle.Id },
        new Player { FirstName = "Tino", LastName = "Livramento", Position = "RB", Number = 21, Age = 23, Nationality = "England", MarketValue = 40m, TeamId = newcastle.Id },
        new Player { FirstName = "Kieran", LastName = "Trippier", Position = "RB", Number = 2, Age = 35, Nationality = "England", MarketValue = 2.5m, TeamId = newcastle.Id },
        new Player { FirstName = "Emil", LastName = "Krafth", Position = "RB", Number = 17, Age = 31, Nationality = "Sweden", MarketValue = 1.5m, TeamId = newcastle.Id },
        new Player { FirstName = "Sandro", LastName = "Tonali", Position = "CDM", Number = 8, Age = 25, Nationality = "Italy", MarketValue = 75m, TeamId = newcastle.Id },
        new Player { FirstName = "Bruno", LastName = "Guimarães", Position = "CM", Number = 39, Age = 28, Nationality = "Brazil", MarketValue = 75m, TeamId = newcastle.Id },
        new Player { FirstName = "Jacob", LastName = "Ramsey", Position = "CM", Number = 41, Age = 24, Nationality = "England", MarketValue = 35m, TeamId = newcastle.Id },
        new Player { FirstName = "Joelinton", LastName = "", Position = "CM", Number = 7, Age = 29, Nationality = "Brazil", MarketValue = 30m, TeamId = newcastle.Id },
        new Player { FirstName = "Lewis", LastName = "Miley", Position = "CM", Number = 67, Age = 19, Nationality = "England", MarketValue = 20m, TeamId = newcastle.Id },
        new Player { FirstName = "Joe", LastName = "Willock", Position = "CM", Number = 28, Age = 26, Nationality = "England", MarketValue = 16m, TeamId = newcastle.Id },
        new Player { FirstName = "Anthony", LastName = "Gordon", Position = "LW", Number = 10, Age = 25, Nationality = "England", MarketValue = 60m, TeamId = newcastle.Id },
        new Player { FirstName = "Harvey", LastName = "Barnes", Position = "LW", Number = 11, Age = 28, Nationality = "England", MarketValue = 32m, TeamId = newcastle.Id },
        new Player { FirstName = "Anthony", LastName = "Elanga", Position = "RW", Number = 20, Age = 23, Nationality = "Sweden", MarketValue = 50m, TeamId = newcastle.Id },
        new Player { FirstName = "Jacob", LastName = "Murphy", Position = "RW", Number = 23, Age = 31, Nationality = "England", MarketValue = 15m, TeamId = newcastle.Id },
        new Player { FirstName = "Nick", LastName = "Woltemade", Position = "ST", Number = 27, Age = 24, Nationality = "Germany", MarketValue = 70m, TeamId = newcastle.Id },
        new Player { FirstName = "Yoane", LastName = "Wissa", Position = "ST", Number = 9, Age = 29, Nationality = "DR Congo", MarketValue = 35m, TeamId = newcastle.Id },
        new Player { FirstName = "William", LastName = "Osula", Position = "ST", Number = 18, Age = 22, Nationality = "Denmark", MarketValue = 15m, TeamId = newcastle.Id }
    });
        }

        if (tottenham != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Guglielmo", LastName = "Vicario", Position = "GK", Number = 1, Age = 29, Nationality = "Italy", MarketValue = 30m, TeamId = tottenham.Id },
        new Player { FirstName = "Antonin", LastName = " Kinský", Position = "GK", Number = 31, Age = 22, Nationality = "Czech Republic", MarketValue = 13m, TeamId = tottenham.Id },
        new Player { FirstName = "Brandon", LastName = "Austin", Position = "GK", Number = 40, Age = 27, Nationality = "England", MarketValue = 0.5m, TeamId = tottenham.Id },
        new Player { FirstName = "Micky", LastName = "van de Ven", Position = "CB", Number = 37, Age = 24, Nationality = "Netherlands", MarketValue = 65m, TeamId = tottenham.Id },
        new Player { FirstName = "Cristian", LastName = "Romero", Position = "CB", Number = 17, Age = 27, Nationality = "Argentina", MarketValue = 60m, TeamId = tottenham.Id },
        new Player { FirstName = "Radu", LastName = "Drăgușin", Position = "CB", Number = 3, Age = 24, Nationality = "Romania", MarketValue = 22m, TeamId = tottenham.Id },
        new Player { FirstName = "Kevin", LastName = "Danso", Position = "CB", Number = 4, Age = 27, Nationality = "Austria", MarketValue = 22m, TeamId = tottenham.Id },
        new Player { FirstName = "Ben", LastName = "Davies", Position = "CB", Number = 33, Age = 32, Nationality = "Wales", MarketValue = 5m, TeamId = tottenham.Id },
        new Player { FirstName = "Destiny", LastName = "Udogie", Position = "LB", Number = 13, Age = 23, Nationality = "Italy", MarketValue = 40m, TeamId = tottenham.Id },
        new Player { FirstName = "Djed", LastName = "Spence", Position = "LB", Number = 24, Age = 25, Nationality = "England", MarketValue = 32m, TeamId = tottenham.Id },
        new Player { FirstName = "Souza", LastName = "", Position = "LB", Number = 38, Age = 19, Nationality = "Brazil", MarketValue = 5m, TeamId = tottenham.Id },
        new Player { FirstName = "Pedro", LastName = "Porro", Position = "RB", Number = 23, Age = 26, Nationality = "Spain", MarketValue = 40m, TeamId = tottenham.Id },
        new Player { FirstName = "Rodrigo", LastName = "Bentancur", Position = "CDM", Number = 30, Age = 28, Nationality = "Uruguay", MarketValue = 27m, TeamId = tottenham.Id },
        new Player { FirstName = "Joao", LastName = "Palhinha", Position = "CDM", Number = 6, Age = 30, Nationality = "Portugal", MarketValue = 25m, TeamId = tottenham.Id },
        new Player { FirstName = "Yves", LastName = "Bissouma", Position = "CDM", Number = 8, Age = 29, Nationality = "Mali", MarketValue = 15m, TeamId = tottenham.Id },
        new Player { FirstName = "Lucas", LastName = "Bergvall", Position = "CM", Number = 15, Age = 20, Nationality = "Sweden", MarketValue = 40m, TeamId = tottenham.Id },
        new Player { FirstName = "Archie", LastName = "Gray", Position = "CM", Number = 14, Age = 19, Nationality = "England", MarketValue = 35m, TeamId = tottenham.Id },
        new Player { FirstName = "Conor", LastName = "Gallagher", Position = "CM", Number = 22, Age = 26, Nationality = "England", MarketValue = 35m, TeamId = tottenham.Id },
        new Player { FirstName = "Pape Matar", LastName = "Sarr", Position = "CM", Number = 29, Age = 23, Nationality = "Senegal", MarketValue = 35m, TeamId = tottenham.Id },
        new Player { FirstName = "Xavi", LastName = "Simons", Position = "CAM", Number = 7, Age = 22, Nationality = "Netherlands", MarketValue = 60m, TeamId = tottenham.Id },
        new Player { FirstName = "Dejan", LastName = "Kulusevski", Position = "CAM", Number = 21, Age = 25, Nationality = "Sweden", MarketValue = 45m, TeamId = tottenham.Id },
        new Player { FirstName = "James", LastName = "Maddison", Position = "CAM", Number = 10, Age = 29, Nationality = "England", MarketValue = 30m, TeamId = tottenham.Id },
        new Player { FirstName = "Wilson", LastName = "Odobert", Position = "LW", Number = 28, Age = 21, Nationality = "France", MarketValue = 22m, TeamId = tottenham.Id },
        new Player { FirstName = "Mohamed", LastName = "Kudus", Position = "RW", Number = 20, Age = 25, Nationality = "Ghana", MarketValue = 55m, TeamId = tottenham.Id },
        new Player { FirstName = "Dominic", LastName = "Solanke", Position = "ST", Number = 19, Age = 28, Nationality = "England", MarketValue = 35m, TeamId = tottenham.Id },
        new Player { FirstName = "Mathys", LastName = "Tel", Position = "ST", Number = 11, Age = 20, Nationality = "France", MarketValue = 30m, TeamId = tottenham.Id },
        new Player { FirstName = "Richarlison", LastName = "", Position = "ST", Number = 9, Age = 28, Nationality = "Brazil", MarketValue = 28m, TeamId = tottenham.Id },
        new Player { FirstName = "Randal", LastName = "Kolo Muani", Position = "ST", Number = 39, Age = 27, Nationality = "France", MarketValue = 25m, TeamId = tottenham.Id }
    });
        }

        if (brighton != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Bart", LastName = "Verbruggen", Position = "GK", Number = 1, Age = 23, Nationality = "Netherlands", MarketValue = 35m, TeamId = brighton.Id },
        new Player { FirstName = "Jason", LastName = "Steele", Position = "GK", Number = 23, Age = 35, Nationality = "England", MarketValue = 0.75m, TeamId = brighton.Id },
        new Player { FirstName = "Tom", LastName = "McGill", Position = "GK", Number = 38, Age = 25, Nationality = "Canada", MarketValue = 0.5m, TeamId = brighton.Id },
        new Player { FirstName = "Jan Paul", LastName = "van Hecke", Position = "CB", Number = 6, Age = 25, Nationality = "Netherlands", MarketValue = 35m, TeamId = brighton.Id },
        new Player { FirstName = "Olivier", LastName = "Boscagli", Position = "CB", Number = 21, Age = 28, Nationality = "France", MarketValue = 18m, TeamId = brighton.Id },
        new Player { FirstName = "Igor", LastName = "Julio", Position = "CB", Number = 3, Age = 28, Nationality = "Brazil", MarketValue = 15m, TeamId = brighton.Id },
        new Player { FirstName = "Adam", LastName = "Webster", Position = "CB", Number = 4, Age = 31, Nationality = "England", MarketValue = 7m, TeamId = brighton.Id },
        new Player { FirstName = "Lewis", LastName = "Dunk", Position = "CB", Number = 5, Age = 34, Nationality = "England", MarketValue = 4m, TeamId = brighton.Id },
        new Player { FirstName = "Ferdi", LastName = "Kadioglu", Position = "LB", Number = 24, Age = 26, Nationality = "Turkey", MarketValue = 28m, TeamId = brighton.Id },
        new Player { FirstName = "Maxim", LastName = "De Cuyper", Position = "LB", Number = 29, Age = 25, Nationality = "Belgium", MarketValue = 22m, TeamId = brighton.Id },
        new Player { FirstName = "Joel", LastName = "Veltman", Position = "RB", Number = 34, Age = 34, Nationality = "Netherlands", MarketValue = 2.5m, TeamId = brighton.Id },
        new Player { FirstName = "Carlos", LastName = "Baleba", Position = "CDM", Number = 17, Age = 22, Nationality = "Cameroon", MarketValue = 60m, TeamId = brighton.Id },
        new Player { FirstName = "Mats", LastName = "Wieffer", Position = "CDM", Number = 27, Age = 26, Nationality = "Netherlands", MarketValue = 25m, TeamId = brighton.Id },
        new Player { FirstName = "Jack", LastName = "Hinshelwood", Position = "CDM", Number = 13, Age = 20, Nationality = "England", MarketValue = 22m, TeamId = brighton.Id },
        new Player { FirstName = "Yasin", LastName = "Ayari", Position = "CM", Number = 26, Age = 22, Nationality = "Sweden", MarketValue = 30m, TeamId = brighton.Id },
        new Player { FirstName = "Diego", LastName = "Gomez", Position = "CM", Number = 25, Age = 22, Nationality = "Paraguay", MarketValue = 25m, TeamId = brighton.Id },
        new Player { FirstName = "Matt", LastName = "O'Riley", Position = "CM", Number = 33, Age = 25, Nationality = "Denmark", MarketValue = 20m, TeamId = brighton.Id },
        new Player { FirstName = "Pascal", LastName = "Gross", Position = "CM", Number = 30, Age = 34, Nationality = "Germany", MarketValue = 3.5m, TeamId = brighton.Id },
        new Player { FirstName = "James", LastName = "Milner", Position = "CM", Number = 20, Age = 40, Nationality = "England", MarketValue = 0.75m, TeamId = brighton.Id },
        new Player { FirstName = "Kaoru", LastName = "Mitoma", Position = "LW", Number = 22, Age = 28, Nationality = "Japan", MarketValue = 30m, TeamId = brighton.Id },
        new Player { FirstName = "Yankuba", LastName = "Minteh", Position = "RW", Number = 11, Age = 21, Nationality = "Gambia", MarketValue = 40m, TeamId = brighton.Id },
        new Player { FirstName = "Solly", LastName = "March", Position = "RW", Number = 7, Age = 31, Nationality = "England", MarketValue = 3m, TeamId = brighton.Id },
        new Player { FirstName = "Georginio", LastName = "Rutter", Position = "ST", Number = 10, Age = 23, Nationality = "France", MarketValue = 32m, TeamId = brighton.Id },
        new Player { FirstName = "Charalampos", LastName = "Kostoulas", Position = "ST", Number = 19, Age = 18, Nationality = "Greece", MarketValue = 25m, TeamId = brighton.Id },
        new Player { FirstName = "Stefanos", LastName = "Tzimas", Position = "ST", Number = 9, Age = 20, Nationality = "Greece", MarketValue = 22m, TeamId = brighton.Id },
        new Player { FirstName = "Danny", LastName = "Welbeck", Position = "ST", Number = 18, Age = 35, Nationality = "England", MarketValue = 4m, TeamId = brighton.Id }
    });
        }

        if (astonVilla != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Emiliano", LastName = "Martinez", Position = "GK", Number = 23, Age = 33, Nationality = "Argentina", MarketValue = 15m, TeamId = astonVilla.Id },
        new Player { FirstName = "Marco", LastName = "Bizot", Position = "GK", Number = 40, Age = 34, Nationality = "Netherlands", MarketValue = 2.5m, TeamId = astonVilla.Id },
        new Player { FirstName = "Ezri", LastName = "Konsa", Position = "CB", Number = 4, Age = 28, Nationality = "England", MarketValue = 40m, TeamId = astonVilla.Id },
        new Player { FirstName = "Pau", LastName = "Torres", Position = "CB", Number = 14, Age = 29, Nationality = "Spain", MarketValue = 22m, TeamId = astonVilla.Id },
        new Player { FirstName = "Victor", LastName = "Lindelöf", Position = "CB", Number = 3, Age = 31, Nationality = "Sweden", MarketValue = 6m, TeamId = astonVilla.Id },
        new Player { FirstName = "Tyrone", LastName = "Mings", Position = "CB", Number = 5, Age = 32, Nationality = "England", MarketValue = 4m, TeamId = astonVilla.Id },
        new Player { FirstName = "Ian", LastName = "Maatsen", Position = "LB", Number = 22, Age = 23, Nationality = "Netherlands", MarketValue = 30m, TeamId = astonVilla.Id },
        new Player { FirstName = "Lucas", LastName = "Digne", Position = "LB", Number = 12, Age = 32, Nationality = "France", MarketValue = 8m, TeamId = astonVilla.Id },
        new Player { FirstName = "Matty", LastName = "Cash", Position = "RB", Number = 2, Age = 28, Nationality = "Poland", MarketValue = 22m, TeamId = astonVilla.Id },
        new Player { FirstName = "Andres", LastName = "Garcia", Position = "RB", Number = 16, Age = 23, Nationality = "Spain", MarketValue = 7m, TeamId = astonVilla.Id },
        new Player { FirstName = "Amadou", LastName = "Onana", Position = "CDM", Number = 24, Age = 24, Nationality = "Belgium", MarketValue = 45m, TeamId = astonVilla.Id },
        new Player { FirstName = "Boubacar", LastName = "Kamara", Position = "CDM", Number = 44, Age = 26, Nationality = "France", MarketValue = 40m, TeamId = astonVilla.Id },
        new Player { FirstName = "Lamare", LastName = "Bogarde", Position = "CDM", Number = 26, Age = 22, Nationality = "Netherlands", MarketValue = 15m, TeamId = astonVilla.Id },
        new Player { FirstName = "Youri", LastName = "Tielemans", Position = "CM", Number = 8, Age = 28, Nationality = "Belgium", MarketValue = 35m, TeamId = astonVilla.Id },
        new Player { FirstName = "Douglas", LastName = "Luiz", Position = "CM", Number = 21, Age = 27, Nationality = "Brazil", MarketValue = 20m, TeamId = astonVilla.Id },
        new Player { FirstName = "John", LastName = "McGinn", Position = "CM", Number = 7, Age = 31, Nationality = "Scotland", MarketValue = 15m, TeamId = astonVilla.Id },
        new Player { FirstName = "Ross", LastName = "Barkley", Position = "CM", Number = 6, Age = 32, Nationality = "England", MarketValue = 5m, TeamId = astonVilla.Id },
        new Player { FirstName = "Morgan", LastName = "Rogers", Position = "CAM", Number = 27, Age = 23, Nationality = "England", MarketValue = 80m, TeamId = astonVilla.Id },
        new Player { FirstName = "Harvey", LastName = "Elliott", Position = "CAM", Number = 9, Age = 22, Nationality = "England", MarketValue = 22m, TeamId = astonVilla.Id },
        new Player { FirstName = "Emiliano", LastName = "Buendia", Position = "CAM", Number = 10, Age = 29, Nationality = "Argentina", MarketValue = 18m, TeamId = astonVilla.Id },
        new Player { FirstName = "Jadon", LastName = "Sancho", Position = "LW", Number = 19, Age = 25, Nationality = "England", MarketValue = 20m, TeamId = astonVilla.Id },
        new Player { FirstName = "Leon", LastName = "Bailey", Position = "RW", Number = 31, Age = 28, Nationality = "Jamaica", MarketValue = 16m, TeamId = astonVilla.Id },
        new Player { FirstName = "Alysson", LastName = "", Position = "RW", Number = 47, Age = 19, Nationality = "Brazil", MarketValue = 10m, TeamId = astonVilla.Id },
        new Player { FirstName = "Ollie", LastName = "Watkins", Position = "ST", Number = 11, Age = 30, Nationality = "England", MarketValue = 30m, TeamId = astonVilla.Id },
        new Player { FirstName = "Tammy", LastName = "Abraham", Position = "ST", Number = 18, Age = 28, Nationality = "England", MarketValue = 20m, TeamId = astonVilla.Id }
    });
        }

        if (brentford != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Caoimhin", LastName = "Kelleher", Position = "GK", Number = 1, Age = 27, Nationality = "Ireland", MarketValue = 25m, TeamId = brentford.Id },
        new Player { FirstName = "Hakon", LastName = "Valdimarsson", Position = "GK", Number = 12, Age = 24, Nationality = "Iceland", MarketValue = 2.5m, TeamId = brentford.Id },
        new Player { FirstName = "Ellery", LastName = "Balcombe", Position = "GK", Number = 31, Age = 26, Nationality = "England", MarketValue = 0.4m, TeamId = brentford.Id },
        new Player { FirstName = "Julian", LastName = "Eyestone", Position = "GK", Number = 41, Age = 19, Nationality = "USA", MarketValue = 0m, TeamId = brentford.Id },
        new Player { FirstName = "Sepp", LastName = "van den Berg", Position = "CB", Number = 4, Age = 24, Nationality = "Netherlands", MarketValue = 32m, TeamId = brentford.Id },
        new Player { FirstName = "Nathan", LastName = "Collins", Position = "CB", Number = 22, Age = 24, Nationality = "Ireland", MarketValue = 30m, TeamId = brentford.Id },
        new Player { FirstName = "Kristoffer", LastName = "Ajer", Position = "CB", Number = 20, Age = 27, Nationality = "Norway", MarketValue = 18m, TeamId = brentford.Id },
        new Player { FirstName = "Ethan", LastName = "Pinnock", Position = "CB", Number = 5, Age = 32, Nationality = "Jamaica", MarketValue = 4m, TeamId = brentford.Id },
        new Player { FirstName = "Rico", LastName = "Henry", Position = "LB", Number = 3, Age = 28, Nationality = "England", MarketValue = 15m, TeamId = brentford.Id },
        new Player { FirstName = "Michael", LastName = "Kayode", Position = "RB", Number = 33, Age = 21, Nationality = "Italy", MarketValue = 35m, TeamId = brentford.Id },
        new Player { FirstName = "Aaron", LastName = "Hickey", Position = "RB", Number = 2, Age = 23, Nationality = "Scotland", MarketValue = 16m, TeamId = brentford.Id },
        new Player { FirstName = "Vitaly", LastName = "Janelt", Position = "CDM", Number = 27, Age = 27, Nationality = "Germany", MarketValue = 18m, TeamId = brentford.Id },
        new Player { FirstName = "Jordan", LastName = "Henderson", Position = "CDM", Number = 6, Age = 35, Nationality = "England", MarketValue = 2m, TeamId = brentford.Id },
        new Player { FirstName = "Yegor", LastName = "Yarmolyuk", Position = "CM", Number = 18, Age = 22, Nationality = "Ukraine", MarketValue = 30m, TeamId = brentford.Id },
        new Player { FirstName = "Mathias", LastName = "Jensen", Position = "CM", Number = 8, Age = 30, Nationality = "Denmark", MarketValue = 12m, TeamId = brentford.Id },
        new Player { FirstName = "Josh", LastName = "Dasilva", Position = "CM", Number = 10, Age = 27, Nationality = "England", MarketValue = 2m, TeamId = brentford.Id },
        new Player { FirstName = "Keane", LastName = "Lewis-Potter", Position = "CM", Number = 23, Age = 25, Nationality = "England", MarketValue = 25m, TeamId = brentford.Id },
        new Player { FirstName = "Mikkel", LastName = "Damsgaard", Position = "CAM", Number = 24, Age = 25, Nationality = "Denmark", MarketValue = 30m, TeamId = brentford.Id },
        new Player { FirstName = "Antoni", LastName = "Milambo", Position = "CAM", Number = 17, Age = 20, Nationality = "Netherlands", MarketValue = 20m, TeamId = brentford.Id },
        new Player { FirstName = "Fabio", LastName = "Carvalho", Position = "CAM", Number = 14, Age = 23, Nationality = "Portugal", MarketValue = 10m, TeamId = brentford.Id },
        new Player { FirstName = "Kevin", LastName = "Schade", Position = "LW", Number = 7, Age = 24, Nationality = "Germany", MarketValue = 35m, TeamId = brentford.Id },
        new Player { FirstName = "Reiss", LastName = "Nelson", Position = "LW", Number = 11, Age = 26, Nationality = "England", MarketValue = 12m, TeamId = brentford.Id },
        new Player { FirstName = "Dango", LastName = "Ouattara", Position = "RW", Number = 19, Age = 24, Nationality = "Burkina Faso", MarketValue = 35m, TeamId = brentford.Id },
        new Player { FirstName = "Romelle", LastName = "Donovan", Position = "RW", Number = 45, Age = 19, Nationality = "England", MarketValue = 3.5m, TeamId = brentford.Id },
        new Player { FirstName = "Igor", LastName = "Thiago", Position = "ST", Number = 9, Age = 24, Nationality = "Brazil", MarketValue = 50m, TeamId = brentford.Id },
        new Player { FirstName = "Kaye", LastName = "Furo", Position = "ST", Number = 47, Age = 19, Nationality = "Belgium", MarketValue = 8m, TeamId = brentford.Id }
    });
        }

        if (fulham != null)
        {
        players.AddRange(new List<Player>
    {
        new Player { FirstName = "Bernd", LastName = "Leno", Position = "GK", Number = 1, Age = 34, Nationality = "Germany", MarketValue = 8m, TeamId = fulham.Id },
        new Player { FirstName = "Benjamin", LastName = "Lecomte", Position = "GK", Number = 23, Age = 34, Nationality = "France", MarketValue = 1.2m, TeamId = fulham.Id },
        new Player { FirstName = "Calvin", LastName = "Bassey", Position = "CB", Number = 3, Age = 26, Nationality = "Nigeria", MarketValue = 28m, TeamId = fulham.Id },
        new Player { FirstName = "Joachim", LastName = "Andersen", Position = "CB", Number = 5, Age = 29, Nationality = "Denmark", MarketValue = 25m, TeamId = fulham.Id },
        new Player { FirstName = "Issa", LastName = "Diop", Position = "CB", Number = 31, Age = 29, Nationality = "France", MarketValue = 10m, TeamId = fulham.Id },
        new Player { FirstName = "Jorge", LastName = "Cuenca", Position = "CB", Number = 15, Age = 26, Nationality = "Spain", MarketValue = 8m, TeamId = fulham.Id },
        new Player { FirstName = "Antonee", LastName = "Robinson", Position = "LB", Number = 33, Age = 28, Nationality = "USA", MarketValue = 25m, TeamId = fulham.Id },
        new Player { FirstName = "Ryan", LastName = "Sessegnon", Position = "LB", Number = 30, Age = 25, Nationality = "England", MarketValue = 20m, TeamId = fulham.Id },
        new Player { FirstName = "Kenny", LastName = "Tete", Position = "RB", Number = 2, Age = 30, Nationality = "Netherlands", MarketValue = 11m, TeamId = fulham.Id },
        new Player { FirstName = "Timothy", LastName = "Castagne", Position = "RB", Number = 21, Age = 30, Nationality = "Belgium", MarketValue = 10m, TeamId = fulham.Id },
        new Player { FirstName = "Sander", LastName = "Berge", Position = "CDM", Number = 16, Age = 28, Nationality = "Norway", MarketValue = 25m, TeamId = fulham.Id },
        new Player { FirstName = "Sasa", LastName = "Lukić", Position = "CM", Number = 20, Age = 29, Nationality = "Serbia", MarketValue = 12m, TeamId = fulham.Id },
        new Player { FirstName = "Harrison", LastName = "Reed", Position = "CM", Number = 6, Age = 31, Nationality = "England", MarketValue = 3m, TeamId = fulham.Id },
        new Player { FirstName = "Tom", LastName = "Cairney", Position = "CM", Number = 10, Age = 35, Nationality = "Scotland", MarketValue = 0.75m, TeamId = fulham.Id },
        new Player { FirstName = "Emile", LastName = "Smith Rowe", Position = "CAM", Number = 32, Age = 25, Nationality = "England", MarketValue = 22m, TeamId = fulham.Id },
        new Player { FirstName = "Josh", LastName = "King", Position = "CAM", Number = 24, Age = 19, Nationality = "England", MarketValue = 20m, TeamId = fulham.Id },
        new Player { FirstName = "Kevin", LastName = "", Position = "LW", Number = 22, Age = 23, Nationality = "Brazil", MarketValue = 30m, TeamId = fulham.Id },
        new Player { FirstName = "Alex", LastName = "Iwobi", Position = "LW", Number = 17, Age = 29, Nationality = "Nigeria", MarketValue = 25m, TeamId = fulham.Id },
        new Player { FirstName = "Oscar", LastName = "Bobb", Position = "RW", Number = 14, Age = 22, Nationality = "Norway", MarketValue = 30m, TeamId = fulham.Id },
        new Player { FirstName = "Harry", LastName = "Wilson", Position = "RW", Number = 8, Age = 28, Nationality = "Wales", MarketValue = 25m, TeamId = fulham.Id },
        new Player { FirstName = "Samuel", LastName = "Chukwueze", Position = "RW", Number = 19, Age = 26, Nationality = "Nigeria", MarketValue = 15m, TeamId = fulham.Id },
        new Player { FirstName = "Rodrygo", LastName = "Muniz", Position = "ST", Number = 9, Age = 24, Nationality = "Brazil", MarketValue = 25m, TeamId = fulham.Id },
        new Player { FirstName = "Raul", LastName = "Jiménez", Position = "ST", Number = 7, Age = 34, Nationality = "Mexico", MarketValue = 4m, TeamId = fulham.Id },
        new Player { FirstName = "Jonah", LastName = "Kusi-Asare", Position = "ST", Number = 18, Age = 18, Nationality = "Sweden", MarketValue = 4m, TeamId = fulham.Id }
    });
        }

        if (wolves != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Jose", LastName = "Sá", Position = "GK", Number = 1, Age = 33, Nationality = "Portugal", MarketValue = 5m, TeamId = wolves.Id },
        new Player { FirstName = "Sam", LastName = "Johnstone", Position = "GK", Number = 31, Age = 32, Nationality = "England", MarketValue = 3m, TeamId = wolves.Id },
        new Player { FirstName = "Daniel", LastName = "Bentley", Position = "GK", Number = 25, Age = 32, Nationality = "England", MarketValue = 1m, TeamId = wolves.Id },
        new Player { FirstName = "Ladislav", LastName = "Krejci", Position = "CB", Number = 37, Age = 26, Nationality = "Czech Republic", MarketValue = 22m, TeamId = wolves.Id },
        new Player { FirstName = "Toti", LastName = "", Position = "CB", Number = 24, Age = 27, Nationality = "Portugal", MarketValue = 20m, TeamId = wolves.Id },
        new Player { FirstName = "Yerson", LastName = "Mosquera", Position = "CB", Number = 15, Age = 24, Nationality = "Colombia", MarketValue = 12m, TeamId = wolves.Id },
        new Player { FirstName = "Santiago", LastName = "Bueno", Position = "CB", Number = 4, Age = 27, Nationality = "Uruguay", MarketValue = 10m, TeamId = wolves.Id },
        new Player { FirstName = "Hugo", LastName = "Bueno", Position = "LB", Number = 3, Age = 23, Nationality = "Spain", MarketValue = 12m, TeamId = wolves.Id },
        new Player { FirstName = "David", LastName = "Moller Wolfe", Position = "LB", Number = 6, Age = 23, Nationality = "Norway", MarketValue = 10m, TeamId = wolves.Id },
        new Player { FirstName = "Jackson", LastName = "Tchatchoua", Position = "RB", Number = 38, Age = 24, Nationality = "Cameroon", MarketValue = 12m, TeamId = wolves.Id },
        new Player { FirstName = "Pedro", LastName = "Lima", Position = "RB", Number = 17, Age = 19, Nationality = "Brazil", MarketValue = 4m, TeamId = wolves.Id },
        new Player { FirstName = "Matt", LastName = "Doherty", Position = "RB", Number = 2, Age = 34, Nationality = "Ireland", MarketValue = 1.5m, TeamId = wolves.Id },
        new Player { FirstName = "André", LastName = "", Position = "CDM", Number = 7, Age = 24, Nationality = "Brazil", MarketValue = 25m, TeamId = wolves.Id },
        new Player { FirstName = "Joao", LastName = "Gomes", Position = "CM", Number = 8, Age = 25, Nationality = "Brazil", MarketValue = 35m, TeamId = wolves.Id },
        new Player { FirstName = "Jean-Ricner", LastName = "Bellegarde", Position = "CM", Number = 27, Age = 27, Nationality = "France", MarketValue = 16m, TeamId = wolves.Id },
        new Player { FirstName = "Rodrigo", LastName = "Gomes", Position = "LM", Number = 21, Age = 22, Nationality = "Portugal", MarketValue = 15m, TeamId = wolves.Id },
        new Player { FirstName = "Mateus", LastName = "Mane", Position = "CAM", Number = 36, Age = 18, Nationality = "Portugal", MarketValue = 20m, TeamId = wolves.Id },
        new Player { FirstName = "Angel", LastName = "Gomes", Position = "CAM", Number = 47, Age = 25, Nationality = "England", MarketValue = 12m, TeamId = wolves.Id },
        new Player { FirstName = "Enso", LastName = "Gonzalez", Position = "LW", Number = 30, Age = 21, Nationality = "Paraguay", MarketValue = 3m, TeamId = wolves.Id },
        new Player { FirstName = "Tolu", LastName = "Arokodare", Position = "ST", Number = 14, Age = 25, Nationality = "Nigeria", MarketValue = 22m, TeamId = wolves.Id },
        new Player { FirstName = "Adam", LastName = "Armstrong", Position = "ST", Number = 9, Age = 29, Nationality = "England", MarketValue = 8m, TeamId = wolves.Id },
        new Player { FirstName = "Hee-chan", LastName = "Hwang", Position = "ST", Number = 11, Age = 30, Nationality = "South Korea", MarketValue = 8m, TeamId = wolves.Id },
        new Player { FirstName = "Nathan", LastName = "Fraser", Position = "ST", Number = 63, Age = 21, Nationality = "Ireland", MarketValue = 0.6m, TeamId = wolves.Id }
    });
        }

        if (nottingham != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "John Victor", LastName = "", Position = "GK", Number = 13, Age = 30, Nationality = "Brazil", MarketValue = 7m, TeamId = nottingham.Id },
        new Player { FirstName = "Stefan", LastName = "Ortega", Position = "GK", Number = 27, Age = 33, Nationality = "Germany", MarketValue = 5m, TeamId = nottingham.Id },
        new Player { FirstName = "Matz", LastName = "Sels", Position = "GK", Number = 26, Age = 34, Nationality = "Belgium", MarketValue = 4m, TeamId = nottingham.Id },
        new Player { FirstName = "Angus", LastName = "Gunn", Position = "GK", Number = 18, Age = 30, Nationality = "Scotland", MarketValue = 1.5m, TeamId = nottingham.Id },
        new Player { FirstName = "Murillo", LastName = "", Position = "CB", Number = 5, Age = 23, Nationality = "Brazil", MarketValue = 50m, TeamId = nottingham.Id },
        new Player { FirstName = "Nikola", LastName = "Milenković", Position = "CB", Number = 31, Age = 28, Nationality = "Serbia", MarketValue = 30m, TeamId = nottingham.Id },
        new Player { FirstName = "Morato", LastName = "", Position = "CB", Number = 4, Age = 24, Nationality = "Brazil", MarketValue = 14m, TeamId = nottingham.Id },
        new Player { FirstName = "Jair", LastName = "Cunha", Position = "CB", Number = 23, Age = 21, Nationality = "Brazil", MarketValue = 12m, TeamId = nottingham.Id },
        new Player { FirstName = "Zach", LastName = "Abbott", Position = "CB", Number = 44, Age = 19, Nationality = "England", MarketValue = 3m, TeamId = nottingham.Id },
        new Player { FirstName = "Willy", LastName = "Boly", Position = "CB", Number = 30, Age = 35, Nationality = "Ivory Coast", MarketValue = 0.5m, TeamId = nottingham.Id },
        new Player { FirstName = "Neco", LastName = "Williams", Position = "LB", Number = 3, Age = 24, Nationality = "Wales", MarketValue = 25m, TeamId = nottingham.Id },
        new Player { FirstName = "Luca", LastName = "Netz", Position = "LB", Number = 25, Age = 22, Nationality = "Germany", MarketValue = 6m, TeamId = nottingham.Id },
        new Player { FirstName = "Ola", LastName = "Aina", Position = "RB", Number = 34, Age = 29, Nationality = "Nigeria", MarketValue = 20m, TeamId = nottingham.Id },
        new Player { FirstName = "Nicolo", LastName = "Savona", Position = "RB", Number = 37, Age = 22, Nationality = "Italy", MarketValue = 18m, TeamId = nottingham.Id },
        new Player { FirstName = "Eric", LastName = "da Silva Moreira", Position = "RB", Number = 17, Age = 19, Nationality = "Portugal", MarketValue = 1m, TeamId = nottingham.Id },
        new Player { FirstName = "Ibrahim", LastName = "Sangaré", Position = "CDM", Number = 6, Age = 28, Nationality = "Ivory Coast", MarketValue = 22m, TeamId = nottingham.Id },
        new Player { FirstName = "Elliot", LastName = "Anderson", Position = "CM", Number = 8, Age = 23, Nationality = "England", MarketValue = 60m, TeamId = nottingham.Id },
        new Player { FirstName = "Nicolas", LastName = "Dominguez", Position = "CM", Number = 16, Age = 27, Nationality = "Argentina", MarketValue = 16m, TeamId = nottingham.Id },
        new Player { FirstName = "Ryan", LastName = "Yates", Position = "CM", Number = 22, Age = 28, Nationality = "England", MarketValue = 8m, TeamId = nottingham.Id },
        new Player { FirstName = "Morgan", LastName = "Gibbs-White", Position = "CAM", Number = 10, Age = 26, Nationality = "England", MarketValue = 60m, TeamId = nottingham.Id },
        new Player { FirstName = "Omari", LastName = "Hutchinson", Position = "CAM", Number = 21, Age = 22, Nationality = "England", MarketValue = 30m, TeamId = nottingham.Id },
        new Player { FirstName = "James", LastName = "McAtee", Position = "CAM", Number = 24, Age = 23, Nationality = "England", MarketValue = 20m, TeamId = nottingham.Id },
        new Player { FirstName = "Callum", LastName = "Hudson-Odoi", Position = "LW", Number = 7, Age = 25, Nationality = "England", MarketValue = 30m, TeamId = nottingham.Id },
        new Player { FirstName = "Dan", LastName = "Ndoye", Position = "RW", Number = 14, Age = 25, Nationality = "Switzerland", MarketValue = 35m, TeamId = nottingham.Id },
        new Player { FirstName = "Dilane", LastName = "Bakwa", Position = "RW", Number = 29, Age = 23, Nationality = "France", MarketValue = 28m, TeamId = nottingham.Id },
        new Player { FirstName = "Lorenzo", LastName = "Lucca", Position = "ST", Number = 20, Age = 25, Nationality = "Italy", MarketValue = 25m, TeamId = nottingham.Id },
        new Player { FirstName = "Igor", LastName = "Jesus", Position = "ST", Number = 19, Age = 25, Nationality = "Brazil", MarketValue = 22m, TeamId = nottingham.Id },
        new Player { FirstName = "Taiwo", LastName = "Awoniyi", Position = "ST", Number = 9, Age = 28, Nationality = "Nigeria", MarketValue = 9m, TeamId = nottingham.Id },
        new Player { FirstName = "Chris", LastName = "Wood", Position = "ST", Number = 11, Age = 34, Nationality = "New Zealand", MarketValue = 6m, TeamId = nottingham.Id }
    });
        }

        if (everton != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Jordan", LastName = "Pickford", Position = "GK", Number = 1, Age = 32, Nationality = "England", MarketValue = 15m, TeamId = everton.Id },
        new Player { FirstName = "Mark", LastName = "Travers", Position = "GK", Number = 12, Age = 26, Nationality = "Ireland", MarketValue = 4m, TeamId = everton.Id },
        new Player { FirstName = "Tom", LastName = "King", Position = "GK", Number = 31, Age = 31, Nationality = "Wales", MarketValue = 0.15m, TeamId = everton.Id },
        new Player { FirstName = "Jarrad", LastName = "Branthwaite", Position = "CB", Number = 32, Age = 23, Nationality = "England", MarketValue = 45m, TeamId = everton.Id },
        new Player { FirstName = "James", LastName = "Tarkowski", Position = "CB", Number = 6, Age = 33, Nationality = "England", MarketValue = 7m, TeamId = everton.Id },
        new Player { FirstName = "Michael", LastName = "Keane", Position = "CB", Number = 5, Age = 33, Nationality = "England", MarketValue = 4m, TeamId = everton.Id },
        new Player { FirstName = "Vitaliy", LastName = "Mykolenko", Position = "LB", Number = 16, Age = 26, Nationality = "Ukraine", MarketValue = 25m, TeamId = everton.Id },
        new Player { FirstName = "Adam", LastName = "Aznou", Position = "LB", Number = 39, Age = 19, Nationality = "Morocco", MarketValue = 7m, TeamId = everton.Id },
        new Player { FirstName = "Jake", LastName = "O'Brien", Position = "RB", Number = 15, Age = 24, Nationality = "Ireland", MarketValue = 18m, TeamId = everton.Id },
        new Player { FirstName = "Nathan", LastName = "Patterson", Position = "RB", Number = 2, Age = 24, Nationality = "Scotland", MarketValue = 10m, TeamId = everton.Id },
        new Player { FirstName = "Seamus", LastName = "Coleman", Position = "RB", Number = 23, Age = 37, Nationality = "Ireland", MarketValue = 0.3m, TeamId = everton.Id },
        new Player { FirstName = "James", LastName = "Garner", Position = "CDM", Number = 37, Age = 24, Nationality = "England", MarketValue = 35m, TeamId = everton.Id },
        new Player { FirstName = "Idrissa", LastName = "Gueye", Position = "CDM", Number = 27, Age = 36, Nationality = "Senegal", MarketValue = 1m, TeamId = everton.Id },
        new Player { FirstName = "Kiernan", LastName = "Dewsbury-Hall", Position = "CM", Number = 22, Age = 27, Nationality = "England", MarketValue = 32m, TeamId = everton.Id },
        new Player { FirstName = "Carlos", LastName = "Alcaraz", Position = "CM", Number = 24, Age = 23, Nationality = "Argentina", MarketValue = 15m, TeamId = everton.Id },
        new Player { FirstName = "Tim", LastName = "Iroegbunam", Position = "CM", Number = 42, Age = 22, Nationality = "England", MarketValue = 15m, TeamId = everton.Id },
        new Player { FirstName = "Harrison", LastName = "Armstrong", Position = "CM", Number = 45, Age = 19, Nationality = "England", MarketValue = 12m, TeamId = everton.Id },
        new Player { FirstName = "Merlin", LastName = "Röhl", Position = "CAM", Number = 34, Age = 23, Nationality = "Germany", MarketValue = 16m, TeamId = everton.Id },
        new Player { FirstName = "Jack", LastName = "Grealish", Position = "LW", Number = 18, Age = 30, Nationality = "England", MarketValue = 25m, TeamId = everton.Id },
        new Player { FirstName = "Tyrique", LastName = "George", Position = "LW", Number = 19, Age = 20, Nationality = "England", MarketValue = 22m, TeamId = everton.Id },
        new Player { FirstName = "Dwight", LastName = "McNeil", Position = "LW", Number = 7, Age = 26, Nationality = "England", MarketValue = 20m, TeamId = everton.Id },
        new Player { FirstName = "Iliman", LastName = "Ndiaye", Position = "RW", Number = 10, Age = 26, Nationality = "Senegal", MarketValue = 50m, TeamId = everton.Id },
        new Player { FirstName = "Tyler", LastName = "Dibling", Position = "RW", Number = 20, Age = 20, Nationality = "England", MarketValue = 22m, TeamId = everton.Id },
        new Player { FirstName = "Thierno", LastName = "Barry", Position = "ST", Number = 11, Age = 23, Nationality = "France", MarketValue = 30m, TeamId = everton.Id },
        new Player { FirstName = "Beto", LastName = "", Position = "ST", Number = 9, Age = 28, Nationality = "Portugal", MarketValue = 20m, TeamId = everton.Id }
    });
        }

        if (leeds != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Lucas", LastName = "Perri", Position = "GK", Number = 1, Age = 28, Nationality = "Brazil", MarketValue = 13m, TeamId = leeds.Id },
        new Player { FirstName = "Illan", LastName = "Meslier", Position = "GK", Number = 16, Age = 26, Nationality = "France", MarketValue = 10m, TeamId = leeds.Id },
        new Player { FirstName = "Karl", LastName = "Darlow", Position = "GK", Number = 26, Age = 35, Nationality = "Wales", MarketValue = 0.2m, TeamId = leeds.Id },
        new Player { FirstName = "Alex", LastName = "Cairns", Position = "GK", Number = 21, Age = 33, Nationality = "England", MarketValue = 0.075m, TeamId = leeds.Id },
        new Player { FirstName = "Pascal", LastName = "Struijk", Position = "CB", Number = 5, Age = 26, Nationality = "Netherlands", MarketValue = 22m, TeamId = leeds.Id },
        new Player { FirstName = "Jaka", LastName = "Bijol", Position = "CB", Number = 15, Age = 27, Nationality = "Slovenia", MarketValue = 18m, TeamId = leeds.Id },
        new Player { FirstName = "Joe", LastName = "Rodon", Position = "CB", Number = 6, Age = 28, Nationality = "Wales", MarketValue = 15m, TeamId = leeds.Id },
        new Player { FirstName = "Sebastiaan", LastName = "Bornauw", Position = "CB", Number = 23, Age = 26, Nationality = "Belgium", MarketValue = 8m, TeamId = leeds.Id },
        new Player { FirstName = "Gabriel", LastName = "Gudmundsson", Position = "LB", Number = 3, Age = 26, Nationality = "Sweden", MarketValue = 20m, TeamId = leeds.Id },
        new Player { FirstName = "Sam", LastName = "Byram", Position = "LB", Number = 25, Age = 32, Nationality = "England", MarketValue = 0.6m, TeamId = leeds.Id },
        new Player { FirstName = "Jayden", LastName = "Bogle", Position = "RB", Number = 2, Age = 25, Nationality = "England", MarketValue = 12m, TeamId = leeds.Id },
        new Player { FirstName = "James", LastName = "Justin", Position = "RB", Number = 24, Age = 28, Nationality = "England", MarketValue = 12m, TeamId = leeds.Id },
        new Player { FirstName = "Ethan", LastName = "Ampadu", Position = "CDM", Number = 4, Age = 25, Nationality = "Wales", MarketValue = 25m, TeamId = leeds.Id },
        new Player { FirstName = "Anton", LastName = "Stach", Position = "CDM", Number = 18, Age = 27, Nationality = "Germany", MarketValue = 25m, TeamId = leeds.Id },
        new Player { FirstName = "Ilia", LastName = "Gruev", Position = "CDM", Number = 44, Age = 25, Nationality = "Bulgaria", MarketValue = 12m, TeamId = leeds.Id },
        new Player { FirstName = "Charlie", LastName = "Crew", Position = "CDM", Number = 50, Age = 19, Nationality = "Wales", MarketValue = 0.15m, TeamId = leeds.Id },
        new Player { FirstName = "Sean", LastName = "Longstaff", Position = "CM", Number = 8, Age = 28, Nationality = "England", MarketValue = 16m, TeamId = leeds.Id },
        new Player { FirstName = "Ao", LastName = "Tanaka", Position = "CM", Number = 22, Age = 27, Nationality = "Japan", MarketValue = 10m, TeamId = leeds.Id },
        new Player { FirstName = "Brenden", LastName = "Aaronson", Position = "CAM", Number = 11, Age = 25, Nationality = "USA", MarketValue = 18m, TeamId = leeds.Id },
        new Player { FirstName = "Facundo", LastName = "Buonanotte", Position = "CAM", Number = 40, Age = 21, Nationality = "Argentina", MarketValue = 16m, TeamId = leeds.Id },
        new Player { FirstName = "Noah", LastName = "Okafor", Position = "LW", Number = 19, Age = 25, Nationality = "Switzerland", MarketValue = 18m, TeamId = leeds.Id },
        new Player { FirstName = "Wilfried", LastName = "Gnonto", Position = "RW", Number = 29, Age = 22, Nationality = "Italy", MarketValue = 18m, TeamId = leeds.Id },
        new Player { FirstName = "Daniel", LastName = "James", Position = "RW", Number = 7, Age = 28, Nationality = "Wales", MarketValue = 12m, TeamId = leeds.Id },
        new Player { FirstName = "Dominic", LastName = "Calvert-Lewin", Position = "ST", Number = 9, Age = 28, Nationality = "England", MarketValue = 22m, TeamId = leeds.Id },
        new Player { FirstName = "Joel", LastName = "Piroe", Position = "ST", Number = 10, Age = 26, Nationality = "Netherlands", MarketValue = 13m, TeamId = leeds.Id },
        new Player { FirstName = "Lukas", LastName = "Nmecha", Position = "ST", Number = 14, Age = 27, Nationality = "Germany", MarketValue = 10m, TeamId = leeds.Id }
    });
        }

        if (westHam != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Mads", LastName = "Hermansen", Position = "GK", Number = 1, Age = 25, Nationality = "Denmark", MarketValue = 15m, TeamId = westHam.Id },
        new Player { FirstName = "Alphonse", LastName = "Areola", Position = "GK", Number = 23, Age = 33, Nationality = "France", MarketValue = 5m, TeamId = westHam.Id },
        new Player { FirstName = "Lukasz", LastName = "Fabianski", Position = "GK", Number = 22, Age = 40, Nationality = "Poland", MarketValue = 0.25m, TeamId = westHam.Id },
        new Player { FirstName = "Jean-Clair", LastName = "Todibo", Position = "CB", Number = 25, Age = 26, Nationality = "France", MarketValue = 23m, TeamId = westHam.Id },
        new Player { FirstName = "Maximilian", LastName = "Kilman", Position = "CB", Number = 3, Age = 28, Nationality = "England", MarketValue = 16m, TeamId = westHam.Id },
        new Player { FirstName = "Axel", LastName = "Disasi", Position = "CB", Number = 4, Age = 27, Nationality = "France", MarketValue = 15m, TeamId = westHam.Id },
        new Player { FirstName = "Konstantinos", LastName = "Mavropanos", Position = "CB", Number = 15, Age = 28, Nationality = "Greece", MarketValue = 15m, TeamId = westHam.Id },
        new Player { FirstName = "Ezra", LastName = "Mayers", Position = "CB", Number = 63, Age = 19, Nationality = "England", MarketValue = 1.2m, TeamId = westHam.Id },
        new Player { FirstName = "El Hadji Malick", LastName = "Diouf", Position = "LB", Number = 12, Age = 21, Nationality = "Senegal", MarketValue = 28m, TeamId = westHam.Id },
        new Player { FirstName = "Oliver", LastName = "Scarles", Position = "LB", Number = 30, Age = 20, Nationality = "England", MarketValue = 10m, TeamId = westHam.Id },
        new Player { FirstName = "Aaron", LastName = "Wan-Bissaka", Position = "RB", Number = 29, Age = 28, Nationality = "DR Congo", MarketValue = 22m, TeamId = westHam.Id },
        new Player { FirstName = "Kyle", LastName = "Walker-Peters", Position = "RB", Number = 2, Age = 28, Nationality = "England", MarketValue = 13m, TeamId = westHam.Id },
        new Player { FirstName = "Soungoutou", LastName = "Magassa", Position = "CDM", Number = 27, Age = 22, Nationality = "France", MarketValue = 17m, TeamId = westHam.Id },
        new Player { FirstName = "Tomas", LastName = "Soucek", Position = "CDM", Number = 28, Age = 31, Nationality = "Czech Republic", MarketValue = 12m, TeamId = westHam.Id },
        new Player { FirstName = "Freddie", LastName = "Potts", Position = "CDM", Number = 32, Age = 22, Nationality = "England", MarketValue = 10m, TeamId = westHam.Id },
        new Player { FirstName = "Mateus", LastName = "Fernandes", Position = "CM", Number = 18, Age = 21, Nationality = "Portugal", MarketValue = 35m, TeamId = westHam.Id },
        new Player { FirstName = "Crysencio", LastName = "Summerville", Position = "LW", Number = 7, Age = 24, Nationality = "Netherlands", MarketValue = 30m, TeamId = westHam.Id },
        new Player { FirstName = "Keiber", LastName = "Lamadrid", Position = "LW", Number = 21, Age = 22, Nationality = "Colombia", MarketValue = 1.2m, TeamId = westHam.Id },
        new Player { FirstName = "Jarrod", LastName = "Bowen", Position = "RW", Number = 20, Age = 29, Nationality = "England", MarketValue = 35m, TeamId = westHam.Id },
        new Player { FirstName = "Adama", LastName = "Traore", Position = "RW", Number = 17, Age = 30, Nationality = "Spain", MarketValue = 8m, TeamId = westHam.Id },
        new Player { FirstName = "Taty", LastName = "Castellanos", Position = "ST", Number = 11, Age = 27, Nationality = "Argentina", MarketValue = 28m, TeamId = westHam.Id },
        new Player { FirstName = "Joao", LastName = "", Position = "ST", Number = 19, Age = 22, Nationality = "Brazil", MarketValue = 18m, TeamId = westHam.Id },
        new Player { FirstName = "Callum", LastName = "Wilson", Position = "ST", Number = 9, Age = 34, Nationality = "England", MarketValue = 5m, TeamId = westHam.Id }
    });
        }

        if (crystalPalace != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Dean", LastName = "Henderson", Position = "GK", Number = 1, Age = 28, Nationality = "England", MarketValue = 28m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Walter", LastName = "Benitez", Position = "GK", Number = 44, Age = 33, Nationality = "Argentina", MarketValue = 5m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Remi", LastName = "Matthews", Position = "GK", Number = 31, Age = 32, Nationality = "England", MarketValue = 0.3m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Maxence", LastName = "Lacroix", Position = "CB", Number = 5, Age = 25, Nationality = "France", MarketValue = 40m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Chris", LastName = "Richards", Position = "CB", Number = 26, Age = 25, Nationality = "USA", MarketValue = 25m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Jaydee", LastName = "Canvot", Position = "CB", Number = 23, Age = 19, Nationality = "France", MarketValue = 20m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Chadi", LastName = "Riad", Position = "CB", Number = 34, Age = 22, Nationality = "Morocco", MarketValue = 12m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Tyrick", LastName = "Mitchell", Position = "LB", Number = 3, Age = 26, Nationality = "England", MarketValue = 25m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Borna", LastName = "Sosa", Position = "LB", Number = 24, Age = 28, Nationality = "Croatia", MarketValue = 4m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Rio", LastName = "Cardines", Position = "LB", Number = 59, Age = 19, Nationality = "England", MarketValue = 0.3m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Daniel", LastName = "Muñoz", Position = "RB", Number = 2, Age = 29, Nationality = "Colombia", MarketValue = 27m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Caleb", LastName = "Kporha", Position = "RB", Number = 58, Age = 19, Nationality = "England", MarketValue = 1m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Nathaniel", LastName = "Clyne", Position = "RB", Number = 17, Age = 34, Nationality = "England", MarketValue = 0.5m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Adam", LastName = "Wharton", Position = "CDM", Number = 20, Age = 22, Nationality = "England", MarketValue = 60m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Cheick", LastName = "Doucoure", Position = "CDM", Number = 28, Age = 26, Nationality = "Mali", MarketValue = 13m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Jefferson", LastName = "Lerma", Position = "CDM", Number = 8, Age = 31, Nationality = "Colombia", MarketValue = 8m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Kaden", LastName = "Rodney", Position = "CDM", Number = 42, Age = 21, Nationality = "England", MarketValue = 0.2m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Will", LastName = "Hughes", Position = "CM", Number = 19, Age = 30, Nationality = "England", MarketValue = 6m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Daichi", LastName = "Kamada", Position = "CAM", Number = 18, Age = 29, Nationality = "Japan", MarketValue = 12m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Justin", LastName = "Devenny", Position = "CAM", Number = 55, Age = 22, Nationality = "Northern Ireland", MarketValue = 12m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Ismaila", LastName = "Sarr", Position = "RW", Number = 7, Age = 28, Nationality = "Senegal", MarketValue = 35m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Jeremy", LastName = "Pino", Position = "RW", Number = 10, Age = 23, Nationality = "Spain", MarketValue = 35m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Brennan", LastName = "Johnson", Position = "RW", Number = 11, Age = 24, Nationality = "Wales", MarketValue = 35m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Evann", LastName = "Guessand", Position = "RW", Number = 29, Age = 24, Nationality = "Ivory Coast", MarketValue = 28m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Jorgen", LastName = "Strand Larsen", Position = "ST", Number = 22, Age = 26, Nationality = "Norway", MarketValue = 45m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Jean-Philippe", LastName = "Mateta", Position = "ST", Number = 14, Age = 28, Nationality = "France", MarketValue = 35m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Christantus", LastName = "Uche", Position = "ST", Number = 12, Age = 22, Nationality = "Nigeria", MarketValue = 15m, TeamId = crystalPalace.Id },
        new Player { FirstName = "Eddie", LastName = "Nketiah", Position = "ST", Number = 9, Age = 26, Nationality = "England", MarketValue = 14m, TeamId = crystalPalace.Id }
    });
        }

        if (bournemouth != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Djordje", LastName = "Petrovic", Position = "GK", Number = 1, Age = 26, Nationality = "Serbia", MarketValue = 28m, TeamId = bournemouth.Id },
        new Player { FirstName = "Christos", LastName = "Mandas", Position = "GK", Number = 29, Age = 24, Nationality = "Greece", MarketValue = 10m, TeamId = bournemouth.Id },
        new Player { FirstName = "Fraser", LastName = "Forster", Position = "GK", Number = 17, Age = 37, Nationality = "England", MarketValue = 0.6m, TeamId = bournemouth.Id },
        new Player { FirstName = "Bafode", LastName = "Diakite", Position = "CB", Number = 18, Age = 25, Nationality = "France", MarketValue = 30m, TeamId = bournemouth.Id },
        new Player { FirstName = "Marcos", LastName = "Senesi", Position = "CB", Number = 5, Age = 28, Nationality = "Argentina", MarketValue = 22m, TeamId = bournemouth.Id },
        new Player { FirstName = "Veljko", LastName = "Milosavljevic", Position = "CB", Number = 44, Age = 18, Nationality = "Serbia", MarketValue = 20m, TeamId = bournemouth.Id },
        new Player { FirstName = "James", LastName = "Hill", Position = "CB", Number = 23, Age = 24, Nationality = "England", MarketValue = 15m, TeamId = bournemouth.Id },
        new Player { FirstName = "Matai", LastName = "Akinmboni", Position = "CB", Number = 45, Age = 19, Nationality = "USA", MarketValue = 1m, TeamId = bournemouth.Id },
        new Player { FirstName = "Adrien", LastName = "Truffert", Position = "LB", Number = 3, Age = 24, Nationality = "France", MarketValue = 25m, TeamId = bournemouth.Id },
        new Player { FirstName = "Julio", LastName = "Soler", Position = "LB", Number = 6, Age = 21, Nationality = "Argentina", MarketValue = 8m, TeamId = bournemouth.Id },
        new Player { FirstName = "Alex", LastName = "Jimenez", Position = "RB", Number = 20, Age = 20, Nationality = "Spain", MarketValue = 22m, TeamId = bournemouth.Id },
        new Player { FirstName = "Adam", LastName = "Smith", Position = "RB", Number = 15, Age = 34, Nationality = "England", MarketValue = 0.5m, TeamId = bournemouth.Id },
        new Player { FirstName = "Tyler", LastName = "Adams", Position = "CDM", Number = 12, Age = 27, Nationality = "USA", MarketValue = 25m, TeamId = bournemouth.Id },
        new Player { FirstName = "Alex", LastName = "Scott", Position = "CM", Number = 8, Age = 22, Nationality = "England", MarketValue = 40m, TeamId = bournemouth.Id },
        new Player { FirstName = "Lewis", LastName = "Cook", Position = "CM", Number = 4, Age = 29, Nationality = "England", MarketValue = 13m, TeamId = bournemouth.Id },
        new Player { FirstName = "Alex", LastName = "Toth", Position = "CM", Number = 27, Age = 20, Nationality = "Hungary", MarketValue = 12m, TeamId = bournemouth.Id },
        new Player { FirstName = "Ryan", LastName = "Christie", Position = "CM", Number = 10, Age = 31, Nationality = "Scotland", MarketValue = 9m, TeamId = bournemouth.Id },
        new Player { FirstName = "Justin", LastName = "Kluivert", Position = "CAM", Number = 19, Age = 26, Nationality = "Netherlands", MarketValue = 30m, TeamId = bournemouth.Id },
        new Player { FirstName = "Marcus", LastName = "Tavernier", Position = "CAM", Number = 16, Age = 26, Nationality = "England", MarketValue = 23m, TeamId = bournemouth.Id },
        new Player { FirstName = "Amine", LastName = "Adli", Position = "LW", Number = 21, Age = 25, Nationality = "Morocco", MarketValue = 20m, TeamId = bournemouth.Id },
        new Player { FirstName = "Ben", LastName = "Gannon-Doak", Position = "RW", Number = 11, Age = 20, Nationality = "Scotland", MarketValue = 16m, TeamId = bournemouth.Id },
        new Player { FirstName = "David", LastName = "Brooks", Position = "RW", Number = 7, Age = 28, Nationality = "Wales", MarketValue = 14m, TeamId = bournemouth.Id },
        new Player { FirstName = "Junior", LastName = "Kroupi", Position = "ST", Number = 22, Age = 19, Nationality = "France", MarketValue = 40m, TeamId = bournemouth.Id },
        new Player { FirstName = "Rayan", LastName = "", Position = "ST", Number = 37, Age = 19, Nationality = "Brazil", MarketValue = 40m, TeamId = bournemouth.Id },
        new Player { FirstName = "Evanilson", LastName = "", Position = "ST", Number = 9, Age = 26, Nationality = "Brazil", MarketValue = 35m, TeamId = bournemouth.Id },
        new Player { FirstName = "Enes", LastName = "Ünal", Position = "ST", Number = 26, Age = 28, Nationality = "Turkey", MarketValue = 8m, TeamId = bournemouth.Id }
    });
        }

        if (burnley != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Max", LastName = "Weiss", Position = "GK", Number = 13, Age = 21, Nationality = "Germany", MarketValue = 4m, TeamId = burnley.Id },
        new Player { FirstName = "Martin", LastName = "Dubravka", Position = "GK", Number = 1, Age = 37, Nationality = "Slovakia", MarketValue = 0.75m, TeamId = burnley.Id },
        new Player { FirstName = "Vaclav", LastName = "Hladky", Position = "GK", Number = 32, Age = 35, Nationality = "Czech Republic", MarketValue = 0.2m, TeamId = burnley.Id },
        new Player { FirstName = "Maxime", LastName = "Esteve", Position = "CB", Number = 5, Age = 23, Nationality = "France", MarketValue = 25m, TeamId = burnley.Id },
        new Player { FirstName = "Bashir", LastName = "Humphreys", Position = "CB", Number = 12, Age = 22, Nationality = "England", MarketValue = 15m, TeamId = burnley.Id },
        new Player { FirstName = "Hjalmar", LastName = "Ekdal", Position = "CB", Number = 18, Age = 27, Nationality = "Sweden", MarketValue = 6m, TeamId = burnley.Id },
        new Player { FirstName = "Axel", LastName = "Tuanzebe", Position = "CB", Number = 6, Age = 28, Nationality = "DR Congo", MarketValue = 5m, TeamId = burnley.Id },
        new Player { FirstName = "Joe", LastName = "Worrall", Position = "CB", Number = 4, Age = 29, Nationality = "England", MarketValue = 3m, TeamId = burnley.Id },
        new Player { FirstName = "Jordan", LastName = "Beyer", Position = "CB", Number = 36, Age = 25, Nationality = "Germany", MarketValue = 2.5m, TeamId = burnley.Id },
        new Player { FirstName = "Quilindschy", LastName = "Hartman", Position = "LB", Number = 3, Age = 24, Nationality = "Netherlands", MarketValue = 18m, TeamId = burnley.Id },
        new Player { FirstName = "Lucas", LastName = "Pires", Position = "LB", Number = 23, Age = 24, Nationality = "Brazil", MarketValue = 5m, TeamId = burnley.Id },
        new Player { FirstName = "Kyle", LastName = "Walker", Position = "RB", Number = 2, Age = 35, Nationality = "England", MarketValue = 2.5m, TeamId = burnley.Id },
        new Player { FirstName = "Connor", LastName = "Roberts", Position = "RB", Number = 14, Age = 30, Nationality = "Wales", MarketValue = 2.5m, TeamId = burnley.Id },
        new Player { FirstName = "Lesley", LastName = "Ugochukwu", Position = "CDM", Number = 8, Age = 21, Nationality = "France", MarketValue = 25m, TeamId = burnley.Id },
        new Player { FirstName = "Florentino", LastName = "", Position = "CDM", Number = 16, Age = 26, Nationality = "Portugal", MarketValue = 20m, TeamId = burnley.Id },
        new Player { FirstName = "James", LastName = "Ward-Prowse", Position = "CM", Number = 20, Age = 31, Nationality = "England", MarketValue = 6m, TeamId = burnley.Id },
        new Player { FirstName = "Josh", LastName = "Cullen", Position = "CM", Number = 24, Age = 29, Nationality = "Ireland", MarketValue = 6m, TeamId = burnley.Id },
        new Player { FirstName = "Josh", LastName = "Laurent", Position = "CM", Number = 29, Age = 30, Nationality = "England", MarketValue = 2m, TeamId = burnley.Id },
        new Player { FirstName = "Hannibal", LastName = "", Position = "CAM", Number = 28, Age = 23, Nationality = "Tunisia", MarketValue = 16m, TeamId = burnley.Id },
        new Player { FirstName = "Mike", LastName = "Tresor", Position = "CAM", Number = 31, Age = 26, Nationality = "Belgium", MarketValue = 3m, TeamId = burnley.Id },
        new Player { FirstName = "Jaidon", LastName = "Anthony", Position = "LW", Number = 11, Age = 26, Nationality = "England", MarketValue = 18m, TeamId = burnley.Id },
        new Player { FirstName = "Jacob", LastName = "Bruun Larsen", Position = "LW", Number = 7, Age = 27, Nationality = "Denmark", MarketValue = 5m, TeamId = burnley.Id },
        new Player { FirstName = "Loum", LastName = "Tchaouna", Position = "RW", Number = 17, Age = 22, Nationality = "France", MarketValue = 15m, TeamId = burnley.Id },
        new Player { FirstName = "Marcus", LastName = "Edwards", Position = "RW", Number = 10, Age = 27, Nationality = "England", MarketValue = 8m, TeamId = burnley.Id },
        new Player { FirstName = "Zian", LastName = "Flemming", Position = "ST", Number = 19, Age = 27, Nationality = "Netherlands", MarketValue = 12m, TeamId = burnley.Id },
        new Player { FirstName = "Lyle", LastName = "Foster", Position = "ST", Number = 9, Age = 25, Nationality = "South Africa", MarketValue = 10m, TeamId = burnley.Id },
        new Player { FirstName = "Zeki", LastName = "Amdouni", Position = "ST", Number = 25, Age = 25, Nationality = "Switzerland", MarketValue = 9m, TeamId = burnley.Id },
        new Player { FirstName = "Armando", LastName = "Broja", Position = "ST", Number = 27, Age = 24, Nationality = "Albania", MarketValue = 8m, TeamId = burnley.Id },
        new Player { FirstName = "Ashley", LastName = "Barnes", Position = "ST", Number = 35, Age = 36, Nationality = "England", MarketValue = 0.2m, TeamId = burnley.Id }
    });
        }

        if (sunderland != null)
        {
            players.AddRange(new List<Player>
    {
        new Player { FirstName = "Robin", LastName = "Roefs", Position = "GK", Number = 22, Age = 23, Nationality = "Netherlands", MarketValue = 25m, TeamId = sunderland.Id },
        new Player { FirstName = "Melker", LastName = "Ellborg", Position = "GK", Number = 31, Age = 22, Nationality = "Sweden", MarketValue = 3m, TeamId = sunderland.Id },
        new Player { FirstName = "Simon", LastName = "Moore", Position = "GK", Number = 21, Age = 35, Nationality = "England", MarketValue = 0.1m, TeamId = sunderland.Id },

        new Player { FirstName = "Dan", LastName = "Ballard", Position = "CB", Number = 5, Age = 26, Nationality = "Northern Ireland", MarketValue = 20m, TeamId = sunderland.Id },
        new Player { FirstName = "Omar", LastName = "Alderete", Position = "CB", Number = 15, Age = 29, Nationality = "Paraguay", MarketValue = 15m, TeamId = sunderland.Id },
        new Player { FirstName = "Luke", LastName = "ONien", Position = "CB", Number = 13, Age = 31, Nationality = "England", MarketValue = 1m, TeamId = sunderland.Id },

        new Player { FirstName = "Dennis", LastName = "Cirkin", Position = "LB", Number = 3, Age = 23, Nationality = "Ireland", MarketValue = 8m, TeamId = sunderland.Id },
        new Player { FirstName = "Reinildo", LastName = "Mandava", Position = "LB", Number = 17, Age = 32, Nationality = "Mozambique", MarketValue = 5m, TeamId = sunderland.Id },

        new Player { FirstName = "Trai", LastName = "Hume", Position = "RB", Number = 32, Age = 23, Nationality = "Northern Ireland", MarketValue = 22m, TeamId = sunderland.Id },
        new Player { FirstName = "Lutsharel", LastName = "Geertruida", Position = "RB", Number = 6, Age = 25, Nationality = "Netherlands", MarketValue = 20m, TeamId = sunderland.Id },
        new Player { FirstName = "Nordi", LastName = "Mukiele", Position = "RB", Number = 20, Age = 28, Nationality = "France", MarketValue = 18m, TeamId = sunderland.Id },

        new Player { FirstName = "Granit", LastName = "Xhaka", Position = "CDM", Number = 34, Age = 33, Nationality = "Switzerland", MarketValue = 10m, TeamId = sunderland.Id },

        new Player { FirstName = "Habib", LastName = "Diarra", Position = "CM", Number = 19, Age = 22, Nationality = "Senegal", MarketValue = 32m, TeamId = sunderland.Id },
        new Player { FirstName = "Noah", LastName = "Sadiki", Position = "CM", Number = 27, Age = 21, Nationality = "DR Congo", MarketValue = 30m, TeamId = sunderland.Id },
        new Player { FirstName = "Enzo", LastName = "Le Fee", Position = "CM", Number = 28, Age = 26, Nationality = "France", MarketValue = 25m, TeamId = sunderland.Id },

        new Player { FirstName = "Abdoullah", LastName = "Ba", Position = "RM", Number = 46, Age = 22, Nationality = "France", MarketValue = 2m, TeamId = sunderland.Id },

        new Player { FirstName = "Chris", LastName = "Rigg", Position = "CAM", Number = 11, Age = 18, Nationality = "England", MarketValue = 25m, TeamId = sunderland.Id },
        new Player { FirstName = "Milan", LastName = "Aleksic", Position = "CAM", Number = 30, Age = 20, Nationality = "Serbia", MarketValue = 0.7m, TeamId = sunderland.Id },
        new Player { FirstName = "Harrison", LastName = "Jones", Position = "CAM", Number = 50, Age = 21, Nationality = "England", MarketValue = 0.15m, TeamId = sunderland.Id },

        new Player { FirstName = "Nilson", LastName = "Angulo", Position = "LW", Number = 10, Age = 22, Nationality = "Ecuador", MarketValue = 17m, TeamId = sunderland.Id },
        new Player { FirstName = "Romaine", LastName = "Mundle", Position = "LW", Number = 14, Age = 22, Nationality = "England", MarketValue = 8m, TeamId = sunderland.Id },

        new Player { FirstName = "Chemsdine", LastName = "Talbi", Position = "RW", Number = 7, Age = 20, Nationality = "Morocco", MarketValue = 25m, TeamId = sunderland.Id },
        new Player { FirstName = "Bertrand", LastName = "Traore", Position = "RW", Number = 25, Age = 30, Nationality = "Burkina Faso", MarketValue = 5m, TeamId = sunderland.Id },
        new Player { FirstName = "Jocelin", LastName = "Ta Bi", Position = "RW", Number = 37, Age = 21, Nationality = "Ivory Coast", MarketValue = 3m, TeamId = sunderland.Id },

        new Player { FirstName = "Brian", LastName = "Brobey", Position = "ST", Number = 9, Age = 24, Nationality = "Netherlands", MarketValue = 25m, TeamId = sunderland.Id },
        new Player { FirstName = "Eliezer", LastName = "Mayenda", Position = "ST", Number = 12, Age = 20, Nationality = "Spain", MarketValue = 18m, TeamId = sunderland.Id },
        new Player { FirstName = "Wilson", LastName = "Isidor", Position = "ST", Number = 18, Age = 25, Nationality = "France", MarketValue = 18m, TeamId = sunderland.Id },
        new Player { FirstName = "Ahmed", LastName = "Abdullahi", Position = "ST", Number = 29, Age = 21, Nationality = "Nigeria", MarketValue = 1m, TeamId = sunderland.Id }
    });
        }


        context.Players.AddRange(players);
        await context.SaveChangesAsync();
    }
}