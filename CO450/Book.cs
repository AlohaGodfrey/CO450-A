using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO450
{
    /// <summary>
    /// This class ...
    /// 
    /// For Tasks 4.2 and 4.3 
    /// 
    /// Author      : Dr Derek Peacock
    /// Modified by : Godfrey
    /// </summary>
    public class Book
    {
        // Attributes of Book

        private string author, name, town;
        private string animal, weapon, job;
        private string gender, day, emotion;

        /// <summary>
        /// This method is a contructer for the book class, if the
        /// use does not want a customized story, the default values
        /// are loaded from here
        /// </summary>
        public Book()
        {
            author = "Godfrey";
            name = "Dave";
            town = "Lewisham";
            animal = "cow";
            weapon = "knife";
            job = "farmer";
            gender = "male";
            day = "wednesday";
            emotion= "terrified";
        }

        /// <summary>
        /// Prompt the user for an answer as a string and return it
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns>answer</returns>
        public string GetString(string prompt)
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }

     
        /// <summary>
        /// Get the details of the author, name, town, animal
        /// job and weapon used in the books stories
        /// </summary>
        public void GetDetails() // keep using ask() to get information
        {
            author = GetString("Please type your name : ");
            name = GetString("Please type a friend's name : ");
            town = GetString("Now give me the name of a town : ");
            animal = GetString("Now a type of animal : ");
            job = GetString("Now a type of job : ");
            weapon = GetString("And your weapon of choice : ");
            gender = GetString("Your Gender: ");
            day = GetString("What day is it: ");
            emotion = GetString("Give me an emotion: ");
        }

        /// <summary>
        /// This method creates a the first chapter of a story using 
        /// all the attributes of the class
        /// </summary>
        public void WriteChapter1()
        {
            Console.Clear();

            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("===============================");

            Console.WriteLine("It was a dark night in " + town + " and " + name
                + " could hear " + animal + "s screaming in the distance.");

            Console.WriteLine(name + " staggered terrified through the streets of "
                + town + ", realising " + gender + " had been followed.");

            Console.WriteLine("In the shadow of a doorway, a demented " + job
                + " waited, clutching a menacing " + weapon);
        }


        /// <summary>
        /// This method creates the second chapter of a story using
        /// three new additional attributes of the book class
        /// </summary>
        public void WriteChapter2()
        {
         

            Console.WriteLine("A Horror Story : Chapter 2");
            Console.WriteLine("===============================");

            Console.WriteLine( "The " + job + " darted towards " + name + ".");
            Console.WriteLine(gender + " began to feel " + emotion + ".");
            Console.WriteLine("This was not how " + name +  " expected to end " 
                + day + " night.");

        }

        /// <summary>
        /// This methods checks the gender of the custom character, to create
        /// a personalized story
        /// </summary>
        public void checkGender()
        {
            if (gender=="male" || gender=="Male" || gender=="MALE" || gender=="M" || gender=="m")
            {
                gender = "he";
            }
            else
            {
                gender = "she";
            }
            
        }
    }
}
