using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPracticeOneDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassParamsEx obj = new ClassParamsEx();

            //obj.add(1, 2, 3, 4, 5, 6, 7, 8);

            CallByValueEx cbv = new CallByValueEx();
            int i = 1, j = 2; // actual parameters.........

            cbv.Add(i, j); // calling...................
            Console.WriteLine("Calling :" +i + ":" +j);

            Console.Read();

        }
    }
}
