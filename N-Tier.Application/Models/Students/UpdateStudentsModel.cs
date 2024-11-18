using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.Students
{
    public class UpdateStudentsModel
    {
        public string Name { get; set; }
    }

    public class UpdateStudentsResponseModel : BaseResponseModel { }
}
