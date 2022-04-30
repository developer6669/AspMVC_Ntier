using Insurance.DAL.Models.Enums.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Interfaces
{
    public interface IInsuranceCalculator
    {
        EnumInsuranceType Type { get; set; }
        decimal FundPrice { get; set; }
        float InsuranceRate { get; set; }
        decimal Calculate();
    }
}