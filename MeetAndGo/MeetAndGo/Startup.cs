using MeetAndGo.Database;
using MeetAndGo.Filters;
using MeetAndGo.Interfaces;
using MeetAndGo.Security;
using MeetAndGo.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace MeetAndGo
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
            services.AddAutoMapper(typeof(Startup));

            services.AddControllers(x =>
            {
                x.Filters.Add<ErrorFilter>();
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MeetAndGo API", Version = "v1" });

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                            },
                            new string[]{}
                        }
                    });
            });

            services.AddDbContext<meetGoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IReadService<Model.Role, object>, BaseReadService<Model.Role, Database.Role, object>>();
            services.AddScoped<IReadService<Model.City, object>, BaseReadService<Model.City, Database.City, object>>();
            services.AddScoped<IReadService<Model.Country, object>, BaseReadService<Model.Country, Database.Country, object>>();
            services.AddScoped<IReadService<Model.Transactions, object>, BaseReadService<Model.Transactions, Database.Transactions, object>>();
            services.AddScoped<IReadService<Model.TypeOfBuilding, object>, BaseReadService<Model.TypeOfBuilding, Database.TypeOfBuilding, object>>();
            services.AddScoped<IReadService<Model.RentedBuilding, object>, BaseReadService<Model.RentedBuilding, Database.RentedBuilding, object>>();
            services.AddScoped<IReadService<Model.CanceledBuilding, object>, BaseReadService<Model.CanceledBuilding, Database.CanceledBuilding, object>>();
            services.AddScoped<IReadService<Model.BuildingReview, object>, BaseReadService<Model.BuildingReview, Database.BuildingReview, object>>();
            services.AddScoped<IReadService<Model.TypeOfOffice, object>, BaseReadService<Model.TypeOfOffice, Database.TypeOfOffice, object>>();
            services.AddScoped<IReadService<Model.RentedOffice, object>, BaseReadService<Model.RentedOffice, Database.RentedOffice, object>>();
            services.AddScoped<IReadService<Model.CanceledOffice, object>, BaseReadService<Model.CanceledOffice, Database.CanceledOffice, object>>();
            services.AddScoped<IReadService<Model.OfficeReview, object>, BaseReadService<Model.OfficeReview, Database.OfficeReview, object>>();


            services.AddScoped<IUserAccountRoleService, UserAccountRoleService>();
            services.AddScoped<IBuildingService, BuildingService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOfficeService, OfficeService>();
            services.AddScoped<IUserAccountService, UserAccountService>();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.)
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
