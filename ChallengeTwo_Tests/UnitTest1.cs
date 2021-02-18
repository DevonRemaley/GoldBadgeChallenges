using ChallengeTwo_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeTwo_Tests
{
    [TestClass]
    public class UnitTest1
    {
        ClaimRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimRepository();
            Claim claim4 = new Claim(
                    4,
                    ClaimType.Car,
                    "Car accident on I65.",
                    700,
                    DateTime.Parse("01/25/2021"),
                    DateTime.Parse("01/27/2021"),
                    true);

            Claim claim5 = new Claim(
                5,
                ClaimType.Home,
                "Flood in basement",
                9000,
                DateTime.Parse("02/11/2021"),
                DateTime.Parse("02/12/2021"),
                true);

            _repo.AddClaimToList(claim4);
            _repo.AddClaimToList(claim5);
        }
        [TestMethod]
        public void AddTest()
        {
            List<Claim> testClaim = _repo.GetClaimList().ToList();

            Claim claim7 = new Claim(
                7,
                ClaimType.Home,
                "Flood in bathroom",
                4000,
                DateTime.Parse("02/11/2021"),
                DateTime.Parse("02/12/2021"),
                true);

            _repo.AddClaimToList(claim7);

            List<Claim> testClaim2 = _repo.GetClaimList();

            Assert.AreNotEqual(testClaim2.Count, testClaim.Count);
        }
        [TestMethod]
        public void GetTest()
        {
            _repo.GetClaimList();
            Assert.IsNotNull(_repo);

        }
    }
}
