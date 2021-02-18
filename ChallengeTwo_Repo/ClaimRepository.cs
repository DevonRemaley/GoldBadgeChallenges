using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Repo
{
    public class ClaimRepository
    {
        private List<Claim> _listOfClaims = new List<Claim>();
       
        public void AddClaimToList(Claim claim)
        {
            _listOfClaims.Add(claim);
        }

        public List<Claim> GetClaimList()
        {
            return _listOfClaims;
        }

        public bool UpdateExistingClaim(int originalClaimID, Claim newClaim)
        {
            Claim oldClaimID = GetClaimByID(originalClaimID);

            if (oldClaimID != null)
            {
                oldClaimID.ClaimID = newClaim.ClaimID;
                oldClaimID.TypeOfClaim = newClaim.TypeOfClaim;
                oldClaimID.Description = newClaim.Description;
                oldClaimID.ClaimAmount = newClaim.ClaimAmount;
                oldClaimID.DateOfIncident = newClaim.DateOfIncident;
                oldClaimID.DateOfClaim = newClaim.DateOfClaim;
                oldClaimID.IsValid = newClaim.IsValid;
                return true;
            }
            else
                return false;
        }

        public bool RemoveClaim(int claimID)
        {
            Claim item = GetClaimByID(claimID);
            if (item == null)
            {
                return false;
            }

            int initialCount = _listOfClaims.Count;
            return _listOfClaims.Remove(item);
        }

        public Claim GetClaimByID(int claimID)
        {
            foreach (Claim claim in _listOfClaims)
            {
                if (claim.ClaimID == claimID)
                {
                    return claim;
                }
            }
            return null;
        }
    }
}
