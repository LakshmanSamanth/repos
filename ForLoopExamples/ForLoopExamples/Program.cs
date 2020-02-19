using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is  * pattern............
            //for (int i = 0; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++) 
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();

            //}


            //pattern two.......
            //int k = 1;
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}", k++);

            //    }
            //    Console.WriteLine("\n");

            //}



            //Pattern 3:
            int[][] arr = new int[3][];
            arr[0] = new int[2] { 1, 2 };
            arr[1] = new int[3] { 1, 2, 3 };
            arr[2] = new int[2] { 5, 7 };

            Console.WriteLine("elements in array...");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + "  ");

            //    }
            //    Console.WriteLine();

            //}

            //Pattern 4:
            string[][] str = new string[3][];
            str[0] = new string[3] { "dotnet", "C", "Csharp" };
            str[1] = new string[2] { "java", "Cpp"};
            str[2] = new string[3] { "php", "python", "SQL" };

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < str[i].Length; j++)
            //    {
            //        Console.Write(str[i][j] + " ");

            //    }
            //    Console.WriteLine();

            //}


            // even numbers:
            //for (int i = 1; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

                

            //}
            Console.WriteLine("\n");
            //for (int i = 1; i < 10; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Sum of ten numbers....
            //int x = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    x = x + i;

            //}
            //Console.WriteLine("Sum of 10 num..");
            //Console.WriteLine(x);

            // Print the patytern..............
            //Get input from keyboard
            //int rows ;
            //rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("............................................");
            //Console.WriteLine("1");
            //Console.WriteLine("2 3");
            //Console.WriteLine("4 5 6");
            //int r, kk = 1;

            //r = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < r; i++)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write(kk++);
            //    }
            //    Console.Write("\n");


            //}




            // Equlateral triangle......numbers
            //Console.WriteLine("Equalateral triangle with Numbers...");
            //int rr, kk, t = 1;
            //rr = Convert.ToInt32(Console.ReadLine());

            //int spc = rr + 4 - 1;
            //for (int i = 1; i <= rr ; i++)
            //{
            //    for ( kk = spc; kk>=1; kk++)
            //    {
            //        Console.WriteLine("  ");
            //    }

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.WriteLine(t++);
            //    }
            //    spc--;

            //}

            //Equlateral triangle...... stars
            Console.WriteLine("Equilateral triangle with stars..");
            int i, j, rows, spc, k;
            rows = Convert.ToInt32(Console.ReadLine());
            spc = (rows+1)/2;
            for ( i = 1; i <= rows ; i++)
            {
                for ( k = spc; k>1; k--)
                {
                    Console.Write("  ");
                }

                for ( j = 0; j < i; j++)
                
                    Console.Write("*");
                    Console.Write("\n");
                
                spc--;

            }


































        }
    }
}
