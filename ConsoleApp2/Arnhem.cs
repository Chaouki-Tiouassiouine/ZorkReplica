using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Arnhem
    {
        public static void StartArnhem()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"



--------------------------------
.____           _____  __   
|    |    _____/ ____\/  |_ 
|    |   /  _ \   __\\   __\
|    |__(  <_> )  |   |  |  
|_______ \____/|__|   |__|  
        \/
--------------------------------"

);
            Console.WriteLine("we zijn in club Loft in het beruchte Arnhem, je kan een drankje verdienen");
            Console.WriteLine("we gaan galgje spelen, raad het woord, 10 kansen heb je");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            char[] guessed = new char[26];
            char[] testword = "********".ToCharArray();
            char[] word = "vrijmibo".ToCharArray();
            char[] copy = word;

            char guess;

            int score = 0, index = 0;
            Console.WriteLine(testword);

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Oke, geef een letter op ");
                Console.WriteLine();

                guess = char.Parse(Console.ReadLine());
                bool right = false;
                for (int j = 0; j < copy.Length; j++)
                {
                    if (copy[j] == guess)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Yes dat is een letter wat in het woord zit!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        testword[j] = guess;
                        guessed[index] = guess;
                        index++;
                        score++;
                        right = true;
                    }
                }

                if (right != true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nope, zit er niet in");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    score++;
                }

                else
                {
                    right = false;
                }

                Console.WriteLine(testword);

                string guessedWord = new string(word);
                string inputWord = new string(testword);
                if (guessedWord == inputWord && score >= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Kijk kijk! je hebt het woord geraden, je krijgt een drankje van mij!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game._level += 2;

                    if (Game._level >= 8)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Was gezellig! Maar je moet naar huis, je bent te dronken");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    break;
                }

                if (guessedWord != inputWord && score >= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"



███████████████████████████
███████▀▀▀░░░░░░░▀▀▀███████
████▀░░░░░░░░░░░░░░░░░▀████
███│░░░░░░░░░░░░░░░░░░░│███
██▌│░░░░░░░░░░░░░░░░░░░│▐██
██░└┐░░░░░░░░░░░░░░░░░┌┘░██
██░░└┐░░░░░░░░░░░░░░░┌┘░░██
██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██
██▌░│██████▌░░░▐██████│░▐██
███░│▐███▀▀░░▄░░▀▀███▌│░███
██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██
██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██
████▄─┘██▌░░░░░░░▐██└─▄████
█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████
████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████
█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████
███████▄░░░░░░░░░░░▄███████
██████████▄▄▄▄▄▄▄██████████
███████████████████████████

Jammer maar helaas, een shotje op jouw kosten


");
                    Console.ForegroundColor = ConsoleColor.White;
                    Game._level += 2;

                    if (Game._level >= 8)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Was gezellig! Maar je moet naar huis, je bent te dronken");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    break;
                }
            }

            Console.WriteLine("dit was club Loft in Arnhem, voor herhaling vatbaar toch?");
            Nijmegen.EndCurrentGame();
        }
    }
}
