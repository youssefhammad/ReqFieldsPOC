using System.Xml.Serialization;

namespace ReqFieldsPOC.Model
{
    public class Organization
    {
        public ProviderOrganizationInformation Information { get; set; }
        [XmlElement(ElementName = "OrganizationAddress")]
        public Address OrganizationAddress { get; set; }
    }
}