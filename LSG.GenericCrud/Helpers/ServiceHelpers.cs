﻿using System;
using LSG.GenericCrud.Repositories;
using LSG.GenericCrud.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LSG.GenericCrud.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class ServiceHelpers
    {
        /// <summary>
        /// Adds the crud.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void AddCrud(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICrudService<>), typeof(CrudService<>));
            services.AddScoped(typeof(ICrudRepository), typeof(CrudRepository));
            services.AddScoped(typeof(IHistoricalCrudService<>), typeof(HistoricalCrudService<>));
        }
    }
}
