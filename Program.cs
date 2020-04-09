using System;
using Wizards_Ninja_Samurai.Models;

namespace Wizards_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Henry = new Human("Henry");
            Ninja Sam = new Ninja("Sam");
            Sam.DragonBlade(Henry);
            Samurai James = new Samurai("James");
            James.OPSwordSlash(Sam);
        }
    }
}
