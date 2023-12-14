using Microsoft.EntityFrameworkCore;
using CourseManagement.Data.Entities;

namespace CourseManagement.Data;

public class CourseDbContext : DbContext
{
    public CourseDbContext(DbContextOptions<CourseDbContext> options)
        : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; } = null!;
}