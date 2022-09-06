using Microsoft.EntityFrameworkCore;
using NourApi.Service;

namespace NourApi.Model
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set;}
       public  DbSet<Company> Companys { get; set; }

    }
}
