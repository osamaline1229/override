using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[] a = { 9, 2, 3, 8, 5, 6, 7 };

        //double sum = 0;
        //double avg = 0;
        //for(int i  = 0; i < a.Length; i++)
        //{
        //    sum = sum + a[i];

        //}
        //avg = sum / a.Length;
        //Console.WriteLine("the average of array : "+avg);

        ////////////////////////////////////////////////////////////


        //int[] array = new int[] { 1, 5, 7, 4, -5 };

        //int max = array.Max();
        //Console.WriteLine(max);
        

        /////////////////////////////////////////////////////////////
        
        //int[] array1 = new int[] { 1, 5, -1, 16, -5 };

        //int min = array1.Min();
        //Console.WriteLine(min);

        ////////////////////////////////////////////////////////////

        //int size;
        //int oddSum = 0, evenSum = 0;

        //Console.WriteLine("Enter the size of the array:");
        //size = Convert.ToInt32(Console.ReadLine());

        //int[] arr = new int[size];

        //Console.WriteLine("Enter the array values:");
        //for (int i = 0; i < size; i++)
        //{
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //for (int i = 0; i < size; i++)
        //{
        //    if (arr[i] % 2 == 0)
        //    {
        //        evenSum += arr[i];
        //    }
        //    else
        //    {
        //        oddSum += arr[i];
        //    }
            
        //}
        //Console.WriteLine("Even Sum: " + evenSum + " Odd Sum: " + oddSum);

        /////////////////////////////////////////////////////////////////////////////
        
        Public static int FibonacciSeries(int n)
        {
            if (n == 0 || n == 1) retern n;
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
            
        }


    }
}
