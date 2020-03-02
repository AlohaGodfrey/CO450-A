using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453A
{
    internal class BodyMassIndex
    {

        /// <summary>
        /// Independent Task 4.4
        /// Uses a BMI class to calculate the BMI value for each patient
        /// Displays the results and can work with data entered using the 
        /// imperial or metric systems
        /// 
        /// For Independent Study Task 4.4
        /// Author: Godfrey
        /// Student ID: 21817368
        /// </summary>
        /// <param name="args"></param>


        //attributes of BodyMassIndex Class
        private double weight, height, BMI;
        private int measureUnit;
        // if measureunit=1 then the patient prefers the metric sytem
        // if the measureUnit=2 then the patient prefers the Imperial system

        /// <summary>
        /// Prompts the user for weight and height
        /// data is collected as a string before being converted and returned
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public double getInput(string prompt)
        {
            string input;
            Console.Write(prompt);
            input = Console.ReadLine();
            return Convert.ToDouble(input);
        }


        /// <summary>
        /// Utilises the measureUnit attribute to give the patient a custom
        /// question before collect the data for the BMI calculations
        /// </summary>
        public void getDetails()
        {
            string weightUnit, heightUnit;
            if (measureUnit == 1)
            {
                weightUnit = "kg";
                heightUnit = "metres";
            }
            else
            {
                weightUnit = "pounds";
                heightUnit = "inches";
            }
            weight = getInput("Please enter your weight (" + weightUnit + ") : ");
            height = getInput("Please enter your height (" + heightUnit + ") : ");
        }


        /// <summary>
        /// Displays the welcome text to the patient and the options available
        /// </summary>
        public void displayMenu()
        {
            Console.WriteLine("Welcome to Godfrey's BMI Calculator");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Metric (Kilogram and Metres)");
            Console.WriteLine("2. Imperial (Pounds and Inches)");
            Console.Write("Choose your measurment system: ");
        }


        /// <summary>
        /// Collects the Measurment selection from the patient. if a value other
        /// than 1 or 2 is entered. The patient is asked to re-enter a new option
        /// from the menu provided.
        /// </summary>
        public void getMenuChoice()
        {
            string inputString;
            bool exitLoop = true; // This boolean flag is used to exit the do...while loop
            do
            {
                inputString = Console.ReadLine();
                measureUnit = Convert.ToInt32(inputString);
                if (measureUnit == 1)
                {
                    Console.WriteLine("Metric units selected.");
                    exitLoop = false;
                }
                else if (measureUnit == 2)
                {
                    Console.WriteLine("Imperial units selected.");
                    exitLoop = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Error! ");
                    Console.WriteLine("Value must be either 1 or 2");
                    Console.Write("Select your option from the Menu above: ");
                }
            } while (exitLoop);
        }


        /// <summary>
        /// Calculates the BMI of the user. The method chooses the a different
        /// algorithm to calculate the BMI depending on the measureUnit attribute
        /// </summary>
        public void calcBMI()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Godfrey's BMI Calculator");
            Console.WriteLine("===================================");
            Console.WriteLine("       ...Calculating BMI....");
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);

            if (measureUnit == 1)
            {
                BMI = weight / (height * height);
            }
            else
            {
                BMI = weight * 703 / (height * height);
            }
        }


        /// <summary>
        /// This method displays the custom result for the patient
        /// depending on the value of their BMI
        /// </summary>
        public void displayResults()
        {
            Console.WriteLine("Your Body Mass Index: " + BMI.ToString("0.00"));
            if (BMI < 18.5)
            {
                Console.WriteLine("BMI ranking: less than 18.5");
                Console.Write("You are    ...Underweight");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("BMI Ranking: 18.5 up to 25");
                Console.Write("You are    ...Desirable weight for size");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("BMI Ranking: 25 up to 30");
                Console.Write("You are    ...Overweight");
            }
            else if (BMI >= 30 && BMI < 40)
            {
                Console.WriteLine("BMI Ranking: 30 up to 40");
                Console.Write("You are    ...Obese");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("BMI Ranking: 40 or over");
                Console.Write("You are    ...Severly Obese");
            }
        }

    }
}