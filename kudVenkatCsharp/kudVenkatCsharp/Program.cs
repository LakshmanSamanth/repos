using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace kudVenkatCsharp
{

    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Sal { get; set; }

        public static void promoteEmp(List<Emp> empList)
        {
            foreach (Emp employee in empList)
            {

                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + " is Promoted");
                }
            }
        }

    }
    public delegate void HelloFunctionDelegate(string Message);


    public class DelegateExample
    {
        

        
    }

    interface Icustomer
    {
        void Print();
    }
    interface I2 : Icustomer
    {
        void Chk();
    }

    class Customer : I2 
    {
        public void Chk()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Hello");
        }
            
        
    }




    public class Student
    {
        private string _FirstName { get; set; }
        private string _Lastname { get; set; }


        public string FirstName { get { return _FirstName; } set { _FirstName = value; } }
        public string LastName { get { return _Lastname; } set { _Lastname = value; } }

        public string GetFName()
        {
            return _FirstName + "" + _Lastname;
            //Console.WriteLine(FirstName + LastName);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {



            Type T = Type.GetType("kudVenkatCsharp.Student");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property);
                Console.WriteLine("   ");
            }

            Student[] student = new Student[3];

            student[0] = new Student { _FirstName = "Lakshman", _Lastname = 1 };
            student[1] = new Student { _FirstName = "Rama", _Lastname = 2 };
            student[3] = new Student { _FirstName = "Anu", _Lastname = 3 };

            foreach (Student stud in student)
            {
                Console.WriteLine("Name = {0} && Gender = {1}",stud._FirstName,stud._Lastname);
            }

          



            Console.WriteLine("     ");
            Console.WriteLine("     ");
            Console.WriteLine("     ");
            Console.WriteLine("     ");
            StreamReader streamReader = new StreamReader("C:\\Users\\Sagar\\Desktop\\RESUME\\new.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();

            List<Emp> eList = new List<Emp>();
            {
                eList.Add(new Emp() { Id = 101, Name = "Ram" , Experience = 4, Sal = 1000});
                eList.Add(new Emp() { Id = 101, Name = "Lakshman", Experience = 5, Sal = 4000});
                eList.Add(new Emp() { Id = 101, Name = "Sam", Experience = 7, Sal = 3000 });
                eList.Add(new Emp() { Id = 101, Name = "Ramesh", Experience = 3, Sal = 2000 });

                Emp.promoteEmp(eList);

            }

            HelloFunctionDelegate Del = new HelloFunctionDelegate(Hello);
            Del("Hello Lakshman Samanth");


             void Hello(string strMessage)
            {
                Console.WriteLine(strMessage);
            }


            Customer C = new Customer();
            C.Print();


            InheritenceKudVenkatEmployee[] employee = new InheritenceKudVenkatEmployee[4];
            employee[0] = new InheritenceKudVenkatEmployee();
            employee[1] = new FullTimeEmployee();
            employee[2] = new PartTimeEmployee();
            employee[3] = new TempEmployee();

            foreach (InheritenceKudVenkatEmployee e in employee)
            {
                e.FullName();
            }



            Department d = new Department();
            d.DepartmentName = "Sales department";
            d.PrintDepartment();
            Age a = new Age();


            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Lakshman";
            FTE.LastName = "Samanath";
            FTE.Email = "lakshmansamanth@gmail.com";
            FTE.YearlySalary = 500000;
            FTE.FullName();


            Program p1 = new Program("Bayern", "Munich");

            p1.PrintFullName();


            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 201;
            Numbers[2] = 301;

            ParamsMethod();

            int Sum = 0;
            int Prod = 0;
            Program.Caliculate(10, 20, out Sum, out Prod);

            Console.WriteLine("Sum is {0}  & Prod is {1}",Sum,Prod);

            int i = 0;
            int m = 3;
            Program.SimpleMethod(i);
            Console.WriteLine(i);
            Console.WriteLine("Bayern  Munich");
            Program.Simple(ref i);
            Console.WriteLine(m);
            Console.ReadLine();

        }

        public static void  SimpleMethod(int j)
        {
             j = 101;
        }

        public static void Simple(ref int k)
        {
            k = 202;
        }

        public static void Caliculate(int a, int b, out int Sum, out int Prod)
        {
            Sum = a + b;
            Prod = a * b;

        }

        public static void ParamsMethod(params int[] Numbers)
        {

            Console.WriteLine("The Number of elements in Array are : {0}" , Numbers.Length);

            Console.WriteLine("The elements in the list are :" );
            foreach (int num in Numbers)
            {
                Console.WriteLine(num);
            }
        }

        // constructor........
        string _firstName;
        string _secondName;

        public Program(string firstName, string secondName)
        {
            this._firstName = firstName;
            this._secondName = secondName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("The Full Name is :{0} " + " " + "{1}", _firstName,_secondName);

        }

       

    }

   
}
