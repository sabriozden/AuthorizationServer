﻿using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Identity.Application
{
    public static class DependencyInjection
    {

        public static void AddApplication(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

    }
}
