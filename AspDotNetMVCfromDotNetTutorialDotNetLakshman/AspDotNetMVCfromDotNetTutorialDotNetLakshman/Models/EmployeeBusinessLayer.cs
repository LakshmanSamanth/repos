using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDotNetMVCfromDotNetTutorialDotNetLakshman.Models
{
     // Here we Add the Business Logic to our Application................

    public class EmployeeBusinessLayer
    {
        public Employee GetDetailsById(int EmployeeId)
        {
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeId,
                Name = "Lakshman Samanth Reddy",
                Gender = "Male",
                City = "Visakhapatnam",
                Salary = 7000,
                Addresss = "Beach Road"
            };

            return employee;


        }
    }
}