using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubClassLibrary.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CR3USUC;Database=ClubDb;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Membership>()
                .HasOne(m => m.Member)
                .WithMany(mb => mb.Memberships)
                .HasForeignKey(m => m.MemberId);

            modelBuilder.Entity<Membership>()
                .HasOne(m => m.MembershipType)
                .WithMany(mb => mb.Memberships)
                .HasForeignKey(m => m.MembershipTypeId);

            modelBuilder.Entity<Payment>()
                .HasOne(m => m.Membership)
                .WithMany(mb => mb.Payments)
                .HasForeignKey(m => m.MembershipId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Payment>()
                .HasOne(m => m.Member)
                .WithMany(mb => mb.Payments)
                .HasForeignKey(m => m.MemberId)
                .OnDelete(DeleteBehavior.NoAction); 

            // Seed Membership Types
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType { Id = 1, Name = "Standard", Description = "Basic membership", BasePrice = 50 },
                new MembershipType { Id = 2, Name = "Premium", Description = "Premium membership with extra features", BasePrice = 100 }
            );

            // Seed Members
            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, Name = "John Doe", PhoneNumber = "1234567890", BirthDate = new DateTime(1990, 5, 20), Address = "123 Main St" },
                new Member { Id = 2, Name = "Jane Smith", PhoneNumber = "9876543210", BirthDate = new DateTime(1985, 8, 10), Address = "456 Elm St" }
            );

            base.OnModelCreating(modelBuilder);
        }//sedding up the relationships between the tables 
    }
}
