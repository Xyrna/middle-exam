using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metnnen reqemleri cixartsin

            
            string digits = "";

            Console.Write("Enter any text: ");
            string msg = Console.ReadLine();

            

            foreach (var i in msg)
            {
                if (char.IsDigit(i))
                {
                    digits = digits + i;
                    
                    
                }

            }

            if (msg == "")
            {
                Console.WriteLine("Please enter any text!");
            }

            else if (digits.Length != 0)
            {
                Console.Write("The text has these digits: ");
                foreach (var k in digits)
                {

                    Console.Write(k + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Number of digits in the text: " + digits.Length);
            }

            else
            {
                Console.WriteLine("The text has no digits!");
            }
            
           

        }
    }
}
