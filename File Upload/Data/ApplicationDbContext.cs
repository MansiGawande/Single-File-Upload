using File_Upload.Models;
using Microsoft.EntityFrameworkCore;

namespace File_Upload.Data
{
    public class ApplicationDbContext :DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        }
        public DbSet<Gift> Gifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Gift>().HasData( // seed data
               new Gift
               {
                   Id = 1,
                   GiftImage = "https://media.istockphoto.com/id/1443034333/photo/christmas-or-birthday-gift-box-on-white-wooden-table-against-blue-turquoise-bokeh-lights.jpg?s=612x612&w=0&k=20&c=9EzZqIg271JMqgd5m6JutoPxrsKtQAXzM-r_QyHTkws=",

               },
               new Gift
               {
                   Id = 2,
                   GiftImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZoVPSd6j-4ifkP5-Ec63-2GIsB29FMM5g9w&s",

               });
        }


    }
}
