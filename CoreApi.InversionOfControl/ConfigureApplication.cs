using CoreApi.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CoreApi.InversionOfControl
{
    public static class ConfigureApplication
    {
        public static void ConfigureSwaggerUi(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(swui =>
            {
                swui.SwaggerEndpoint("/swagger/CoreApi/swagger.json", "Core Api Demo");
            });
        }

        public static void PopulateDatabase(this IApplicationBuilder app, IServiceProvider serviceProvider)
        {
            var databaseContext = serviceProvider.GetService<DatabaseContext>();
            DatabaseTestData.Create(databaseContext);
        }
    }
}