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
        public DbSet<BookType> _BookType { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Collect> Collect { get; set; }
        public DbSet<FriendLink> FriendLink { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<WebConfig> WebConfig { get; set; }
        public DbSet<_BookTags> _BookTags { get; set; }
        public DbSet<Carousel> Carousel { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookChapter>().ToTable("BookChapter");
            modelBuilder.Entity<BookInfo>().ToTable("BookInfo");
            modelBuilder.Entity<BookType>().ToTable("BookType");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Collect>().ToTable("Collect");
            modelBuilder.Entity<FriendLink>().ToTable("FriendLink");
            modelBuilder.Entity<Tags>().ToTable("Tags");
            modelBuilder.Entity<WebConfig>().ToTable("WebConfig");
            modelBuilder.Entity<_BookTags>().ToTable("_BookTags");
            modelBuilder.Entity<Carousel>().ToTable("Carousel");

            //modelBuilder.Entity<BookChapter>(entity =>
            //{
            //    entity.HasKey("");
            //});

            base.OnModelCreating(modelBuilder);
        }
    }
}
