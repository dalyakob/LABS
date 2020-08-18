using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiphyAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GiphyAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddHttpClient<IGiphyService, ApiGiphyService>(c =>
            {
                c.BaseAddress = new Uri("https://giphy.p.rapidapi.com/v1/gifs/");
                c.DefaultRequestHeaders.Add("x-rapidapi-host", "giphy.p.rapidapi.com");
                c.DefaultRequestHeaders.Add("x-rapidapi-key", "0009e57da2mshc443e5d7aa25521p1fc4d6jsn431a7f10e629");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Giphy}/{action=Index}/{id?}");
            });
        }
    }
}
