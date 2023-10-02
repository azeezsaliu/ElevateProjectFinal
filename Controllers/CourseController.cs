using ElevateProjectFinal.Models;
using ElevateProjectFinal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ElevateProjectFinal.Controllers
{
    public class CourseController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private ICourseService courseService;
        public CourseController(ICourseService courseService, IWebHostEnvironment hostEnvironment)
        {
            this.courseService = courseService;
            this._hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public async Task<IActionResult> CreateAsync(Course course, IFormFile ImageFile)
        {

            if (ModelState.IsValid)
            {
                //Save image to wwwroot/image
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                string extension = Path.GetExtension(ImageFile.FileName);
                string ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                course.ImageUrl = path;
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(fileStream);
                }
                //Insert record
                //courseContext.Add(course);
                courseService.Create(course);
                //await courseContext.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return View();
            } 
            //return View(imageModel);
            

            return View();
        }
    }
}
