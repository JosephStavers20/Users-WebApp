using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users_WebApp.Data;
using Microsoft.EntityFrameworkCore;
using Users_WebApp.Services.ProductsService;
using Users_WebApp.Services.OrdersService;
using Users_WebApp.Services.ProductReviewService;
using Users_WebApp.Services.CustomersService;
using Auth0.AspNetCore.Authentication;

namespace Users_WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env
        }

        private IWebHostEnvironment _env = null;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddAuth0WebAppAuthentication(options => {
                    options.Domain = Configuration["Auth0:Domain"];
                    options.ClientId = Configuration["Auth0:ClientId"];
                    options.ClientSecret = Configuration["Auth0:ClientSecret"];
                }).WithAccessToken(options => { options.Audience = Configuration["Auth0:Audience"]; });

            if (_env.IsDevelopment())
            {
                services.AddTransient<IProductsService, FakeProductsService>();
            }
            else
            {
                services.AddHttpClient<IProductsService, ProductsService>();
            }

            services.AddControllersWithViews();

            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddDbContext<OrdersContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("OrdersContext")));

            services.AddDbContext<CustomersContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("CustomersContext")));

            services.AddDbContext<CustomerAccountDeletionRequestContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("CustomerAccountDeletionRequest")));

            services.AddDbContext<ProductReviewContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ProductReview")));

            services.AddDbContext<ProductsContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Products")));

            //services.AddHttpClient<IOrdersService, OrdersService >();

            services.AddHttpClient<IProductReviewService, ProductReviewsService>();

            services.AddHttpClient<ICustomersService, CustomersService>();

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

            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404 || context.Response.StatusCode == 400)
                {
                    context.Request.Path = "/Home";
                    await next();
                }
            });


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
