using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKudVenkatCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // context
            LinqToSqlTutorialDataContext db = new LinqToSqlTutorialDataContext();


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var evenNumbers = from number in numbers
            //                  where (number % 2) == 0
            //                  select number;
            //foreach (var str in evenNumbers)
            //{
            //    Console.WriteLine("Even Numbers are :" + str.ToString());
            //}
            //Console.ReadLine();

            // Linq to SQL classes

            //var cityLondon = from city in db.Employees
            //                 where city.City == "London"
            //                 select city;

            //foreach(var str in cityLondon)
            //{
            //    Console.WriteLine("the city is : "+str.ToString());
            //}
            //Console.ReadLine();


            public static List<Student> studentList = new List<Student>()
            {
                new Student(){ ID=1, Name="Bill",Gender = "Male"},
                new Student(){ ID=2, Name="Steve",Gender = "Male"},
                new Student(){ ID=3, Name="Ram",Gender ="Female"},
                new Student(){ ID=4, Name="Moin",Gender = "Male"}
            };

        IEnumerable<Student> query = studentList.Where(student => student.Gender == "Female");
        



        }
    }
}
