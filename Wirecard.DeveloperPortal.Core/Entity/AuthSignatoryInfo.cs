using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wirecard.DeveloperPortal.Core.Entity
{
    public class AuthSignatoryInfo
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Surname")]
        public string Surname { get; set; }
        [XmlElement("BirthDate")]
        public string BirthDate { get; set; }
    }
}