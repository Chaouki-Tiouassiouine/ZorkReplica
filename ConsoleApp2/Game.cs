﻿using System;

namespace ConsoleApp2
{
    public class Game
    {

        private static string _name;
        private static string _street;
        public static int _level { get; set; }

        public static void StartGame()
        {
            Initiliaze();

            Start();

            End();

        }

 

        private static void End()
        {
            Console.WriteLine("");
            Console.WriteLine("Was gezellig!");
        }

        private static void Start()
        {
            Console.WriteLine("wat is je naam?");
            _name = Console.ReadLine();
            //if (!Regex.IsMatch(_name, @"\w{1-35}"))
            //    throw new ArgumentException("Dat is niet je echte naam...");
            Console.WriteLine("welke stad wil je heen? Amsterdam of Utrecht?");
            _street = Console.ReadLine();
            Console.WriteLine("wat is je pacelevel op basis van 1 tot 10?");
            _level = int.Parse(Console.ReadLine());


            Console.WriteLine($"Hi {_name}, we gaan dus naar {_street} en je pace is op level {_level}");

            if (_street == "Amsterdam")
            {
                Amsterdam.StartAmsterdam();
            }

            else
            {
                Utrecht.StartUtrecht();
            }

            UseMethod();

        }

        private static void UseMethod()
        {
           
            

        }

        private static void Initiliaze()
        {
            Console.WriteLine($"Hi! het is {DateTime.Now} mooi tijdstip om een drankje te doen");
            Console.WriteLine("We hebben een uur te tijd, ga je mee? yes or no?");

            string answer;
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine(@"       


.   *   ..  . *  *
       *  * @()Ooc()*   o  .
           (Q@*0CG*O()  ___
          |\_________/|/ _ \
          |  |  |  |  | / | |
          |  |  |  |  | | | |
          |  |  |  |  | | | |
          |  |  |  |  | | | |
          |  |  |  |  | | | |
          |  |  |  |  | \_| |
          |  |  |  |  |\___/  
          |\_|__|__|_/|
           \_________/


        LetsGo, heb wel een aantal gegevens nodig...");
            }

            else
            {
                Console.WriteLine("Oke, andere x dan ");
                Console.ReadKey();
                Environment.Exit(0);
            }



        }
    }
}
