using System.Collections.Generic;

using netcore.Models;
namespace netcore.Untity
{
    public class Item
    {
        public static List<Techer> GetAllTeacher()
        {
            return new List<Techer>
            {
                new Techer { Name="Mike", Skill="Turner"},
                new Techer { Name="Sonja", Skill="Markus"},
                new Techer { Name="Luck", Skill="Martins"},
                new Techer { Name="Sofia", Skill="Packner"},
                new Techer { Name="John", Skill="Doe"}
            };
        }
    }
}
