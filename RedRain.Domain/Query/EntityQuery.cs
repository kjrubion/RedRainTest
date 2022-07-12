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
        /// <summary>
        /// The entity repository
        /// </summary>
        private readonly IEntityRepository _entityRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQuery"/> class.
        /// </summary>
        /// <param name="entityRepository">The entity repository.</param>
        public EntityQuery(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }
        /// <summary>
        /// Gets the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GenericResult Get(EntityRequest request)
        {
            var result = _entityRepository.GetEntityByType(request);
            return Helper.Response(200, result);
        }
    }
}
