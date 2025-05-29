using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProjectD3
{ /*
     
 
 The class should have the following:  
 
  ○ Single Club Members: a variable that assigns them to a club.  
     The CheckIn method throws an exception if it’s not their club.
    */

    class SingleClubMember : Member
    {
        // Define data for the class ( not already in superclass)

       public String clubName { get; set; }

        // Define constructor to initialize the class 
        // We need data required by the superclass and date for the the sub class
        public SingleClubMember(String theClubName, int id, String name, int monthlyFee) : base(id, name, monthlyFee) // we're sending data the super class needs to the super contructor
        {
            clubName = theClubName;

        }

        public SingleClubMember(String theClubName, int id, String name, int monthlyFee, bool isCheckedIn) : base(id, name, monthlyFee, isCheckedIn) // we're sending data the super class needs to the super contructor
        {
            clubName = theClubName;


        }

        public override string ToString()
        {
            return $"clubName {this.clubName} memberName {_name} id {_id} ";
        }

        
        public override void CheckIn(Club club)
        {
            club.CheckIn(this);
        }
        
    }
}
