using Microsoft.EntityFrameworkCore;
using SafeCamFrontToBack.DAL;

namespace SafeCamFrontToBack;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<AppDbConttext>(opt =>
            opt.UseSqlServer(
                "Server=localhost,51433;Database=safe_cam; " +
                "User ID=sa;Password=StrongP@ssw0rd123;TrustServerCertificate=True")
        );

        var app = builder.Build();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
        );

        app.UseStaticFiles();

        app.Run();
    }
}