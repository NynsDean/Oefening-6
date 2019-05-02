using H6.Oefeningen.web.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6.Oefeningen.web.Data
{
    public class LuchtvaartContext : DbContext
    {
        public LuchtvaartContext(DbContextOptions<LuchtvaartContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArrivingFlight>().
                HasKey(af => af.Id);

            modelBuilder.Entity<ArrivingFlight>().
                Property(af => af.Origin).
                IsRequired();

            modelBuilder.Entity<ArrivingFlight>().
                Property(af => af.ActualTime).
                IsRequired();

            modelBuilder.Entity<ArrivingFlight>().
                Property(af => af.ScheduledTime).
                IsRequired();

            modelBuilder.Entity<ArrivingFlight>().
                Property(af => af.Airline).
                IsRequired();

            modelBuilder.Entity<ArrivingFlight>()
                       .HasOne(af => af.Airline)
                       .WithMany(a => a.ArrivingFlights)
                       .IsRequired(false)
                       .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<DepartingFlight>()
                       .HasOne(df => df.Airline)
                       .WithMany(a => a.DepartingFlights)
                       .IsRequired(false)
                       .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);
        } 

        public DbSet<Airline> Airline { get; set; }
        public DbSet<ArrivingFlight> ArrivingFlights { get; set; }
        public DbSet<DepartingFlight> DepartingFlights { get; set; }


    }
}
