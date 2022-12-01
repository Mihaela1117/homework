using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK
{
    public class Context:DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalType> Types { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder) =>
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Animal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
