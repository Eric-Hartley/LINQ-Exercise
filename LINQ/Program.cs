using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mlsTeams = new List<string>() { "Atlanta United FC", "Inter Miami FC", "Nashville SC", "Orlando City FC" };

            var result = mlsTeams.OrderBy(x => x.Length);
            foreach(var team in result)
            {
                Console.WriteLine(team);
            }
            
            

        }

        


    }
    
}
