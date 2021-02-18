using ChallengeOne_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_ProgramUI
{
    class ProgramUI
    {
        private MenuItemRepository _itemRepo = new MenuItemRepository();
        public void Run()
        {
            StockItemList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Please choose an option:\n" +
                    "1) View All Items\n" +
                    "2) Create New Item\n" +
                    "3) Delete Existing Item\n" +
                    "4) Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayAllItems();
                        break;
                    case "2":
                        CreateNewItem();
                        break;
                    case "3":
                        DeleteExistingItem();
                        break;
                    case "4":
                        Console.WriteLine("Have a nice day!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateNewItem()
        {
            Console.Clear();
            MenuItem newItem = new MenuItem();

            Console.WriteLine("Please enter the name for the item:");
            newItem.MealName = Console.ReadLine();

            Console.WriteLine("Please enter the number for the item:");
            string mealNumberAsString = Console.ReadLine();
            newItem.MealNumber = int.Parse(mealNumberAsString);
            
            Console.WriteLine("Please enter the description for the item:");
            newItem.MealDescription = Console.ReadLine();
            
            Console.WriteLine("Please enter the ingredients for the item:");
            newItem.MealIngredients = Console.ReadLine();
            
            Console.WriteLine("Please enter the price for the item:");
            string mealPriceAsString = Console.ReadLine();
            newItem.MealPrice = Decimal.Parse(mealPriceAsString);

            _itemRepo.AddItemToList(newItem);
        }

        private void DisplayAllItems()
        {
            Console.Clear();
            List<MenuItem> listOfItems = _itemRepo.GetItemList();

            foreach (MenuItem item in listOfItems)
            {
                Console.WriteLine($"Name: " + item.MealName);
            }
            Console.ReadKey();
        }

        public void DeleteExistingItem()
        {
            Console.WriteLine("\nPlease enter the name of the item you'd like to remove: ");
            string input = Console.ReadLine();
            bool wasDeleted = _itemRepo.RemoveItemFromList(input);
            if (wasDeleted)
            {
                Console.WriteLine("The item was successfully deleted.");
            }
            else
                Console.WriteLine("The item could not be deleted.");
        }

        private void StockItemList()
        {
            MenuItem hotCoffee = new MenuItem("Hot Coffee", 1, "Your favorite cup of Joe", "Water, ground coffee", 2);
            MenuItem icedCoffee = new MenuItem("Iced Coffee", 2, "Your favorite cup of Joe over ice", "Water, ground coffee", 2);
            MenuItem bagel = new MenuItem("Bagel", 3, "Bagel with cream cheese(optional)", "Flour, water, yeast(optional: Milk, salt)", 3);

            _itemRepo.AddItemToList(hotCoffee);
            _itemRepo.AddItemToList(icedCoffee);
            _itemRepo.AddItemToList(bagel);
        }
    }
}
