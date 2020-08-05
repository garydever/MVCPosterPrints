using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebStore.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //Seed database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Artwork>().HasData(new Artwork 
            { 
                ArtworkId = 1,
                Name = "Borobudur",
                Price = 450M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354589/Artwork/468_jcx5ul.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637950/Artwork/thumbs/468_jcx5ul_ihlzm3.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 2,
                Name = "The Samurai",
                Price = 320M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354587/Artwork/341_pbzjfl.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637949/Artwork/thumbs/341_pbzjfl_vuiyvn.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 3,
                Name = "Jakarta Square",
                Price = 500M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354586/Artwork/388_l2fdca.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637951/Artwork/thumbs/388_l2fdca_umlexg.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 4,
                Name = "Wooden Bridge",
                Price = 680M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354524/Artwork/183_nmetro.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637950/Artwork/thumbs/183_nmetro_vyqoba.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 5,
                Name = "Waterfalls",
                Price = 250M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354517/Artwork/163_fiikqb.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637949/Artwork/thumbs/163_fiikqb_cnysju.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 6,
                Name = "Flower Town",
                Price = 490M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354494/Artwork/102_ecai9z.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637949/Artwork/thumbs/102_ecai9z_jyyfuc.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 7,
                Name = "Costume Rack",
                Price = 345M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354415/Artwork/099_lijtxm.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637949/Artwork/thumbs/099_lijtxm_sqqa3p.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 8,
                Name = "The Tracks",
                Price = 400M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596635834/Artwork/663_fremja.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637950/Artwork/thumbs/049_veynib_axgpm9.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 9,
                Name = "Bangkok Bridge",
                Price = 280M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354414/Artwork/045_nanv2j.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637949/Artwork/thumbs/045_nanv2j_yzns7p.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 10,
                Name = "The Church",
                Price = 430M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354414/Artwork/014_x25gdn.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637951/Artwork/thumbs/014_x25gdn_vhusr8.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 11,
                Name = "The Punks",
                Price = 375M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1595354411/Artwork/072_zkdlzd.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637949/Artwork/thumbs/072_zkdlzd_b32se5.jpg"
            });
            modelBuilder.Entity<Artwork>().HasData(new Artwork
            {
                ArtworkId = 12,
                Name = "Train Yard",
                Price = 380M,
                IsSold = false,
                ImageUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596635834/Artwork/663_fremja.jpg",
                ThumbUrl = "https://res.cloudinary.com/dncjt6b7t/image/upload/v1596637952/Artwork/thumbs/663_fremja_vvgi7l.jpg"
            });
        }
    }
}
