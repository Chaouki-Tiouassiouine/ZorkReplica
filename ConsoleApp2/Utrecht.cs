using System;

namespace ConsoleApp2
{
    class Utrecht
    {
        public static void StartUtrecht()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welkom bij Chupitos!");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Even een vraagje, als je het goed hebt krijg je een drankje van mij");
            Console.WriteLine("Hoeveel inwoners heeft Utrecht afgerond, 3x raden!");

            string number;
            number = Console.ReadLine();
            int inputNumber = int.Parse(number);

            int residentsNumber = 344000;

            int numberAttempts = 3;
            while(inputNumber != 344000 && numberAttempts >0)
            {
                Console.WriteLine($"Fout je mag nog {--numberAttempts} raden");
                number = Console.ReadLine();
                inputNumber = int.Parse(number);
            } 

            if (inputNumber == residentsNumber)
            {
                Console.WriteLine("Nice! een drankje op mijn kosten");
                Game._level++;
                //Utrecht.StartUtrecht();
            }
        }
    }
}

