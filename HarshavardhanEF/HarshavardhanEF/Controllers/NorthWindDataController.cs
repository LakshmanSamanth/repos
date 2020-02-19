using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HarshavardhanEF.Models;

namespace HarshavardhanEF.Controllers
{
    public class NorthWindDataController : Controller
    {
        NORTHWNDEntities ND = new NORTHWNDEntities();

        // GET: NorthWindData
        public ActionResult Customers()
        {
            NORTHWNDEntities ND = new NORTHWNDEntities();

            List<Customer> customers = ND.Customers.ToList();

            

            return View(customers);
        }


        public ActionResult Employees()
        {
            List<Employee> employees = ND.Employees.ToList();

            return View(employees);
        }

        public ActionResult CreateEmployee()
        {

            return View();

        }

        [HttpPost]
        public ActionResult CreateEmployees()
        {
            return View();
        }


        // Execute All CRUD ops for all the Orders...............
        public ActionResult Orders()
        {
            List<Order> orders = ND.Orders.ToList();

            return View(orders);
        }

        public ActionResult OrderDetails( int id)
        {
            var details = ND.Orders.Where(t => t.OrderID == id).FirstOrDefault();

            return View(details);

        }

        // Delete Orders from here............
        public ActionResult Delete(int id)
        {
            var deleteOrder = ND.Orders.Where(t => t.OrderID == id).FirstOrDefault();
            if (id == deleteOrder.OrderID)
            {
                ND.SaveChanges();
            }

            return View();
        }

        public ActionResult OrdersFromGermany(string search = "")
        {
            //List<Order> OrdersFromGermany = ND.Orders.Where(t => t.ShipCountry == "Germany").ToList();

            List<Order> OrdersFromGermany = ND.Orders.Where(t => t.ShipCity.Contains(search)).ToList();
            ViewBag.Search = search;

            return View(OrdersFromGermany);
        } 

        public ActionResult OrdersFromFrance()
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ShipCountry", "France")
                //you can add more parameters here
            };
            List<Order> ordersFromFrance = ND.Database.SqlQuery<Order>("exec GetOrdersFromFrance @ShipCountry", sqlParameters).ToList();

            return View(ordersFromFrance);

        }

        public ActionResult SearchInFranceOrders(string search = "")
        {
            List<Order> searchFranceOrders = ND.Orders.Where(t => t.ShipCity.Contains(search)).ToList();

            ViewBag.Search = search;

            return View(searchFranceOrders);
        }

        public ActionResult OrdersFromUsa()
        {
            List<Order> OrdersFromUSA = ND.Orders.Where(t => t.ShipCountry == "USA").ToList();

            return View();

        }

       
    }
}