using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter, then the third number and press enter:");

            // declare four integer variables
            int n1, n2, n3, sum;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these three numbers
            sum = n1 + n2 + n3;

            // print a message along with the sum of the three numbers
            Console.WriteLine("The sum of those three numbers is");
            Console.WriteLine(sum);

            int product = n1 * n2 * n3;
            Console.WriteLine("The product of those three numbers is");
            Console.WriteLine(product);

            int quotient = sum / product;
            Console.WriteLine("The sum / product of those three numbers is");
            Console.WriteLine(quotient);

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}