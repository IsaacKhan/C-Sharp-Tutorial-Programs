using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp_Part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Builder(?) //
            // Used to edit a string without making a new string

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1}", "Isaac", "Mississippi");

            // sb.Clear() will clear the contents of the string

            // this will replace every letter a with the letter e
            sb.Replace("a", "e");

            // This will remove whatever is at index 5 to index 7
            sb.Remove(5, 7);

            // Since sb is not a string we need to convert using ToString() so that we can output the data.
            Console.WriteLine(sb.ToString());


            // Arrays! //

            // Simple declaration, but in C++ the [] are usually after the variable name.
            int[] randNumArray;

            // Previous comment is probably because its more like Java, If I remember correctly.
            int[] randArray = new int[5];

            // of course we can initialize an array like this
            int[] randArray2 = { 1, 2, 3, 4, 5 };

            // and now for some printing to see the data.
            Console.WriteLine("Array Length " + randArray2.Length);

            Console.WriteLine("Item 0 " + randArray2[0]);

            // iterating through the arry to print out the values at each index
            for(int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, randArray2[i]);
            }

            // can also use foreach for the same thing
            foreach(int num in randArray2)
            {
                Console.WriteLine(num);

            }

            // finding the index of a specific item
            Console.WriteLine("Where is 1 " + Array.IndexOf(randArray2, 1));

            string[] names = { "Tom", "Paul", "Sally" };

            // turning this string array into an string
            string nameStr = string.Join(", ", names);

            // and turing a string into an string array
            string[] nameArray = nameStr.Split(',');


            // multi-diementional array

            // going with a 2d array, a 5 by 3
            int[,] multArray = new int[5, 3];

            // a more visual initialization
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach(int num in multArray2)
            {
                Console.WriteLine(num);
            }

            for(int i = 0; i < multArray2.GetLength(0); i++)
            {
                for(int j = 0; j < multArray2.GetLength(1); j++)
                {
                    Console.WriteLine("{0} | {1} : {2}", i, j, multArray2[i,j]);
                }
            }

        }
    }
}
