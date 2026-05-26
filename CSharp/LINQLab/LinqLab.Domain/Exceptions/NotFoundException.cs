using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Domain.Exceptions
{
    public class NotFoundException : DomainException
    {
        public string EntityName { get;}
        public object EntityId { get;}
        public NotFoundException(string entityName, object entityId) : base($"Entity '{entityName}' with id '{entityId}'")
        {
            EntityName = entityName;
            EntityId = entityId;
        }
    }
}
