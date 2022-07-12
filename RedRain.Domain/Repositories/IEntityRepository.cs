using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedRain.Domain.Common;

namespace RedRain.Domain.Repositories
{
    public interface IEntityRepository
    {
        public Entity? GetEntityByType(EntityRequest request);
    }
}
