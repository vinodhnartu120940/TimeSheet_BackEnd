using Microsoft.EntityFrameworkCore;
using TimeSheets.API.Models;

namespace TimeSheets.API.Data
{
    public class TimeSheetsDbContext : DbContext
    {
        public TimeSheetsDbContext(DbContextOptions options) : base(options)
        {
        }
        //Dbset
        public DbSet<TimeSheet> TimeSheets { get; set; }
        
    }
}
