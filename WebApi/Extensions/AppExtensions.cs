namespace WebApi.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using WebApi.Middleware;

    public static class AppExtensions
    {
        #region Swagger Region - Do Not Delete
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "");
            });
        }
        #endregion

        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
