using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIcatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APIcatalogo.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ): base( options ){}
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
    }
}