using Microsoft.AspNetCore.Builder;

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
    }
}