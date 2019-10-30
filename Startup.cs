using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using netcore.Models;

using DinkToPdf.Contracts;
using DinkToPdf;
using System.IO;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Logging;
using Microsoft.Owin.Logging;
using LoggerFactory = Microsoft.Extensions.Logging.LoggerFactory;
using netcore.Controllers;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace netcore
{
    public class Startup
    {
       // private readonly IConfigurationRoot _appConfiguration;
        private readonly IHostingEnvironment _hostingEnvironment;
        /*public Startup(IHostingEnvironment env)
        {
           // _appConfiguration = env.GetAppConfiguration();
            _hostingEnvironment = env;
        }*/

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            _hostingEnvironment = env;

        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var architectureFolder = (IntPtr.Size == 8) ? "64 bit" : "32 bit";
            var wkHtmlToPdfPath = Path.Combine(_hostingEnvironment.ContentRootPath, $"wkhtmltox\\v0.12.4\\{architectureFolder}\\libwkhtmltox");
            CustomAssemblyLoadContext context1 = new CustomAssemblyLoadContext();
            context1.LoadUnmanagedLibrary(wkHtmlToPdfPath);
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            //-------------------------------------------------------------------------------------------
            services.AddMvc(options =>
            {
                options.Filters.Add(new AuthorizeFilter());
                options.MaxModelValidationErrors = 50;
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(
          (_) => "The field is required.");
                options.AllowValidatingTopLevelNodes = false;

            });
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {

                // Set a short timeout for easy testing.
                //options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.IdleTimeout = TimeSpan.FromSeconds(20);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false; //ตอนแรก เป็น true
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
               


            });
           
           
            //--------------------------------------------------------------------------------


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
           services.Add(new ServiceDescriptor(typeof(Connectdb), new Connectdb(Configuration.GetConnectionString("DefaultConnection"))));
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            //services.AddTransient<Condb>(_ => new Condb(Configuration["ConnectionStrings:DefaultConnection"]));
            //----------------------------------------------------------------------------------------------------------------------
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
                options =>
                {
                    options.LoginPath = "/Home/Index";
                    // options.LoginPath = new PathString("/Home");
                    options.Cookie.Name = "SimpleTalk.AuthCookieAspNetCore";
                    options.LogoutPath = "/Home/Logout";
                    options.AccessDeniedPath = "/Home/Privacy";

                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = _hostingEnvironment.IsDevelopment()
                      ? CookieSecurePolicy.None : CookieSecurePolicy.Always;
                    options.Cookie.SameSite = SameSiteMode.Lax;
                    options.Cookie.Expiration = TimeSpan.FromMinutes(10);
                    options.Cookie.MaxAge = TimeSpan.FromDays(2);

                });
            
            //-----------------------------------------------------------------------------------------------------------
            services.AddSingleton<RequestHandler>();
            services.AddHttpContextAccessor();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();

            //app.UseAuthorization();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }


    }
}
