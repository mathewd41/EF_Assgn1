using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class BaseType: BaseEntity
    {
        public Status Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
