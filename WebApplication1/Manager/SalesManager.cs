using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Manager
{
    public class SalesManager
    {
        public void QueueSale(CreateSaleRequest request)
        {
            #region Mapping

            var queueItem = new NixQueueItem();

            queueItem.RequestKey = Guid.NewGuid().ToString();
            queueItem.CreateDate = DateTime.UtcNow;
            queueItem.AffiliationData.Email = request.Email;
            queueItem.AffiliationData.MerchantName = "Imasters";
            queueItem.AmountInCents = Convert.ToInt32(request.Amount * 100);
            queueItem.Card.CreditCardBrand = "Mastercard";
            queueItem.Card.CreditCardNumber = request.CreditCard.Number;
            queueItem.Card.ExpMonth = request.CreditCard.ExpirationMonth.ToString();
            queueItem.Card.ExpYear = request.CreditCard.ExpirationYear.ToString();
            queueItem.Card.HolderName = request.CreditCard.HolderName;
            queueItem.Card.SecurityCode = request.CreditCard.Cvv;

            string queueItemJson = JsonConvert.SerializeObject(queueItem);

            #endregion

            #region Send to queue

            string connectionString = CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");

            QueueClient Client = QueueClient.CreateFromConnectionString(connectionString, CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.QueueName"));

            Client.Send(new BrokeredMessage(queueItemJson));

            #endregion
        }
    }
}