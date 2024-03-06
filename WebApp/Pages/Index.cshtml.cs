using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<ImageModel> Images { get; set; } = new List<ImageModel>();

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    
    public void OnGet()
    {
        // Replace "YourImagePath" with the actual path to your images folder
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

            // Check if the images folder exists
            if (Directory.Exists(imagePath))
            {
                // Get all image files from the folder
                var imageFiles = Directory.GetFiles(imagePath, "*.jpg"); // Adjust the file extension as needed

                // Populate the Images list with ImageModel objects
                Images = imageFiles.Select(file => new ImageModel
                {
                    ImagePath = Path.Combine("/images", Path.GetFileName(file)),
                    Description = Path.GetFileNameWithoutExtension(file) // You can read descriptions from a file or another source
                }).ToList();
            }
            else
            {
                _logger.LogError("Images folder not found at: {ImagePath}", imagePath);
                // Handle the case where the images folder is not found
            }
    }
}


