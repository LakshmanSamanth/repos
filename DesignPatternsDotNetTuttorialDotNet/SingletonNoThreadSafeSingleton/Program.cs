using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonNoThreadSafeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("Hello Lakshman");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("Hello Sairam  Sagar");

            Console.ReadLine();



        }
    }
}
