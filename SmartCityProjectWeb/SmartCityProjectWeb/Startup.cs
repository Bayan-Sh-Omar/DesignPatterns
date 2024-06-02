using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.Configuration;
using SmartCity.Business.Abstract;
using SmartCity.Business.Concrete;
using SmartCity.DataAccess.Abstract;
using SmartCity.DataAccess.Concrete.EntityFramework;
using SmartCityProjectWeb.Filters;
using SmartCityProjectWeb.Models;

namespace SmartCityProjectWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICarParkService, CarParkManager>();
            services.AddScoped<ICarParkDal, CarParkDal>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, UserDal>();
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.Configure<ServiceModal>(Configuration.GetSection("Service"));

            services.AddScoped<LoginFilter>();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
                options.Cookie.HttpOnly = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();
            app.UseStatusCodePages();
            app.UseMvc();
        }
    }
}