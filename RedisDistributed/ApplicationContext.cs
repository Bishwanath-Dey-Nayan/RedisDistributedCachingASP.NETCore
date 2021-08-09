using Microsoft.EntityFrameworkCore;
using RedisDistributed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisDistributed
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base (options)
        {

        }
        public ApplicationContext()
        {

        }
        public DbSet<Student> Student { get; set; }
    }
}
