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
        public double DoValidation()
        {
            parseTest = false;
            while (!parseTest)
            {
                Console.Write("Enter radius: ");
                try
                {
                    parseTest = double.TryParse(GetUserData, out outPutNum);
                    if (outPutNum <= 0)
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
            return outPutNum;
        }
    }
}
