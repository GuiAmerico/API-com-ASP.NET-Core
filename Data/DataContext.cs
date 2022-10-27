using API_com_ASP.NET_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API_com_ASP.NET_Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Pessoa> pessoa {get; set;}
    }
}