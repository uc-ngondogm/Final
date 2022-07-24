using System.Collections.Generic;
namespace Final.interfaces
{
    public interface IProjectContext2
    {
        List<TeamName> GetAllNames();
        List<TeamHobby> GetAllHobbies();
        TeamName GetNameById(int id);
        //TeamName RemoveNameById(int id);
        int? RemoveNameById(int id);
        int? updateName(TeamName name);
        int? Add(TeamName name);
    }
    
}