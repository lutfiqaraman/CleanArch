using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        public ICourseRepository CourseRepository { get; private set; }

        public CourseService(ICourseRepository courseRepository)
        {
            CourseRepository = courseRepository;
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
