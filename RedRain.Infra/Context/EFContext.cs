﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RedRain.Domain;

namespace RedRain.Infra.Context
{
    public class EFContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public EFContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Entity> Entities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            var connectionString = _configuration.GetConnectionString("DBConnection");
            optionsBuilder
                .UseSqlServer(connectionString);
        }
    }
}
