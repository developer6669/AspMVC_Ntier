using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.DAL.Models.ViewModels.InsuranceType
{
    class InsuranceTypeVm
    {
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }

        [Display(Name = "نرخ بیمه")]
        [Required(ErrorMessage = "*")]
        public float InsuranceRate { get; set; }

        [Display(Name = "حداقل سرمایه")]
        [Required(ErrorMessage = "*")]
        public float MaxFundValue { get; set; }

        [Display(Name = "حداکثر سرمایه")]
        [Required(ErrorMessage ="*")]
        public float MinFundValue { get; set; }
    }
}
