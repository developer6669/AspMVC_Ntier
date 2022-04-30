using Insurance.DAL.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Repositories
{
    public interface IInsuranceTypeRepository : IGenericRepository<InsuranceType>
    {
        IEnumerable<InsuranceType> GetInsuranceTypeByGender(string Name);
        IEnumerable<InsuranceType> GetInsuranceTypeByDepartment(string Name);
    }
}