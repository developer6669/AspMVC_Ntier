using Insurance.DAL.DataAccess;
using Insurance.DAL.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Repositories
{
    public class InsuranceTypeRepository : GenericRepository<InsuranceType>, IInsuranceTypeRepository
    {
        public InsuranceTypeRepository(IUnitOfWork<DatabaseContext> unitOfWork)
            : base(unitOfWork)
        {
        }
        public InsuranceTypeRepository(DatabaseContext context)
            : base(context)
        {
        }
        public IEnumerable<InsuranceType> GetInsuranceTypeByGender(string Name)
        {
            return Context.InsuranceType.Where(emp => emp.Name == Name).ToList();
        }
        public IEnumerable<InsuranceType> GetInsuranceTypeByDepartment(string Name)
        {
            return Context.InsuranceType.Where(emp => emp.Name == Name).ToList();
        }
    }
}