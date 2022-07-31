using System.Linq;
using System.Collections.Generic;
using Final.interfaces;
using System;

namespace Final.Data
{
    public class ProjectContext2 : IProjectContext2
    {
        private ProjectContext _context;
       public ProjectContext2(ProjectContext context)
       {
        _context = context;

       }

        public List<TeamName> GetAllNames()
        {
            //throw new System.NotImplementedException();
            return _context.Names.ToList();          
        }      
        
        public TeamName GetNameById(int id)
        {
            return _context.Names.Where(x => x.TeamNameId.Equals(id)).FirstOrDefault();
        }
        //public TeamName RemoveNameById(int id)
        public int? RemoveNameById(int id)
        {
            var name = this.GetNameById(id);
            if (name == null) return null;
            try
            {
                _context.Names.Remove(name);
                _context.SaveChanges();
                //return name;
                return 1;
            }
            catch (Exception)
            {
                //return new TeamName();
                return 0;
            }                     
        }
        public int? updateName(TeamName name)
        {
            var nameToUpdate = this.GetNameById(name.TeamNameId);
            if (nameToUpdate == null)
                return null;

            //nameToUpdate = name;
            nameToUpdate.FullName = name.FullName;
            nameToUpdate.Birthate = name.Birthate;
            nameToUpdate.CollegeProgram = name.CollegeProgram;
            nameToUpdate.YearInProgram = name.YearInProgram;

            try
            {
                _context.Names.Update(nameToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? Add(TeamName name)
        {
            var names = _context.Names.Where(x => x.FullName.Equals(name.FullName) && x.YearInProgram.Equals(name.YearInProgram)).FirstOrDefault();
            //var names = _context.Names.Where(x => x.FullName.Equals(name.FullName)).FirstOrDefault();
            if (names != null)
                return null;
            try
            {
                _context.Names.Add(name);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }        
        } 

        public List<TeamHobby> GetAllHobbies()
        {
            //throw new System.NotImplementedException();
            return _context.Hobbies.ToList();
        }
        public TeamHobby GetHobbyById(int id)
        {
            return _context.Hobbies.Where(x => x.TeamHobbyId.Equals(id)).FirstOrDefault();
        }

        //public TeamName RemoveHobbyById(int id)
        public int? RemoveHobbyById(int id)
        {
            var hobby = this.GetHobbyById(id);
            if (hobby == null) return null;
            try
            {
                _context.Hobbies.Remove(hobby);
                _context.SaveChanges();
                //return name;
                return 1;
            }
            catch (Exception)
            {
                //return new TeamHobby();
                return 0;
            }
                     
        }
        public int? updateHobby(TeamHobby hobby)
        {
            var hobbyToUpdate = this.GetHobbyById(hobby.TeamHobbyId);
            if (hobbyToUpdate == null)
                return null;

            //hobbyToUpdate = name;            
            hobbyToUpdate.HobbyName = hobby.HobbyName;
            hobbyToUpdate.YearStarted = hobby.YearStarted;
            hobbyToUpdate.Frequency = hobby.Frequency;
            hobbyToUpdate.Location = hobby.Location;

            try
            {
                _context.Hobbies.Update(hobbyToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int? Add(TeamHobby hobby)
        {
            var hobbies = _context.Hobbies.Where(x => x.HobbyName.Equals(hobby.HobbyName) && x.YearStarted.Equals(hobby.YearStarted)).FirstOrDefault();
            //var names = _context.Names.Where(x => x.FullName.Equals(name.FullName)).FirstOrDefault();
            if (hobbies != null)
                return null;
            try
            {
                _context.Hobbies.Add(hobby);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }            
        }
        public List<TeamClass> GetAllClasses()
        {
            //throw new System.NotImplementedException();
            return _context.Classes.ToList();
        }
        public TeamClass GetClassById(int id)
        {
            return _context.Classes.Where(x => x.TeamClassId.Equals(id)).FirstOrDefault();
        }

        //public TeamName RemoveClassById(int id)
        public int? RemoveClassById(int id)
        {
            var class1 = this.GetClassById(id);
            if (class1 == null) return null;
            try
            {
                _context.Classes.Remove(class1);
                _context.SaveChanges();
                //return Class;
                return 1;
            }
            catch (Exception)
            {
                //return new TeamClass();
                return 0;

            }
                     
        }
        public int? updateClass(TeamClass class1)
        {
            var class1ToUpdate = this.GetClassById(class1.TeamClassId);
            if (class1ToUpdate == null)
                return null;

            //hobbyToUpdate = name;            
            class1ToUpdate.ClassName = class1.ClassName;
            class1ToUpdate.Grade = class1.Grade;
            class1ToUpdate.YearStarted = class1.YearStarted;
            //class1ToUpdate.Location = class1.Location;

            try
            {
                _context.Classes.Update(class1ToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? Add(TeamClass class1)
        {
            var classes = _context.Classes.Where(x => x.ClassName.Equals(class1.ClassName) && x.YearStarted.Equals(class1.YearStarted)).FirstOrDefault();
            //var names = _context.Names.Where(x => x.FullName.Equals(name.FullName)).FirstOrDefault();
            if (classes != null)
                return null;
            try
            {
                _context.Classes.Add(class1);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        public List<TeamGame> GetAllGames()
        {
            //throw new System.NotImplementedException();
            return _context.Games.ToList();
        }
        public TeamGame GetGameById(int id)
        {
            return _context.Games.Where(x => x.TeamGameId.Equals(id)).FirstOrDefault();
        }        
        public int? RemoveGameById(int id)
        {
            var game = this.GetGameById(id);
            if (game == null) return null;
            try
            {
                _context.Games.Remove(game);
                _context.SaveChanges();
                //return Game;
                return 1;
            }
            catch (Exception)
            {
                //return new TeamGame();
                return 0;
            }
                     
        }
        public int? updateGame(TeamGame game)
        {
            var gameToUpdate = this.GetGameById(game.TeamGameId);
            if (gameToUpdate == null)
                return null;
                        
            gameToUpdate.GameName = game.GameName;
            gameToUpdate.YearStarted = game.YearStarted;
            gameToUpdate.Frequency = game.Frequency;           

            try
            {
                _context.Games.Update(gameToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? Add(TeamGame game)
        {
            var games = _context.Games.Where(x => x.GameName.Equals(game.GameName) && x.YearStarted.Equals(game.YearStarted)).FirstOrDefault();
           
            if (games != null)
                return null;
            try
            {
                _context.Games.Add(game);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }            
        }       
    }
}   
  
            
   