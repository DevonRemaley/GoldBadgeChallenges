using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Repo
{
    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft
    }


    /*
       public bool IsValid(Claim claim)
       {
           TimeSpan difference = claim.DateOfClaim - claim.DateOfIncident;

           if (claim.DateOfClaim <= claim.DateOfIncident)

               if (difference.Days <= 30)
               {
                   claim.IsValid = true;
               }
               else
                   claim.IsValid = false;

       }
       */

    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {

        }

        public Claim() { }

        public Claim(int claimID,
            ClaimType claimType,
            string description,
            decimal claimAmount,
            DateTime dateOfIncident,
            DateTime dateOfClaim,
            bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
