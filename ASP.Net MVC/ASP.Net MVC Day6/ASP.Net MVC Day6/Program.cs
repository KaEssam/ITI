using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASP.Net_MVC_Day6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            ConfigureServices(app.Services);

            Configure(app, app.Environment);

            app.Run();
        }

        private static void ConfigureServices(IServiceProvider services)
        {
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // Middleware: Use
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("This is the 'Use' middleware.");
                await next();
            });

            // Middleware: Map
            app.Map("/map", mappedApp =>
            {
                mappedApp.Run(async context =>
                {
                    await context.Response.WriteAsync("This is the 'Map' middleware.");
                });
            });

            // Middleware: Run
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("This is the 'Run' middleware.");
            });
        }
    }
}