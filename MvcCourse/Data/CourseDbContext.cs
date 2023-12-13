using Microsoft.EntityFrameworkCore;
using MvcCourse.Data.Entities;

namespace MvcCourse.Data;

public class CourseDbContext : DbContext
{
    public CourseDbContext(DbContextOptions<CourseDbContext> options)
        : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; } = null!;
}