using System;

namespace ConsoleApp2
{
    public class Game
    {
        public static string _name { get; set; }
        public static int _level = 0; //aantal drankjes

        public static void StartGame()
        {
            Initiliaze();
            Start();
            End();
        }

        private static void End()
        {
            if (Game._level >= 8)
            {
                Console.WriteLine();
                Console.WriteLine("Was gezellig! Maar je moet naar huis, je bent te dronken");
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Was gezellig!");
            }
        }

        private static void Start()
        {
            Console.WriteLine("wat is je naam?");
            Console.WriteLine();
            _name = Console.ReadLine();
            Console.WriteLine();
            //if (!Regex.IsMatch(_name, @"\w{1-35}"))
            //    throw new ArgumentException("Dat is niet je echte naam...");
            Console.WriteLine("welke stad zullen we als eerst heen? Amsterdam, Utrecht, Nijmegen of Arnhem?");
            Console.WriteLine();
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
                    Nijmegen.EndCurrentGame();
                    break;

            }
        }

        public static void UseMethod()
        {
            if (_level > 0 && _level <= 3)
            {
                Console.WriteLine($"{_name} zo dronken ben je niet.. zeg maar waar je heen wil?");
                Console.WriteLine("We kunnen naar Arnhem, Nijmegen, Utrecht of Amsterdam.");
                Nijmegen.EndCurrentGame();
            }

            if (_level > 3 && _level <= 7)
            {
                Console.WriteLine($"Doe rustig aan met de drank {_name}.. zeg maar waar je heen wil?");
                Nijmegen.EndCurrentGame();
            }

            if (_level > 7 && _level <= 10)
            {
                Console.WriteLine($"You are wasted, {_name}.. Je moet naar huis..");
                Console.WriteLine(@"
    _____
   /.---.\
   |`````|
   \     /
    `-.-'           ____
      |    /\     .'   /\
    __|__  |K----;    |  |
   `-----` \/     '.___\/");


                Console.ReadKey(); 
                Environment.Exit(0);
            }
        }

            private static void Initiliaze()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
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
                ___________                                
                \__    ___/___ ______ ______   ___________ 
                  |    | /  _ \\____ \\____ \_/ __ \_  __ \
                  |    |(  <_> )  |_> >  |_> >  ___/|  | \/
                  |____| \____/|   __/|   __/ \___  >__|
                               |__|   |__|        \/   
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