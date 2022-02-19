using Kanban.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Kanban.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<List> Lists { get; set; }
    }
}