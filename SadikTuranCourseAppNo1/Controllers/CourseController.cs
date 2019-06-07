using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SadikTuranCourseAppNo1.Models;

namespace SadikTuranCourseAppNo1.Controllers
{
    public class CourseController:Controller
    {
        public IActionResult Apply()
        {
          
          return View();
        }
        public IActionResult Details()
        {
            var course =new Course();
            course.Name = "Core mvc kursu";
            course.description="";
          //TODO: Implement Realistic Implementation
          return View();
        }
        //actionmethod
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
