
using API_with_EntitiyFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace API_with_EntitiyFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Adatbázis kapcsolat hozzáadása
            builder.Services.AddDbContext<ShopDbContext>(options=>options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=ProductDB;Trusted_Connection=True"));

            //Nuget konzolba: add-migration InitialCreate -> update-database

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
