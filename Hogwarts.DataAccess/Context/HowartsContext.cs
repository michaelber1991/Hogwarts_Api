using Hogwarts.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.DataAccess.Context
{
    public class HowartsContext : DbContext
    {
        public DbSet<AdmissionRequest> AdmissionRequest { get; set; }

        public DbSet<House> House { get; set; }

        public HowartsContext(DbContextOptions<HowartsContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdmissionRequest>().HasKey(p => p.Id);
            modelBuilder.Entity<AdmissionRequest>().Property(p => p.Name).HasMaxLength(20);
            modelBuilder.Entity<AdmissionRequest>().Property(p => p.LastName).HasMaxLength(20);
            modelBuilder.Entity<AdmissionRequest>().Property(p => p.Identification).HasMaxLength(10);
            modelBuilder.Entity<AdmissionRequest>().Property(p => p.Age).HasMaxLength(10);


            modelBuilder.Entity<House>().HasKey(p => p.Id);
            modelBuilder.Entity<House>().Property(p => p.Name).HasMaxLength(20);

            // Seed
            modelBuilder.Entity<House>().HasData(new House() 
            {
                Id = new Guid("11e6f800-a51d-4981-bd1b-a7ce662323b7"),
                Name = "Gryffindor"
            });;

            modelBuilder.Entity<House>().HasData(new House()
            {
                Id = new Guid("d4345b32-b146-41b4-ab0c-53e82c47d07e"),
                Name = "Hufflepuff"
            }); ;

            modelBuilder.Entity<House>().HasData(new House()
            {
                Id = new Guid("0f444e63-249c-4f72-a031-d5df767fa456"),
                Name = "Ravenclaw"
            }); ;

            modelBuilder.Entity<House>().HasData(new House()
            {
                Id = new Guid("a01844d7-e79a-475d-b87d-91dd55776e0f"),
                Name = "Slytherin"
            }); ;
        }
    }

}
