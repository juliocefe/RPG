using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_RPG
{
    class Weapon
    {

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        Range damagerange;

        internal Range Damagerange
        {
            get { return damagerange; }
            set { damagerange = value; }
        }

        
        

    }
}
