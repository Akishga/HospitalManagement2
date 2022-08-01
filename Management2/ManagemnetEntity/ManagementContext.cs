using Management2.Models;
using Microsoft.EntityFrameworkCore;

namespace Management2.ManagemnetEntity
{
    public class ManagementContext:DbContext
    {
        public ManagementContext(DbContextOptions<ManagementContext>options):base(options)
        {

        }
        public DbSet<Doctor> _AddDoc { get; set; }
    }
}
