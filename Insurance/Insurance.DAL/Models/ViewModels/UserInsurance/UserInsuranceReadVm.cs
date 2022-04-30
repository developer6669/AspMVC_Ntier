using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.DAL.Models.ViewModels.UserInsurance
{
    public class UserInsuranceReadVm
    {
        public List<Insurance.DAL.Models.Database.UserInsurance> ListInsurance { get; set; }
    }
}
