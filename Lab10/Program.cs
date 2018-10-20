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
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Circle Tester");

            Console.Write("Enter radius: ");
            Validator check = new Validator(Console.ReadLine());
            

            Circle myCircle = new Circle(check.DoValidation());

            string formattedArea = myCircle.CalculateFormattedArea();
            string formattedCircum = myCircle.CalculateFormattedCircumference();
            Console.WriteLine("The area is {0} and the circumference is {1}",
                formattedArea, formattedCircum);
            Console.ReadLine();
        }

    }
}
