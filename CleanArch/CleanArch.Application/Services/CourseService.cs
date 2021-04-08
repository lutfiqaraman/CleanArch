using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
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
        public IMediatorHandler Bus { get; private set; }

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            CourseRepository = courseRepository;
            Bus = bus;
        }

        public CourseViewModel GetCourses()
        {
            CourseViewModel result = new()
            {
                Courses = CourseRepository.GetCourses()
            };


            return result;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            CreateCourseCommand createCourseCommand = 
                new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl);

            Bus.SendCommand(createCourseCommand);
        }
    }
}
