using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kudVenkatCsharp
{
    public class InheritenceKudVenkatEmployee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string DepartmentName;




        public virtual void FullName()
        {
            Console.WriteLine("Full Name is : {0} " + " " + "{1}", FirstName,LastName);
        }
    }

    public class FullTimeEmployee : InheritenceKudVenkatEmployee
    {
        public DateTime DoB;
        public float YearlySalary;

        public override void FullName()
        {
            Console.WriteLine("Software Developer : Sai Ram Sagar");
        }



    }
    public class PartTimeEmployee : InheritenceKudVenkatEmployee
    {
        public float HourlyRate;

        public override void FullName()
        {
            Console.WriteLine("Web Designer : Reus");
        }

    }

    public class TempEmployee : InheritenceKudVenkatEmployee
    {
        public override void FullName()
        {
            Console.WriteLine("contractor : Bayern Man");
        }

    }

    // This c# does nt suppiort multiple base class properties
    // It Supports only multi level class inhhertence in C#.

    //Mutli - Level Inhertence example
    public class  Age : FullTimeEmployee
    {
        public int AgeOfFullTimeEmployee;

    }

    public class Department :FullTimeEmployee
    {
        public  void  PrintDepartment()
        {
            Console.WriteLine("Department Name : {0}",DepartmentName);
        }
    }




}
