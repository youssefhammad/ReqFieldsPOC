namespace ReqFieldsPOC.Model
{
    public class AuthenticatorInformation
    {
        public string OrganizationName { get; set; }
        public string Identifier { get; set; }
        public string ProvidingEntityRole { get; set; }
        public string Telecom { get; set; }
        public Address Address { get; set; }
        public Name AuthenticatorName { get; set; }

    }
}