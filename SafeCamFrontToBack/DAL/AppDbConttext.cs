using Microsoft.EntityFrameworkCore;
using SafeCamFrontToBack.Models;

namespace SafeCamFrontToBack.DAL;

public class AppDbConttext : DbContext
{
    public AppDbConttext(DbContextOptions<AppDbConttext> options) : base(options)
    {
    }

    public DbSet<Slider> Sliders { get; set; }
    
    public DbSet<TeamMember> TeamMembers { get; set; }
}