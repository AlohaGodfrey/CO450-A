using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO450
{
    class Program
    {

        static void Main(string[] args)
        {
            //TestDistanceConverter();
            TestBook();
        }

        private static void TestBook()
        {
            Book book = new Book();

            book.GetDetails();
            book.checkGender();
            book.WriteChapter1();
            Console.ReadLine();
            book.WriteChapter2();
            Console.ReadLine();
        }

        static void Main1(string[] args)
        {
            int miles, feet, choice;
            string input;

            DistanceConverter converter = new DistanceConverter();

            do
            {
                
                converter.DisplayChoice();
                Console.Write("option: ");
                input = Console.ReadLine();
                choice = Convert.ToInt32(input);

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        miles = converter.GetInput("miles");
                        feet = converter.toFeet(miles);
                        Console.WriteLine(miles + " miles in feet: " + feet);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        feet = converter.GetInput("feet");
                        miles = converter.toMiles(feet);
                        Console.WriteLine(feet + " feet is equivalent to " + miles + " miles.");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("...Exiting Program");
                        break;
                    default:
                        Console.WriteLine("Select an Option from the Menu Above!");
                        Console.WriteLine();
                        break;
                }
            } while (choice != 3);

            Console.ReadLine();



            
        }
    }
}
