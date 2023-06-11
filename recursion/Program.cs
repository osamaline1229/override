internal class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        float answer2 = 0;
        //answer = fac(6);
        answer2 = pow(3, 3);
        Console.WriteLine(answer);
        Console.WriteLine("the answer is : "+answer2);
    }

    //private static int fac(int n)
    //{
    //    if (n == 1) return 1;
    //    return n * fac(n -1);
    //}

    private static float pow(float num, int power)
    {
        if (power == 1) return num;
        return num * pow(num, power - 1);
    }
}