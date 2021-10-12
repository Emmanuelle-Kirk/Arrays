using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ammo System");
            //WE WISH TO STORE THE AMMO OF ALL WEAPONS
            //pistol 6/6
            //shotgun 2/2
            //...
            //BFG 10/10


            Console.WriteLine("BEFORE Arrays");
            int weapon = 0; //0 = pistol, 1 = shotgun, etc...

            int pistolAmmo = 6; //declaration + innitialization
            int shotGunAmmo = 2;
            //...
            int bfgAmmo = 20;
            //HOW DO WE SHOW THE AMMO OF THE CORRENT WEAPON
            //(without hardcoding)
            if (weapon == 0)
            {
                Console.WriteLine("Pistol Ammo: " + pistolAmmo);
            }
            else if (weapon == 1)
            {
                Console.WriteLine("Shot Gun Ammo: " + shotGunAmmo);
            }
            else if (weapon == 3)
            {
                Console.WriteLine("BFG Ammo: " + bfgAmmo);
            }
            //...
            Console.WriteLine("Arrays");
            int[] ammo; //declaration (telling compiler what ammo is)
            //int[] means an array of integers
            // so 'ammo' is an array of integers

            ammo = new int[3]; //initialization (telling the compiler the size)
            ammo[0] = 6; //pistol
            ammo[1] = 2; //shotgun
            ammo[2] = 10; //bfg

            //HOW DO WE SHOW THE AMMO OF THE CORRENT WEAPON
            //(without hardcoding)

            if (weapon == 0)
            {
                Console.WriteLine("Pistol Ammo: " + ammo[0]);
            }
            else if (weapon == 1)
            {
                Console.WriteLine("Shot Gun Ammo: " + ammo[1]);
            }
            else if (weapon == 3)
            {
                Console.WriteLine("BFG Ammo: " + ammo[2]);
            }

            Console.WriteLine("Pistol Ammo: " + ammo[0]);
            Console.WriteLine("Shot Gun Ammo: " + ammo[1]);
            Console.WriteLine("BFG Ammo: " + ammo[2]);

            Console.WriteLine("Ammo: " + ammo[weapon]);

            Console.ReadKey(true);
        }
    }
}
