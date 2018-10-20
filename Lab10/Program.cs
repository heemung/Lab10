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

            while (userCont)
            {
                Console.Write("Enter radius: ");
                Validator check = new Validator(Console.ReadLine());


                Circle myCircle = new Circle(check.DoValidation());

                string formattedArea = myCircle.CalculateFormattedArea();
                string formattedCircum = myCircle.CalculateFormattedCircumference();
                Console.WriteLine("The area is {0} and the circumference is {1}",
                    formattedArea, formattedCircum);
                Continue willCont = new Continue("temp");
                userCont = willCont.AnswerValid();
                countProgramRun++;
            }
            Console.WriteLine("\nGoodbye: You created {0} Circle object(s).", countProgramRun);
            Console.ReadLine();
        }

    }
}
