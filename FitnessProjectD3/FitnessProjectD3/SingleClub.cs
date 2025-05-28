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

    class SingleClub : Member
    {
        SingleClub singleClub1 = new SingleClub();
       

        

    public SingleClub()
        {
           
        }

        public override void CheckIn(Club club)
        {
            club.CheckIn(this);
        }
        
    }
}
