using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPracticeOneDS
{
    class ClassParamsEx
    {
        public void add(int a, int b, params int[] c)
        {
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
