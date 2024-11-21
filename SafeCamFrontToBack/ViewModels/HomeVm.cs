using SafeCamFrontToBack.Models;

namespace SafeCamFrontToBack.ViewModels;

public class HomeVm
{
    public List<Slider> Sliders { get; set; }
    public List<Services> Services { get; set; }
    public List<TeamMember> TeamMembers { get; set; }
}