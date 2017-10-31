using System;

namespace ConsoleApp2
{
    class Amsterdam
    {
        public static void StartAmsterdam()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Welkom op het Leidse! leuk spelletje tussendoor, geef een getal onder de vijf");
            Console.BackgroundColor = ConsoleColor.White;

            string number; 
            number = Console.ReadLine();
            int inputNumber = int.Parse(number);
     
            Random random = new Random();
            int randomNumber = random.Next(0, 5);

            if (inputNumber == randomNumber)
            {
                Console.WriteLine("Nice! een drankje op mijn kosten");
                Game._level ++;            
            }

            else
            {
                Console.WriteLine("Fout.. jij betaalt!");
            }

            Console.WriteLine("waar wil je heen Utrecht, Arnhem of Nijmegen?");
        }
    }
}

