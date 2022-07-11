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
using RedRain.Domain.Repositories;
using RedRain.Infra.Context;

namespace RedRain.Infra.EntityRepository
{
    public class EntityRepositorySP : IEntityRepository
    {
        private readonly EFContext _efContext;

        public EntityRepositorySP(EFContext efContext)
        {
            _efContext = efContext;
        }

        public Entity? GetEntityByType(string type)
        {
            var result = _efContext.Entities.FromSqlRaw($"GetEntityByType @Type={type};").ToList();
            return result.Any() ? result.FirstOrDefault(): new Entity();
        }
    }
}
