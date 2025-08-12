using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject
{
    internal class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookStore;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        
        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Project Hail Mary", Author = "Andy Weir", Genre = "Science Fiction", ImageData = ImageToByteArray(Properties.Resources.generic_book), Price = 24.99m },
                new Book { Id= 2, Name = "The Will of The Many", Author = "James Islington", Genre = "Fantasy", ImageData = ImageToByteArray(Properties.Resources.The_Will_of_the_Many), Price = 19.99m },
                new Book { Id = 3,Name = "The Myth of Normal", Author = "Gabor Maté", Genre = "Psychology", ImageData = ImageToByteArray(Properties.Resources.myth_of_normal), Price = 22.99m },
                new Book { Id = 4, Name = "Blood Over Bright Haven", Author = "M. L. Wang", Genre = "Fantasy", ImageData = ImageToByteArray(Properties.Resources.blood_over_bright_haven), Price = 18.99m },
                new Book { Id=5, Name = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", ImageData = ImageToByteArray(Properties.Resources.Great_gasby), Price = 10.99m },
                new Book { Id=6, Name = "The Anxious Generation", Author = "Jonathan Haidt", Genre = "Psychology", ImageData = ImageToByteArray(Properties.Resources.anxious_generation), Price = 15.99m },
                new Book { Id = 7,Name = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", ImageData = ImageToByteArray(Properties.Resources.to_kill_mockingbird), Price = 12.99m },
                new Book { Id=8, Name = "1984", Author = "George Orwell", Genre = "Dystopian", ImageData = ImageToByteArray(Properties.Resources._1984), Price = 14.99m },
                new Book { Id = 9,Name = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", ImageData = ImageToByteArray(Properties.Resources.catcher_in_the_rye), Price = 11.99m },
                new Book { Id = 10,Name = "I'll Give You the Sun", Author = "Jandy Nelson", Genre = "Fiction", ImageData = ImageToByteArray(Properties.Resources.ill_give_you_the_sun), Price = 9.99m },
                new Book { Id= 11, Name = "The Alchemist", Author = "Paulo Coelho", Genre = "Fiction", ImageData = ImageToByteArray(Properties.Resources.the_alchemist), Price = 13.99m },
                new Book { Id = 12, Name = "The Hunger Games", Author = "Suzanne Collins", Genre = "Dystopian", ImageData = ImageToByteArray(Properties.Resources.Hunger_Games), Price = 12.99m },
                new Book { Id = 13, Name = "The Fault in Our Stars", Author = "John Green", Genre = "Fiction", ImageData = ImageToByteArray(Properties.Resources.fault_in_our_stars), Price = 14.99m },
                new Book { Id = 14, Name = "The Way of Kings", Author = "Brandon Sanderson", Genre = "Fantasy", ImageData = ImageToByteArray(Properties.Resources.way_of_kings), Price = 24.99m },
                new Book { Id = 15, Name = "The Silent Patient", Author = "Alex Michaelides", Genre = "Thriller", ImageData = ImageToByteArray(Properties.Resources.silent_patient), Price = 16.99m },
                new Book { Id = 16, Name = "Educated", Author = "Tara Westover", Genre = "Memoir", ImageData = ImageToByteArray(Properties.Resources.educated), Price = 17.99m },
                new Book { Id = 17, Name = "Red Rising", Author = "Pierce Brown", Genre = "Science Fiction", ImageData = ImageToByteArray(Properties.Resources.Red_Rising), Price = 19.99m },
                new Book { Id = 18, Name = "Archetype ", Author = "M. D. Waters", Genre = "Science Fiction", ImageData = ImageToByteArray(Properties.Resources.archetype), Price = 18.99m },
                new Book { Id = 19, Name = "Dark Matter", Author = "Blake Crouch", Genre = "Thriller", ImageData = ImageToByteArray(Properties.Resources.dark_matter), Price = 20.99m },
                new Book { Id = 20, Name = "Born a Crime", Author = "Trevor Noah", Genre = "Memoir", ImageData = ImageToByteArray(Properties.Resources.born_a_crime), Price = 15.99m },
                new Book { Id= 21, Name = "Scythe", Author = "Neal Shusterman", Genre = "Dystopian", ImageData = ImageToByteArray(Properties.Resources.scythe), Price = 14.99m },
                new Book { Id= 22, Name="The Boy We Made", Author = "Taylor Harris", Genre = "Memoir", ImageData = ImageToByteArray(Properties.Resources.the_boy_we_made), Price = 22.99m },
                new Book { Id = 23, Name= "Like Streams to the Ocean", Author = "Jedidiah Jenkins", Genre = "Memoir", ImageData = ImageToByteArray(Properties.Resources.like_streams_to_the_ocean), Price = 16.99m },
                new Book { Id = 24, Name = "Gone Girl", Author = "Gillian Flynn", Genre = "Thriller", ImageData = ImageToByteArray(Properties.Resources.gone_girl), Price = 18.99m }
            );
        }
    }
}
