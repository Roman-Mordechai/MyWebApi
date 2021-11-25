using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebApi.Models
{
    public class ValuationRequestModel
    {
        [Required]
        public string Brand { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public int? Mileage { get; set; }

    }
}