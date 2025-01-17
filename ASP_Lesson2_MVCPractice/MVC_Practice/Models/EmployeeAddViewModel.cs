using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Practice.Entities;
using System.Collections.Generic;

namespace MVC_Practice.Models
{
    public class EmployeeAddViewModel
    {
       public Employee Employee { get; set; }

        public List<SelectListItem> Cities { get; set; }
    }
}
