using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_WillB
{
    internal class Player
    {
        public int x;
        public int y;
        public HealthSystem healthsys;


        public Player()
        {
            healthsys = new HealthSystem(100);
        }

    }
}
