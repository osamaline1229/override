using System;
using System.Collections.Generic;

public class SumofRowColumn
{
    public static void Main()
    {
        //int rows, cols, sumRow, sumCol;

        ////Initialize a  
        //int[,] a = {
        //                {1, 2, 3},
        //                {4, 5, 6},
        //                {7, 8, 9}
        //           };

        ////Calculates number of rows and columns present in given   
        //rows = a.GetLength(0);
        //cols = a.GetLength(1);

        ////Calculates sum of each row of given 
        //for (int i = 0; i < rows; i++)
        //{
        //    sumRow = 0;
        //    for (int j = 0; j < cols; j++)
        //    {
        //        sumRow = sumRow + a[i, j];
        //    }
        //    Console.WriteLine("Sum of " + (i + 1) + " row: " + sumRow);
        //}

        ////Calculates sum of each column of given 
        //for (int i = 0; i < cols; i++)
        //{
        //    sumCol = 0;
        //    for (int j = 0; j < rows; j++)
        //    {
        //        sumCol = sumCol + a[j, i];
        //    }
        //    Console.WriteLine("Sum of " + (i + 1) + " column: " + sumCol);
        //}

        //  int i, j, n;
        //  int[,] arr1 = new int[20, 20];
        //  int[,] arr2 = new int[20, 20];
        //  int[,] arr3 = new int[20, 20];
        //  // setting matrix row and columns size
        //  n = 3;
        //  Console.Write("Enter elements in the first matrix:");
        //for (i = 0; i < n; i++)
        //  {
        //      for (j = 0; j < n; j++)
        //      {
        //          arr1[i, j] = Convert.ToInt32(Console.ReadLine());
        //      }
        //  }
        //  Console.Write("Enter elements in the second matrix:");
        //for (i = 0; i < n; i++)
        //  {
        //      for (j = 0; j < n; j++)
        //      {
        //          arr2[i, j] = Convert.ToInt32(Console.ReadLine());
        //      }
        //  }
        //  Console.Write("First matrix is:");
        //for (i = 0; i < n; i++)
        //  {
        //      Console.Write("");
        //   for (j = 0; j < n; j++)
        //          Console.Write("{0}\t", arr1[i, j]);
        //  }
        //  Console.Write("Second matrix is:");
        //for (i = 0; i < n; i++)
        //  {
        //      Console.Write("");
        //   for (j = 0; j < n; j++)
        //          Console.Write("{0}\t", arr2[i, j]);
        //  }
        //  for (i = 0; i < n; i++)
        //      for (j = 0; j < n; j++)
        //          arr3[i, j] = arr1[i, j] + arr2[i, j];
        //  Console.Write("Adding two matrices: ");
        //for (i = 0; i < n; i++)
        //  {
        //      Console.Write("");
        //   for (j = 0; j < n; j++)
        //          Console.Write("{0}\t", arr3[i, j]);
        //  }
        //  Console.Write("");


        /////////////////////////get the sum of whole code and print the maximum value///////////////////////

        //double[,] array = new double[,] {
        //                                  {7, 3, 4},
        //                                  {3, 44, 9},
        //                                  {3, 7, 10},
        //                                };

        //double sum = array.Cast<double>().Sum();
        //double max = array.Cast<double>().Max();
        //double min = array.Cast<double>().Min();
        //Console.WriteLine("the sum is :"+sum);
        //Console.WriteLine("the minimum is :" + min);
        //Console.WriteLine("the maximum is :" + max);

        static void Main()
        {
            double sum = 0, avg = 0;
            double[] numbers = { 10, 20, 50, 40 };
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);

        }





    }

}



