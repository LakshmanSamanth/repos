using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKudvenkat
{
    class Program
    {

        static void Main()
        {

            int n;
            Console.WriteLine("Enter a Number:");
            n = int.Parse(Console.ReadLine());
            // To check if it is Odd Or Even........

            if (n % 2 == 0)
            { Console.WriteLine("The  entered number is Even:"); }
            else
                Console.WriteLine("The Number is Odd");

            //create entry point for following methjod.......
            // EvenOrOddWithoutMod();
            //Calculator();
            //Vowel();
            //LeapYear();
            //AddDigits();
            // FactFor();
            //Factorial(n);
            //KeyboardValues();
            //Swap();
            //CallByReference_Swap(ref int a,int b);


        }
        static void EvenOrOddWithoutMod()
        {
            int x;
            Console.WriteLine("Check if odd or even");
            x = int.Parse(Console.ReadLine());
            // check withiout using Mod operator.......
            if ((x / 2) * 2 == x)
            { Console.WriteLine("Even"); }
            else
            {

                Console.WriteLine("Odd");
            }
        }

        //Calculator
        static void Calculator()
        {
            int first, second, add, subtract, multiply;
            float divide;
            Console.WriteLine("Enter two numbers:");
            first = int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());
            //Add
            add = first + second;
            subtract = first - second;
            multiply = first * second;
            divide = first / (float)second;  // typecasting.....

            Console.WriteLine("Addition : {0}", add);
            Console.WriteLine("subtraction : {0}", subtract);
            Console.WriteLine("Multiplicqation: {0}", multiply);
            Console.WriteLine("Division : {0}", divide);

        }
        //Vowel or Not
        static void Vowel()
        {
            char ch;
            Console.WriteLine("enter an Alphabet:");
            ch = char.Parse(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {

                Console.WriteLine("%c is a Vowel", ch);
            }
            else
            {
                Console.WriteLine("%c is a Consonant", ch);
            }
        }

        //LeapYear.....
        static void LeapYear()
        {
            int year;
            Console.WriteLine("Enter Year:");
            year = int.Parse(Console.ReadLine());
            // check if leap year or not....................

            if (year % 400 == 0)
            {
                Console.WriteLine("Its a Leap Year..");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Not a Leap year");
            }
            else if (year % 4 == 0)
            { Console.WriteLine("Leap Year"); }
            else { Console.WriteLine("Not Leap Year......"); }
        }

        //AddDigits
        static void AddDigits()
        {
            int x, sum = 0, remainder;
            Console.WriteLine("Enter a Number....");
            x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                remainder = x % 10;
                sum = sum + remainder;
                x = x / 10;
            }
            Console.WriteLine("The Sum of the digits is :{0}", sum);
        }


        //Factorialo with For.......
        static void FactFor()
        {
            int n, c, fact = 1;
            Console.WriteLine("Get Number:");
            n = int.Parse(Console.ReadLine());
            for (c = 1; c <= n; c++)
                fact = fact * c;
            //Console.WriteLine("factorial of {0} = {0}",n,fact);
            Console.WriteLine("factorial : {0}", fact);
        }

        // Factorial using recursion
        static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return (n * Factorial(n - 1));
        }

        //Add Numbers from keyboard.....
        static void KeyboardValues()
        {
            int n,sum = 0,c;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter a Number to Add the {0} th Number",n);
                c = int.Parse(Console.ReadLine());
                sum = sum + c;
            }
            Console.WriteLine("Sum of Inputs from KB :{0}", sum);

        }

        //Swap
        static void Swap()
        {
            int a, b;
            Console.WriteLine("A :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("B :");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The value of a is :{0}",a);
            Console.WriteLine("The value of b is :{0}",b);
        }

        //Swap with Call By Reference.....
        //static void CallByReference_Swap(ref int a ,ref int b)
        //{
        //    int temp;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}


        //Reverse a Num
        static void ReverseNum()
        {
            int n,reverse = 0;
            Console.WriteLine("Enter Num :");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + n % 10;
                n = n / 10;
            }
        }
        
    }
}
