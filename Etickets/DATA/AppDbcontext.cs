using Microsoft.EntityFrameworkCore;

namespace Etickets.DATA
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext>options):base (options)
        {

        }
    }
}
