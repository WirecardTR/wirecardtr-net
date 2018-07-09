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
    public class TokenizeCCRequest
    {
        [XmlElement("ServiceType")]
        public string ServiceType { get; set; }
        [XmlElement("OperationType")]
        public string OperationType { get; set; }
        [XmlElement("Token")]
        public Token Token { get; set; }
        [XmlElement("CreditCardNumber")]
        public string CreditCardNumber { get; set; }
        [XmlElement("NameSurname")]
        public string NameSurname { get; set; }
        [XmlElement("ExpiryDate")]
        public string ExpiryDate { get; set; }
        [XmlElement("CVV")]
        public string CVV { get; set; }
        [XmlElement("IPAddress")]
        public string IPAddress { get; set; }
        [XmlElement("CustomerId")]
        public string CustomerId { get; set; }
        [XmlElement("ValidityPeriod")]
        public string ValidityPeriod { get; set; }
        [XmlElement("Port")]
        public string Port { get; set; }

        public static string Execute(TokenizeCCRequest request, Settings options)
        {
            return RestHttpCaller.Create().PostXMLString(options.BaseUrl, request);
        }
    }
}
