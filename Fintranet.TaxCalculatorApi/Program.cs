using Fintranet.TaxCalculatorModel;
using Fintranet.TaxCalculatorService.TaxCalculator.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Fintranet.TaxCalculatorApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMediatR(a =>
            {
                a.RegisterServicesFromAssembly(typeof(VehicleTaxCalculator).Assembly);
            }); 

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<CalculatorDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("default")));

            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<CalculatorDataContext>().Database.MigrateAsync().Wait(); 
            }

            app.UseSwagger();
            app.UseSwaggerUI(); 

            app.MapPost("/api/calculate", async (VehicleTaxCalculateDto request, IMediator mediator) =>
            {
                return await mediator.Send(request);
            });

            app.Run();
        }
    }
}
