using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPICore3.Models;

namespace WebAPICore3.Data
{
    public class WebAPICore3Context : DbContext
    {
        public WebAPICore3Context (DbContextOptions<WebAPICore3Context> options)
            : base(options)
        {
        }

        public DbSet<WebAPICore3.Models.User> User { get; set; }
    }
}
