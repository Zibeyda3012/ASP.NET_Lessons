using MVC_Practice.Entities;
using System.Collections.Generic;

namespace MVC_Practice.Models
{
    public class EmployeeViewModel
    {
        public List<Employee> Emloyees { get; set; }

        public List<string> Cities { get; set; }


    }
}
