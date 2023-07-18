using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.BusinessLayer.Concrete;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using Pizzapan.DataAccessLayer.EntityFramework;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzapan.WebUI
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
            services.AddDbContext<PizzapanContext>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<PizzapanContext>().AddErrorDescriber<CustomIdentityValidator>();

            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<ICategoryDal,EfCategoryDal>();
            
            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<IProductDal,EfProductDal>();

             services.AddScoped<IContactService,ContactManager>();
            services.AddScoped<IContactDal,EfContactDal>();
            
            services.AddScoped<ITestimonialService,TestimonialManager>();
            services.AddScoped<ITestimonialDal,EfTestimonialDal>();
            
            services.AddScoped<ICompanyInfoService,CompanyInfoManager>();
            services.AddScoped<ICompanyInfoDal,EfCompanyInfoDal>();
            
            services.AddScoped<IDiscountService,DiscountManager>();
            services.AddScoped<IDiscountDal,EfDiscountDal>();
            
            services.AddScoped<IProductImageService,ProductImageManager>();
            services.AddScoped<IProductImageDal,EfProductImageDal>();

            services.AddScoped<IOurTeamService,OurTeamManager>();
            services.AddScoped<IOurTeamDal,EfOurTeamDal>();

            services.AddScoped<IRegisterService,RegisterManager>();
 
            services.AddControllersWithViews();

            // authorization işlemi
            //services.AddMvc(config =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //    config.Filters.Add(new AuthorizeFilter(policy));

            //});
            //services.AddMvc();


            //services.AddAuthentication(
            //    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
            //    {
            //        x.Cookie.Name = "CasgemMvc.Auth";
            //        x.LoginPath = "/Login/Index/";
            //        x.LogoutPath = "/Login/Logout/";
            //        x.AccessDeniedPath = "/Login/Index/";
            //        //x.ExpireTimeSpan = TimeSpan.FromMinutes(1);
            //        //x.Cookie.HttpOnly = false;
            //        //x.SlidingExpiration = true;
            //    });

            //services.ConfigureApplicationCookie(opt =>
            //{
            //    opt.ExpireTimeSpan = TimeSpan.FromMinutes(60);
            //    opt.LoginPath = "/Login/Index/";
            //    opt.LogoutPath = "/Login/Logout/";
            //    //opt.AccessDeniedPath = "/Login/Index/";
            //    opt.Cookie.HttpOnly = false;
            //    opt.SlidingExpiration = true;
            //});
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
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
