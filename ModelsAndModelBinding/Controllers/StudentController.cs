using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet] // When user navigates to url
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // Call this Add method after user posts form data
        public IActionResult Add(IFormCollection form)
        {
            // Need server-side validation for all data

            Student stu = new Student();
            stu.FullName = form["full_name"];
            stu.DateOfBirth = Convert.ToDateTime(form["dob"]);
            stu.PhoneNumber = form["home_phone"];
            stu.EmailAddress = form["email"];

            // Add to database

            ViewData["Added"] = stu.FullName + " was added with an ID of 1";

            return View();
        }
    }
}
