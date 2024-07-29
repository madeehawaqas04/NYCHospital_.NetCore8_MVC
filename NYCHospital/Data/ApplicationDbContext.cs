using Microsoft.EntityFrameworkCore;
using NYCHospital.Models;

namespace NYCHospital.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
    }
}

