using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Controllers;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FirstWebMVC.Controllers.Person> Person { get; set; } = default!;
        public DbSet<FirstWebMVC.Controllers.Student> Person { get; set; } = default!;
    }
