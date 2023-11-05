using System;

public class FeelingActivity : Activity
{
    public FeelingActivity() : base("Feeling Activity", "This activity will help you understand better your emotions. It is similar to breathing activity. While breathing think about what you are feeling now.")
    {
    }
    public void PromptFeeling()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();
        
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Breathe in... What needs are not being met? ");
        Timer(2);
        Console.WriteLine();
        Console.Write("Breathe out...");
        Timer(3);

        while (currentTime <= futureTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in... Why do you feel this way? ");
            Timer(4);
            Console.WriteLine();
            Console.Write("Breathe out... Is there wisdom in these emotions? ");
            Timer(6);
            currentTime = DateTime.Now;
        }
    }
}