using System;

namespace TicTacToe
{
    class Program
    {
        static string[] pos = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };       
      
        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool isCorrect = true;
            

            do
            {              
                if (player == 2)
                {
                    player = 1;
                    XorO(player, input);
                }                    
                else if (player == 1)
                {
                    player = 2;
                    XorO(player, input);
                }

                Box();
                #region
                string[] XandO = { "X", "O" };

                foreach(string XO in XandO)
                {
                    if ((XO == pos[0] && XO == pos[1] && XO == pos[2]) 
                        || (XO == pos[3] && XO == pos[4] && XO == pos[5])
                        || (XO == pos[6] && XO == pos[7] && XO == pos[8])
                        || (XO == pos[0] && XO == pos[4] && XO == pos[8])
                        || (XO == pos[2] && XO == pos[4] && XO == pos[6])
                        || (XO == pos[0] && XO == pos[3] && XO == pos[6])
                        || (XO == pos[1] && XO == pos[4] && XO == pos[7])
                        || (XO == pos[2] && XO == pos[5] && XO == pos[8]))
                    {
                       if(XO == "X")
                        {
                            Console.WriteLine("\nPLAYER 2 HAS WON THE GAME!!!");
                        }
                        else if(XO == "O")
                        {
                            Console.WriteLine("\nPLAYER 1 HAS WON THE GAME!!!");
                        }
                        Console.WriteLine("\nPRESS ANY KEY TO RESET THE GAME!!");
                        Console.ReadKey();
                        Reset();
                        break;
                    }else if(turns == 10)
                    {
                        Console.WriteLine("\nDRAW MATCH!!!");
                        Console.WriteLine("\nPRESS ANY KEY TO RESET THE GAME!!");
                        Console.ReadKey();
                        Reset();
                        break;
                    }
                       
                }          

                #endregion


                #region 
                //Test if field is already taken
                do
                {                   
                    Console.WriteLine("\nPlayer {0}, choose the field: ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("PEASE ENTER THE NUMBER BETWEEN 1 TO 9");
                    }
                    if (input == 1 && pos[0] == "1")
                        isCorrect = true;
                    else if (input == 2 && pos[1] == "2")
                        isCorrect = true;
                    else if (input == 3 && pos[2] == "3")
                        isCorrect = true;
                    else if (input == 4 && pos[3] == "4")
                        isCorrect = true;
                    else if (input == 5 && pos[4] == "5")
                        isCorrect = true;
                    else if (input == 6 && pos[5] == "6")
                        isCorrect = true;
                    else if (input == 7 && pos[6] == "7")
                        isCorrect = true;
                    else if (input == 8 && pos[7] == "8")
                        isCorrect = true;
                    else if (input == 9 && pos[8] == "9")
                        isCorrect = true;
                    else
                    {
                        Console.WriteLine("\nINCORRECT FIELD, PLEASE ENTER  IN THE CORRECT FIELD");
                        isCorrect = false;
                    }

                } while (!isCorrect);
                #endregion

            }
            while (true);
           
        }        
        
        public static void XorO(int player, int input)
        {
            string playerSign = " ";

            if (player == 1)
                playerSign = "X";
            else if (player == 2)
                playerSign = "O";
            switch (input)
            {
                case 1:
                    pos[0] = playerSign;
                    break;
                case 2:
                    pos[1] = playerSign;
                    break;
                case 3:
                    pos[2] = playerSign;
                    break;
                case 4:
                    pos[3] = playerSign;
                    break;
                case 5:
                    pos[4] = playerSign;
                    break;
                case 6:
                    pos[5] = playerSign;
                    break;
                case 7:
                    pos[6] = playerSign;
                    break;
                case 8:
                    pos[7] = playerSign;
                    break;
                case 9:
                    pos[8] = playerSign;
                    break;
            }
        }

        public static void Reset()
        {
            string[] posInitial = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            pos = posInitial;
            Box();
            turns = 0;
        }

        static void Box()
        {
            Console.Title = "TIC TAC TOE";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("                          'TIC TAC TOE'                       ");
            Console.WriteLine("..............................................................");
            Console.WriteLine();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ",pos[0], pos[1], pos[2] );
            Console.WriteLine("------------------");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", pos[3], pos[4], pos[5]);
            Console.WriteLine("------------------");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", pos[6], pos[7], pos[8]);
            turns++;
        }
    }
}
