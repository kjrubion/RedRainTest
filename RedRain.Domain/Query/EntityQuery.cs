using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedRain.Domain.Abstractions;
using RedRain.Domain.Common;
using RedRain.Domain.Repositories;

namespace RedRain.Domain.Query
{
    public class EntityQuery
    {
        private readonly IEntityRepository _entityRepository;

        public EntityQuery(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }
        public GenericResult Get(string type)
        {
            var result = _entityRepository.GetEntityByType(type);
            return Helper.Response(200, result);
        }
    }
}
