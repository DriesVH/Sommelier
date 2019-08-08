using Microsoft.Extensions.DependencyInjection;
using Sommelier.Models;
using Sommelier.Repositories;
using Sommelier.Repositories.Consultants;
using Sommelier.Services.Consultants;
using Sommelier.WebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sommelier.WebApp.Helpers
{
    public static class StartupHelpers
    {
        public static void RegsiterServices(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Consultant>, ConsultantsRepository>();
            services.AddTransient<IConsultantsService, ConsultantsService>();
        }
    }
}
