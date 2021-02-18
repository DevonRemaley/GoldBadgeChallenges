using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Repo
{
    public class BadgeRepository
    {
        private Dictionary<int, List<string>> myDictionary = new Dictionary<int, List<string>>();

        public void AddBadge()
        {
            Badges idNumber = new Badges();

            Console.Clear();
            Console.WriteLine("Please enter a new badge number:");
            idNumber.BadgeID = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter a door that Badge #{idNumber.BadgeID} needs access to:"); 
            
        }

        public void EditBadge()
        {

        }

        public void DisplayAllBadges()
        {

        }
    }
}
