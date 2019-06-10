using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wirecard.DeveloperPortal.Core.Entity
{
   public class CustomerInfo
    {
        [XmlElement("CustomerName")]
        public string CustomerName { get; set; }
        [XmlElement("CustomerSurname")]
        public string CustomerSurname { get; set; }
        [XmlElement("CustomerEmail")]
        public string CustomerEmail { get; set; }
    }
}
