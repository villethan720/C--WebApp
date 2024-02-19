using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C__part_2.Pages;

public class NextModel : PageModel
{
    private readonly ILogger<NextModel> _logger;

    public NextModel(ILogger<NextModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string nextEvent = "Tom Brady Coming Back?";
        string possible = "Rumors about Brady and Bill Belichick reuniting";
        ViewData["nextEvent"] =nextEvent + " " + possible;

    }

}