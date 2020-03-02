using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CO453A.Bubble;


namespace CO453A
{
   
    class Program
    {

        static void Main()
        {
            //TestDistanceConverter();    // T4.1  
            //TestBook();                 // T4.2 and T4.3
            //TestBMI();                  // T4.4  


            //TestTournament();           // T5.1 and 5.3
            //TestSongs();                // T5.2
            //TestBubbleSort();           // T5.4 
            //TestMotelBooking();         // T5.6
        }

        private static void TestBubbleSort()
        {
           Bubble sort1 = new Bubble();
    
           sort1.inputNumbers();
           sort1.display();
        }

       

        private static void TestSongs()
        {
            MP3Chart chart = new MP3Chart();

            chart.ShowSongs();

            bool finish = false;

            while (!finish)
            {
                int songNo = chart.GetVotes();
                if (songNo == 0) finish = true;

            }

            chart.ShowVotes();
        }

       
        private static void TestTournament()
        {
            Tournament tournament = new Tournament();

            tournament.GetDetails();

            tournament.ShowDetails();
        }

        private static void TestBMI()
        {
            BodyMassIndex Patient1 = new BodyMassIndex();
            
            Patient1.displayMenu();
            Patient1.getMenuChoice();
            Patient1.getDetails();
            Patient1.calcBMI();
            Patient1.displayResults();

            Console.ReadLine();

        }

        private static void TestBook()
        /// <summary>
        /// Task 4.2 and 4.3
        /// Create a customizable story
        /// </summary>
        {
            string input;
            Book book = new Book();

            Console.Clear();
            Console.Write("Do you want start a customizable story? (Y/N): ");
            input = Console.ReadLine();



            if (input == "y" || input == "Y")
            {
                book.GetDetails();
            }

            book.checkGender();
            book.WriteChapter1();
            Console.ReadLine();
            book.WriteChapter2();
            Console.ReadLine();
        }

        public static void TestDistanceConverter()
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
