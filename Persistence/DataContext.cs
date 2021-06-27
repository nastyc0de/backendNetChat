using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Channel> Channels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Channel>()
                .HasData(new Channel
                {
                    id = Guid.NewGuid(),
                    name = ".NET CORE",
                    description = "Canal de .NET CORE"
                },
                new Channel
                {
                    id = Guid.NewGuid(),
                    name = "ReactJs",
                    description = "Canal de ReactJs"
                },
                new Channel
                {
                    id = Guid.NewGuid(),
                    name = "Angular",
                    description = "Canal de Angular"
                },
                new Channel
                {
                    id = Guid.NewGuid(),
                    name = "Vue",
                    description = "Canal de Vue"
                });
        }
    }
}
