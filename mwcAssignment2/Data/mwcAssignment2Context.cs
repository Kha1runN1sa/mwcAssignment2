using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mwcAssignment2.Models
{
    public class mwcAssignment2Context : DbContext
    {
        public mwcAssignment2Context (DbContextOptions<mwcAssignment2Context> options)
            : base(options)
        {
        }

        public DbSet<mwcAssignment2.Models.Blog> Blog { get; set; }
    }
}
