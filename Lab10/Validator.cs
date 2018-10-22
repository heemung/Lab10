using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validator
    {
        public Validator(string s)
        {
            GetUserData = s;
        }

        public string GetUserData { get; set; }


        public static bool parseTest;
        public double outPutNum;

        //catches 
        public double DoValidation()
        {
            parseTest = false;
            //Try parse will continue unless try parse double is false.
            //if statment wants a number greater than 0, returns double.
            while (!parseTest)
            {
                try
                {
                    parseTest = double.TryParse(GetUserData, out outPutNum);
                    if (outPutNum <= 0)
                    {
                        Console.WriteLine("Enter a number greater than 0\n");
                        Console.Write("Enter radius: ");
                        parseTest = false;
                        GetUserData = Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return outPutNum;
        }
    }
}
