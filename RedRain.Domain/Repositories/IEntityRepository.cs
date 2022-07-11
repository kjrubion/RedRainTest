using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedRain.Domain.Repositories
{
    public interface IEntityRepository
    {
        public Entity? GetEntityByType(string type);
    }
}
