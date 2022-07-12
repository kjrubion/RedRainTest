using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RedRain.Domain;
using RedRain.Domain.Common;
using RedRain.Domain.Repositories;
using RedRain.Infra.Context;

namespace RedRain.Infra.EntityRepository
{
    public class EntityRepositorySP : IEntityRepository
    {
        /// <summary>
        /// The ef context
        /// </summary>
        private readonly EFContext _efContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRepositorySP"/> class.
        /// </summary>
        /// <param name="efContext">The ef context.</param>
        public EntityRepositorySP(EFContext efContext)
        {
            _efContext = efContext;
        }

        /// <summary>
        /// Gets the type of the entity by.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Entity? GetEntityByType(EntityRequest request)
        {
            if (!string.IsNullOrEmpty(request.Source))
            {
                _efContext.ConfigureSource(request.Source);
            }
            var result = _efContext.Entities.FromSqlRaw($"GetEntityByType @Type={request.Type};").ToList();
            return result.Any() ? result.FirstOrDefault() : new Entity();
        }
    }
}
