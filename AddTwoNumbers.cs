using System;
class AddTwoNumbers
{
    public static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        string output = "";
        while (testCases > 0)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            output += int.Parse(inputNumbers[0])+int.Parse(inputNumbers[1])+"\n";
            testCases--;
        }
        Console.WriteLine(output);
        Console.ReadKey();
    }
}