using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.DAL.Models.ViewModels.UserInsurance
{
    public class UserInsuranceVm
    {
        public int Id { get; set; }

        [Display(Name = "عنوان درخواست")]
        public string Name { get; set; }

        [Display(Name="میزان سرمایه")]
        public decimal FundValue { get; set; }

        [Display(Name = "نرخ بیمه")]
        public float InsuranceRate { get; set; }

        [Display(Name = "مبلغ بیمه")]
        public decimal InsuranceValue { get; set; }

        public List<int> ListInsuranceTypeSelectedId { get; set; }
        public List<Insurance.DAL.Models.Database.InsuranceType> ListInsuranceType { get; set; }
    }
}
