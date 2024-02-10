using Microsoft.AspNetCore.Mvc;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddStudentViewModel viewModel)
        {
            // return View(); what the video said

            if (ModelState.IsValid) {
                return View("AddConfirmation", viewModel);
            }

            return View(viewModel);
        }
    }
}