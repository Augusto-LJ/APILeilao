﻿using Microsoft.EntityFrameworkCore;
using APILeilao.API.Entities;

namespace APILeilao.API.Repositories
{
    public class APILeilaoDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\projetos\APILeilao\leilaoDbNLW.db");
        }
    }
}
