using Insurance.DAL.Models.Database;
using Insurance.DAL.Models.ViewModels.UserInsurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Repositories
{
    public interface IUserInsuranceRepository : IGenericRepository<UserInsurance>
    {
        void CreateBulk(UserInsuranceVm ViewModel);        
    }
}