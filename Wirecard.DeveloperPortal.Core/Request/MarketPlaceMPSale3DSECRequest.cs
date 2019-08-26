using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Wirecard.DeveloperPortal.Core.Entity;

namespace Wirecard.DeveloperPortal.Core.Request
{
    [XmlRoot("WIRECARD")]
    public class MarketPlaceMPSale3DSECRequest
    {
        [XmlElement("ServiceType")]
        public string ServiceType { get; set; }
        [XmlElement("OperationType")]
        public string OperationType { get; set; }
        [XmlElement("Token")]
        public Token Token { get; set; }
        [XmlElement("SubPartnerId")]
        public int SubPartnerId { get; set; }
        [XmlElement("Price")]
        public int Price { get; set; }
        [XmlElement("CommissionRate")]
        public int CommissionRate { get; set; }
        [XmlElement("MPAY")]
        public string MPAY { get; set; }
        [XmlElement("CurrencyCode")]
        public string CurrencyCode { get; set; }
        [XmlElement("InstallmentOptions")]
        public int InstallmentOptions { get; set; }
        [XmlElement("CommissionRateList")]
        public CommissionRateList CommissionRateList { get; set; }

        [XmlElement("ErrorURL")]
        public string ErrorURL { get; set; }
        [XmlElement("SuccessURL")]
        public string SuccessURL { get; set; }

        [XmlElement("ExtraParam")]
        public string ExtraParam { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("PaymentContent")]
        public string PaymentContent { get; set; }

        public static string Execute(MarketPlaceMPSale3DSECRequest request, Settings options)
        {
            return RestHttpCaller.Create().PostXMLString(options.BaseUrl, request);
        }
    }
}
