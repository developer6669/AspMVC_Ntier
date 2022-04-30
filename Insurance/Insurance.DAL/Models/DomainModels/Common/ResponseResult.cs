using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance.DAL.Models.DomainModels.Common
{
    public class ResponseResult
    {
        public bool Result { get; set; }
        public string Message { get; set; }
    }
}