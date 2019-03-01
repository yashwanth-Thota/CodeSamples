using System;
class ATM
{
    public static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int requestedAmount = int.Parse(inputs[0]);
        decimal availableBalance = decimal.Parse(inputs[1]);
        if(availableBalance<requestedAmount || requestedAmount%5!=0)
        {
            Console.WriteLine(availableBalance);
        }
        else
        {
            Console.WriteLine(availableBalance-requestedAmount-0.50M);
        }
        Console.ReadKey();
    }
}