using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDotNetMVCfromDotNetTutorialDotNetLakshman.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int AddressId { get; set; }


    }
}