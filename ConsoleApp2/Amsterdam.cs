using System;

namespace ConsoleApp2
{
    class Amsterdam
    {
        public static void StartAmsterdam()
        {
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
            Console.WriteLine($"Welkom bij de bubbels {Game._name}!  leuk spelletje tussendoor, raad het getal onder de tien, je mag drie keer raden");
            Console.ForegroundColor = ConsoleColor.White;

            string number;
            number = Console.ReadLine();
            int inputNumber = int.Parse(number);

            Random random = new Random();
            int randomNumber = random.Next(0, 5);

            int numberAttempts = 3;
            while (inputNumber != randomNumber && numberAttempts > 1)
            {
                Console.WriteLine($"Fout je mag nog {--numberAttempts}x raden");
                number = Console.ReadLine();
                inputNumber = int.Parse(number);
            }

            if (numberAttempts == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wat slecht.. voor straf moet je 2 shotjes nemen");
                Console.ForegroundColor = ConsoleColor.White;
                Game._level += 2;
            }

            if (inputNumber == randomNumber)
            {
                Console.WriteLine("Nice! een shotje en een drankje op mijn kosten");
                Game._level += 2;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Waar zullen we nu heen?");
            Console.ForegroundColor = ConsoleColor.White;
            string inputCity = Console.ReadLine();

            switch (inputCity)
            {

                case "Amsterdam":
                    Amsterdam.StartAmsterdam();
                    break;

                case "Utrecht":
                    Utrecht.StartUtrecht();
                    break;

                case "Nijmegen":
                    Nijmegen.StartNijmegen();
                    break;

                case "Arnhem":
                    Arnhem.StartArnhem();
                    break;

                case "help":
                    Game.UseMethod();
                    break;

                default:
                    Console.WriteLine("Heb je niet goed verstaan..");
                    break;

            }
        }
    }
}

