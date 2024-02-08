namespace vidly_MVC
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() {
                nameof = "Shrek"
            };
            return View();
        }
    }
    
}