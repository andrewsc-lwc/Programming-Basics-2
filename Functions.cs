using System;

public class Functions
{
	public Functions()
	{
        Console.WriteLine("What is the first number you want to add");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the second number you want to add");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        int answer = Add2Numbers(firstNumber, secondNumber);
        Console.WriteLine(firstNumber + " + "+ secondNumber + " = " + answer);

        Console.WriteLine("What is the freezing point of water");
        int answerCheck = Convert.ToInt32(Console.ReadLine());
        bool myAnswer = Accurate(answerCheck);
        Console.WriteLine(myAnswer);
	}
	//<visibility> <return type> <name>(<parameters>)

	private bool Accurate(int test)
    {
        bool answer;
		if (test == 0)
        {
			answer = true;
        }
        else
        {
            answer = false;
        }
        return answer;
    }



    private int Add2Numbers(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
}
