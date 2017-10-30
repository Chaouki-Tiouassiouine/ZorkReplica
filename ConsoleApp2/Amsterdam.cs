using System;

namespace ConsoleApp2
{
    class Amsterdam
    {
        public static void StartAmsterdam()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welkom op het Leidse! leuk spelletje tussendoor, geef een getal onder de tien");

            string number; 
            number = Console.ReadLine();
            int inputNumber = int.Parse(number);
     

            Random random = new Random();
            int randomNumber = random.Next(0, 10);

            if (inputNumber == randomNumber)
            {
                Console.WriteLine("Nice! een drankje op mijn kosten");
                Game._level ++;
                Utrecht.StartUtrecht();             
            }

            else
            {
                Console.WriteLine("Fout.. doei");
            }

        }
    }
}

