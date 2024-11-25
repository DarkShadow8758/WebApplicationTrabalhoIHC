using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationTrabalhoIHC.Models;

namespace WebApplicationTrabalhoIHC.Data
{
    public class WebApplicationTrabalhoIHCContext : DbContext
    {
        public WebApplicationTrabalhoIHCContext (DbContextOptions<WebApplicationTrabalhoIHCContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationTrabalhoIHC.Models.Cliente> Cliente { get; set; } = default!;
    }
}
