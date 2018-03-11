using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Delegates go here. Sounds like a new concept to me.
delegate double GetSum(double num1, double num2);


/*
 * The final topic covered in the video is File I/O. While I think this is useful to learn,
 * all the video is doing is a breif explaination as opposed to the step by step from eariler in the video.
 * Some notes would be user StreamWrite when writing TO or creating a new File for output.
 * Similar to creating an oject when you use the keyword new, etc, etc.
 * To read from a file we use StreamReader, who would have thought? 
 * 
 * That concludes these tutorials, for now, and the video I was watching!
 */

namespace Learning_C_Sharp_Part_10
{
    // Let's talk enums and Structs!
    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }

    // Structs are containers that can hold many different data types
    struct Customers
    {
        private string name;
        private double balance;
        private int id;

        // can be seen like a constructor for the struct.
        public void createCust(string n, double b, int i)
        {
            name = n;
            balance = b;
            id = i;
        }

        public void showCust()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Balance " + balance);
            Console.WriteLine("ID " + id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create a variable of the type of the enum we created, then we can assign it a value
            Temperature micTemp = Temperature.Low;

            // Here is a switch that will check and print the value of micTemp
            switch(micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;

                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;

                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;

                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }

            // Creating a Customer, which is a struct.
            Customers bob = new Customers();

            // giving the object som value and then printing those values to the screen.
            bob.createCust("Bob", 15.50, 12345);
            bob.showCust();

            // This is also called an anonymous method
            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 = "+ sum(5, 10));

            // Lambda experssions are like anonymous methods. Often used with lists.
            Func<int, int, int> getSum = (x, y) => x + y;

            Console.WriteLine("6 + 3 = " + getSum.Invoke(5, 3));
        }
    }
}
