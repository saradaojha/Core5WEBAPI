using Core5WEBAPI.CustomExceptionMiddleware;
using Core5WEBAPI.Extensions;
using Core5WEBAPI.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core5WEBAPI
{
    public class Startup
    {
        string message = "";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //try
            {
                
                services.AddControllers();
                services.AddSingleton<INotifier, EmailNotifier>(); 
                //services.AddSwaggerGen(c =>
                //{
                //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Core5WEBAPI", Version = "v1" });
                //});
                //throw new Exception("Testing");
            }

           // catch (Exception ex)
            {
            //    message = ex.Message;
            }
        }
      
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
              //  app.UseExceptionHandlerMiddleware(); 
                ////app.UseExceptionHandler("/Error");
                //app.UseExceptionHandler(
                //options =>
                //{
                //    options.Run(
                //        async context =>
                //        {
                //            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                //            context.Response.ContentType = "text/html";
                //            var exceptionObject = context.Features.Get<IExceptionHandlerFeature>();
                //            if (null != exceptionObject)
                //            {
                //                var errorMessage = $"<b>Exception Error: {exceptionObject.Error.Message} </b> {exceptionObject.Error.StackTrace}";
                //                await context.Response.WriteAsync(errorMessage).ConfigureAwait(false);
                //            }
                //        });
                //}
            //);
              
                //app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                // app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Core5WEBAPI v1"));
            }
            //app.ConfigureExceptionHandler(logger);
           // app.UseMiddleware<ExceptionMiddleware>();
            string a = message;
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMiddleware<ErrorHandlerMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
