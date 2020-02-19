using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace WebApiKudvenkat.Controllers
{
    public class EmployeesController : ApiController
    {
        public /*IEnumerable<Employee>*/ IHttpActionResult Get()
        {
            using (
                
                EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                
                return Ok(entities.Employees.ToList());//);
                //return Ok(result);
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.EmployeeID == id);
            }
        }
    }
}
