using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp_Part_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's talk about Lists

            // Like an array but when you add data it will resize automatically
            List<int> numList = new List<int>();

            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

            // can add an array to lists, just make sure its the same data type
            int[] randArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray);

            // can use numList.Clear() to empty out a list, when needed

            // can initialize a list with an array
            List<int> numList2 = new List<int>(randArray);

            // just another method to do the previous comment
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            // you can also insert into a list at a specific index
            numList.Insert(1, 10);

            // this will remove the value 5 from the list
            numList.Remove(5);

            // and you can remove at a specific index
            numList.RemoveAt(2);

            // iterating through the list. To get the size of the list we use .Count
            for(int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            // returning the index at which a given value is at
            Console.WriteLine("4 is in Index " + numList3.IndexOf(4));

            // checking to see if a given value is in a list can be done as well
            Console.WriteLine("5 in List " + numList.Contains(5));

            // strings lists can be done also
            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });

            // we can search for lowercase by using StringComparer.OrdinalIgnoreCase
            Console.WriteLine("Tom in list " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            // a list can sort on its own..
            strList.Sort();


        }
    }
}
