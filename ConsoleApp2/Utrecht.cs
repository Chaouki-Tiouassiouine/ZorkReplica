using System;

namespace ConsoleApp2
{
    class Utrecht
    {
        public static void StartUtrecht()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welkom bij Chupitos!");
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("Even een vraagje, als je het goed hebt krijg je een level erbij");
            Console.WriteLine("Hoeveel inwoners heeft Utrecht afgerond, 3x raden!");

            string number;
            number = Console.ReadLine();
            int inputNumber = int.Parse(number);

            int residentsNumber = 344000;
            do
            {
                Console.WriteLine("Fout");
                numberAttempts--;
            } while (inputNumber != 344000 && numberAttempts != 0);

            if (inputNumber == residentsNumber)
            {
                Console.WriteLine("Nice! een drankje op mijn kosten");
                Game._level++;
                //Utrecht.StartUtrecht();
            }
        }
    }
}

