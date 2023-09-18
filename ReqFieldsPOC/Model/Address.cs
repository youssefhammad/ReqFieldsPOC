using ReqFieldsPOC.Validations;

namespace ReqFieldsPOC.Model
{
    public class Address
    {
        public string StreetAddressName { get; set; }
        public string City { get; set; }
        [RequiredFieldPath]
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}