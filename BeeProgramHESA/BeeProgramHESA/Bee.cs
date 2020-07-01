using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeProgramHESA
{
    class Bee
    {
        public string name { get; set; }

        public int health { get; set; }

        public override string ToString()
        {
            return name + health.ToString();
        }

        //Bee Constructor
        public Bee(string _name)
        {
            this.name = _name;
            
            this.health = 100;
        }       


        //Bee Taking Damage
        public Bee damage(Bee bee, int damage)
        {
            //Subtract health first before checking if bee is dead            
            bee.health = bee.health - damage;

            //while the bee is alive subtract damage
            while (!isDead(bee))
            {               
                return bee;
            }
            
            bee.health = 0;           

            //if dead just return bee
            return bee;

        }


        //Check if bee is alive or dead
        public bool isDead(Bee bee)
        {
            if (bee.name == "Queen")
            {
                if (bee.health <= 20)
                {
                    return true;
                }
            }
            else if (bee.name == "Worker")
            {
                if (bee.health <= 70)
                {
                    return true;
                }
            }
            else if (bee.name == "Drone")
            {
                if (bee.health <= 50)
                {
                    return true;
                }
            }

            return false;
        }


        


    }

}

