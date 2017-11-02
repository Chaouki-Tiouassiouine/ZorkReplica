using System;
using System.Threading;

namespace ConsoleApp2
{
    class Utrecht
    {
        public static void StartUtrecht()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"

__________________  ___________   _____      _____   
\______   \_____  \ \_   _____/  /     \    /  _  \  
 |     ___//   |   \ |    __)_  /  \ /  \  /  /_\  \ 
 |    |   /    |    \|        \/    Y    \/    |    \
 |____|   \_______  /_______  /\____|__  /\____|__  /
                  \/        \/         \/         \/ 


");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Welkom {Game._name}, bij Poema!");
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fout je mag nog {--numberAttempts}x raden");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                number = Console.ReadLine();
                inputNumber = int.Parse(number);
            }

            if (inputNumber != 344000 && numberAttempts == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Jammer joh.. voor straf moet je 2 shotjes nemen");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Game._level += 2;
            }

            if (inputNumber == residentsNumber)
            {
                Console.WriteLine("Nice! Wacht even ik ga een shotje en een drankje op mijn kosten halen! ");
                Console.WriteLine();
                Thread.Sleep(5000);
                Game._level+= 2;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("Hoppa! Gaat het nog een beetje? Waar zullen we nu heen?");
            Console.WriteLine();
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

