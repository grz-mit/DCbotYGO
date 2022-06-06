using DiscordBotYGO.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotYGO.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CardModel> Cards { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }

    }
}
