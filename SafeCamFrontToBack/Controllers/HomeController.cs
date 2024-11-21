using Microsoft.AspNetCore.Mvc;
using SafeCamFrontToBack.DAL;
using SafeCamFrontToBack.Models;
using SafeCamFrontToBack.ViewModels;

namespace SafeCamFrontToBack.Controllers;

public class HomeController : Controller
{
    private readonly AppDbConttext _conttext;

    public HomeController(AppDbConttext appDbConttext)
    {
        _conttext = appDbConttext;
    }
    
    public IActionResult Index()
    {
        List<Slider> sliders = _conttext.Sliders.ToList();
        
        List<Services> services = new List<Services>();
        Services service1 = new Services()
        {
            Title = "CCTV1",
            Description = "CCTV1 Description",
            About = "CCTV1 About",
        };
        Services service2 = new Services()
        {
            Title = "CCTV2",
            Description = "CCTV2 Description",
            About = "CCTV2 About",
        };
        Services service3 = new Services()
        {
            Title = "CCTV3",
            Description = "CCTV3 Description",
            About = "CCTV3 About",
        };
        services.Add(service1);
        services.Add(service2);
        services.Add(service3);
        
        List<TeamMember> teamMembers = new List<TeamMember>();
        TeamMember teamMember1 = new TeamMember()
        {
            Name = "John",
            Position = "Backend Developer",
            ImgUrl = "team-1.jpg"
        };
        
        TeamMember teamMember2 = new TeamMember()
        {
            Name = "Tommas",
            Position = "Front Developer",
            ImgUrl = "team-3.jpg"
        };
        
        TeamMember teamMember3 = new TeamMember()
        {
            Name = "Sherif",
            Position = "Cyber Security",
            ImgUrl = "team-2.jpg"
        };
        
        teamMembers.Add(teamMember1);
        teamMembers.Add(teamMember2);
        teamMembers.Add(teamMember3);
        
        _conttext.TeamMembers.AddRange(teamMembers);
        _conttext.SaveChanges();
        
        HomeVm vm = new HomeVm()
        {
            Sliders = sliders,
            Services = services,
            TeamMembers = teamMembers,
        };
        
        return View(vm);
    }
}