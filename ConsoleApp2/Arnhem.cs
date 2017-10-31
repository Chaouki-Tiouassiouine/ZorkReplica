using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Arnhem
    {
        public static void StartArnhem()
        {
            Console.WriteLine("Oke we zijn in het beruchte Arnhem, je kan een drankje verdienen");

            char[] guessed = new char[26];
            char[] testword = "********".ToCharArray();
            char[] word = "VrijMiBo".ToCharArray();
            char[] copy = word;

            char guess;

            int score = 0, index = 0;
            Console.WriteLine(testword);

            for (int i = 0; i < 10; i++)
            {

                Console.Write("Oke, geef een letter op  ");

                guess = char.Parse(Console.ReadLine());
                bool right = false;
                for (int j = 0; j < copy.Length; j++)
                {
                    if (copy[j] == guess)
                    {
                        Console.WriteLine("Yes correct..");
                        testword[j] = guess;
                        guessed[index] = guess;
                        index++;
                        right = true;
                    }
                }

                if (right != true)
                {
                    Console.WriteLine("Nope, zit er niet in");
                    score++;
                }
                else
                {
                    right = false;
                }

                Console.WriteLine(testword);


            }

            Console.WriteLine("Kijk kijk.. je score is " + score);

            Console.ReadLine();

        }
    }
}
