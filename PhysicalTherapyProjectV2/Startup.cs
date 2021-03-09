using System.Security.Policy;
using AutoMapper;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PhysicalTherapyProject.Application.Infrastructure;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Application.Services;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Data;
using PhysicalTherapyProject.Persistance.Infrastructure;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using PhysicalTherapyProject.Persistance.Repositories;
using Tag = PhysicalTherapyProject.Domain.Models.Tag;

namespace PhysicalTherapyProjectV2
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
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IGenericRepository<Image>, GenericRepository<Image>>();
            services.AddScoped<IGenericRepository<Tag>, GenericRepository<Tag>>();
            services.AddScoped<IGenericRepository<Occupation>, GenericRepository<Occupation>>();
            services.AddScoped<IGenericRepository<ApplicationRole>, GenericRepository<ApplicationRole>>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IDataExportService, DataExportService>();

            services.AddAutoMapper(typeof(MapProfile));
            services.AddDbContext<ApplicationDbContext>(options =>

            options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, ApplicationRole>(opt =>
            {
                opt.Password.RequiredLength = 1;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireLowercase = false;
                opt.User.RequireUniqueEmail = true;
                opt.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                MapCustomRoutes(endpoints);

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            IdentitySeeder.SeedData(userManager, roleManager);
        }

        private static void MapCustomRoutes(IEndpointRouteBuilder endpoints)
        {

            endpoints.MapControllerRoute(
                name: "teamMembers",
                pattern: "komandos-nariai/sąrašas",
                defaults: new {controller = "TeamMember", action = "Index"});

            endpoints.MapControllerRoute(
                name: "getArticle",
                pattern: "straipsnis/{id}",
                defaults: new {controller = "Article", action = "Get"});
            endpoints.MapControllerRoute(
                name: "getTeamMember",
                pattern: "komandos-nariai/{id}",
                defaults: new {controller = "TeamMember", action = "Get"});

            endpoints.MapControllerRoute(
                name: "eventAdminList",
                pattern: "renginiai/admin-sąrašas",
                defaults: new {controller = "Event", action = "AdminList"});
            endpoints.MapControllerRoute(
                name: "teamMembersAdminList",
                pattern: "komandos-nariai/admin-sąrašas",
                defaults: new {controller = "TeamMember", action = "AdminList"});
            endpoints.MapControllerRoute(
                name: "articleAdminList",
                pattern: "straipsniai/admin-sąrašas",
                defaults: new {controller = "Article", action = "AdminList"});
        }
    }
}
