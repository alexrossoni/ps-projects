using Microsoft.EntityFrameworkCore;
using MinimalMvc.Model;

namespace MinimalMvc.Controller.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddDbContext<MinimalMvcDb>(opt => opt.UseInMemoryDatabase("MinimalMvc"));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            var app = builder.Build();
            app.MapControllers();
            app.Run();
        }
    }
}