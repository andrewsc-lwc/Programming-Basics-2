using System;

namespace Programming_Basics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            //wait for user input
            //Assign value to variable myName
            string myName = Console.ReadLine();
            Console.WriteLine("Hello " + myName);

            int number = 65;
            float distance = 5.65f;
            bool correct = true;
            char letter = 'r';
            string word = "Hello";

            float number1 = 17;
            float number2 = 12;
            double result;
            result = number1 / number2;
            Console.WriteLine(result);
            Console.WriteLine(17d / 12d);
        }
    }
}
