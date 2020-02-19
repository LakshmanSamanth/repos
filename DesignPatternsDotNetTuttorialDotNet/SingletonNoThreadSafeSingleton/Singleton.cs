using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonNoThreadSafeSingleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        // Instance initiated with null reference,
        private static Singleton instance = null; // so here we can initiate one instance at a time for all public methods
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;

            }
        }

        // Constructor is declared as Private ( so no outside Instance, only inside Instance possible)
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value : "  + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }



    }
}
