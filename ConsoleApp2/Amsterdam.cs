using System;

namespace ConsoleApp2
{
    class Amsterdam
    {
        public static void StartAmsterdam()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
__________     ___.  ___.          .__          
\______   \__ _\_ |__\_ |__   ____ |  |   ______
 |    |  _/  |  \ __ \| __ \_/ __ \|  |  /  ___/
 |    |   \  |  / \_\ \ \_\ \  ___/|  |__\___ \ 
 |______  /____/|___  /___  /\___  >____/____  >
        \/          \/    \/     \/          \/

--------------------------------------------------


");
            Console.WriteLine($"Welkom bij de bubbels {Game._name}!  leuk spelletje tussendoor, raad het getal onder de vijf, je hebt een kans");
            Console.BackgroundColor = ConsoleColor.Black;

            string number;
            number = Console.ReadLine();
            int inputNumber = int.Parse(number);

            Random random = new Random();
            int randomNumber = random.Next(0, 5);

            if (inputNumber == randomNumber)
            {
                Console.WriteLine("Nice! een drankje op mijn kosten");
                Game._level++;
            }

            else
            {
                Console.WriteLine("Fout.. jij betaalt!");
                Game._level++;
            }

            Console.ForegroundColor = ConsoleColor.Red;
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

