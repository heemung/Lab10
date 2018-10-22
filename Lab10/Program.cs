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
            bool userCont = true;
            int countProgramRun = 0;
            Console.WriteLine("Welcome to the Circle Tester");

            //user continue loop but this one counts how many times looped by 
            //countProgramRun incerements
            while (userCont)
            {
                Console.Write("Enter radius: ");

                //validator checks to see if the user enter number greater than 0 
                //and returns a double
                Validator check = new Validator(Console.ReadLine());

                //passes in the check do validation method that returns a double.
                Circle myCircle = new Circle(check.DoValidation());

                //sets the caluateion formats methods from circle class to strings
                string formattedArea = myCircle.CalculateFormattedArea();
                string formattedCircum = myCircle.CalculateFormattedCircumference();

                //Prints answer 
                Console.WriteLine("The area is {0} and the circumference is {1}",
                    formattedArea, formattedCircum);
                //Class that passes in a string for some reason, bad design.
                //returns bool, and will exit if false
                Continue willCont = new Continue("temp");
                userCont = willCont.AnswerValid();

                //counts how many times program runs
                countProgramRun++;
            }
            Console.WriteLine("\nGoodbye: You created {0} Circle object(s).", countProgramRun);
            Console.ReadLine();
        }

    }
}
