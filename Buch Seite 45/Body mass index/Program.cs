using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_mass_index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body Mass Index (BMI) Calculator");
            Console.WriteLine("---------------------------------");

            Console.Write("Enter your weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine()); //defining and declaring weight variable with user input

            Console.Write("Enter your height in meters: ");
            double height = double.Parse(Console.ReadLine());//defining and declaring hight variable with user input

            double bmi = CalculateBMI(weight, height);//using function
            Console.WriteLine($"Your BMI is: {bmi}");//output result

            //output categories
            Console.WriteLine("BMI Categories:");
            Console.WriteLine("Underweight: BMI < 18.5");
            Console.WriteLine("Normal weight: 18.5 <= BMI < 25");
            Console.WriteLine("Overweight: 25 <= BMI < 30");
            Console.WriteLine("Obesity: BMI >= 30");

            Console.ReadLine(); // So that the console doesn't close immediately
        }

        static double CalculateBMI(double weight, double height) //created function to do the math
        {
            return weight / (height * height);
        }
    }
}