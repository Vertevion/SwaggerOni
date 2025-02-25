﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using oni.Application.Behaviours;
using oni.Application.Helpers;
using oni.Application.Interfaces;
using oni.Domain.Entities;
using System.Reflection;

namespace oni.Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddScoped<IDataShapeHelper<Position>, DataShapeHelper<Position>>();
            services.AddScoped<IDataShapeHelper<Employee>, DataShapeHelper<Employee>>();
            services.AddScoped<IModelHelper, ModelHelper>();
            // * use Scutor to register generic IDataShapeHelper interface for DI and specifying the lifetime of dependencies
            services.Scan(selector => selector
                .FromCallingAssembly()
                .AddClasses(classSelector => classSelector.AssignableTo(typeof(IDataShapeHelper<>)))
                .AsImplementedInterfaces()
                .WithTransientLifetime());
        }
    }
}