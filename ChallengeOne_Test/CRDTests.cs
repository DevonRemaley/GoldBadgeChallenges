using ChallengeOne_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeOne_Test
{
    [TestClass]
    public class CRDTests
    {
        MenuItemRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuItemRepository();
            MenuItem hotAmericano = new MenuItem(
                "Hot Americano",
                5,
                "Espresso and water",
                "Water, ground coffee",
                3);
            MenuItem icedAmericano = new MenuItem(
                "Iced Americano",
                5,
                "Espresso and water over ice",
                "Water, ground coffee",
                3);

            _repo.AddItemToList(hotAmericano);
            _repo.AddItemToList(icedAmericano);
        }
        [TestMethod]
        public void AddTest()
        {
            MenuItem item = new MenuItem(
                "Donut",
                4,
                "Yum",
                "Flour, sugar, yeast, water",
                1);

            bool wasAdded = _repo.AddItemToList(item);

            Assert.IsTrue(wasAdded);
        }
        [TestMethod]
        public void GetTest()
        {
            List<MenuItem> testItem = _repo.GetItemList().ToList();

            MenuItem item = new MenuItem("Latte",
                5,
                "yum",
                "pdipsdf",
                3
                );

            _repo.AddItemToList(item);

            List<MenuItem> testItem2 = _repo.GetItemList();

            Assert.AreNotEqual(testItem2.Count, testItem.Count);

        }
    }
}
