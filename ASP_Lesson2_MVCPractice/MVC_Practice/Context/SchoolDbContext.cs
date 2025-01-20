using Microsoft.EntityFrameworkCore;
using MVC_Practice.Entities;

namespace MVC_Practice.Context
{
    public class SchoolDbContext: DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
