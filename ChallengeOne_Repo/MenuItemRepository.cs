using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Repo
{
    public class MenuItemRepository
    {
        private List<MenuItem> _listOfItems = new List<MenuItem>();

        public bool AddItemToList(MenuItem item)
        {
            int startingCount = _listOfItems.Count;
            _listOfItems.Add(item);

            bool wasAdded = _listOfItems.Count > startingCount;
            return wasAdded;
        }

        public List<MenuItem> GetItemList()
        {
            return _listOfItems;
        }

        public bool RemoveItemFromList(string name)
        {
            MenuItem item = GetMenuItemByName(name);
            if (item == null)
            {
                return false;
            }

            int initialCount = _listOfItems.Count;
            return _listOfItems.Remove(item);
        }

        public MenuItem GetMenuItemByName(string name)
        {
            foreach (MenuItem item in _listOfItems)
            {
                if (item.MealName == name)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
