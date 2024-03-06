using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    /// <summary>
    /// Represents an image model.
    /// </summary>
    public class ImageModel
    {
        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets the description of the image.
        /// </summary>
        public string Description { get; set; }
    }
}