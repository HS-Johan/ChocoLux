using ChocoLux.DataModels;
using Microsoft.EntityFrameworkCore;

namespace ChocoLux.Data
{
    public class ChocoLuxContext : DbContext
    {
        public ChocoLuxContext(DbContextOptions<ChocoLuxContext> options) : base(options)
        {

        }

        public DbSet<ContactUs> ContactUs { get; set; } = default!;

        public DbSet<Testimonial> Testimonial { get; set; } = default!;

    }
}
