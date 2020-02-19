using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPracticeOneDS
{
    class CallByValueEx
    {
        public void Add(int a, int b)
        {
            a = 10;
            b = 20;
            Console.WriteLine(a + ": " + b);
        }
    }
}
