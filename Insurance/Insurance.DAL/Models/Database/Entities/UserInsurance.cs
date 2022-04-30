using Insurance.DAL.Models.Enums.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Models.Database
{
    public class UserInsurance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int InsuranceTypeId { get; set; }
        public decimal FundValue { get; set; }
        public float InsuranceRate { get; set; }
        public decimal InsuranceValue { get; set; }
    }
}