using System;

namespace slump
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int man1 = generator.Next(0, 30);
            int man2 = generator.Next(0, 30);
            int dmg1 = generator.Next(0, 10);
            int dmg2 = generator.Next(0, 10);
            string namn1;
            string namn2;
            int round = 1;
            //string name2;
            Console.WriteLine("två män krigar för sina liv. Vem vinner?");

            Console.WriteLine("skriv namn för den första krigaren");
            namn1 = Console.ReadLine();
            Console.WriteLine("Skriv namn för den första krigaren");
            namn2 = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine(namn2 + " gör " + dmg2 + "damage och har" + man2 + "hp");
            Console.ReadLine();
            Console.WriteLine(namn1 + " gör " + dmg1 + "damage och har" + man1 + "hp");

            while (man1 > 0 && man2 > 0)
            {
                Console.WriteLine("round" + round);
                round++;
                man1 = man1 - dmg2;
                Console.WriteLine(namn1 + " har " + man1 + "hp kvar");


                man2 = man2 - dmg1;
                Console.WriteLine(namn2 + " har " + man2 + "hp kvar");

                Console.WriteLine("tryck på enter för nästa runda");

                Console.ReadLine();

            }
            if (man1 <= 0)
            {
                Console.WriteLine(namn2 + "vann!");

            }
            else if (man2 <= 0)
            {
                Console.WriteLine(namn1 + "vann!");

            }
            if (man1 <= 0 && man2 <= 0)
            {
                Console.WriteLine("de döda varandra retards");
            }
            Console.ReadLine();
        }
    }

}

