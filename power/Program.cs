using System.Globalization;

internal class Program
{
    static void Main (string[] args)
    {
        System.Console.WriteLine( power(3, 3));

    }

    static int calculateFib(int n)
    {
        int secondLastTerm = 0;
        int lastTerm = 1;
        int nextTerm = 0;

        for (int i = 2; i <= n; i++)
        {
            nextTerm = lastTerm + secondLastTerm;
            secondLastTerm = lastTerm;
            lastTerm = nextTerm;
        }
        return nextTerm;
    }

    static int power(int num, int pow)
    {
        if(pow == 0)
        {
            return 1;
        }
        if (pow == 1)
        {
            return num;
        }
        return num * power(num, pow - 1);

    }
}