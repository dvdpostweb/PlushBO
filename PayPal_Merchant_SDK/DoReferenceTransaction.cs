using System;
using System.Collections.Generic;
using System.Text;
using PayPal.PayPalAPIInterfaceService.Model;
using PayPal.PayPalAPIInterfaceService;
using System.Web;
using System.Data; 

namespace PayPal
{
    public class PayPalResponse
    {
        public PayPalResponse()
        {
            XMLRequest = string.Empty;
            XMLResponse = string.Empty;
            Response = new DoReferenceTransactionResponseType();
        }
        public string XMLRequest;
        public string XMLResponse;
        public DoReferenceTransactionResponseType Response;
    }
 
    public class DoReferenceTransaction 
    {

        public PayPalResponse PayPalSendPayments(DataRow drCustomer)
        {
            // Create request object
            DoReferenceTransactionRequestType request = new DoReferenceTransactionRequestType();
            populateRequestObject(request, drCustomer);

            // Invoke the API
            DoReferenceTransactionReq wrapper = new DoReferenceTransactionReq();
            wrapper.DoReferenceTransactionRequest = request;
            PayPalAPIInterfaceServiceService service = new PayPalAPIInterfaceServiceService();
            DoReferenceTransactionResponseType doReferenceTxnResponse = service.DoReferenceTransaction(wrapper);

            // Check for API return status
            return setKeyResponseObjects(service, doReferenceTxnResponse);
        }

        private PayPalResponse setKeyResponseObjects(PayPalAPIInterfaceServiceService service, DoReferenceTransactionResponseType response)
        {
            PayPalResponse ppr = new PayPalResponse ();
            ppr.XMLRequest = service.getLastRequest();
            ppr.XMLResponse = service.getLastResponse();
            ppr.Response = response;

            return ppr;
            //Dictionary<string, string> responseParams = new Dictionary<string, string>();
            //responseParams.Add("Correlation Id", response.CorrelationID);

//            if (response.Ack.HasValue)
//             if (response.Ack.Value == AckCodeType.SUCCESS ) 
//             {
//                return response.Ack.Value.ToString();
//             }
//             else
//             {
//                 DoReferenceTransactionResponseDetailsType transactionDetails = response.DoReferenceTransactionResponseDetails;

//                 if (response.Ack.Value == AckCodeType.SUCCESSWITHWARNING ) 
//                 return response.Ack.Value.ToString() + ", " + transactionDetails.PaymentInfo.
//             }
//            else
//return 
            //if (response.Ack.Equals(AckCodeType.FAILURE) ||
            //    (response.Errors != null && response.Errors.Count > 0))
            //{
            //    CurrContext.Items.Add("Response_error", response.Errors);
            //}
            //else
            //{
            //    CurrContext.Items.Add("Response_error", null);
                
            //    responseParams.Add("Transaction ID", transactionDetails.TransactionID);
            //    responseParams.Add("Payment status", transactionDetails.PaymentInfo.PaymentStatus.ToString());
            //    if (transactionDetails.PaymentInfo.PendingReason != null)
            //    {
            //        responseParams.Add("Pending reason", transactionDetails.PaymentInfo.PendingReason.ToString());
            //    }
            //}
            //CurrContext.Items.Add("Response_keyResponseObject", responseParams);
            //Server.Transfer("../APIResponse.aspx");
        }

        private void populateRequestObject(DoReferenceTransactionRequestType request, DataRow rCustomer)
        {
            DoReferenceTransactionRequestDetailsType referenceTransactionDetails = new DoReferenceTransactionRequestDetailsType();
            request.DoReferenceTransactionRequestDetails = referenceTransactionDetails;
            referenceTransactionDetails.ReferenceID = (string)rCustomer["paypal_agreement_id"] ;
            referenceTransactionDetails.PaymentAction = (PaymentActionCodeType)
                Enum.Parse(typeof(PaymentActionCodeType), "SALE");

            // Populate payment requestDetails. 
            PaymentDetailsType paymentDetails = new PaymentDetailsType();
            referenceTransactionDetails.PaymentDetails = paymentDetails;
            double orderTotal = 0.0;
            double itemTotal = 0.0;
            CurrencyCodeType currency = (CurrencyCodeType)
            Enum.Parse(typeof(CurrencyCodeType), "EUR");

            
            paymentDetails.ShippingTotal = new BasicAmountType(currency, "0.00");
            orderTotal += Double.Parse("0.00");


            paymentDetails.InsuranceTotal = new BasicAmountType(currency, "0.00");
            paymentDetails.InsuranceOptionOffered = "true";
            orderTotal += Double.Parse("0.00");

            paymentDetails.HandlingTotal = new BasicAmountType(currency, "0.00");
            orderTotal += Double.Parse("0.00");


            paymentDetails.TaxTotal = new BasicAmountType(currency, "0.0");
            orderTotal += Double.Parse("0.0");
            
            
            paymentDetails.OrderDescription = "DVDPost monthly subscription";
            
            paymentDetails.PaymentAction = (PaymentActionCodeType)
            Enum.Parse(typeof(PaymentActionCodeType), "SALE");


            // Each payment can include requestDetails about multiple payment items
            // This example shows just one payment item
            //if (itemName.Value != null && itemAmount.Value != null && itemQuantity.Value != null)
            //{
                PaymentDetailsItemType itemDetails = new PaymentDetailsItemType();
                itemDetails.Name = (string)rCustomer["products_model"];
                itemDetails.Amount = new BasicAmountType(currency, (string)rCustomer["amount"]);
                itemDetails.Quantity = 1;
                itemDetails.ItemCategory = (ItemCategoryType)
                Enum.Parse(typeof(ItemCategoryType), "DIGITAL");
                itemTotal += Double.Parse(itemDetails.Amount.value); // *itemDetails.Quantity.Value;
                
                    itemDetails.Tax = new BasicAmountType(currency, "0.00");
                    orderTotal += Double.Parse("0.00");
                
                
                    itemDetails.Description = "Subscription for the next period";
                
                paymentDetails.PaymentDetailsItem.Add(itemDetails);
            //}
            orderTotal += itemTotal;
            paymentDetails.ItemTotal = new BasicAmountType(currency, (string)rCustomer["amount"]) ; //itemTotal.ToString("0.00"));
            paymentDetails.OrderTotal = new BasicAmountType(currency, (string)rCustomer["amount"]) ; //orderTotal.ToString("0.00"));

        }

    }
}
