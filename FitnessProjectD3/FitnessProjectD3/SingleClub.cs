using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProjectD3
{
    
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
