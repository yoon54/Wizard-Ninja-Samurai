using System;

namespace Wizards_Ninja_Samurai.Models
{
    public class Ninja : Human
    {
        public int dexterity;

        public Ninja(string name) : base(name)
        {
            dexterity = 175;
        }

        public int DragonBlade(Human target)
        {
            if(target is Human)
            {
                Random rand = new Random();
                int roll = rand.Next(4);
                int extradmg = 0;
                if(roll == 0)
                {
                    extradmg = 10;
                }
                int dmg = dexterity * 5 + extradmg;
                Console.WriteLine($"{Name} shouts 'ryujin no ken wo kurae' and takes out his sword and slices {target.Name} to do {dmg} to {target.Name}");
                return target.TakeDmg(dmg);
            }
            else
            {
                throw new Exception("That wasn't a proper Attack!!!");
            }
        }
        public int Steal(Human target){
            int dmg = 5;
            this.heal(5);
            Console.WriteLine($"{Name} has healed for 5 health and did 5 dmg to {target.Name}");
            return target.TakeDmg(dmg);
        }
    }

}