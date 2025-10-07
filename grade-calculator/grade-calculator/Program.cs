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

Console.WriteLine("Welcome " + name);
Console.Write("Here are your grades: ");
for (int i = 0; i < 10; i++)
{
    if (i == 9)
    {
        Console.WriteLine(grades[i] + ".");
    }
    Console.Write(grades[i] + ", ");
}