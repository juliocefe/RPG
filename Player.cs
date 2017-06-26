using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_RPG
{
    class Player
    {



        private string name;
        private int hitPoints;

        private int acuracy;

        private int armor;
        private int eXPReward;

        private Weapon weapon;

      
        
        
        public int HitPoints
        {
            get { return hitPoints; }
            set { hitPoints = value; }
        }
      

        
        public int Acuracy
        {
            get { return acuracy; }
            set { acuracy = value; }
        }
      

        
        public int EXPReward
        {
            get { return eXPReward; }
            set { eXPReward = value; }
        }
        

       
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }


       

        internal Weapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }



        public bool isDead()
        {

            return true;
        }


        public void attack(Player player)
        {




        }

        public void takeDamage(int damage)
        {


        }

        public void displayHitPoints()
        {


        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

    }
}
