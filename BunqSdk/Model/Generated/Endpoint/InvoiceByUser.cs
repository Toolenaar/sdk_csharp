using Bunq.Sdk.Context;
using Bunq.Sdk.Http;
using Bunq.Sdk.Json;
using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Object;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Used to list bunq invoices by user.
    /// </summary>
    public class InvoiceByUser : BunqModel
    {
        /// <summary>
        /// Endpoint constants.
        /// </summary>
        private const string ENDPOINT_URL_LISTING = "user/{0}/invoice";
        private const string ENDPOINT_URL_READ = "user/{0}/invoice/{1}";
    
        /// <summary>
        /// Object type.
        /// </summary>
        private const string OBJECT_TYPE = "Invoice";
    
        /// <summary>
        /// The id of the invoice object.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; private set; }
    
        /// <summary>
        /// The timestamp of the invoice object's creation.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public string Created { get; private set; }
    
        /// <summary>
        /// The timestamp of the invoice object's last update.
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; private set; }
    
        /// <summary>
        /// The invoice date.
        /// </summary>
        [JsonProperty(PropertyName = "invoice_date")]
        public string InvoiceDate { get; private set; }
    
        /// <summary>
        /// The invoice number.
        /// </summary>
        [JsonProperty(PropertyName = "invoice_number")]
        public string InvoiceNumber { get; private set; }
    
        /// <summary>
        /// The invoice status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }
    
        /// <summary>
        /// The invoice item groups.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public List<InvoiceItemGroup> Group { get; private set; }
    
        /// <summary>
        /// The total discounted item price including VAT.
        /// </summary>
        [JsonProperty(PropertyName = "total_vat_inclusive")]
        public Amount TotalVatInclusive { get; private set; }
    
        /// <summary>
        /// The total discounted item price excluding VAT.
        /// </summary>
        [JsonProperty(PropertyName = "total_vat_exclusive")]
        public Amount TotalVatExclusive { get; private set; }
    
        /// <summary>
        /// The VAT on the total discounted item price.
        /// </summary>
        [JsonProperty(PropertyName = "total_vat")]
        public Amount TotalVat { get; private set; }
    
        /// <summary>
        /// The label that's displayed to the counterparty with the invoice. Includes user.
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public MonetaryAccountReference Alias { get; private set; }
    
        /// <summary>
        /// The customer's address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public Address Address { get; private set; }
    
        /// <summary>
        /// The label of the counterparty of the invoice. Includes user.
        /// </summary>
        [JsonProperty(PropertyName = "counterparty_alias")]
        public MonetaryAccountReference CounterpartyAlias { get; private set; }
    
        /// <summary>
        /// The company's address.
        /// </summary>
        [JsonProperty(PropertyName = "counterparty_address")]
        public Address CounterpartyAddress { get; private set; }
    
        /// <summary>
        /// The company's chamber of commerce number.
        /// </summary>
        [JsonProperty(PropertyName = "chamber_of_commerce_number")]
        public string ChamberOfCommerceNumber { get; private set; }
    
        /// <summary>
        /// The company's chamber of commerce number.
        /// </summary>
        [JsonProperty(PropertyName = "vat_number")]
        public string VatNumber { get; private set; }
    
        /// <summary>
        /// </summary>
        public static BunqResponse<List<InvoiceByUser>> List(ApiContext apiContext, int userId, IDictionary<string, string> urlParams = null, IDictionary<string, string> customHeaders = null)
        {
            if (urlParams == null) urlParams = new Dictionary<string, string>();
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(apiContext);
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_LISTING, userId), urlParams, customHeaders);
    
            return FromJsonList<InvoiceByUser>(responseRaw, OBJECT_TYPE);
        }
    
        /// <summary>
        /// </summary>
        public static BunqResponse<InvoiceByUser> Get(ApiContext apiContext, int userId, int invoiceByUserId, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(apiContext);
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_READ, userId, invoiceByUserId), new Dictionary<string, string>(), customHeaders);
    
            return FromJson<InvoiceByUser>(responseRaw, OBJECT_TYPE);
        }
    }
}
