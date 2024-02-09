using Microsoft.EntityFrameworkCore;

namespace vidly_MVC;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }

    

}
