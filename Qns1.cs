using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionH
{
    class Qns1
    
    {
       
        public static int ReadInteger(string message)
        {
            bool IsParseDone;
            int userinput;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                IsParseDone = Int32.TryParse(input, out userinput);
            }
            while (IsParseDone == false);
           

            return userinput;
        }
    }
}
