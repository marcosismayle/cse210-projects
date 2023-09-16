using System;

class Program
{
    static void Main(string[] args)
    {
        ///Ask the user for a grade percentage

        Console.Write("Please, enter grade percentage: ");
        string input = Console.ReadLine();

        int gradePercentage = int.Parse(input);

        ///Create the variable for the letter
        
        string letterGrade;

        ///Determine the letter grade

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        ///Determine the sign
        
        string sign;
        
        if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }

        else if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        ///Setting the sign properly
        
        if (gradePercentage >= 97 || gradePercentage < 60)
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letterGrade}{sign}");

        ///Determine if the student pass or not

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulation, you pass.");
        }

        else
        {
            Console.WriteLine("Sorry, you didn't pass.");
        }
    }
}