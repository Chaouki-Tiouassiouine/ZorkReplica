using System;

namespace ConsoleApp2
{
    public class Game
    {
        public static string _name { get; set; }
        private static string _street;
        public static int _level = 0; //aantal drankjes

        public static void StartGame()
        {
            Initiliaze();
            Start();
            End();
        }

        private static void End()
        {
            Console.WriteLine();
            Console.WriteLine("Was gezellig!");
        }

        private static void Start()
        {
            Console.WriteLine("wat is je naam?");
            Console.WriteLine();
            _name = Console.ReadLine();
            //if (!Regex.IsMatch(_name, @"\w{1-35}"))
            //    throw new ArgumentException("Dat is niet je echte naam...");
            Console.WriteLine("welke stad zullen we als eerst heen? Amsterdam, Utrecht, Nijmegen of Arnhem?");

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

                default:
                    Console.WriteLine("Heb je niet goed verstaan..");
                    break;

            }

        }

        public static void UseMethod()
        {

            //ik wil nog de locaties tonen waar men nog niet is geweest en dat ze daaruit kunnen kiezen, als ze overal zijn geweest moeten ze gewoon naar huis
            string str = Console.ReadLine();
            if (str == "help")
 
            if (_level > 0 && _level <= 5)
            {
                Console.WriteLine($"{_name} zo dronken ben je niet.. waar wil je heen?");
                Console.WriteLine();
                }

            if (_level > 5 && _level <= 7)
            {
                Console.WriteLine($"Doe rustig aan met de drank {_name}.. waar wil je heen?");
                Console.WriteLine();
            }

            if (_level > 7 && _level <= 10)
            {
                Console.WriteLine($"You are wasted, {_name}.. we kunnen naar huis of naar (resterende steden)? ");
                Console.WriteLine();
            }

            string direction;
            direction = Console.ReadLine();

            if (direction == null)
            {
                Console.WriteLine("Tijd om naar huis te gaan, we zijn overal geweest!");
                Console.WriteLine();
            }
        }

        private static void Initiliaze()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"


-----------------------------------------------------
               .__                               
__  _  __ ____ |  |   ____  ____   _____   ____  
\ \/ \/ // __ \|  | _/ ___\/  _ \ /     \_/ __ \ 
 \     /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/ 
  \/\_/  \___  >____/\___  >____/|__|_|  /\___  >
             \/          \/            \/     \/ 

------------------------------------------------------



");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"Hi! het is " + DateTime.Now + " mooi tijdstip om een drankje te doen? ");
            Console.WriteLine();
            Console.WriteLine("We hebben een uur te tijd, ga je mee? yes or no?");
            Console.WriteLine();

            string answer;
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"       


        .   *   ..  . *  *
       *  * @()OoO()*   o  .
           (()*0O0*O()  ___
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


___________                                
\__    ___/___ ______ ______   ___________ 
  |    | /  _ \\____ \\____ \_/ __ \_  __ \
  |    |(  <_> )  |_> >  |_> >  ___/|  | \/
  |____| \____/|   __/|   __/ \___  >__|   
               |__|   |__|        \/       


            ");

                Console.ForegroundColor = ConsoleColor.White;
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