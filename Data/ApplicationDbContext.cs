using Microsoft.EntityFrameworkCore;
using 2526_2221050384_BaiThi.Models;

namespace 2526_2221050384_BaiThi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Khai báo bảng
        public DbSet<Student> Students { get; set; }
    }
}