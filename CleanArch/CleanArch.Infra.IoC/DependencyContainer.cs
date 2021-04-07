using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection srv)
        {
            srv.AddScoped<IMediatorHandler, InMemoryBus>();
            srv.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
            srv.AddScoped<ICourseService, CourseService>();
            srv.AddScoped<ICourseRepository, CourseRepository>();
            srv.AddScoped<UniversityDBContext>();
        }
    }
}
