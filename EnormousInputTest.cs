using System;
class EnormousInputTest
{
    public static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int testCases=int.Parse(inputs[0]),divisor=int.Parse(inputs[1]);
        int numberOfMulitiples = 0;
        while (testCases > 0)
        {
            int temp = int.Parse(Console.ReadLine());
            if (temp % divisor == 0) numberOfMulitiples++;
            testCases--;
        }
        Console.WriteLine(numberOfMulitiples);
        Console.ReadKey();
    }
}