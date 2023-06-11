using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EFlabDay2.Models
{
    public  class BlogContext:DbContext
    {
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Blogging;Integrated Security=True;TrustServerCertificate=True");
        }
       

    }
}
