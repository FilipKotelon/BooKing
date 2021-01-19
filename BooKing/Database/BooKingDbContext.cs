using Microsoft.EntityFrameworkCore;
using BooKing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooKing.Database
{
    public class BooKingDbContext : DbContext
    {
        public BooKingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApartmentEntity> Apartments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
