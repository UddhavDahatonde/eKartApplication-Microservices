
using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using NLog;
using Product.Core.Domain.RepositeryContract;
using Product.Core.Services;
using Product.Core.ServicesContract;
using Product.Infrastructure.DataContext;
using Product.Infrastructure.Repositery;

namespace Product.Api
{
    public class Program
    {
        private static readonly NLog.ILogger logger = LogManager.GetCurrentClassLogger();
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            builder.Services.AddControllers();
            //builder.Services.AddLogging();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            builder.Services.AddScoped(typeof(ICategoryRepositery), typeof(CategoryRepositery));
            builder.Services.AddScoped(typeof(IProductService), typeof(ProductServices));
            builder.Services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            builder.Services.AddSingleton<ILoggerManager, LoggerManager>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
               builder =>
               {
                   builder.WithOrigins("http://localhost:4200")
                       .AllowAnyHeader()
                       .AllowAnyMethod();
               });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowOrigin");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
