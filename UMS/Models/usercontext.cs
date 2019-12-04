using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMS.Models
{
    public class usercontext : DbContext
    {
        public usercontext(DbContextOptions<usercontext>options) : base(options)
        {

        }

        public DbSet<user> user { get; set; }
    }
}
