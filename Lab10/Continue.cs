using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Continue
    {
        public Continue(string s)
        {
            StringCont = s;
        }
        public string StringCont { get; set; }

        public bool AnswerValid()
        {
            Console.WriteLine("Do you wish to continue? 'yes' / 'no'");
            StringCont = Console.ReadLine().ToLower();
            while (true)
            {

            if (StringCont == "yes")
                {
                    return true;

                }
            else if(StringCont == "no")
                {
                    return false;
                }
            else
                {
                    Console.WriteLine("Please enter either 'yes' or 'no'");
                    StringCont = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
