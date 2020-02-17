using System;
using Microsoft;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesStudent.Data
{
    public class RazorPagesStudentContext : DbContext
    {
        public RazorPagesStudentContext(
            DbContextOptions<RazorPagesStudentContext> options)
            : base(options)
        {
        }

        public DbSet<ProgClub.Models.Student> Student { get; set; }
    }

}