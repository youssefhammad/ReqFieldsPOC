using ReqFieldsPOC.Validations;

namespace ReqFieldsPOC.Model
{
    public class ProviderData
    {
        [RequiredFieldPath]
        public Name Name { get; set; }
        [RequiredFieldPath]
        public string Role { get; set; }
        public string AcademicDegree { get; set; }
        [RequiredFieldPath]
        public string NationalProviderIdentifier { get; set; }
        [RequiredFieldPath]
        public string TelephoneContact { get; set; }

    }
}