using ClassLibrary1;
using classlibrary;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Class1 learn = new Class1();
        Console.WriteLine(learn.name);
        learn.surname();

        Program print = new Program();
        Console.WriteLine(print.a);
        Program.cou();


    }
}