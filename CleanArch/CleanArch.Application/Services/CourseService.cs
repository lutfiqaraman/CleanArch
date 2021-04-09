using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        public IMapper AutoMapper { get; private set; }


        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper automapper)
        {
            CourseRepository = courseRepository;
            Bus = bus;
            AutoMapper = automapper;
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return 
                CourseRepository
                .GetCourses()
                .ProjectTo<CourseViewModel>(AutoMapper.ConfigurationProvider);
        }

        public void Create(CourseViewModel courseViewModel)
        {
            Bus.SendCommand(AutoMapper.Map<CreateCourseCommand>(courseViewModel));
        }
    }
}
