using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C__part_2.Pages;

public class AboutModel : PageModel
{
    private readonly ILogger<AboutModel> _logger;

    public AboutModel(ILogger<AboutModel> logger)
    {
        _logger = logger;
    }

    

    public void OnGet()
    {
        string info = "This is a massive National Football Game.";
        string place = " This game took place in Las Vegas";
        string teams = " between the Kansas City Chiefs vs San Francisco 49ers.";
        string winner = " The game went down to the wire, but the Chiefs won it on the last play of the game.";
        string score = " The score ended 25-22 in overtime.";

        ViewData["info"] = info + place + teams + winner + score;

    }

}