using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagement.Model;

namespace LibraryManagement.Db
{
    public class LibraryContext : DbContext

    {

        private readonly string _connectionString;
        public LibraryContext()
        {
            _connectionString = "Server=DREAM-HOUSE;Database =DBLibraryManagement;User Id=sa;Password=1287;";
        }
        public LibraryContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
       
        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.Entity<IssueBook>()
                .HasOne(bi => bi.Student)
                .WithMany(s => s.BookIssues)
                .HasForeignKey(bi => bi.StudentId);

            builder.Entity<ReturnBook>()
                .HasKey(rb => new { rb.StudentId, rb.BookBarCode });
            builder.Entity<ReturnBook>()
                .HasOne(rb => rb.Student)
                .WithMany(s => s.BookReturns)
                .HasForeignKey(rb => rb.StudentId);
            base.OnModelCreating(builder);

        }
        public DbSet<StudentInfo> Students { get; set; }
        public DbSet<BookInfo> Books { get; set; }
        public DbSet<IssueBook> IssueBook { get; set; }
        public DbSet<ReturnBook> ReturnBooks { get; set; }


    }
}
