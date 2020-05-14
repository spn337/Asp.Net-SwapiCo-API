using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SWAPICO.Entities;

namespace SWAPICO
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
            services.AddDbContext<AppDbContext>(opt =>
               opt.UseSqlServer(Configuration
                   .GetConnectionString("DefaultConnection")));

            services.AddCors(); // добавляем сервисы CORS

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();
            //app.UseStaticFiles();


            // подключаем CORS
            app.UseCors(builder =>
            {
                builder.WithOrigins("http://localhost:3000")
                       .AllowAnyMethod()
                       .AllowCredentials()
                       .AllowAnyHeader();
            });


            //var contentRootPath = env.ContentRootPath;
            //string imgDirName = this.Configuration.GetValue<string>("ImagesPath");
            //string imgDirPathSave = Path.Combine(contentRootPath, imgDirName);
            //if (!Directory.Exists(imgDirPathSave))
            //{
            //    Directory.CreateDirectory(imgDirPathSave);
            //}
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(imgDirPathSave),
            //    RequestPath = new PathString("/images")
            //});


            app.UseMvc();

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                Seeder.SeedData(context);
            }
        }
    }
}
