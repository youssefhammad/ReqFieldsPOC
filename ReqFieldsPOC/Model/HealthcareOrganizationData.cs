using ReqFieldsPOC.Validations;

namespace ReqFieldsPOC.Model
{
    public class HealthcareOrganizationData
    {
        [RequiredFieldPath]
        public string NameofOrg { get; set; }
        [RequiredFieldPath("State")]
        public Address Address { get; set; }
        [RequiredFieldPath]
        public string TelephoneContact { get; set; }
    }
}