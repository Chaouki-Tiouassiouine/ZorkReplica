using System;

namespace ConsoleApp2
{
    class Amsterdam
    {
        public static void StartAmsterdam()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"

-------------------------------------------------
__________     ___.  ___.          .__          
\______   \__ _\_ |__\_ |__   ____ |  |   ______
 |    |  _/  |  \ __ \| __ \_/ __ \|  |  /  ___/
 |    |   \  |  / \_\ \ \_\ \  ___/|  |__\___ \ 
 |______  /____/|___  /___  /\___  >____/____  >
        \/          \/    \/     \/          \/

--------------------------------------------------

");
            Console.WriteLine($"Welkom bij de bubbels {Game._name}!  leuk spelletje tussendoor, raad het getal onder de vijf, je mag drie keer raden");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            string number;
            number = Console.ReadLine();
            int inputNumber = int.Parse(number);

            Random random = new Random();
            int randomNumber = random.Next(0, 5);

            int numberAttempts = 3;
            while (inputNumber != randomNumber && numberAttempts > 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fout je mag nog {--numberAttempts}x raden");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                number = Console.ReadLine();
                inputNumber = int.Parse(number);
            }

            if (numberAttempts == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jammer, maar helaas, voor straf moet je 2 shotjes nemen");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Game._level += 2;

                if (Game._level >= 8)
                {
                    Console.WriteLine();
                    Console.WriteLine("Was gezellig! Maar je moet naar huis, je bent te dronken");
                    Environment.Exit(0);
                }
            }

            if (inputNumber == randomNumber)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Nice! een shotje en een drankje op mijn kosten");
                Console.ForegroundColor = ConsoleColor.White;
                Game._level += 2;

                if (Game._level >= 8)
                {
                    Console.WriteLine();
                    Console.WriteLine("Was gezellig! Maar je moet naar huis, je bent te dronken");
                    Environment.Exit(0);
                }
            }

            Nijmegen.EndCurrentGame();
            
        }
    }
}

