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
        public List<TeamHobby> GetAllHobbies()
        {
            //throw new System.NotImplementedException();
            return _context.Hobbies.ToList();
        }
        public List<TeamClass> GetAllClasses()
        {
            return _context.Classes.ToList();
        }

        public List<TeamGame> GetAllGames()
        {
            return _context.Games.ToList();
        }

        public TeamName GetNameById(int id)
        {
            return _context.Names.Where(x => x.TeamNameId.Equals(id)).FirstOrDefault();
        }

        public TeamClass GetClassById(int id)
        {
            return _context.Classes.Where(x => x.TeamNameId.Equals(id)).FirstOrDefault();
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

        public int? RemoveClassById(int id)
        {
            var class = this.GetClassById(id);
            if (class == null) return null;
            try
            {
                _context.Classes.Remove(class);
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

        public int? updateClass(TeamClass class)
        {
            var classToUpdate = this.GetClassById(class.TeamClassId);
            if (classToUpdate == null)
                return null;

            //nameToUpdate = name;
            classToUpdate.ClassName = class.ClassName
            classToUpdate.Grade = class.Grade
            classToUpdate.YearStarted = class.YearStarted
    

            try
            {
                _context.Classes.Update(classToUpdate);
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
        
        public int? Add(ClassName class)
        {
            var classes = _context.Classes.Where(x => x.ClassName.Equals(class.ClassName) && x.Grade.Equals(class.Grade) && x.YearStarted.Equals(class.YearStarted)).FirstOrDefault();
            if (classes != null)
                return null;
            try
            {
                _context.Classes.Add(class)
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