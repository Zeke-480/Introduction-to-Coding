using System; //This is where we start

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args) //First few lessons 

          //Output and Variables
        {
            Console.WriteLine("I Like Pizza");
            Console.WriteLine("It's really good");
            Console.Write("Hey!");
            Console.WriteLine("Yows");


            //This is a comment

            Console.WriteLine("\tZeke");


            int x; //declaration
            x = 564; //initialization

            int y = 253; //declaration + initialization

            int z = x + y;

            int age = 17; //whole integer
            double height = 5.8; //decimal number
            bool alive = true; //true or false
            char symbol = '@'; //singular letter or symbols
            String name = "Zeke"; //words or phrases with multiple chatracters



            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            int exp = 12; //whole integer
            double jobs = 1.5; //decimal number

            Console.WriteLine("Wassup " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "ft");
            Console.WriteLine("Your years of education are " + exp + "!!!");
            Console.WriteLine("Your have worked in " + jobs + " places before");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            String username = symbol + name;
            Console.WriteLine("Your username is " + username);

            //Constants


            //constants = immutable values which are known at compile time 
            //            and do not change for the life of the program
            //            permanent and unchangeable 

            const double pi = 3.14159;

            //Type Casting

            //type casting = Converting a value to a different data type
            //               Useful when we accept user input (string)
            //               Different data types can do different things


            double k = 3.14;
            int b = Convert.ToInt32(k);

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            // User input 
            // Code is Console.ReadLine(); = Presents an empty space that can be filled with string data types(can store other data types if converted)

            Console.WriteLine("What is your name?");
            String zeke = Console.ReadLine();

            Console.WriteLine("Your name is " + zeke);

        }
    }
}


