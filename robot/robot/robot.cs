using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    class robot
    {
        private int kollife;
        public int getlife()
        {
            return kollife;
        }
        public void min(int a)
        {
            kollife = a;
            kollife = (int)kollife / 2;
        }
    }
}
