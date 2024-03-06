using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp.Pages.Forms
{
    public class AddImage : PageModel
    {
        private readonly ILogger<AddImage> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AddImage(ILogger<AddImage> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
        }

        /// <summary>
        /// Handles the HTTP POST request for uploading an image file.
        /// </summary>
        /// <param name="imageFile">The uploaded image file.</param>
        /// <returns>
        /// Returns an <see cref="IActionResult"/> representing the result of the action.
        /// If the image upload is successful, it redirects to the index page.
        /// If the image upload fails, it returns the current page.
        /// </returns>
        public IActionResult OnPost(IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                // Specify the path where you want to save the uploaded image
                var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", imageFile.FileName);
                var directoryPath = Path.GetDirectoryName(imagePath);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Save the uploaded image to the specified path
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                _logger.LogInformation("Image uploaded successfully.");

                // Redirect to the index page or any other page
                return RedirectToPage("/Index");
            }

            _logger.LogError("Image upload failed.");

            // Handle the case where the image upload fails
            return Page();
        }
    }
}