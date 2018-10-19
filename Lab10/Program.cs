using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
        
        class Program
    {
        static double userInputs;
        static void Main(string[] args)
        {
            bool parseTest = false;
            Console.WriteLine("Welcome to the Circle Tester");
            while (!parseTest)
            {
                Console.Write("Enter radius: ");
                try
                {

                    parseTest = double.TryParse(Console.ReadLine(), out userInputs);
                    if(userInputs <= 0)
                    {
                        Console.WriteLine("Enter a number greater than 0\n");
                        parseTest = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            Circle myCircle = new Circle(userInputs);

            string formattedArea = myCircle.CalculateFormattedArea();
            string formattedCircum = myCircle.CalculateFormattedCircumference();
            Console.WriteLine("The area is {0} and the circumference is {1}",
                formattedArea, formattedCircum);
            Console.ReadLine();
        }

    }
}
