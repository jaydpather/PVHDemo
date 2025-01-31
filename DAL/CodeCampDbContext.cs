﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class CodeCampDbContext : DbContext
    {
        
        public CodeCampDbContext(DbContextOptions<CodeCampDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistrationModel>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<ProgrammingLanguageModel>()
                .HasKey(x => x.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //todo: add web.config settingfor connection string
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CodeCamp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<RegistrationModel> Registrations { get; set; }
        public DbSet<ProgrammingLanguageModel> ProgrammingLanguagesMaster { get; set; }
    }
}
