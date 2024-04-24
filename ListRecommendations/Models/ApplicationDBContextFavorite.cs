using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRecommendations.Models
{
    public class ApplicationDBContextFavorite : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DBProject.db");
        }
        public DbSet<Favorite> Favorites { get; set; }
    }
}
