
using Microsoft.EntityFrameworkCore;
using MiServicioWeb.Data;
using Universidad; // Replace 'YourNamespace.Models' with the actual namespace where AppDbContext is defined

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        services.AddControllers();
    }
}

