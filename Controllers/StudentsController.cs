using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models;
using vidly_MVC;

namespace StudentPortal.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            

            //added myself
            if (ModelState.IsValid) {
                return View("AddConfirmation", viewModel);
            }


            return View(viewModel);
        }

        //starting the list functionality to list all the students
        [HttpGet]
        public async Task<IActionResult> List() 
        {
            var students = await dbContext.Students.ToListAsync();

            return View(students);
        }
    }
}