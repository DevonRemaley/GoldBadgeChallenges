using ChallengeThree_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Console
{
    class ProgramUI
    {
        public void Run()
        {
            StockBadgeList();
            Menu();
        }

        public void Menu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Hello Security Admin\n" +
                    "What would you like to do?\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all badges\n" +
                    "4. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        DisplayBadges();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
            }
        }

        public void AddBadge()
        {

        }

        public void EditBadge()
        {

        }

        public void DisplayBadges()
        {

        }

        public void StockBadgeList()
        {
            Badges badgeOne = new Badges(12345, new List<string> { "A5", "A7" });
            Badges badgeTwo = new Badges(22345, new List<string> { "A1", "A4", "B1", "B2" });
            Badges badgeThree = new Badges(32345, new List<string> { "A4", "A5" });

            .Add(badgeOne);
            .Add(badgeTwo);
            .Add(badgeThree);
        }
    }
}