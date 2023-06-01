internal class Program
{
    private static void Main(string[] args)
    {
        int a = 6;
        int b = 9;
        a = a * b;
        b = a / b;
        a = a / b;
        
        Console.WriteLine("a = "+a +" b = "+b);

        String h = "Hello";
        String j = "world1234";
        h = h + j;
        j = h.Substring(0, h.Length - j.Length);
        h = h.Substring(j.Length);

        
        Console.WriteLine("h = " + h + " and j = " + j);

    }
}