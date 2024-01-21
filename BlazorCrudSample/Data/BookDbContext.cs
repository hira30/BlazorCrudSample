using BlazorCrudSample.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudSample.Data
{
    public class BookDbContext(DbContextOptions<BookDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "リーダブルコード", Author = "Dustin Boswell, Trevor Foucher",　Publisher = "オライリージャパン", PublihedYear = 2012 },
                new Book { Id = 2, Title = "ハリー・ポッターと賢者の石", Author = "J.K.ローリング", Publisher = "静山社", PublihedYear = 1999 },
                new Book { Id = 3, Title = "坂の上の雲", Author = "司馬遼太郎", Publisher = "文藝春秋", PublihedYear = 1999 }
                );
        }

        public DbSet<Book> Books { get; set; }
    }
}
