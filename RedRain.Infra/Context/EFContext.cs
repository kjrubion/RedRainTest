using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RedRain.Domain;

namespace RedRain.Infra.Context
{
    public class EFContext : DbContext
    {
        /// <summary>
        /// The configuration
        /// </summary>
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="EFContext"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public EFContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        public DbSet<Entity> Entities { get; set; }
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        private string Source { get; set; }
        /// <summary>
        /// Configures the DB source.
        /// </summary>
        /// <param name="source">The DB source.</param>
        public void ConfigureSource(string source)
        {
            if (!string.IsNullOrEmpty(source))
            {
                Source = source;
            }
        }

        /// <summary>
        /// <para>
        /// Override this method to configure the database (and other options) to be used for this context.
        /// This method is called for each instance of the context that is created.
        /// The base implementation does nothing.
        /// </para>
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            var connectionString = _configuration.GetConnectionString("DBConnection");
            optionsBuilder
                .UseSqlServer(connectionString);
            if (!string.IsNullOrEmpty(Source))
            {
                optionsBuilder.UseSqlServer(Source);
            }
        }
    }
}
