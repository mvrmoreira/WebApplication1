using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CreateSaleRequest
    {
        [Required]
        public decimal Amount { get; set; }

        [Required]
        [Range(1, 12)]
        public int Installments { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public CreditCard CreditCard { get; set; }
    }
}