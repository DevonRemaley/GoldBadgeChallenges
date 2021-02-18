using ChallengeTwo_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Console
{
    class ProgramUI
    {
        private ClaimRepository _claimRepo = new ClaimRepository();

        private void StockClaimList()
        {
            Claim claimOne = new Claim(
                    1,
                    ClaimType.Car,
                    "Car accident on 465.",
                    400,
                    DateTime.Parse("04/25/2018"),
                    DateTime.Parse("04/27/2018"),
                    true);

            Claim claimTwo = new Claim(
                2,
                ClaimType.Home,
                "House fire in kitchen",
                4000,
                DateTime.Parse("04/11/2018"),
                DateTime.Parse("04/12/2018"),
                true);

            Claim claimThree = new Claim(
                3,
                ClaimType.Theft,
                "Stolen pancakes.",
                4,
                DateTime.Parse("04/27/2018"),
                DateTime.Parse("06/01/2018"),
                false);

            _claimRepo.AddClaimToList(claimOne);
            _claimRepo.AddClaimToList(claimTwo);
            _claimRepo.AddClaimToList(claimThree);
        }

        public void Run()
        {
            StockClaimList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                Console.WriteLine("Please select a menu option:\n" +
                    "1) Create New Claim\n" +
                    "2) View All Claims\n" +
                    "3) View Claims By ID\n" +
                    "4) Update Existing Claim\n" +
                    "5) Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateNewClaim();
                        break;
                    case "2":
                        DisplayAllClaim();
                        break;
                    case "3":
                        DisplayClaimByClaimID();
                        break;
                    case "4":
                        UpdateExistingClaim();
                        break;
                    case "5":
                        Console.WriteLine("Have a nice day!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateNewClaim()
        {
            Claim newClaim = new Claim();

            Console.WriteLine("Please enter the ID for the Claim:");
            newClaim.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the type of Claim:\n" +
                "Car\n" +
                "Home\n" +
                "Theft");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    newClaim.TypeOfClaim = ClaimType.Car;
                    break;
                case "2":
                    newClaim.TypeOfClaim = ClaimType.Home;
                    break;
                case "3":
                    newClaim.TypeOfClaim = ClaimType.Theft;
                    break;
            }

            Console.WriteLine("Please enter a Description for the Claim:");
            newClaim.Description = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter the Amount for the Claim:");
            string claimAmountAsString = Console.ReadLine();
            newClaim.ClaimAmount = int.Parse(claimAmountAsString);

            Console.WriteLine("Please enter Date of Incident in correct format:\n" +
                "mm/dd/yyyy");
            string dateOfIncident = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(dateOfIncident);

            Console.WriteLine("Please enter Date of Claim in correct format:\n" +
                "mm/dd/yyyy");
            string dateOfClaim = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(dateOfClaim);

            Console.WriteLine("Is this Claim Valid? (y/n)");
            string claimIsValid = Console.ReadLine().ToLower();

            if (claimIsValid == "y")
            {
                newClaim.IsValid = true;
            }
            else
                newClaim.IsValid = false;

            _claimRepo.AddClaimToList(newClaim);

        }
        private void DisplayAllClaim()
        {
            Console.Clear();

            List<Claim> listOfClaims = _claimRepo.GetClaimList();

            Console.WriteLine($"|{"Claim ID:",-9}" +
                $"|{"Claim Type",-10}" +
                $"|{"Claim Description",-10}" +
                $"|{"Claim Amount",-12}" +
                $"|{"Date of Incident",-16}" +
                $"|{"Date of Claim",-13}" +
                $"|{"Is Valid",-5}");



            foreach (Claim claim in listOfClaims)
            {
                Console.WriteLine($"|{claim.ClaimID,-9}" +
                    $"|{claim.TypeOfClaim,-10}" +
                    $"|{claim.Description,-17}" +
                    $"|{claim.ClaimAmount,-12}" +
                    $"|{claim.DateOfIncident,-16}" +
                    $"|{claim.DateOfClaim,-13}" +
                    $"|{claim.IsValid,-5}");
            }
            Console.WriteLine("Please press any key to continue...");
        }

        private void DisplayClaimByClaimID()
        {
            Console.Clear();
            Console.WriteLine("Please enter ID of Claim you wish to see:");

            string claimID = Console.ReadLine();
            Claim claim = _claimRepo.GetClaimByID(int.Parse(claimID));

            if (claim != null)
            {
                Console.WriteLine($"Claim ID: {claim.ClaimID}\n" +
                    $"Claim Type: {claim.TypeOfClaim}\n" +
                    $"Claim Description: {claim.Description}\n" +
                    $"Claim Amount: {claim.ClaimAmount}\n" +
                    $"Date of Incident: {claim.DateOfIncident}\n" +
                    $"Date of Claim: {claim.DateOfClaim}\n" +
                    $"Valid? {claim.IsValid}");

                Console.WriteLine("Do you wish to work on this Claim? (Y/N)");
                string wantsToWork = Console.ReadLine().ToUpper();

                if (wantsToWork == "Y")
                {

                }
                else
                    Menu();
            }
            else
                Console.WriteLine("No Claim by that ID");
        }

        private void UpdateExistingClaim()
        {
            DisplayAllClaim();
            Console.WriteLine("Please enter the ID of the Claim you would like to Update:");
            int oldID = int.Parse(Console.ReadLine());

            Claim newClaim = new Claim();

            Console.WriteLine("Please enter the ID for the Claim:");
            string claimIdAsString = Console.ReadLine();
            newClaim.ClaimID = int.Parse(claimIdAsString);

            Console.WriteLine("Please enter the type of Claim:\n" +
                "1) CAR\n" +
                "2) HOME\n" +
                "3) THEFT");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    newClaim.TypeOfClaim = ClaimType.Car;
                    break;
                case "2":
                    newClaim.TypeOfClaim = ClaimType.Home;
                    break;
                case "3":
                    newClaim.TypeOfClaim = ClaimType.Theft;
                    break;
            }

            Console.WriteLine("Please enter a Description for the Claim:");
            newClaim.Description = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter the Amount for the Claim:");
            string claimAmountAsString = Console.ReadLine();
            newClaim.ClaimAmount = int.Parse(claimAmountAsString);

            Console.WriteLine("Please enter Date of Incident in correct format:\n" +
                "mm/dd/yyyy");
            string dateOfIncident = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(dateOfIncident);

            Console.WriteLine("Please enter Date of Claim in correct format:\n" +
                "mm/dd/yyyy");
            string dateOfClaim = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(dateOfClaim);

            Console.WriteLine("Is this Claim Valid? (Y/N)");
            string claimIsValid = Console.ReadLine().ToUpper();

            if (claimIsValid == "Y")
            {
                newClaim.IsValid = true;
            }
            else
                newClaim.IsValid = false;

            bool wasUpdated = _claimRepo.UpdateExistingClaim(oldID, newClaim);
            if (wasUpdated)
            {
                Console.WriteLine("Claim successfully updated!");
            }
            else
                Console.WriteLine("Youd could not update Claim.");
        }
    }
}
