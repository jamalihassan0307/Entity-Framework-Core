
using Entity_Framework_Core_test.Models;
using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
namespace Entity_Framework_Core_test.DB
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }

}
