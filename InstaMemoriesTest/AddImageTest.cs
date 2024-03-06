using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Hosting;
using Xunit;
using Moq;
using WebApp.Models;
using WebApp.Pages.Forms;

namespace InstaMemoriesTest
{
    public class AddImageTest
    {
        [Fact]
        public void OnPost_ValidImage_UploadsSuccessfully()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<AddImage>>();
            var hostingEnvironmentMock = new Mock<IWebHostEnvironment>();

            // Set up a temporary directory for testing
            var tempDirectory = Path.Combine(Path.GetTempPath(), "TestImages", "wwwroot", "images");

            hostingEnvironmentMock.Setup(e => e.WebRootPath).Returns(tempDirectory);

            var pageModel = new AddImage(loggerMock.Object, hostingEnvironmentMock.Object);

            // Create a mock FormFile
            var formFile = new FormFile(new MemoryStream(new byte[] { 1, 2, 3 }), 0, 3, "imageFile", "test.jpg");

            // Act
            var result = pageModel.OnPost(formFile);

            // Assert
            Assert.IsType<RedirectToPageResult>(result);

            // Verify that the image file was saved in the specified directory
            var expectedImagePath = Path.Combine(tempDirectory, "images", "test.jpg");
            Assert.True(File.Exists(expectedImagePath), $"Image file does not exist at {expectedImagePath}");
        }
    }
}