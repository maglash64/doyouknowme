using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace doyouknowme
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void ConfigureRoute(IRouteBuilder route)
        {
            route.MapRoute("Default","{Controller=base}/{Action=index}/{id?}");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                
            }

            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();

            app.UseMvc(ConfigureRoute);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<html><body><h1 align='center'>404 : Page Not Found!</h1></body></html>");
            });
        }
    }
}
