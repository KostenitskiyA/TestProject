using System;
using Microsoft.EntityFrameworkCore;
using TestProject.Models;

namespace TestProject.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            /*Database.EnsureDeleted();
            Database.EnsureCreated();*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user1 = new User()
            {
                Id = 1,
                RegistrationDate = new DateTime(2021, 5, 14),
                LastActivityDate = new DateTime(2021, 5, 15)
            };
            var user2 = new User()
            {
                Id = 2,
                RegistrationDate = new DateTime(2021, 5, 14),
                LastActivityDate = new DateTime(2021, 5, 15)
            };
            var user3 = new User()
            {
                Id = 3,
                RegistrationDate = new DateTime(2021, 5, 14),
                LastActivityDate = new DateTime(2021, 5, 16)
            };
            var user4 = new User()
            {
                Id = 4,
                RegistrationDate = new DateTime(2021, 5, 15),
                LastActivityDate = new DateTime(2021, 5, 17)
            };
            var user5 = new User()
            {
                Id = 5,
                RegistrationDate = new DateTime(2021, 5, 15),
                LastActivityDate = new DateTime(2021, 5, 17)
            };
            var user6 = new User()
            {
                Id = 6,
                RegistrationDate = new DateTime(2021, 5, 16),
                LastActivityDate = new DateTime(2021, 5, 17)
            };
            var user7 = new User()
            {
                Id = 7,
                RegistrationDate = new DateTime(2021, 5, 17),
                LastActivityDate = new DateTime(2021, 5, 18)
            };
            var user8 = new User()
            {
                Id = 8,
                RegistrationDate = new DateTime(2021, 5, 17),
                LastActivityDate = new DateTime(2021, 5, 19)
            };
            var user9 = new User()
            {
                Id = 9,
                RegistrationDate = new DateTime(2021, 5, 17),
                LastActivityDate = new DateTime(2021, 5, 20)
            };
            var user10 = new User()
            {
                Id = 10,
                RegistrationDate = new DateTime(2021, 5, 17),
                LastActivityDate = new DateTime(2021, 5, 21)
            };
            var user11 = new User()
            {
                Id = 11,
                RegistrationDate = new DateTime(2021, 5, 18),
                LastActivityDate = new DateTime(2021, 5, 20)
            };
            var user12 = new User()
            {
                Id = 12,
                RegistrationDate = new DateTime(2021, 5, 18),
                LastActivityDate = new DateTime(2021, 5, 19)
            };
            var user13 = new User()
            {
                Id = 13,
                RegistrationDate = new DateTime(2021, 5, 19),
                LastActivityDate = new DateTime(2021, 5, 21)
            };
            var user14 = new User()
            {
                Id = 14,
                RegistrationDate = new DateTime(2021, 5, 20),
                LastActivityDate = new DateTime(2021, 5, 21)
            };
            var user15 = new User()
            {
                Id = 15,
                RegistrationDate = new DateTime(2021, 5, 20),
                LastActivityDate = new DateTime(2021, 5, 21)
            };
            var user16 = new User()
            {
                Id = 16,
                RegistrationDate = new DateTime(2021, 5, 20),
                LastActivityDate = new DateTime(2021, 5, 20)
            };

            modelBuilder.Entity<User>()
                .HasData(new User[]
                {
                    user1,
                    user2,
                    user3,
                    user4,
                    user5,
                    user6,
                    user7,
                    user8,
                    user9,
                    user10,
                    user11,
                    user12,
                    user13,
                    user14,
                    user15,
                    user16
                });
        }
    }
}
