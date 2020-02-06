using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO450
{
    class DistanceConverter
    {
        public int toFeet(int miles)
        {
            return miles*1760*3;
        }

        public int toMiles(int feet)
        {
            return feet / 1760 / 3;
        }

        public int GetInput(string Unit)
        {
            string input;
            int value;

            Console.Write("Enter distance in "+ Unit +": ");
            input = Console.ReadLine();
            value = Convert.ToInt32(input);

            return value;
        }

        public void DisplayChoice()
        {
            Console.WriteLine("Godfrey's Distance Converter");
            Console.WriteLine("=============================");
            Console.WriteLine("1. Convert miles to feet");
            Console.WriteLine("2. Convert feet to miles");
            Console.WriteLine("3. Quit test");

        }
    }
}
