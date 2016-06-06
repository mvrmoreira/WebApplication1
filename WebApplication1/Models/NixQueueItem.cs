using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class NixQueueItem
    {
        public DateTime CreateDate { get; set; }

        public string RequestKey { get; set; }

        public long AmountInCents { get; set; }

        public AffiliationData AffiliationData { get; set; }

        public Card Card { get; set; }

        public NixQueueItem()
        {
            AffiliationData = new AffiliationData();
            Card = new Card();
        }
    }

    public class AffiliationData
    {
        public string Email { get; set; }

        public string MerchantName { get; set; }
    }

    public class Card
    {
        public string CreditCardNumber { get; set; }

        public string SecurityCode { get; set; }

        public string HolderName { get; set; }

        public string ExpMonth { get; set; }

        public string ExpYear { get; set; }

        public string CreditCardBrand { get; set; }
    }
}