using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ConsoleApp2
{
    class Nijmegen
    {
        //making array and   
        //by default I am providing 0-9 where no use of zero  
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //By default player 1 is set  
        static int choice; //This holds the choice at which position user want to mark   

        // The flag veriable checks who has won if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running  
        static int flag = 0;

        public static void StartNijmegen()
        {
            do
            {

                Console.Clear();// whenever loop will be again start then screen will be clear 

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
------------------------------------------------
___________         __                
\_   _____/__  ____/  |______    ______ ____  
 |    __)_\  \/  /\   __\__  \  /  ___// __ \ 
 |        \>    <  |  |  / __ \_\___ \\  ___/ 
/_______  /__/\_ \ |__| (____  /____  >\___  >
        \/      \/           \/     \/     \/
-------------------------------------------------
WELKOM IN CLUB EXTASE!! Tijd voor een leuk spelletje!

");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{Game._name}: X - Ikke: O");
                if (player % 2 == 0)//checking the chance of the player  
                {
                    Console.WriteLine($"{Game._name} het is jouw beurt");
                }
                else
                {
                    Console.WriteLine("Mijn beurt");
                }
                Console.WriteLine("\n");
                Board();// calling the board Function  
                choice = int.Parse(Console.ReadLine());//Taking users choice   

                // checking that position where user want to run is marked (with X or O) or not  
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else //If there is any possition where user want to run and that is already marked then show message and load board again  
                {
                    Console.WriteLine("Uhh,  sorry maar rij {0} is al door {1} ingenomen", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Wacht even ik herschrijf het even.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();// calling of check win  
            } while (flag != 1 && flag != -1);// This loof will be run until all cell of the grid is not marked with X and O or some player is not win  

            Console.Clear();// clearing the console  
            Board();// getting filled board again  

            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
                Nijmegen.EndNijmegenGame();
            }
            else// if flag value is -1 the match will be draw and no one is winner  
            {
                Console.WriteLine("Draw");
                Nijmegen.EndNijmegenGame();
            }
            Console.ReadLine();
        }
        // Board method which creats board  
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        //In deze methode "CheckWin" kijk ik of een speler heeft gewonnen of niet, 
        //ik kijk telkens of een rij in de Array gelijk is, als dat het geval is return ik standaard speler 1 anders aan het einde speler 0
        private static int CheckWin()
        {
            // hier controleer ik of er gewonnen is in de horizontale rijen 
            //Als de bovenste Row in de Array gelijk is    
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Voor de tweede rij wordt hier een controle uitgevoerd of een speler gewonnen heeft   
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Voor de tweede rij wordt hier een controle uitgevoerd of een speler gewonnen heeft  
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }

            //Verticale controle hier
            //Winning Condition For First Column       
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column  
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column  
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }


            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion

            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match  
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;     
            }
        }

        public static void EndNijmegenGame()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
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
                    EndNijmegenGame();
                    break;
            }
        }
    }
}

   
