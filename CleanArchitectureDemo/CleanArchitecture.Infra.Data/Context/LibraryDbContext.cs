using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Data.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options): base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
