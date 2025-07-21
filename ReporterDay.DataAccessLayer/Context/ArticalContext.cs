using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.DataAccessLayer.Context
{
    public class ArticalContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O65VQEH\\SQLEXPRESS;initial catalog=ReporterBlogDayDb;integrated security=true;trust server certificate=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Artical> Articals { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Slider> Sliders  { get; set; }
        public DbSet<Tag>  Tags { get; set; }
    }
}
