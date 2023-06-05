internal class Program
{
    private static void Main(string[] args)
    {

        //for( int i = 0; i < 20; i++)
        //{



        //    for( int j = 0; j < 50; j++) 
        //    {


        //         Console.Write("*");



        //    }

        //    Console.WriteLine("*");

        //} 



        //int a = 1;
        //a += 2;

        //Console.WriteLine(a+=3); //a= a + 3
        //Console.WriteLine(++a);

        Console.Write("Enter the factorial value : ");
        int a = Convert.ToInt32(Console.ReadLine());

        int i;
        int g;

        for (i=0; i > a; a--) 
        {
           g = g - 1;
           Console.WriteLine(g);
           a = a * g;

           
            
            
            
        }
        
        Console.WriteLine(a);
        

        
    }
}