using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProjectD3
{

    /*
     *  
 
 This class should have the following:  
 

 
  ○ Multi-Club Members: a variable that stores their membership points.  
     The CheckIn method adds to their membership points.
     */

    class MultiClubMember : Member
    {
       public List<Club> multiClubs { get; set; } = new List<Club>();
        public int _multiPoints { get; set; }
 
        public int _totalPoints { get; set; }

        // Define constructor to initialize the class 
        // We need data required by the superclass and date for the the sub class
        public MultiClubMember(Club aClub, int id, String name, int monthlyFee) : base(id, name, monthlyFee) // we're sending data the super class needs to the super contructor
        {
            multiClubs.Add(aClub);

        }

        public MultiClubMember(Club aClub, int id, String name, int monthlyFee, bool isCheckedIn) : base(id, name, monthlyFee, isCheckedIn) // we're sending data the super class needs to the super contructor
        {
            multiClubs.Add(aClub);


        }








        public override void CheckIn(Club club)
        {
            club.CheckIn(this);
        }
    }
}
