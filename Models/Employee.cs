using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThisMVCOne.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
}
/* From MyView when using Employee @Model, now using Viewmodel so had to be removed
 @{
            ThisMVCOne.Models.Employee emp = (ThisMVCOne.Models.Employee)
                ViewData["Employee"];
        }

        <b>Employee Details </b><br />
        Employee Name : @emp.FirstName @emp.LastName <br />
        Employee Salary: @emp.Salary.ToString("C")

        <br /><br />

        <!-- ViewBag Version -->

        @{
            ThisMVCOne.Models.Employee emp1 = (ThisMVCOne.Models.Employee)
                ViewBag.Employee2;
        }
        <b>Employee Details</b><br />

        Employee Name: @emp1.FirstName @emp1.LastName <br />

        Employee Salary: @emp1.Salary.ToString("C")

        <br /> 
        
        <!-- Now with the strongly typed view.. -->

        <b>Employee Details</b><br />
        Employee Name : @Model.FirstName @Model.LastName<br />

        @if (Model.Salary > 15000)
        {
            <span style="background-color:yellow">
                Employee Salary: @Model.Salary.ToString("C")
            </span>
        }
        else{
            <span style="background-color:green">
                
                Employee Salary: @Model.Salary.ToString("C")
            </span>
        }
*/