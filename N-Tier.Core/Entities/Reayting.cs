using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Core.Entities
{
    public class Reayting : BaseEntity
    {
        public List<Students> Students { get; set; } = new List<Students>();
    }
}
