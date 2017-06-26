using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_RPG
{
    class Monster
    {

        private string name;
        private int hitPoints;

        private int acuracy;

        private int armor;
        private int eXPReward;

        private Weapon weapon;

        public Monster(string name, int hp, int acc, int xpReward, int armor, Weapon weapon)
        {
            this.name = name;
            hitPoints = hp;
            acuracy = acc;
            eXPReward = xpReward;
            this.armor = armor;
            this.weapon = weapon;

        }


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

            //Es ua condicion para si no tiene puntos de vida.
            return this.hitPoints <= 0;
        }





        public void attack(Player player)
        {

            if (Range.random(0, 20) < this.acuracy)
            {

                Console.WriteLine(this.name + " Ha fallado el ataque");

            }
            else
            {

                int damage = Range.random(this.weapon.Damagerange);
                int totalDamage = damage - player.Armor;

                if (totalDamage > 0)
                {

                    player.takeDamage(totalDamage);
                    Console.WriteLine("Te golpearon por " + totalDamage + " daño");



                }
                else
                {
                    Console.WriteLine("La armadura te protegio");
                }
            }


        }

        public void takeDamage(int damage)
        {
            this.hitPoints -= damage;

        }



        public void displayHitPoints()
        {
            Console.WriteLine(this.name + "Puntos de vida = " + this.hitPoints);   
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
}
