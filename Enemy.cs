using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_WillB
{
    internal class Enemy
    {
        public int y;
        public int x;
        public HealthSystem healthsys;


        public Enemy()
        {
            healthsys = new HealthSystem(100); 
        }
    }
}
