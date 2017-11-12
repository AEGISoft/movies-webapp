using Microsoft.EntityFrameworkCore;

namespace app.web.mvc.Models
{
    public class appwebmvcContext : DbContext
    {
        public appwebmvcContext (DbContextOptions<appwebmvcContext> options)
            : base(options)
        {
        }

        public DbSet<app.web.mvc.Models.Movie> Movie { get; set; }
    }
}
