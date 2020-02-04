using Microsoft.EntityFrameworkCore;
using CoreAPI.Api.Models;

namespace CoreAPI.Api.Data
{
    public class CoreAPIContext :DbContext
    {
        public CoreAPIContext (DbContextOptions<CoreAPIContext> options) : base(options)
        {
        }

        public DbSet<Product> Products {get; set; }
        
    }
}