namespace ReqFieldsPOC.Model
{
    public class OrganizationofAffiliationAddress
    {
        public string NameofOrganization { get; set; }
        public string Identifier { get; set; }
        public string Telecom { get; set; }
        public Address Address { get; set; }
    }
}