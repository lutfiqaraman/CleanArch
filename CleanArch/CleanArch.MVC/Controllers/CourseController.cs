using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.MVC.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        public ICourseService CourseService { get; private set; }

        public CourseController(ICourseService courseSrv)
        {
            CourseService = courseSrv;
        }

        public IActionResult Index()
        {
            CourseViewModel model = CourseService.GetCourses();
            return View(model);
        }
    }
}
