using System;

namespace Wizards_Ninja_Samurai.Models
{
    public class Samurai : Human
    {
        public int health;

        public Samurai(string name) : base(name)
        {
            health = 200;
        }

        public int OPSwordSlash(Human target)
        {
            if(target is Human)
            {
                
                if(target.Health < 50)
                {
                    int dmg = target.Health;
                    Console.WriteLine($"{Name} slashes and one shots {target.Name} to do {dmg} to {target.Name}");
                    return target.TakeDmg(dmg);
                }
                else{
                    return this.Attack(target);
                }
                
                
            }
            else
            {
                throw new Exception("That wasn't a proper Attack!!!");
            }
        }
        public int Meditate(){
            health = 200;
            Console.WriteLine($"{Name} has meditated to return back to full health");
            return health; 
        }
    }

}