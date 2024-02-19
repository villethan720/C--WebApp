using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C__part_2.Pages;

public class PhotosModel : PageModel
{
    private readonly ILogger<PhotosModel> _logger;

    public PhotosModel(ILogger<PhotosModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
        
        string brand = "Photos";
        int yearStarted = 2024;              //information on back end that can be passed to the front end by calling the tag
        ViewData["brand"] = brand +" Established " + yearStarted;
    }

}