using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace blazorapp.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> AppUsers {get; set;}
        public DbSet<Tesoro> Tesoros {get; set;}
        public DbSet<Coordinate> Coordinates {get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>(entityTypeBuilder => {
                entityTypeBuilder.ToTable("Users");
                entityTypeBuilder.Property(u => u.Uid).HasMaxLength(100).IsRequired();
                entityTypeBuilder.Property(u => u.Name).HasMaxLength(100);
                entityTypeBuilder.Property(u => u.Color).HasMaxLength(8).HasDefaultValue("#ffffff");
            });
        }
    }
    public class AppUser : IdentityUser
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
    public class Tesoro
    {
        public Guid Uid {get; set;}
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string Descripcion {get; set;}
        public DateTime Date {get; set;}
        public float Weight {get; set;}
        public string Lugar {get; set;}
        public string Valor {get; set;}
        public Coordinate Coordinates {get; set;}
        public string UrlRef {get; set;}
    }
    public class Coordinate 
    {
        public Guid Id {get; set;}
        public Guid Tid {get; set;}
        public Guid Uid {get; set;}
        public float Lat {get; set;}
        public float Lng {get; set;}
    }
}
