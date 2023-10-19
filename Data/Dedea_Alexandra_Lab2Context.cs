using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dedea_Alexandra_Lab2.Models;

namespace Dedea_Alexandra_Lab2.Data
{
    public class Dedea_Alexandra_Lab2Context : DbContext
    {
        public Dedea_Alexandra_Lab2Context (DbContextOptions<Dedea_Alexandra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dedea_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dedea_Alexandra_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Dedea_Alexandra_Lab2.Models.Author>? Author { get; set; }
    }
}
