using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebApi.Models
{
    public class DateNotInFutureAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return ((DateTime)value).Date <= DateTime.Today;
        }
    }
}