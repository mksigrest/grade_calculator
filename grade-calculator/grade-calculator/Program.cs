/*
 * Max Sigrest
 * IGME 201, tue/thur 8:00 am
 * October 7th, 2025
 */

using System.ComponentModel.DataAnnotations;

string name = "Max Sigrest";
int[] grades = new int[10];
grades[0] = 100;
grades[1] = 92;
grades[2] = 87;
grades[3] = 200;
grades[4] = -20;
grades[5] = 52;
grades[6] = 82;
grades[7] = 75;
grades[8] = 67;
grades[9] = 88;
float average = 0;

Console.WriteLine("Welcome " + name);
Console.WriteLine("Here are your grades: ");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(grades[i]);
    if (grades[i] >= 90 && grades[i] <= 100)
    {
        Console.WriteLine("This grade is an A!");
        if (grades[i] == 100)
        {
            Console.WriteLine("WOW! A perfect score!");
        }
    }
    else if (grades[i] >= 80 && grades[i] < 90)
    {
        Console.WriteLine("This grade is an B");
    }
    else if (grades[i] >= 70 && grades[i] < 80)
    {
        Console.WriteLine("This grade is an C");
    }
    else if (grades[i] >= 65 && grades[i] < 70)
    {
        Console.WriteLine("This grade is an D");
    }
    else if (grades[i] >= 0 && grades[i] < 65)
    {
        Console.WriteLine("This grade is an F");
    }
    else
    {
        Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
    }

    average += grades[i];
}

average = (average / 10);
Console.WriteLine("Your final calculated average is: " + average);
Console.WriteLine("We have displayed all grades for " + name);