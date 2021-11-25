using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebApi.Models
{
    public class ListLimitsAttribute : ValidationAttribute
    {
        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public override bool IsValid(object value)
        {
            var valueCast = value as IList;

            return valueCast.Count >= MinLength && valueCast.Count <= MaxLength;

        }
    }
}