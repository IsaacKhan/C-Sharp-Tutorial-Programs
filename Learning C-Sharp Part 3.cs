using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic exampe of if statements. Nothing too different from C++.

            int age = 17;

            if( (age>=5) && (age<=7) )
            {
                Console.WriteLine("Go to elementary School");
            }
            else if( (age > 7) && (age<13) )
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }


            if( age<14 || age > 67)
            {
                Console.WriteLine("You shuoldn't work");
            }

            // This just shows that you can get the oposite of something by putting ! before it
            // That's Pretty Neat.
            Console.WriteLine("Not True " + (!true));

            // Ternary Operator...

            // so this does a compare between 16 and the value of age, and depending on that comparison,
            // the boolean canDrive will be set to true or false. This looks easy to read, but I'm sure
            // that I will forget to use this, since to me it will be clearer to use a different method.
            bool canDrive = age >= 16 ? true : false;

            // Switch Statements

            switch(age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");

                    // I'm not too sure how to feel about goto statements. I know they can make this hairy to read
                    // but in some cases it could be helpful...maybe.
                    goto Cute;
            }

            // AND the video even says they hope we don't use goto statements.
            // again, I'm just following along with this video, you can find the link back on the readme file
        Cute:
            Console.WriteLine("Toddler are Cute");
        }
    }
}
