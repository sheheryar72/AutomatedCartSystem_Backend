using AutomatedCartSystem.IRepositories;
using AutomatedCartSystem.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem
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
            /*services.AddCors(options=>
            {
                *//*options.AddPolicy("MyPolicy",
                a => a.WithOrigins("domain info"));*//*
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });*/

            /*services.AddCors(options =>
            {
                options.AddPolicy("CorsApi",
                    builder => builder.AllowAnyOrigin(x => true)
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });*/

            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", builder => builder
                    .SetIsOriginAllowed(origin => true)
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials());
            });

            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddControllersWithViews();
            services.AddScoped<ICustomerRepositories>(provider => new CustomerRepositories(new SqlConnection(connectionString)));
            services.AddScoped<IProductRepositories>(provider => new ProductRepositories(new SqlConnection(connectionString)));
            services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "AutomatedCartSystem",
                    Description = "A Automated Cart System to Api's",
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (true) //ab daalde publish chal jaega
            {
                /*app.UseCors( option =>
                {
                    option.
                        WithOrigins("domian Information", "").
                        AllowAnyMethod().
                        AllowAnyHeader();
                });
                app.UseCors("MyPolicy");*/
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Showing API V1");
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            /*app.UseHttpsRedirection();*/
            app.UseStaticFiles();

            app.UseRouting();
            /*app.UseCors("CorsApi");*/

            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
