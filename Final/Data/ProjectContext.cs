using System;
using Microsoft.EntityFrameworkCore;

namespace Final
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamName>().HasData(
                new TeamName {TeamNameId = 1, FullName = "Guy-David Ngondo", Birthate ="04/04/1995" ,CollegeProgram = "Networking System",YearInProgram = "Senior" },
                new TeamName {TeamNameId = 2, FullName = "Mitchell Hansbauer", Birthate ="02/20/2000" ,CollegeProgram = "Software Dev",YearInProgram = "Sophomore"},
                new TeamName {TeamNameId = 3, FullName = "Robert Champion", Birthate ="04/04/1990" ,CollegeProgram = "Software Dev",YearInProgram = "Senior" });
                
            builder.Entity<TeamHobby>().HasData(
                new TeamHobby {TeamHobbyId = 1,TeamNameId=1, HobbyName = "Martial Art", YearStarted ="04/04/1999" ,Frequency = "4/Month",Location = "Fairfield" },
                new TeamHobby {TeamHobbyId = 2,TeamNameId=2, HobbyName = "Guitar", YearStarted ="10/30/2009" ,Frequency = "8/Month",Location = "Home" },
                new TeamHobby {TeamHobbyId = 3,TeamNameId=3, HobbyName = "Hiking", YearStarted ="10/30/2009" ,Frequency = "8/Month",Location = "Park" });

            builder.Entity<TeamClass>().HasData(
                new TeamClass {TeamClassId = 1,TeamNameId=1, ClassName = "Contemperary Programming", Grade = 100 ,YearStarted = "5/8/2022"},
                new TeamClass {TeamClassId = 2,TeamNameId=2, ClassName = "Contemperary Programming", Grade = 100 ,YearStarted = "5/8/2022"},
                new TeamClass {TeamClassId = 3,TeamNameId=3, ClassName = "Contemperary Programming", Grade = 100 ,YearStarted = "5/8/2022"});

            builder.Entity<TeamGame>().HasData(
                new TeamGame {TeamGameId = 1,TeamNameId=1, GameName = "Call of Duty Black Ops 2", YearStarted = "5/8/2022", Frequency = "4/month"},
                new TeamGame {TeamGameId = 2,TeamNameId=2, GameName = "Minecraft", YearStarted = "5/8/2022", Frequency = "12/month"},
                new TeamGame {TeamGameId = 3,TeamNameId=3, GameName = "Far Cry 3", YearStarted = "5/8/2022", Frequency = "8/month"});
        }

        internal object GetNames(int id)
        {
            throw new NotImplementedException();
        }
        public DbSet<TeamName> Names {get; set;} 

        internal object GetHobbies(int id)
        {
            throw new NotImplementedException();
        }
        public DbSet<TeamHobby> Hobbies {get; set;} 

        internal object GetClasses(int id)
        {
            throw new NotImplementedException();
        }
        public DbSet<TeamClass> Classes {get; set;}

        internal object GetGames(int id)
        {
            throw new NotImplementedException();
        }
        public DbSet<TeamGame> Games {get; set;}
    }
}