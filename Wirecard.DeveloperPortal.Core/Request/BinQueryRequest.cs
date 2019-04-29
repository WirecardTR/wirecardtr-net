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
    public class BinQueryRequest
    {
        
        [XmlElement("ServiceType")] public string ServiceType { get; set; }
        [XmlElement("OperationType")] public string OperationType { get; set; }
        [XmlElement("Token")] public Token Token { get; set; }
        [XmlElement("BIN")] public string BIN { get; set; }


        public static string Execute(BinQueryRequest request, Settings options)
        {
            return RestHttpCaller.Create().PostXMLString(options.BaseUrl, request);
        }
    }
}
