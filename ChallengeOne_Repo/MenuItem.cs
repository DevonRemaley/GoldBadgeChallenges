using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Repo
{
    public class MenuItem
    {
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public decimal MealPrice { get; set; }

        public MenuItem() {}

        public MenuItem(
        string name,
        int number,
        string description,
        string ingredients,
        decimal price)
        {
        MealName = name;
        MealNumber = number;
        MealDescription = description;
        MealIngredients = ingredients;
        MealPrice = price;
        }
    }
}


