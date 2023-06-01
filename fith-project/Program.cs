internal class Program
{
    private static void Main(string[] args)
    {
        
        for( int i = 0; i < 5; i++)
        {
            
            

            for( int j = 0; j < 8; j++) 
            {
                if(i == j)
                {
                    Console.Write("*");
                }
                
            
            }

            Console.WriteLine("*");
        
        } 
        
    }
}