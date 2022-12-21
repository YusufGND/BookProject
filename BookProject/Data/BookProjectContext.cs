using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookProject.Models;

namespace BookProject.Data
{
    public class BookProjectContext : DbContext
    {
        public BookProjectContext (DbContextOptions<BookProjectContext> options)
            : base(options)
        {
        }

        public DbSet<BookProject.Models.book> book { get; set; }

        public DbSet<BookProject.Models.usersaccounts> usersaccounts { get; set; }

        public DbSet<BookProject.Models.orders> orders { get; set; }
        public DbSet<BookProject.Models.report> report { get; set; }

    }
}
