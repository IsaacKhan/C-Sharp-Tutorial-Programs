using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp_Part_8
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exception Handling
            try
            {
                // going for a divide by 0 exception
                Console.Write("Divide 10 by ");
                
                // Using .Parse to convert the string data we get from the user into numeric data
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0} = {1}", num, (10 / num));
            }

            // the ex can give us extra info on the exception
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Can't Divide by Zero.");
                // This is where ex comes in. It can give us the name of the exception
                Console.WriteLine(ex.GetType().Name);
                // and here we are getting the description of this exception
                Console.WriteLine(ex.Message);
            }

            // and now we have our default exception 
            catch(Exception ex)
            {
                // just a little copy and past from the above catch function
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
