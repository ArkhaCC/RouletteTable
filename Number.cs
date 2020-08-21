using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace RouletteTable
{
    class Number
    {
        public static int result = 0;

        //public static object Numbers { get; internal set; }

        public static int Spin()
        {
           
                int[] Numbers = new int[] { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
                var rand = new Random();
                int num = rand.Next(39);

                result = Numbers[num];
                //Console.WriteLine(result);
                //Console.WriteLine(Numbers[num]);
                return result;


            


        }

        private static void TakeBets()
        {
            
        }
    }
}
