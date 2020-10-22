using EntityFrameworkCase.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCase.Infrastructure.EntityFramework
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<FirstName> FirstName { get; set; }
        public DbSet<Street> Street { get; set; }
        public DbSet<Surname> Surname { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Workplace> Workplace { get; set; }
    }
}
