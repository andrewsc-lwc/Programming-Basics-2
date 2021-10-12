using System;

public class Functions
{
	public Functions()
	{
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
}
