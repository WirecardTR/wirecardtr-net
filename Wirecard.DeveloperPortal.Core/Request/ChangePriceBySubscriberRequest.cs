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
    public class ChangePriceBySubscriberRequest
    {
        [XmlElement("ServiceType")]
        public string ServiceType { get; set; }
        [XmlElement("OperationType")]
        public string OperationType { get; set; }
        [XmlElement("Token")]
        public Token Token { get; set; }

        [XmlElement("SubscriberId")]
        public string SubscriberId { get; set; }
        [XmlElement("ValidFrom")]
        public string ValidFrom { get; set; }
        [XmlElement("Price")]
        public string Price { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }

        public static string Execute(ChangePriceBySubscriberRequest request, Settings options)
        {
            return RestHttpCaller.Create().PostXMLString(options.BaseUrl, request);
        }
    }

}
