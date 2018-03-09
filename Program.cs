using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // got some variables going...

            // basic boolean
            bool canVote = true;

            // basic char 
            char grade = 'A';

            // the following are basic numeric variables, but just doing these anyway for practice.
            // It is cool that you can set a variable to its max value like this. Not sure if something
            // like this is in C++, but I don't see why there wouldn't be. I probably just didn't learn about it.
            int maxInt = int.MaxValue;
            long maxLong = long.MaxValue;

            // I can't recall if there is something similar to deciaml in C++...
            // decimal is pretty big, but BigInteger is even BIGGER
            decimal maxDec = decimal.MaxValue;

            // Float has precision of 7 while Double has recision of 15
            float maxFloat = float.MaxValue;
            double maxDouble = double.MaxValue;

            // Now I'm just going to print out the values for fun/reference.
            Console.WriteLine("Max Int = " + maxInt);
            Console.WriteLine("Max Long = " + maxLong);
            Console.WriteLine("Max Double = " + maxDouble);
            Console.WriteLine("Max Float = " + maxFloat);
            Console.WriteLine("Max Decimal = " + maxDec);

            // So a var is a variable who's data type is determined once it is assigned something at complie time.
            // Afterwards, its value can't be changed, which is pretty cool.
            var anotherName = "Tom";

            // commenting out this line, but it shows that this would give an error.
            // anotherName = 2;

            // so {0} is like a place holder for the next agrument, which in this case, going to be
            // the variable type String. Also Cool.
            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());

        }
    }
}
