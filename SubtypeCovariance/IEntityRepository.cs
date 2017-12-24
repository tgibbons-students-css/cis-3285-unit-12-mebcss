using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public interface IEntityRepository
    {
        public Entity GetByID(Guid id)
        {
            return new Entity(id);
        }
    }
}