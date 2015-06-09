using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThisMVCOne.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string Username { get; set; }
    }
}