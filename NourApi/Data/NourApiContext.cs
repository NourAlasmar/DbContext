using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NourApi.Model;

namespace NourApi.Data
{
    public class NourApiContext : DbContext
    {
        public NourApiContext (DbContextOptions<NourApiContext> options)
            : base(options)
        {
        }

        public DbSet<NourApi.Model.Company> Company { get; set; } = default!;
    }
}
