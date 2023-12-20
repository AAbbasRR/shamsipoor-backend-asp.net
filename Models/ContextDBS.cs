
using Microsoft.EntityFrameworkCore;

namespace Abbas_Rahimzadeh.Models
{
    public class ContextDBS:DbContext
    {
        public ContextDBS(DbContextOptions<ContextDBS> options):base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Contact> Cantact { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}