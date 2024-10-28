using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Numerics;

namespace WebApplicationTnsClub.Controllers
{
    [ApiController]
    [Route("api/download")]///[controller]
    [Produces("application/json")]
    public class DownloadController : Controller
    {
 
        private readonly IWebHostEnvironment _hostingEnvironment;
 
        public DownloadController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
  
        }

        private readonly string _fileRoot = @"C:\wwwroot\images\"; // Adjust this path as per your file location

        [HttpGet("images/{fileName}")]
       async public Task<IActionResult> Download(string fileName)
        {
            string filePath = Path.Combine(_fileRoot, fileName);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound(); // Or handle the scenario where file does not exist
            }

            return PhysicalFile(filePath, "image/jpeg");
        }
    }
}
