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

        [Required]
        [DateNotInFuture(ErrorMessage = "Date must not be in the future")]
        public DateTime? RegisteredDate { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int? Mileage { get; set; }
        
        [ListLimits(MinLength = 5, MaxLength = 10, ErrorMessage = "Must list between 0 and 10 options")]
        public List<CarSpecification> CarSpecifications { get; set; }
}

    public class CarSpecification
    {
        public string CarModel { get; set; }
        public string CarName { get; set; }

    }
}