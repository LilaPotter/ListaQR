
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ListaQR.Models;


namespace ListaQR
{
    public class applicationDbContext : DbContext
    {
        public DbSet<usuarios_model> usuarios { get; set; }
        public applicationDbContext(DbContextOptions<applicationDbContext> options) : base(options)
        {

        }        

    }
}
