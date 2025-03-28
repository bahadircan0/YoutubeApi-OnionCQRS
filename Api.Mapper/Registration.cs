﻿using Api.Application.Interfaces.AutoMapper;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Api.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<Application.Interfaces.AutoMapper.IMapper,AutoMapper.Mapper>();
        }
    }
}
