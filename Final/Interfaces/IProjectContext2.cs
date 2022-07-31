using System.Collections.Generic;
namespace Final.interfaces
{
    public interface IProjectContext2
    {
        List<TeamName> GetAllNames();
        TeamName GetNameById(int id);
        //TeamName RemoveNameById(int id);
        int? RemoveNameById(int id);
        int? updateName(TeamName name);
        int? Add(TeamName name);
        List<TeamHobby> GetAllHobbies();        
        TeamHobby GetHobbyById(int id);        
        int? RemoveHobbyById(int id);
        int? updateHobby(TeamHobby hobby);
        int? Add(TeamHobby hobby);
        List<TeamClass> GetAllClasses();        
        TeamClass GetClassById(int id);        
        int? RemoveClassById(int id);
        int? updateClass(TeamClass class1);
        int? Add(TeamClass class1);
        List<TeamGame> GetAllGames();        
        TeamGame GetGameById(int id);        
        int? RemoveGameById(int id);
        int? updateGame(TeamGame game);
        int? Add(TeamGame game);
    }
    
}