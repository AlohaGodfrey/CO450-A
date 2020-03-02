using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0453A
{
    public class Bubble
    {
        public const int ArraySize = 6;
        private int[] RandomNumberList = new int[ArraySize];
        Random rnd = new Random();

        public int inputNumbers()
        {
            for (int count = 0; count < 6; count++)
            {
                RandomNumberList[count] = rnd.Next(100);
            }

            return 0;
        }

        public void display()
        {
            Console.Clear();
            for (int count = 0; count < 6; count++)
            {
                Console.WriteLine(RandomNumberList[count]);
            }
        }
    }
}