using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThisMVCOne.Models;
using ThisMVCOne.ViewModels;

namespace ThisMVCOne.Controllers
{

    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    }
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public string GetString()
        {
            return "Hello World is old now. It&rsquo;s time for wassup bro ;)";
        }
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address1";
            return c;
        }
        [NonAction] // a public non-action method, cannot be invoked in web, will not run
        public string SimpleMethod()
        {
            return "Hi, I am not action method";
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName="Marla";
            emp.Salary = 20000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if(emp.Salary>15000)
            {
                vmEmp.SalaryColor="yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }

            vmEmp.UserName = "Admin";

            return View("MyView", vmEmp);

            /* For use with model, not ViewModel
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;

            ViewData["Employee"] = emp;

            // with ViewBag
            Employee emp1 = new Employee();
            emp1.FirstName = "Jack";
            emp1.LastName = "Flaherty";
            emp1.Salary = 200000;

            ViewBag.Employee2 = emp1;

            // with strongly typed view

            Employee emp2 = new Employee();
            emp2.FirstName = "Test";
            emp2.LastName = "Employee";
            emp2.Salary = 20000;


            return View("MyView", emp2);


            //return View("MyView"); */
        }
    }
}
