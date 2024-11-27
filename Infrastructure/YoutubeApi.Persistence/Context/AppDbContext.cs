﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Brand>Brands { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Tüm konfigrasyon dosyalarını bulur.
            
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        //}
    }
}
