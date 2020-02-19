using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsUdemy
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count} : {text}");
            return count;
        }

        public void  removeEntry(int index)
        {
            entries.RemoveAt(index);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        public void Save(string fileName)
        {
            File.WriteAllText(fileName, ToString());
        }

        public  void Load(string fileName)
        {
            

        }
    }

    public class Persistence
    {
        public void SaveToFile(Journal j, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, j.ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var J = new Journal();
            J.AddEntry("Bayern Munich");
            J.AddEntry("Borussia Dortmund");
            Console.WriteLine(J);
            Console.ReadLine();

        }
    }
}
