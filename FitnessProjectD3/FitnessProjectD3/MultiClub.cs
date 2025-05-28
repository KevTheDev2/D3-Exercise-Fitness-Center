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

    class MultiClub : Member
    {
        MultiClub multiClub1 = new MultiClub();
        public int _multiPoints { get; set; }
 
        public int _totalPoints { get; set; }

        

        
        public MultiClub()
        {

        }

        

        public override void CheckIn(Club club)
        {
            club.CheckIn(this);
        }
    }
}
