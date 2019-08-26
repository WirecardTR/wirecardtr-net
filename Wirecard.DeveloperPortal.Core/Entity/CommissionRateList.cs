using System.Xml.Serialization;

namespace Wirecard.DeveloperPortal.Core.Entity
{
    public class CommissionRateList
    {
        [XmlElement("Inst0")]
        public int Inst0 { get; set; }

        [XmlElement("Inst3")]
        public int Inst3 { get; set; }

        [XmlElement("Inst6")]
        public int Inst6 { get; set; }

        [XmlElement("Inst9")]
        public int Inst9 { get; set; }
    }
}
