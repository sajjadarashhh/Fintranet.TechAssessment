
using Carter;
using Fintranet.TaxCalculatorModel;
using Microsoft.EntityFrameworkCore;

namespace Fintranet.TaxCalculatorApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCarter();

            // Add services to the container.

            builder.Services.AddDbContext<CalculatorDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("default")));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<CalculatorDataContext>().Database.Migrate();
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.MapCarter();



            app.Run();
        }
    }
}
