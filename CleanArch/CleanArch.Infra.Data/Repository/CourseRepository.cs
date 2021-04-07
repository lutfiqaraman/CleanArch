using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public UniversityDBContext Context { get; private set; }

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            Context = universityDBContext;
        }

        IEnumerable<Course> ICourseRepository.GetCourses()
        {
            return Context.Courses;
        }

        public void Add(Course course)
        {
            Context.Courses.Add(course);
            Context.SaveChanges();
        }
    }
}
