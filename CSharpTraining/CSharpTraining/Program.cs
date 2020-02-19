using System;

namespace CSharpTraining
{
    class Program
    {
        

        //mathematical examples......

        //Odd or Even
        static void OddOrEven()
        {
            int n;
            Console.WriteLine("Enter number : ");
             n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            { Console.WriteLine("Even Number"); }
            else
            { Console.WriteLine("Odd Number"); }
        }

        //Odd or even without mod operator....
        //OddOrEvenNoMod
        static void OddOrEvenNoMod()
        {
            int n;
            Console.WriteLine("enter number:");
            n = int.Parse(Console.ReadLine());
            if ((n / 2) * 2 == n)
            { Console.WriteLine("Even"); }
            else
            { Console.WriteLine("Odd"); }
        }

        //Caliculator
        static void Calculator()
        {
            int a, b, add, subtract, multiply;
            float divide;
            Console.WriteLine("enter two integers:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            add = a + b;
            subtract = a - b;
            multiply = a * b;
            divide = a / (float)b; // why ? type casting....

            Console.WriteLine("Addition : {0}",add);
            Console.WriteLine("Subtraction: {0}",subtract);
            Console.WriteLine("Multiplication: {0}", multiply);
            Console.WriteLine("division : {0}",divide);

            
        }

        //Vowels
        static void VowelOrNot()
        {
            char ch;
            Console.WriteLine("Enter character:");
            ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            { Console.WriteLine("{0} is a Vowel", ch); }
            else
            { Console.WriteLine("{0} is not Vowel",ch); }
        }

        //Leap Year
        static void LeapYear()
        {
            int year;
            Console.WriteLine("Enter a year: ");
            year = int.Parse(Console.ReadLine());

            if(year % 400 == 0 )
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Non-Leap Year");
        }

        //Add Digits
        static void AddDigits()
        {
            int n,r, sum = 0;
            Console.WriteLine("Enter a Number :");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine("the sum of digiyts is : {0}",sum);

        }

        //Factorial with For Loop
        static void FactorialFor()
        {
            int i, n, f = 1;
            Console.WriteLine("enter number:");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial of n is : {0}",f);
        }

        //Add numbers entered from keyboard
        static void AddNumbers()
        {
            int n, i, var,sum = 0;
            Console.WriteLine("Enter the no. of numbers");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                var = int.Parse(Console.ReadLine());
                sum = sum + var;
            }

            Console.WriteLine("the sum of numbers is {0}",sum);
        }

        //Swap two numbers
        static void Swap()
        {
            int a, b;
            Console.WriteLine("enter a and b :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("the new values of a = {0} and b = {0} are ",a,b);
        }
        //Swap with Call by Reference
        static void SwapCbR(ref int a,ref int b)
        {
            int temp;

            temp = a;
            b = a;
            a = temp;


        }

        //reverse a number
        static void Palindrome()
        {
            int n, reverse = 0, temp;
            n = int.Parse(Console.ReadLine());
            temp = n;

            while(temp != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + temp % 10;
                temp = temp / 10;

            }
            if (n == reverse)
            { Console.WriteLine("Palindrome Number"); }
            else
            { Console.WriteLine("Not Palindrome"); }

        }




        // Add the function OddOrEven here in main method.....
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Palindrome();
        }
    }
}
