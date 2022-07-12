using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedRain.Domain.Common
{
    public class EntityRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRequest"/> class.
        /// </summary>
        public EntityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRequest"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="source">The DB source.</param>
        public EntityRequest(string type, string? source)
        {
            Type = type;
            Source = source;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public string? Source { get; set; }
    }
}
