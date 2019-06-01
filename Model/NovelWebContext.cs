using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class NovelWebContext : DbContext
    {
        public NovelWebContext(DbContextOptions<NovelWebContext> options) : base(options)
        {

        }

        public DbSet<BookChapter> BookChapter { get; set; }
        public DbSet<BookInfo> BookInfo { get; set; }
        public DbSet<BookType> BookType { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Collect> Collect { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookChapter>().ToTable("BookChapter");
            modelBuilder.Entity<BookInfo>().ToTable("BookInfo");
            modelBuilder.Entity<BookType>().ToTable("BookType");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Collect>().ToTable("Collect");

            //modelBuilder.Entity<BookChapter>(entity =>
            //{
            //    entity.HasKey("");
            //});

            base.OnModelCreating(modelBuilder);
        }
    }
}
