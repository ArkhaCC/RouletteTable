using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace RouletteTable
{
    class Program
    {
        
        Number number = new Number();
        
        
        static void Main(string[] args)
        {
            //Black = 0 ; Red = 1 ; Green = 2

            int[,] board = new int[12, 3]
            {     { 1, 0, 1 },
                  { 0, 1, 0 },
                  { 1, 0, 1 },
                  { 0, 0, 1 },
                  { 0, 1, 0 },
                  { 1, 0, 1 },
                  { 1, 0, 1 },
                  { 0, 1, 0 },
                  { 1, 0, 1 },
                  { 0, 0, 1 },
                  { 0, 1, 0 },
                  { 1, 0, 1 }
            };
            PlaceBets();

            Number.Spin();

            SpaceOnBoard(board);

            if (betPlaced == numberLanded)

            //switch (numberLanded)
            //{
            //    case 0:
            //        board[numberLanded] = 
            //}



        }

        public static int PlaceBets()
        {
            Console.WriteLine("What type of bet would you like to make?");
            Console.WriteLine("1. Individual number (35 : 1)\n2. Even or Odd (1 : 1)\n3. Red or Black (1 : 1)\n4. Low or High (1 : 1)\n5. Columns");
            int betPlaced = 0;
            int input = int.Parse( Console.ReadLine());

            if (input == 1)
            {
                //Number bet
                NumberBet(betPlaced);
            }


            else { return betPlaced; };
            
        }

        private static int NumberBet(int betPlaced)
        {
            Console.WriteLine("A straight Number bet! Which number?");
            Console.WriteLine("00, 0, or anything between 1-36");
            //TODO: Fix the 00 potential bug (not an int)
            betPlaced = int.Parse(Console.ReadLine());
            return betPlaced;
        }

        public static int SpaceOnBoard(int[,] board)
        {
            // Will take the result of the spin and apply it to the Board to determine color

            int color = 0;
            int numberLanded = Number.result;
            
            if (numberLanded <= 0 )
            {
                color = 2;
            }
            if (numberLanded % 3 == 0)
            {
                color = board[(numberLanded / 3), 3];

            }

            else if (numberLanded % 3 == 1)
            {
                color = board[(numberLanded / 3), 2];
            }

            else if (numberLanded % 3 == 2)
            {
                color = board[(numberLanded / 3), 1];
            }

            switch (color)
            {
                case 0:
                    Console.WriteLine($"The winning number is Black {numberLanded}!" );
                    break;
                case 1:
                    Console.WriteLine($"The winning number is Red {numberLanded}");
                    break;
                case 2:
                    Console.WriteLine($"The winning number is {numberLanded}! How rare!");
                    break;
            }

            //Console.WriteLine(color);
            return color;
        }

    }
}



