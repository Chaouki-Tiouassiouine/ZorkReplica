using System;

namespace ConsoleApp2
{
    class Utrecht
    {
        public static void StartUtrecht()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"

__________________  ___________   _____      _____   
\______   \_____  \ \_   _____/  /     \    /  _  \  
 |     ___//   |   \ |    __)_  /  \ /  \  /  /_\  \ 
 |    |   /    |    \|        \/    Y    \/    |    \
 |____|   \_______  /_______  /\____|__  /\____|__  /
                  \/        \/         \/         \/ 


");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine($"Welkom bij Poema {Game._name}");
            Console.WriteLine();
            Console.WriteLine($"Even een vraagje, als je het goed hebt krijg je een drankje van mij");
            Console.WriteLine("Hoeveel inwoners heeft Utrecht afgerond, 3x raden!");

            string number;
            number = Console.ReadLine();
            int inputNumber = int.Parse(number);

            int residentsNumber = 344000;

            int numberAttempts = 3;
            while (inputNumber != 344000 && numberAttempts > 1)
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

            if (inputNumber == residentsNumber)
            {
                Console.WriteLine("Nice! een shotje en een drankje op mijn kosten");
                Game._level+= 2;
                //Utrecht.StartUtrecht();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hoppa! Gaat het nog een beetje? Waar zullen we nu heen?");
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

