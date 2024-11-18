using N_Tier.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Core.Entities
{
    public class Employees : BaseEntity
    {
        public string Name {  get; set; }
        public string CreatedBy { get; set; }
    }
}
