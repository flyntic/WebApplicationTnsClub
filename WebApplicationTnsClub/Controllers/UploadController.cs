using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.IO;
using System.Net.Http.Headers;
using System.Numerics;
using WebApplicationTnsClub.Services;

namespace WebApplicationTnsClub.Controllers
{
    [ApiController]
    [Route("api/upload")]///[controller]
    [Produces("application/json")]
    public class UploadController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public UploadController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> UploadFile()
        {

            if (!Request.Form.Files.Any())
                return BadRequest("No files found in the request");

            if (Request.Form.Files.Count > 1)
                return BadRequest("Cannot upload more than one file at a time");

            if (Request.Form.Files[0].Length <= 0)
                return BadRequest("Invalid file length, seems to be empty");

            try
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                string uploadsDir = Path.Combine(webRootPath, "images");

                // wwwroot/images/
                if (!Directory.Exists(uploadsDir))
                    Directory.CreateDirectory(uploadsDir);

                IFormFile file = Request.Form.Files[0];
                string fileName = "temp"+ Guid.NewGuid().ToString()+ DateTime.Now.ToString("-dd-MM-yy-hh-mm-ss-") + new FileInfo(System.Net.Http.Headers.ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName).Extension.Trim('"');
                string fullPath = Path.Combine(uploadsDir, fileName);

                using var image = Image.Load(file.OpenReadStream());
                image.Mutate(x => x.Resize(100, 100));
                await image.SaveAsync(fullPath);

                string location=$"images/{fileName}";
                var result = new
                {
                    message = "Upload successful",
                    url = location
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Upload failed: " + ex.Message);
            }
        }
    }
}
