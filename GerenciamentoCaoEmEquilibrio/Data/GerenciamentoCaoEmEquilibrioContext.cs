using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GerenciamentoCaoEmEquilibrio.Models;

    public class GerenciamentoCaoEmEquilibrioContext : DbContext
    {
        public GerenciamentoCaoEmEquilibrioContext (DbContextOptions<GerenciamentoCaoEmEquilibrioContext> options)
            : base(options)
        {
        }

        public DbSet<GerenciamentoCaoEmEquilibrio.Models.Tutor> Tutor { get; set; }
    }
