using Microsoft.Extensions.DependencyInjection;
using ScienceHub.Core.Abstarctions;
using ScienceHub.Data.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceHub.Data
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IArticleService,ArticleService>();
        }
    }
}
