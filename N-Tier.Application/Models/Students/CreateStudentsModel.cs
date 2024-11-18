using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.Students
{
    public class CreateStudentsModel
    {
        public string Name { get; set; }
    }

    public class CreateStudentsResponseModel : BaseResponseModel { }

}
