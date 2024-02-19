using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C__part_2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string[] players = new string[4]{"Mahomes", "Purdy", "McCaffrey", "Pacheco"};
        int[] yards = new int[4]{333, 255, 80, 66};
        int[] touchdowns = new int[4]{2, 1, 0, 0};

        string betterQuarter;
        string betterRunning;
        

        string player1 = players[0] + " is the Chiefs Quarterback. He got " + yards[0] + " passing yards and " + touchdowns[0] + " touchdowns in the air.";
        string player2 = players[1] + " is the 49ers Quarterback. He got " + yards[1] + " passing yards and " + touchdowns[1] + " touchdowns in the air.";
        string player3 = players[2] + " is the 49ers Running back. He got " + yards[2] + " rushing yards and " + touchdowns[2] + " rushing touchdowns";
        string player4 = players[3] + " is the Chiefs Running back. He got " + yards[3] + " rushing yards and " + touchdowns[3] + " rushing touchdowns";

        @ViewData["player1"] = player1;
        @ViewData["player2"] = player2;
        @ViewData["player3"] = player3;
        @ViewData["player4"] = player4;

        if(yards[0] > yards[1]){
            betterQuarter = players[0];
        } else{
            betterQuarter = players[1];
        }

        if(yards[2] > yards[3]){
            betterRunning = players[2];
        } else{
            betterRunning = players[3];
        }

        @ViewData["betterQuarter"] = "The better quarterback this game was " + betterQuarter;
        @ViewData["betterRunning"] = "The better running back this game was " + betterRunning;
    }
}

