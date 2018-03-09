using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp_Part_5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Working on Strings functions now

            string sampleString = "A bunch of random words";

            // so what is happening here is we are using an Object called String to check
            // if the string we created above is empty or NULL
            Console.WriteLine("is empty " + String.IsNullOrEmpty(sampleString));

            // We can also check if the string is Null or contains only whitespace
            Console.WriteLine("is empty " + String.IsNullOrWhiteSpace(sampleString));

            // and of course we can get the length of a string
            Console.WriteLine("String length " + sampleString.Length);

            // Here we are searching for the index at which the word "bunch" is found. Neat-o.
            Console.WriteLine("Index of bunch " + sampleString.IndexOf("bunch"));

            // .Substring allows us to break out a part of the current string into a...sub string
            Console.WriteLine("2nd word " + sampleString.Substring(2, 6));


            string sampleString2 = "More random words";

            // comparing two strings
            Console.WriteLine("String Equal " + sampleString.Equals(sampleString));

            // seeing if a string starts with certain characters/words
            Console.WriteLine("Starts with \"A bunch\" " + sampleString.StartsWith("A bunch"));

            // and seeing if a string ends with certain characters/words
            Console.WriteLine("Ends with \"words\" " + sampleString.EndsWith("words"));

            // We can trim the whitespace using Trim(), as well as TrimEnd(), and TrimStart()
            sampleString = sampleString.Trim();

            // Searching for a word and replacing it with another? I see you C#.
            sampleString = sampleString.Replace("words", "characters");

            // removes indices from the string (start, stop) kind of deal
            sampleString = sampleString.Remove(0, 2);


            // String ARRAY
            string[] names = new string[3] { "Matt", "Joe", "Paul" };

            Console.WriteLine("Name List " + String.Join(", ", names));


            // Now on to FORMATTING //

            // Okay, so we know {0} is like a place holder, with the addition of ":c" making it {0:c}
            // that lets the system know this should be formatted as currency.

            // so the number to the left of the colon notates which agrument/paraneter/value is going to 
            // be stored in this position. AS we can see this is 0 based.
            // Then we tell the system we want 2 zeros before and after the decimal point.
            // With the number given, this will result in the loss of .007 making the value now 15.56

            // The # represents that there could be a zero placed here, or not. It depends on the value given.

            // The last placeholder gives the formatting for thousands, like 15,000. It just adds a comma.
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);

            Console.WriteLine(fmtStr);

        }
    }
}
