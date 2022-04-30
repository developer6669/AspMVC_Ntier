using Insurance.DAL.DataAccess;
using Insurance.DAL.Models.Database;
using Insurance.DAL.Models.ViewModels.UserInsurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Repositories
{
    public class UserInsuranceRepository : GenericRepository<UserInsurance>, IUserInsuranceRepository
    {
        private DatabaseContext _context;
        public UserInsuranceRepository(IUnitOfWork<DatabaseContext> unitOfWork)
            : base(unitOfWork)
        {
            _context = unitOfWork.Context;
        }
        public UserInsuranceRepository(DatabaseContext context)
            : base(context)
        {
            _context = context;
        }
        public void CreateBulk(UserInsuranceVm ViewModel)
        {
            foreach (var item in ViewModel.ListInsuranceTypeSelectedId)
            {
                UserInsurance userInsurance = new UserInsurance();

                userInsurance.InsuranceTypeId = item;
                userInsurance.FundValue = ViewModel.FundValue;
                userInsurance.InsuranceRate = ViewModel.InsuranceRate;
                userInsurance.InsuranceValue = ViewModel.InsuranceValue;

                _context.UserInsurance.Add(userInsurance);
            }
        }

    }
}