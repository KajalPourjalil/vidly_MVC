using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models;

namespace vidly_MVC;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; }

}
