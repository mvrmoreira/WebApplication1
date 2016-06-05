using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CreditCard
    {
        [Required]
        [MinLength(14)]
        [MaxLength(16)]
        public string Number { get; set; }

        [Required]
        public string HolderName { get; set; }

        [Required]
        [Range(1, 12)]
        public int ExpirationMonth { get; set; }

        [Required]
        public int ExpirationYear { get; set; }

        [MinLength(3)]
        [MaxLength(4)]
        public string Cvv { get; set; }
    }
}