using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProjectD3
{
    class MultiClub : Member
    {
        MultiClub multiClub1 = new MultiClub();



        public MultiClub()
        {

        }

        public override void CheckIn(Club club)
        {
            club.CheckIn(this);
        }
    }
}
