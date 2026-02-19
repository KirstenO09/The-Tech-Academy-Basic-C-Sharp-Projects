using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;


namespace CarInsurance.Data
{
    public class CarInsuranceContext : DbContext
    {
        public CarInsuranceContext(DbContextOptions<CarInsuranceContext> options) : base(options)
        {
            
        }

        public DbSet<Insuree> Insuree { get; set; }
    }
}
