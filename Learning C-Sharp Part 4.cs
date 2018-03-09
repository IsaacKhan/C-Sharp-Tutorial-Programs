using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp_Part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // let talk loops.


            // WHILE LOOP


            int i = 0;

            // so far so good.
            while (i<10)
            {
                // check if i is 7
                if(i==7)
                {
                    i++;
                    continue;
                }

                // check if i is 9
                if(i==9)
                {
                    break;
                }

                // check if i is odd. Even numbers would have no remainder.
                if( (i%2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            }


            // DO WHILE

            string guess;

            do
            {
                Console.WriteLine("Guess a Number");
                guess = Console.ReadLine();

                // This says while the variable "guess" is NOT equal to 15, continue looping
                // Interesting that this is the way to compare as opposed to C++ style
            } while (!guess.Equals("15"));


            // FOR 

            for (int j = 0; j < 10; j++)
            {
                if( j%2 > 0)
                {
                    Console.WriteLine(j);
                }
            }

            // FOR EACH

            string randString = "Here are some random characters";

            // So this is new to me, but it basically loops through a collection of data,
            // and in this case it is going to print out each character within the string randString.
            foreach(char c in randString)
            {
                Console.WriteLine(c);
            }


        }
    }
}
