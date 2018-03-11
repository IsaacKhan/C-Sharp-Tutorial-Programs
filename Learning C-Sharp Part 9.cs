using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnng_C_Sharp_Part_9
{
    // Now we're doing big boy work, Classes!

    class Animal
    {
        // C# can make getters and setters like this, which is pretty neat. Makes things easier for sure.
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        // and of course we can make our own getters and setters.
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructors //

        // Normally the default constructor will be created automatically, but we can make our own, as seen here
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";

            // This would be how we increment our tracker for this, or any, objects.
            numOfAnimals++;
        }

        // what if we want to track how many objects of Animal have been created? Static Fields.
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;

            // This would be how we increment our tracker for this, or any, objects.
            numOfAnimals++;
        }

        // This variable will be accessable and shared between all instances of animal created ever.
        static int numOfAnimals = 0;

        // This is the static method used to get the value (or get access to) numOfAnimals.
        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weights {2} lbs, and likes to say {3}.", name, height, weight, sound);
        }

        // Here we are doing some function overloading. This works as long as the data types aren't the same
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }
        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }


        static void Main(string[] args)
        {
            // Creating some stuff so we can get some output
            Animal spot = new Animal(15, 10, "Spot", "Woof");

            Console.WriteLine("{0} says {1}", spot.Name, spot.sound);

            // Here we are getting the number of Animal Objects, so we need to call the CLASS Animal
            // Not the OBJECT Spot, because the method getNumOfAnimals is a part of the class, not the object.
            Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());

            // Calling our function to print out a description of our Animal Spot
            Console.WriteLine(spot.toString());

            // Calling our overloaded Functions on Spot, who is an animal that can do addition. So Smart!
            Console.WriteLine(spot.getSum(1, 2));
            Console.WriteLine(spot.getSum(1.5, 3.2));

            // Can also pass in values in the incorrect order
            Console.WriteLine(spot.getSum(num2: 1, num1: 2));

            // Can also create object using what is called the Object Initializer, as follows
            Animal grover = new Animal
            {
                height = 16,
                weight = 18,
                name = "Grover",
                sound = "Grrrr"
            };

            // creating our new object.
            Dog spike = new Dog();

            // printing out the base info.
            Console.WriteLine(spike.toString());

            // and now we are giving values to Dog.
            spike = new Dog(20, 15, "Spike", "Grrrr", "Chicken");

            // andd printing out Dog again.
            Console.WriteLine(spike.toString());


            // Here the video is going to show how to use polymorphism through the use of an Abstract Class
            // So first of all we need to create some objects. Easy.
            Shape rect = new Rectangle(5, 5);
            Shape tri = new Trianlge(5, 5);

            // printing out so we can see what the results would be
            Console.WriteLine("Rect Area " + rect.area());
            Console.WriteLine("Tri Area " + tri.area());

            // using our overloaded operator to add two triangles together
            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);

            // and print the result of the above line of code
            Console.WriteLine("combRect Area " + combRect.area());

            // Now we are creating our Generic Class Object

            // same setup so far, just make sure the data types match up
            // and we can provide or not provide values, hence the "".
            KeyValue<string, string> superman = new KeyValue<string, string>("","");

            // give variables some values
            superman.key = "Superman";
            superman.value = "Clark Kent";

            // creatog another Generic Class Object
            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");

            samsungTV.key = 12345;
            samsungTV.value = "a 50inch Samsun TV";

            // displaying info on each Generic Class Object
            superman.showData();
            samsungTV.showData();


        }
    }


    // creating subclass of Animal. This class will get everything that is defined in Animal.
    class Dog : Animal
    {
        public string favFood { get; set; }

        // :base() calls the super class. Basically calls Animals constructor and takes that data and applies it
        // to the sub class Dog(). Neat!
        public Dog() : base()
        {
            // since all the other attributes are defined and assigned in Animal's contructor,
            // all we need to do is define and assign favFood.
            this.favFood = "No Favorite";
        }

        // can also create our own, as always. Here, we are also passing in what was defined in the superclass
        // so again all we need to do is assign favFood
        public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)
        {
            this.favFood = favFood;
        }

        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, weights {2} lbs, and likes to say {3} and eats {4}.", name, height, weight, sound, favFood);
        }
    }

    // Abstract Class!
    // This class with basically define the methods for the classes that are derived from it
    // it being the abstract class. Can only inherit 1 abstract class per class (?)
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }

    // Creating an Interface
    // I don't think this video is going to go too in depth about this concept, 
    // so I may look into this seperately since this sound somewhat new to me.
    public interface ShapeItem
    {
        double area();
    }

    // All that is happening here is inheritance "Ractanlge 'is a' shape"
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        // Here we have some overriding, the video glosses over this, but nothing a little bit of
        // reading won't remedy. 
        public override double area()
        {
            return length * width;
        }

        // Here we are going to be talking about operator overloading, which is cool.
        // For example, we can overload the + operator so that it can add two rectanlges together!
        public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
        {
            // all we're doing is adding the lengths and widths so that the program will
            // understand what we want it to do when we say "add these two Rectangles together!"
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            // and then we return a new Rectanlge to represent the combination of the two given rectangles
            return new Rectangle(rectLength, rectWidth);
        }
    }

    // creating another Shape subclass
    class Trianlge : Shape
    {
        private double theBase;
        private double height;

        public Trianlge(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return .5 * (theBase * height);
        }
    }

    // Now wthe video talks about Generics, which sounds like a Template Class in C++
    // Basically a class without a specificed data type.
    class KeyValue<TKey, TValue>
    {
        public TKey key {get; set;}
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1} ", this.key, this.value);
        }

    }
}
