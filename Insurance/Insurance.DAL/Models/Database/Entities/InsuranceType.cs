using Insurance.DAL.Models.Enums.Insurance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Models.Database
{
    public class InsuranceType
    {        
        public int Id { get; set; }

        public string Name { get; set; }

        public float InsuranceRate { get; set; }

        public float MaxFundValue { get; set; }

        public float MinFundValue { get; set; }
    }
}