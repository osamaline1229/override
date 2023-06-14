using addElements;
using data;
using subject;
using System.Formats.Asn1;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        student chair = new student();
        chair.work();


        database dat = new database();
        dat.order();

        addition area1 = new addition();

        addition.(area1);
        
        
    }
}


namespace addElements
{
    class addition
    {
        int area = 0;
        public void areaof(int lenght, int wieght)
        {
            area = lenght * wieght;
            Console.WriteLine(area);
        }
    }
}