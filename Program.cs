using System;

namespace Programming_Basics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Iteration();

            int a = 1;
            int b = 2;
            int c = 3;
            if ((a > b) && (a > c)){
                Console.WriteLine("A is largest");
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("B is largest");
            }
            else
            {
                Console.WriteLine("C is largest");
            }

            if ((a > b) || (a > c))
            {
                Console.WriteLine("A is not the smallest");
            }
            else if ((b > a) || (b > c))
            {
                Console.WriteLine("B is not the smallest");
            }
            else
            {
                Console.WriteLine("C is not the smallest");
            }

            if (!(a == b))
            {
                Console.WriteLine("I DON'T EVEN KNOW WHAT THIS MEANS.");
            }

            //Class1 myObject = new Class1();

            //int answer;
            //Console.WriteLine("What is your answer?");

            //try
            //{
            //    answer = Convert.ToInt32(Console.ReadLine());
            //}
            //catch{
            //    answer = 99;
            //}
            //finally
            //{
            //    Console.WriteLine("Coming up with an answer");
            //}



            //switch (answer)
            //{
            //    case 1:
            //        Console.WriteLine("Hello");
            //        break;
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Bob");
            //        break;
            //    case 99:
            //        Console.WriteLine("Not a Number");
            //        break;
            //    default:
            //        Console.WriteLine("Help");
            //        break;
            //}

            //string month;
            //string lowerMonth;
            //string firstThreeMonth;
            //int daysInMonth = 1;
            //Console.WriteLine("What Month do you want to know the days for?");
            //month = Console.ReadLine();
            //lowerMonth = month.ToLower();
            //firstThreeMonth = lowerMonth.Substring(0, 3);
            //Console.WriteLine(firstThreeMonth);
            //switch (month)
            //{
            //    case "jan": case "mar": case "may":
            //        daysInMonth = 31;
            //        break;
            //    case "apr": case "sep":
            //        daysInMonth = 30;
            //        break;

            //}
            //Console.WriteLine(daysInMonth);


            //Console.WriteLine("What is your name?");
            ////wait for user input
            ////Assign value to variable myName
            //string myName = Console.ReadLine();
            //Console.WriteLine("Hello " + myName);

            //int number = 65;
            //float distance = 5.65f;
            //bool correct = true;
            //char letter = 'r';
            //string word = "Hello";

            //int number1 = 17;
            //int number2 = 12;
            //double result;
            //result = number1 / number2;
            //Console.WriteLine(result);
            //Console.WriteLine(17d / 12d);
            //result = Convert.ToDouble(number1) / Convert.ToDouble(number2);
            //Console.WriteLine("Different"+result);

            //Console.WriteLine(Math.Pow(6.435, 2));//Power
            ////Round             Math.Round
            ////Floor division... Math.Floor
            ////Mod...            %

            //string myWord = "A long string";
            //Console.WriteLine(myWord.Length);
            //Console.WriteLine(myWord.Contains("ong"));
            //Console.WriteLine(Convert.ToChar(97));
            //Console.WriteLine(Convert.ToInt32('a'));
            //Console.WriteLine(Convert.ToInt32('7'));

            //DateTime date1 = new(1984,9,3);
            //Console.WriteLine(date1);
        }
    }
}
