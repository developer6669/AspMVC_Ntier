using Insurance.DAL.Models.Enums.Insurance;
using Insurance.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Models.DomainModels.Insurance
{
    public class InsuranceCalculator : IInsuranceCalculator
    {
        public EnumInsuranceType Type { get; set; }
        public decimal FundPrice { get; set; }
        public float InsuranceRate { get; set; }

        public decimal Calculate()
        {
            switch (Type)
            {
                case EnumInsuranceType.Surgery:
                    InsuranceRate = 0.5F;
                    break;
                case EnumInsuranceType.Dental:
                    InsuranceRate = 1.5F;
                    break;
                case EnumInsuranceType.Hospitalization:
                    InsuranceRate = 2.5F;
                    break;
                default:
                    break;
            }

            return Convert.ToDecimal(InsuranceRate) * FundPrice;
        }
    }
}