using System;

namespace Wizards_Ninja_Samurai.Models
{
    public class Wizard : Human
    {
        public int health;
        public int intelligence;

        public Wizard(string name) : base(name)
        {
            health = 50;
            intelligence = 25;
        }

        public int LifeSteal(Human target)
        {
            if(target is Human)
            {
                int dmg = intelligence * 5;
                Console.WriteLine($"{Name} shouts 'Life Steal' and does {dmg} to {target.Name} and gains health for {dmg}");
                health += dmg;
                return target.TakeDmg(dmg);
            }
            else
            {
                throw new Exception("That wasn't a proper Attack!!!");
            }
        }
        public int Heal(){
            int heals = 10*intelligence;
            health += heals;
            Console.WriteLine($"{Name} has healed for {heals} and current health is {health}");
            return health; 
        }
    }

}