using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    string page = File.ReadAllText("site/htmlpage.html");
                    await context.Response.WriteAsync(page);
                });

                endpoints.MapGet("/adminpage", async context =>
                {
                    string page = File.ReadAllText("site/adminpage.html");
                    await context.Response.WriteAsync(page);
                });

                endpoints.MapGet("/answersPage", async context =>
                {
                    string page = File.ReadAllText("site/answersPage.html");
                    await context.Response.WriteAsync(page);
                });

                endpoints.MapGet("/password", async context =>
                {
                    string password = "vodichka";
                    await context.Response.WriteAsync(password);
                });

                endpoints.MapGet("/login", async context =>
                {
                    string login = "vodichka";
                    await context.Response.WriteAsync(login);
                });

                endpoints.MapGet("/randomAnswer", async context =>
                {
                    string random = "Рандом";
                    await context.Response.WriteAsync(random);
                });

                endpoints.MapGet("/predictionsPage", async context => 
                {
                    string page = File.ReadAllText("site/predictionsPage.html");
                    await context.Response.WriteAsync(page);
                });

                endpoints.MapGet("/randomPrediction", async context =>
                {
                    // * будут проблемы
                    PredictionsManager pm = new PredictionsManager();
                    var s = pm.GetRandomPrediction();
                    await context.Response.WriteAsync(s);
                });

                endpoints.MapGet("/addPrediction", async context =>
                {
                    // * будут проблемы
                    PredictionsManager pm = new PredictionsManager();
                    //var quary = context.Request.Query;
                    pm.AddPrediction("Новая строка");
                });
            });
        }
    }
}
