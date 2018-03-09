using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Learning_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // So it this is outputing "Hello World" to the screen/console.
            // write line will add the \n or endl after the output.
            Console.WriteLine("Hello World");


            // now the video is showing how to get some input from the user
            // as I stated earler, WriteLine adds a \n, so we want to use just Write
            Console.Write("What is your name?");
            
            // Then we are creating a string to store the user input, simple enough.
            string name = Console.ReadLine();

            // Here we see you can just slap in a variable with the + sign for output. Pretty Neat.
            Console.WriteLine("Hello " + name);


        }
    }
}
