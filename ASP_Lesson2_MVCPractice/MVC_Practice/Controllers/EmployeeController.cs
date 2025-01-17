using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Practice.Entities;
using MVC_Practice.Models;
using System.Collections.Generic;
using System.Net.Mail;

namespace MVC_Practice.Controllers
{
    public class EmployeeController : Controller
    {

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new EmployeeAddViewModel()
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text = "Baku",Value="10"},
                    new SelectListItem{Text = "Ganja",Value="20"},
                    new SelectListItem{Text = "Sumqayit",Value="50"},
                    new SelectListItem{Text = "Masalli",Value="44"},

                }
            };
            return View(vm);

        }

        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel viewModel)
        {
            //var vm = new EmployeeAddViewModel()
            //{
            //    Employee = new Employee()
            //};

            //return View(vm);

            if(ModelState.IsValid)
            {
                return Redirect("/home/index");
            }

            return View(viewModel); 

        }
    }
}
