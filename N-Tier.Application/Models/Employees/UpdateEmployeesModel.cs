using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Models.Employees
{
    public class UpdateEmployeesModel
    {
        public string Name { get; set; }
    }

    public class UpdateEmployeesResponseModel : BaseResponseModel { }
}
