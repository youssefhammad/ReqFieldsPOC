namespace ReqFieldsPOC.Model
{
    public class AuthorInformation
    {
        public string Identifier { get; set; }
        public string AuthorRole { get; set; }
        public Address Address { get; set; }
        public string Telecom { get; set; }
        public Name Name { get; set; }
        public string AcademicCertification { get; set; }
    }
}